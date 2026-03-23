import { createRouter, createWebHistory } from "vue-router";
import AuthRoutes from "@/features/auth/auth.routes";
import homeRoutes from "@/features/home/home.routes";
import { useAuthStore } from "@/stores/AuthStore";

const routes = [...AuthRoutes, ...homeRoutes];

const router = createRouter({
  history: createWebHistory(),
  routes,
});

router.beforeEach((to) => {
  const authStore = useAuthStore();

  // If route requires login
  if (to.meta.requiresAuth && !authStore.isAuthenticated) {
    return "/login";
  }

  // If route requires specific role
  if (to.meta.role && authStore.userRole !== to.meta.role) {
    return "/login";
  }

  // If route requires multiple roles
  if (to.meta.roles && !to.meta.roles.includes(authStore.userRole)) {
    return "/login";
  }

  // allow navigation
  return true;
});

export default router;
