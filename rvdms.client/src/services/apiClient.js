import axios from "axios";
import router from "@/router/Index";

const apiClient = axios.create({
  baseURL: import.meta.env.VITE_API_URL || "https://localhost:7026/api",
  headers: {
    "Content-Type": "application/json",
  },
});

// ===============================
// REQUEST INTERCEPTOR
// ===============================

apiClient.interceptors.request.use(
  (config) => {
    const token = localStorage.getItem("accessToken");

    if (token) {
      config.headers.Authorization = `Bearer ${token}`;
    }

    return config;
  },
  (error) => Promise.reject(error),
);

// ===============================
// RESPONSE INTERCEPTOR (ONLY REFRESH LOGIC)
// ===============================

apiClient.interceptors.response.use(
  (response) => response,
  async (error) => {
    const originalRequest = error.config;
    const isAuthEndpoint =
      originalRequest.url.includes("/Auth/login") || originalRequest.url.includes("/Auth/refresh");

    if (error.response?.status === 401 && !originalRequest._retry && !isAuthEndpoint) {
      originalRequest._retry = true;

      try {
        const refreshToken = localStorage.getItem("refreshToken");

        if (!refreshToken) throw new Error("No refresh token");

        const refreshResponse = await axios.post(
          `${apiClient.defaults.baseURL}/Auth/refresh-token`,
          { refreshToken },
        );

        const { isSuccess, value } = refreshResponse.data;

        if (!isSuccess) throw new Error("Refresh failed");

        localStorage.setItem("accessToken", value.accessToken);
        localStorage.setItem("refreshToken", value.refreshToken);

        originalRequest.headers.Authorization = `Bearer ${value.accessToken}`;

        return apiClient(originalRequest);
      } catch (err) {
        localStorage.clear();
        router.push("/login");
        return Promise.reject(err);
      }
    }

    return Promise.reject(error);
  },
);

export default apiClient;
