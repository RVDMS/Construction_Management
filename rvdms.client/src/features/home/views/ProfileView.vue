<!-- src/views/Profile.vue -->
<template>
  <div class="min-h-screen bg-slate-50 p-4 md:p-6">
    <div class="max-w-4xl mx-auto space-y-6">
      <!-- Header with Back Button -->
      <div class="flex items-center gap-4">
        <button
          @click="goBack"
          class="p-2 hover:bg-white rounded-lg transition-colors"
          :title="'Go back'"
        >
          <ArrowLeftIcon class="w-5 h-5 text-slate-600" />
        </button>
        <h1 class="text-2xl font-semibold text-slate-900">My Profile</h1>
      </div>

      <!-- Profile Card -->
      <div class="bg-white rounded-xl border border-slate-200 shadow-sm overflow-hidden">
        <!-- Profile Header -->
        <div class="bg-gradient-to-r from-emerald-600 to-emerald-700 px-6 py-8 text-white">
          <div class="flex items-center gap-6">
            <!-- Avatar -->
            <div class="relative">
              <div
                class="w-20 h-20 bg-white/20 rounded-full flex items-center justify-center backdrop-blur-sm border-2 border-white/50"
              >
                <span class="text-3xl font-bold text-white">
                  {{ userInitials }}
                </span>
              </div>
              <div
                class="absolute -bottom-1 -right-1 w-6 h-6 bg-emerald-400 rounded-full border-2 border-white flex items-center justify-center"
              >
                <CheckIcon class="w-3 h-3 text-white" />
              </div>
            </div>

            <!-- User Info -->
            <div class="flex-1">
              <h2 class="text-2xl font-bold">{{ user?.fullName || "User" }}</h2>
              <p class="text-emerald-100 flex items-center gap-2 mt-1">
                <BriefcaseIcon class="w-4 h-4" />
                {{ userRoleLabel }}
              </p>
              <p class="text-emerald-100 text-sm mt-2">
                Last login: {{ formatLastLogin(user?.lastLoginAt) }}
              </p>
            </div>
          </div>
        </div>

        <!-- Profile Content -->
        <div class="p-6">
          <!-- Alert Messages -->
          <div
            v-if="alertMessage"
            :class="[
              'mb-6 p-4 rounded-lg flex items-start gap-3',
              alertType === 'success'
                ? 'bg-emerald-50 text-emerald-800 border border-emerald-200'
                : 'bg-red-50 text-red-800 border border-red-200',
            ]"
          >
            <AlertCircleIcon v-if="alertType === 'error'" class="w-5 h-5 flex-shrink-0" />
            <CheckCircleIcon v-else class="w-5 h-5 flex-shrink-0" />
            <p class="text-sm flex-1">{{ alertMessage }}</p>
            <button @click="clearAlert" class="text-slate-400 hover:text-slate-600">
              <XIcon class="w-4 h-4" />
            </button>
          </div>

          <!-- Personal Information - VIEW ONLY -->
          <div class="space-y-6">
            <div>
              <h3 class="text-sm font-medium text-slate-900 mb-4 flex items-center gap-2">
                <UserIcon class="w-4 h-4 text-emerald-600" />
                Personal Information
              </h3>
              <div class="grid grid-cols-1 md:grid-cols-2 gap-4">
                <div>
                  <label class="block text-sm text-slate-500 mb-1">First Name</label>
                  <div
                    class="text-sm font-medium text-slate-900 py-2 px-3 bg-slate-50 rounded-lg border border-slate-200"
                  >
                    {{ user?.firstName || "Not provided" }}
                  </div>
                </div>
                <div>
                  <label class="block text-sm text-slate-500 mb-1">Last Name</label>
                  <div
                    class="text-sm font-medium text-slate-900 py-2 px-3 bg-slate-50 rounded-lg border border-slate-200"
                  >
                    {{ user?.lastName || "Not provided" }}
                  </div>
                </div>
                <div>
                  <label class="block text-sm text-slate-500 mb-1">Email Address</label>
                  <div
                    class="text-sm font-medium text-slate-900 py-2 px-3 bg-slate-50 rounded-lg border border-slate-200"
                  >
                    {{ user?.email || "Not provided" }}
                  </div>
                </div>
                <div>
                  <label class="block text-sm text-slate-500 mb-1">Phone Number</label>
                  <div
                    class="text-sm font-medium text-slate-900 py-2 px-3 bg-slate-50 rounded-lg border border-slate-200"
                  >
                    {{ user?.phoneNumber || "Not provided" }}
                  </div>
                </div>
              </div>
            </div>

            <!-- Account Information - VIEW ONLY -->
            <div class="pt-4 border-t border-slate-200">
              <h3 class="text-sm font-medium text-slate-900 mb-4 flex items-center gap-2">
                <ShieldIcon class="w-4 h-4 text-emerald-600" />
                Account Information
              </h3>
              <div class="grid grid-cols-1 md:grid-cols-2 gap-4">
                <div>
                  <label class="block text-sm text-slate-500 mb-1">Username</label>
                  <div
                    class="text-sm font-medium text-slate-900 py-2 px-3 bg-slate-50 rounded-lg border border-slate-200 font-mono"
                  >
                    {{ user?.userName || "Not provided" }}
                  </div>
                </div>
                <div>
                  <label class="block text-sm text-slate-500 mb-1">User ID</label>
                  <div class="flex items-center gap-2">
                    <div
                      class="flex-1 text-sm font-medium text-slate-900 py-2 px-3 bg-slate-50 rounded-lg border border-slate-200 font-mono truncate"
                    >
                      {{ user?.id || "Not provided" }}
                    </div>
                    <button
                      type="button"
                      @click="copyToClipboard(user?.id)"
                      class="p-2 text-slate-600 hover:text-emerald-600 hover:bg-emerald-50 rounded-lg transition-colors"
                      title="Copy User ID"
                    >
                      <CopyIcon class="w-4 h-4" />
                    </button>
                  </div>
                </div>
                <div>
                  <label class="block text-sm text-slate-500 mb-1">Role</label>
                  <div
                    class="text-sm font-medium text-slate-900 py-2 px-3 bg-slate-50 rounded-lg border border-slate-200"
                  >
                    {{ userRoleLabel }}
                  </div>
                </div>
                <div>
                  <label class="block text-sm text-slate-500 mb-1">Account Status</label>
                  <div>
                    <span
                      class="inline-flex items-center gap-1.5 px-3 py-1.5 bg-emerald-100 text-emerald-700 rounded-full text-sm"
                    >
                      <span class="w-2 h-2 bg-emerald-600 rounded-full"></span>
                      Active
                    </span>
                  </div>
                </div>
              </div>
            </div>

            <!-- Location/Assignment Info (Role-specific) -->
            <div v-if="userLocationInfo" class="pt-4 border-t border-slate-200">
              <h3 class="text-sm font-medium text-slate-900 mb-4 flex items-center gap-2">
                <MapPinIcon class="w-4 h-4 text-emerald-600" />
                {{ locationTitle }}
              </h3>
              <div class="bg-slate-50 rounded-lg p-4 border border-slate-200">
                <p class="text-sm text-slate-700">{{ userLocationInfo }}</p>
              </div>
            </div>
          </div>
        </div>
      </div>

      <!-- Change Password Card - ONLY EDITABLE SECTION -->
      <div class="bg-white rounded-xl border border-slate-200 shadow-sm overflow-hidden">
        <div class="px-6 py-4 border-b border-slate-200 bg-slate-50">
          <h3 class="text-sm font-medium text-slate-900 flex items-center gap-2">
            <LockIcon class="w-4 h-4 text-emerald-600" />
            Change Password
          </h3>
        </div>

        <div class="p-6">
          <form @submit.prevent="changePassword" class="space-y-4 max-w-md">
            <!-- Current Password -->
            <div>
              <label class="block text-sm text-slate-700 mb-1">Current Password</label>
              <div class="relative">
                <input
                  v-model="passwordForm.currentPassword"
                  :type="showCurrentPassword ? 'text' : 'password'"
                  class="w-full px-3 py-2 border border-slate-300 rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500 pr-10"
                  placeholder="Enter current password"
                  required
                />
                <button
                  type="button"
                  @click="showCurrentPassword = !showCurrentPassword"
                  class="absolute right-3 top-1/2 -translate-y-1/2 text-slate-400 hover:text-slate-600"
                >
                  <EyeIcon v-if="!showCurrentPassword" class="w-4 h-4" />
                  <EyeOffIcon v-else class="w-4 h-4" />
                </button>
              </div>
            </div>

            <!-- New Password -->
            <div>
              <label class="block text-sm text-slate-700 mb-1">New Password</label>
              <div class="relative">
                <input
                  v-model="passwordForm.newPassword"
                  :type="showNewPassword ? 'text' : 'password'"
                  class="w-full px-3 py-2 border border-slate-300 rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500 pr-10"
                  placeholder="Enter new password"
                  required
                  minlength="6"
                />
                <button
                  type="button"
                  @click="showNewPassword = !showNewPassword"
                  class="absolute right-3 top-1/2 -translate-y-1/2 text-slate-400 hover:text-slate-600"
                >
                  <EyeIcon v-if="!showNewPassword" class="w-4 h-4" />
                  <EyeOffIcon v-else class="w-4 h-4" />
                </button>
              </div>
              <p class="text-xs text-slate-500 mt-1">Must be at least 6 characters</p>
            </div>

            <!-- Confirm New Password -->
            <div>
              <label class="block text-sm text-slate-700 mb-1">Confirm New Password</label>
              <div class="relative">
                <input
                  v-model="passwordForm.confirmPassword"
                  :type="showConfirmPassword ? 'text' : 'password'"
                  class="w-full px-3 py-2 border border-slate-300 rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500 pr-10"
                  :class="{ 'border-red-500': passwordMismatch }"
                  placeholder="Confirm new password"
                  required
                />
                <button
                  type="button"
                  @click="showConfirmPassword = !showConfirmPassword"
                  class="absolute right-3 top-1/2 -translate-y-1/2 text-slate-400 hover:text-slate-600"
                >
                  <EyeIcon v-if="!showConfirmPassword" class="w-4 h-4" />
                  <EyeOffIcon v-else class="w-4 h-4" />
                </button>
              </div>
              <p v-if="passwordMismatch" class="text-xs text-red-600 mt-1">
                Passwords do not match
              </p>
            </div>

            <!-- Password Strength Indicator -->
            <div v-if="passwordForm.newPassword" class="space-y-2">
              <div class="flex items-center gap-2">
                <div class="flex-1 h-1.5 bg-slate-200 rounded-full overflow-hidden">
                  <div
                    class="h-full transition-all"
                    :class="passwordStrengthClass"
                    :style="{ width: passwordStrength + '%' }"
                  ></div>
                </div>
                <span class="text-xs font-medium" :class="passwordStrengthTextClass">
                  {{ passwordStrengthLabel }}
                </span>
              </div>
              <ul class="text-xs space-y-1 text-slate-600">
                <li
                  :class="{ 'text-emerald-600': passwordHasLength }"
                  class="flex items-center gap-1"
                >
                  <CheckCircleIcon v-if="passwordHasLength" class="w-3 h-3" />
                  <XCircleIcon v-else class="w-3 h-3 text-slate-400" />
                  At least 6 characters
                </li>
                <li
                  :class="{ 'text-emerald-600': passwordHasNumber }"
                  class="flex items-center gap-1"
                >
                  <CheckCircleIcon v-if="passwordHasNumber" class="w-3 h-3" />
                  <XCircleIcon v-else class="w-3 h-3 text-slate-400" />
                  Contains at least one number
                </li>
                <li
                  :class="{ 'text-emerald-600': passwordHasLetter }"
                  class="flex items-center gap-1"
                >
                  <CheckCircleIcon v-if="passwordHasLetter" class="w-3 h-3" />
                  <XCircleIcon v-else class="w-3 h-3 text-slate-400" />
                  Contains at least one letter
                </li>
              </ul>
            </div>

            <button
              type="submit"
              :disabled="changingPassword || !isPasswordValid"
              class="w-full bg-emerald-600 hover:bg-emerald-700 text-white py-2.5 rounded-lg transition-colors disabled:opacity-50 disabled:cursor-not-allowed flex items-center justify-center gap-2"
            >
              <Loader2Icon v-if="changingPassword" class="w-4 h-4 animate-spin" />
              {{ changingPassword ? "Updating..." : "Update Password" }}
            </button>
          </form>
        </div>
      </div>

      <!-- Session Information Card -->
      <div class="bg-white rounded-xl border border-slate-200 shadow-sm overflow-hidden">
        <div class="px-6 py-4 border-b border-slate-200 bg-slate-50">
          <h3 class="text-sm font-medium text-slate-900 flex items-center gap-2">
            <ClockIcon class="w-4 h-4 text-emerald-600" />
            Session Information
          </h3>
        </div>

        <div class="p-6">
          <div class="grid grid-cols-1 sm:grid-cols-2 gap-4">
            <div class="bg-slate-50 rounded-lg p-4">
              <p class="text-xs text-slate-500 mb-1">Token Expires</p>
              <p class="text-sm font-medium text-slate-900">{{ tokenExpiryTime }}</p>
            </div>
            <div class="bg-slate-50 rounded-lg p-4">
              <p class="text-xs text-slate-500 mb-1">Last Login</p>
              <p class="text-sm font-medium text-slate-900">
                {{ formatDateTime(user?.lastLoginAt) }}
              </p>
            </div>
          </div>

          <!-- Permissions -->
          <div class="mt-4 pt-4 border-t border-slate-200">
            <p class="text-xs text-slate-500 mb-2">Your Permissions</p>
            <div class="flex flex-wrap gap-2">
              <span
                v-for="permission in userPermissions"
                :key="permission"
                class="px-3 py-1 bg-emerald-50 text-emerald-700 rounded-full text-xs"
              >
                {{ permission }}
              </span>
              <span v-if="!userPermissions.length" class="text-xs text-slate-400">
                No specific permissions
              </span>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>
<script setup>
import { ref, computed, onMounted } from "vue";
import { useRouter } from "vue-router";
import { useToast } from "vue-toastification";
import { useAuthStore } from "@/stores/AuthStore";
import apiClient from "@/services/apiClient";
import {
  ArrowLeft as ArrowLeftIcon,
  User as UserIcon,
  Briefcase as BriefcaseIcon,
  MapPin as MapPinIcon,
  Shield as ShieldIcon,
  Lock as LockIcon,
  Check as CheckIcon,
  Eye as EyeIcon,
  EyeOff as EyeOffIcon,
  Loader2 as Loader2Icon,
  AlertCircle as AlertCircleIcon,
  CheckCircle as CheckCircleIcon,
  XCircle as XCircleIcon,
  Copy as CopyIcon,
  X as XIcon,
  Clock as ClockIcon,
} from "lucide-vue-next";
import { jwtDecode } from "jwt-decode";

const router = useRouter();
const toast = useToast();
const authStore = useAuthStore();

// State
const changingPassword = ref(false);
const alertMessage = ref("");
const alertType = ref("success");

// Password visibility
const showCurrentPassword = ref(false);
const showNewPassword = ref(false);
const showConfirmPassword = ref(false);

// Password form
const passwordForm = ref({
  currentPassword: "",
  newPassword: "",
  confirmPassword: "",
});

// Computed
const user = computed(() => authStore.user);

const userInitials = computed(() => {
  if (!user.value) return "U";
  const first = user.value.firstName?.charAt(0) || "";
  const last = user.value.lastName?.charAt(0) || "";
  return (first + last).toUpperCase() || "U";
});

const userRoleLabel = computed(() => {
  const role = authStore.userRole;
  const roles = {
    CS: "Principal Secretary",
    RL: "Regional Lead",
    CDH: "County Director of Housing",
    COW: "Clerk of Works",
    TL: "Technical Lead (Consultant)",
  };
  return roles[role] || role || "User";
});

const userLocationInfo = computed(() => {
  const role = authStore.userRole;
  if (role === "CDH" && user.value?.county) {
    return `County: ${user.value.county}`;
  }
  if (role === "RL" && user.value?.region) {
    return `Region: ${user.value.region}`;
  }
  if (role === "COW") {
    // This would come from their assigned project
    return "Assigned to: Affordable Housing Project";
  }
  return null;
});

const locationTitle = computed(() => {
  const role = authStore.userRole;
  if (role === "CDH") return "County Assignment";
  if (role === "RL") return "Region Assignment";
  if (role === "COW") return "Project Assignment";
  return "Location";
});

// Password validation
const passwordMismatch = computed(() => {
  return passwordForm.value.newPassword !== passwordForm.value.confirmPassword;
});

const passwordHasLength = computed(() => {
  return passwordForm.value.newPassword.length >= 6;
});

const passwordHasNumber = computed(() => {
  return /\d/.test(passwordForm.value.newPassword);
});

const passwordHasLetter = computed(() => {
  return /[a-zA-Z]/.test(passwordForm.value.newPassword);
});

const passwordStrength = computed(() => {
  let strength = 0;
  if (passwordHasLength.value) strength += 33;
  if (passwordHasNumber.value) strength += 33;
  if (passwordHasLetter.value) strength += 34;
  return strength;
});

const passwordStrengthClass = computed(() => {
  if (passwordStrength.value < 33) return "bg-red-500";
  if (passwordStrength.value < 66) return "bg-amber-500";
  return "bg-emerald-500";
});

const passwordStrengthLabel = computed(() => {
  if (passwordStrength.value < 33) return "Weak";
  if (passwordStrength.value < 66) return "Medium";
  return "Strong";
});

const passwordStrengthTextClass = computed(() => {
  if (passwordStrength.value < 33) return "text-red-600";
  if (passwordStrength.value < 66) return "text-amber-600";
  return "text-emerald-600";
});

const isPasswordValid = computed(() => {
  return (
    passwordHasLength.value &&
    passwordHasNumber.value &&
    passwordHasLetter.value &&
    !passwordMismatch.value &&
    passwordForm.value.currentPassword
  );
});

const tokenExpiryTime = computed(() => {
  const token = authStore.accessToken;
  if (!token) return "N/A";

  try {
    const decoded = jwtDecode(token);
    const expiryDate = new Date(decoded.exp * 1000);
    return expiryDate.toLocaleString("en-KE", {
      year: "numeric",
      month: "short",
      day: "numeric",
      hour: "2-digit",
      minute: "2-digit",
    });
  } catch {
    return "N/A";
  }
});

const userPermissions = computed(() => {
  const token = authStore.accessToken;
  if (!token) return [];

  try {
    const decoded = jwtDecode(token);
    const permissions = decoded.permission || decoded.permissions || [];
    return Array.isArray(permissions) ? permissions : [permissions];
  } catch {
    return [];
  }
});

// Methods
const formatLastLogin = (dateString) => {
  if (!dateString) return "Never";
  const date = new Date(dateString);
  const now = new Date();
  const diffMs = now - date;
  const diffMins = Math.floor(diffMs / 60000);
  const diffHours = Math.floor(diffMs / 3600000);
  const diffDays = Math.floor(diffMs / 86400000);

  if (diffMins < 1) return "Just now";
  if (diffMins < 60) return `${diffMins} minutes ago`;
  if (diffHours < 24) return `${diffHours} hours ago`;
  if (diffDays < 7) return `${diffDays} days ago`;
  return formatDateTime(dateString);
};

const formatDateTime = (dateString) => {
  if (!dateString) return "N/A";
  return new Date(dateString).toLocaleString("en-KE", {
    year: "numeric",
    month: "short",
    day: "numeric",
    hour: "2-digit",
    minute: "2-digit",
  });
};

const goBack = () => {
  router.back();
};

const copyToClipboard = async (text) => {
  try {
    await navigator.clipboard.writeText(text);
    showAlert("User ID copied to clipboard", "success");
  } catch (err) {
    showAlert("Failed to copy", "error");
  }
};

const showAlert = (message, type = "success") => {
  alertMessage.value = message;
  alertType.value = type;
  setTimeout(() => {
    alertMessage.value = "";
  }, 5000);
};

const clearAlert = () => {
  alertMessage.value = "";
};

// Change password - ONLY editable action
const changePassword = async () => {
  if (!isPasswordValid.value) return;

  changingPassword.value = true;
  try {
    const response = await apiClient.post("/Auth/change-password", {
      currentPassword: passwordForm.value.currentPassword,
      newPassword: passwordForm.value.newPassword,
      confirmNewPassword: passwordForm.value.confirmPassword,
    });

    const { isSuccess, error } = response.data;

    if (!isSuccess) {
      throw new Error(error || "Failed to change password");
    }

    showAlert("Password changed successfully", "success");

    // Reset form
    passwordForm.value = {
      currentPassword: "",
      newPassword: "",
      confirmPassword: "",
    };
  } catch (error) {
    showAlert(error.message || "Failed to change password", "error");
  } finally {
    changingPassword.value = false;
  }
};

// No initialization needed since we're just displaying user data from store
onMounted(() => {
  // Just verify user is logged in
  if (!authStore.isAuthenticated) {
    router.push("/login");
  }
});
</script>
