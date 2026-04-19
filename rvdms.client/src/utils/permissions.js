// src/utils/permissions.js

// Format currency with commas - NO rounding/abbreviation
export const formatCurrency = (value) => {
  if (!value && value !== 0) return "0";

  // Convert to number and format with commas
  const number = typeof value === "string" ? parseFloat(value) : value;

  // Format with 2 decimal places and commas
  return number.toLocaleString("en-KE", {
    minimumFractionDigits: 2,
    maximumFractionDigits: 2,
  });
};

// Alternative: If you want no decimal places for whole numbers
export const formatCurrencySimple = (value) => {
  if (!value && value !== 0) return "0";

  const number = typeof value === "string" ? parseFloat(value) : value;

  // Check if it's a whole number
  if (number % 1 === 0) {
    return number.toLocaleString("en-KE");
  }

  return number.toLocaleString("en-KE", {
    minimumFractionDigits: 2,
    maximumFractionDigits: 2,
  });
};

// Keep existing functions
export const getStatusBadgeClass = (status) => {
  const classes = {
    Delayed: "bg-red-100 text-red-700 border border-red-200",
    Slow: "bg-amber-100 text-amber-700 border border-amber-200",
    OnTrack: "bg-emerald-100 text-emerald-700 border border-emerald-200",
    Ahead: "bg-blue-100 text-blue-700 border border-blue-200",
    Completed: "bg-slate-100 text-slate-700 border border-slate-200",
  };
  return classes[status] || "bg-slate-100 text-slate-700 border border-slate-200";
};

export const getProgressBarClass = (project) => {
  if (project.isAtRisk) return "bg-red-600";
  if (project.variance < -10) return "bg-amber-600";
  return "bg-emerald-600";
};

export const formatDate = (dateString) => {
  if (!dateString) return "N/A";
  return new Date(dateString).toLocaleDateString("en-KE", {
    year: "numeric",
    month: "short",
    day: "numeric",
  });
};

export const formatDateTime = (dateTime) => {
  if (!dateTime) return null;
  const d = new Date(dateTime);
  if (isNaN(d.getTime())) return null;
  return d.toLocaleString("en-KE", {
    year: "numeric",
    month: "short",
    day: "numeric",
    hour: "2-digit",
    minute: "2-digit",
  });
};

export const getRoleDisplayName = (role) => {
  const roles = {
    RL: "Regional Lead",
    CS: "Cluster Supervisor",
    CDH: "County Director",
    COW: "Clerk of Works",
    TL: "Technical Lead",
    SuperAdmin: "Super Administrator",
  };
  return roles[role] || role || "User";
};
