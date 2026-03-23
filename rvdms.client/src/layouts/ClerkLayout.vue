<!-- src/layouts/ClerkLayout.vue -->
<template>
  <div class="min-h-screen bg-slate-50 dark:bg-slate-900">
    <header
      class="bg-white dark:bg-slate-800 border-b border-slate-200 dark:border-slate-700 sticky top-0 z-40"
    >
      <div class="flex items-center justify-between px-4 md:px-6 py-3">
        <div class="flex items-center gap-3">
          <img
            src="@/assets/logos/ministry.jpg"
            alt="Ministry Logo"
            class="h-8 w-8 md:h-10 md:w-10 object-contain"
          />
          <div>
            <h1 class="text-sm font-semibold">Clerk of Works Dashboard</h1>
            <p class="text-xs text-slate-600">Project Management</p>
          </div>
        </div>
        <div class="flex items-center gap-3">
          <button @click="toggleTheme" class="p-2 rounded-lg hover:bg-slate-100">
            <SunIcon v-if="isDark" class="w-5 h-5 text-amber-400" /><MoonIcon
              v-else
              class="w-5 h-5"
            />
          </button>
          <div class="relative" ref="profileMenuRef">
            <button
              @click="showProfileMenu = !showProfileMenu"
              class="flex items-center gap-2 px-3 py-2 bg-white border rounded-lg"
            >
              <div class="w-8 h-8 bg-emerald-100 rounded-full flex items-center justify-center">
                <span class="text-sm font-medium">{{ userInitials }}</span>
              </div>
              <div class="hidden md:block">
                <p class="text-sm font-medium">{{ user?.fullName }}</p>
                <p class="text-xs text-slate-500">Clerk of Works</p>
              </div>
              <ChevronDownIcon class="w-4 h-4" />
            </button>
            <div
              v-if="showProfileMenu"
              class="absolute right-0 mt-2 w-48 bg-white rounded-lg shadow-lg border py-1 z-50"
            >
              <RouterLink
                to="/profile"
                class="flex items-center gap-2 px-4 py-2 text-sm hover:bg-slate-100"
                @click="showProfileMenu = false"
                ><UserIcon class="w-4 h-4" /> My Profile</RouterLink
              >
              <button
                @click="logout"
                class="flex items-center gap-2 px-4 py-2 text-sm text-red-600 hover:bg-red-50 w-full"
              >
                <LogOutIcon class="w-4 h-4" /> Logout
              </button>
            </div>
          </div>
        </div>
      </div>
    </header>
    <main class="p-4 md:p-6"><RouterView /></main>
  </div>
</template>

<script setup>
import { ref, computed, onMounted, onUnmounted } from "vue";
import { useRouter } from "vue-router";
import { useAuthStore } from "@/stores/AuthStore";
import { useThemeStore } from "@/stores/themeStore";
import { ChevronDownIcon, UserIcon, LogOutIcon, SunIcon, MoonIcon } from "lucide-vue-next";

const router = useRouter();
const authStore = useAuthStore();
const themeStore = useThemeStore();

const showProfileMenu = ref(false);
const profileMenuRef = ref(null);
const user = computed(() => authStore.user);
const isDark = computed(() => themeStore.isDark);
const userInitials = computed(() => {
  const u = user.value;
  if (!u) return "U";
  return (u.firstName?.charAt(0) || "") + (u.lastName?.charAt(0) || "");
});
const toggleTheme = () => themeStore.toggleTheme();
const logout = () => {
  authStore.logout();
  router.push("/login");
};
const handleClickOutside = (e) => {
  if (profileMenuRef.value && !profileMenuRef.value.contains(e.target))
    showProfileMenu.value = false;
};
onMounted(() => document.addEventListener("click", handleClickOutside));
onUnmounted(() => document.removeEventListener("click", handleClickOutside));
</script>
