export default [
  {
    name: "home",
    path: "/",
    component: () => import("./views/HomeView.vue"),
    meta: { requiresAuth: false },
  },
  // Principal Secretary
  // {
  //   name: "psDashboard",
  //   path: "/dashboard/ps",
  //   component: () => import("./views/dashboard/PsDashboard.vue"),
  //   meta: { requiresAuth: true, role: "CS" },
  // },

  // Regional Lead
  // {
  //   name: "regionalDashboard",
  //   path: "/dashboard/regional",
  //   component: () => import("./views/dashboard/RegionalDashboard.vue"),
  //   meta: { requiresAuth: true, role: "RL" },
  // },

  // County Head
  // {
  //   name: "countyDashboard",
  //   path: "/dashboard/county",
  //   component: () => import("./views/dashboard/CountyDashboard.vue"),
  //   meta: { requiresAuth: true, role: "CDH" },
  // },

  // Clerk of Works
  {
    name: "clerkDashboard",
    path: "/dashboard/clerk",
    component: () => import("./views/dashboard/ClerkDashboard.vue"),
    meta: { requiresAuth: true, role: "COW" },
  },
  {
    path: "/profile",
    name: "profile",
    component: () => import("./views/ProfileView.vue"),
    meta: {
      requiresAuth: true,
      title: "My Profile",
    },
  },

  // Technical Lead / Consultant
  // {
  //   name: "consultantDashboard",
  //   path: "/dashboard/consultant",
  //   component: () => import("./views/dashboard/ConsultantDashboard.vue"),
  //   meta: { requiresAuth: true, role: "TL" },
  // },
];
