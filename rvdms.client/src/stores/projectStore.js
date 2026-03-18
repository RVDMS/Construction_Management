import { defineStore } from "pinia";
import apiClient from "@/services/apiClient";

export const useProjectStore = defineStore("project", {
  state: () => ({
    myProject: null,
    loading: false,
  }),

  actions: {
    async fetchMyProject() {
      this.loading = true;

      try {
        const response = await apiClient.get("/Projects/my-project");
        this.myProject = response.data;
      } catch (error) {
        console.error("Failed to load project", error);
        this.myProject = null;
      } finally {
        this.loading = false;
      }
    },
  },
});
