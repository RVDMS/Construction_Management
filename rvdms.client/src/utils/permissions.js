// src/utils/permissions.js
export const getRoleDisplayName = (role) => {
  const roleMap = {
    CS: "Cluster Supervisor",
    RL: "Regional Lead",
    CDH: "County Director of Housing",
    COW: "Clerk of Works",
    TL: "Technical Lead",
  };
  return roleMap[role] || role || "User";
};

export const getStatusBadgeClass = (status) => {
  const classes = {
    Delayed: "bg-red-100 text-red-700 dark:bg-red-900/30 dark:text-red-400",
    Slow: "bg-amber-100 text-amber-700 dark:bg-amber-900/30 dark:text-amber-400",
    OnTime: "bg-emerald-100 text-emerald-700 dark:bg-emerald-900/30 dark:text-emerald-400",
    OnTrack: "bg-emerald-100 text-emerald-700 dark:bg-emerald-900/30 dark:text-emerald-400",
    Ahead: "bg-blue-100 text-blue-700 dark:bg-blue-900/30 dark:text-blue-400",
    Completed: "bg-slate-100 text-slate-700 dark:bg-slate-700 dark:text-slate-300",
  };
  return classes[status] || "bg-slate-100 text-slate-700 dark:bg-slate-700 dark:text-slate-300";
};

export const getProgressBarClass = (project) => {
  if (project.isAtRisk) return "bg-red-500";
  if (project.variance < -10) return "bg-amber-500";
  return "bg-emerald-500";
};

export const getRoleBadgeClass = (role) => {
  const classes = {
    CS: "bg-purple-100 text-purple-700 dark:bg-purple-900/30 dark:text-purple-400",
    RL: "bg-blue-100 text-blue-700 dark:bg-blue-900/30 dark:text-blue-400",
    CDH: "bg-emerald-100 text-emerald-700 dark:bg-emerald-900/30 dark:text-emerald-400",
    COW: "bg-amber-100 text-amber-700 dark:bg-amber-900/30 dark:text-amber-400",
    TL: "bg-slate-100 text-slate-700 dark:bg-slate-700 dark:text-slate-300",
  };
  return classes[role] || "bg-slate-100 text-slate-700";
};

export const formatCurrency = (value) => {
  if (!value) return "0";
  if (value >= 1000000) {
    return `${(value / 1000000).toFixed(2)}M`;
  }
  return value.toLocaleString("en-KE");
};

export const formatDate = (dateString) => {
  if (!dateString) return "N/A";
  return new Date(dateString).toLocaleDateString("en-KE", {
    year: "numeric",
    month: "short",
    day: "numeric",
  });
};

export const formatDateTime = (dateString) => {
  if (!dateString) return "N/A";
  return new Date(dateString).toLocaleString("en-KE", {
    year: "numeric",
    month: "short",
    day: "numeric",
    hour: "2-digit",
    minute: "2-digit",
  });
};
