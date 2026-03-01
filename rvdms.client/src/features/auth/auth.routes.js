export default [
  {
    name: "login",
    path: "/login",
    component: () => import("./views/LoginView.vue"),
    meta: { requiresAuth: false },
  },
  {
    name: "register",
    path: "/register",
    component: () => import("./views/RegisterView.vue"),
    meta: { requiresAuth: false },
  },
];
