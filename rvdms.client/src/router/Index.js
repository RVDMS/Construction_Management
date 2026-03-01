import { createRouter, createWebHistory } from "vue-router";
import AuthRoutes from "@/features/auth/auth.routes";

const routes = [...AuthRoutes];

const router = createRouter({
  history: createWebHistory(),
  routes,
});

router.beforeEach((to, next) => {
  const token = localStorage.getItem("token");

  if (to.meta.requiresAuth && !token) {
    next("/login");
  } else {
    next();
  }
});

export default router;
