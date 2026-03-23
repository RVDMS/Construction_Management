<!-- src/views/dashboard/admin/UserDetails.vue -->
<template>
  <div v-if="loading" class="flex justify-center py-12">
    <Loader2Icon class="w-8 h-8 animate-spin text-emerald-600" />
  </div>
  <div v-else-if="!user" class="text-center py-12">
    <AlertCircleIcon class="w-12 h-12 text-slate-400 mx-auto mb-3" />
    <p>User not found</p>
    <RouterLink to="/dashboard/users" class="text-emerald-600 mt-2 inline-block"
      >Back to Users</RouterLink
    >
  </div>
  <div v-else class="space-y-6">
    <div class="flex items-center gap-4">
      <button @click="goBack" class="p-2 hover:bg-slate-100 rounded-lg">
        <ArrowLeftIcon class="w-5 h-5" />
      </button>
      <div>
        <div class="flex items-center gap-3">
          <h1 class="text-2xl font-semibold">{{ user.fullName }}</h1>
          <span
            :class="['px-3 py-1 rounded-full text-xs font-medium', getRoleBadgeClass(user.role)]"
            >{{ getRoleDisplayName(user.role) }}</span
          >
        </div>
        <p class="text-slate-600 mt-1">{{ user.email }}</p>
      </div>
    </div>

    <div class="grid grid-cols-1 lg:grid-cols-3 gap-6">
      <div class="lg:col-span-2 space-y-6">
        <div class="bg-white rounded-xl border p-6">
          <h3 class="text-sm font-medium mb-4">Personal Information</h3>
          <div class="grid grid-cols-2 gap-4">
            <div>
              <p class="text-xs text-slate-500 mb-1">Full Name</p>
              <p class="text-sm font-medium">{{ user.fullName }}</p>
            </div>
            <div>
              <p class="text-xs text-slate-500 mb-1">Email</p>
              <p class="text-sm">{{ user.email }}</p>
            </div>
            <div>
              <p class="text-xs text-slate-500 mb-1">Phone</p>
              <p class="text-sm">{{ user.phoneNumber || "Not provided" }}</p>
            </div>
            <div>
              <p class="text-xs text-slate-500 mb-1">Username</p>
              <p class="text-sm">{{ user.userName }}</p>
            </div>
            <div>
              <p class="text-xs text-slate-500 mb-1">User ID</p>
              <div class="flex items-center gap-2">
                <p class="text-sm font-mono">{{ user.id }}</p>
                <button @click="copyToClipboard(user.id)" class="p-1 hover:bg-slate-100 rounded">
                  <CopyIcon class="w-3 h-3" />
                </button>
              </div>
            </div>
            <div>
              <p class="text-xs text-slate-500 mb-1">Status</p>
              <span
                :class="
                  user.isActive ? 'bg-emerald-100 text-emerald-700' : 'bg-red-100 text-red-700'
                "
                class="px-2 py-1 rounded-full text-xs"
                >{{ user.isActive ? "Active" : "Inactive" }}</span
              >
            </div>
          </div>
        </div>
        <div class="bg-white rounded-xl border p-6">
          <h3 class="text-sm font-medium mb-4 flex items-center gap-2">
            <ClockIcon class="w-4 h-4" />Account Activity
          </h3>
          <div class="grid grid-cols-2 gap-4">
            <div>
              <p class="text-xs text-slate-500 mb-1">Last Login</p>
              <p class="text-sm">{{ formatDateTime(user.lastLoginAt) || "Never" }}</p>
            </div>
            <div>
              <p class="text-xs text-slate-500 mb-1">Account Created</p>
              <p class="text-sm">{{ formatDateTime(user.createdAt) || "Unknown" }}</p>
            </div>
          </div>
        </div>
      </div>
      <div class="space-y-6">
        <div class="bg-white rounded-xl border p-6">
          <div class="flex justify-between mb-4">
            <h3 class="text-sm font-medium">Assigned Projects</h3>
            <span class="text-xs bg-slate-100 px-2 py-1 rounded-full"
              >{{ user.projectAssignments?.length || 0 }} projects</span
            >
          </div>
          <div v-if="!user.projectAssignments?.length" class="text-center py-8">
            <FolderOpenIcon class="w-12 h-12 text-slate-300 mx-auto mb-3" />
            <p class="text-slate-500">No projects assigned</p>
          </div>
          <div v-else class="space-y-3">
            <div
              v-for="assignment in user.projectAssignments"
              :key="assignment.projectId"
              @click="goToProject(assignment.projectId)"
              class="p-3 border rounded-lg hover:bg-slate-50 cursor-pointer"
            >
              <p class="text-sm font-medium">{{ assignment.projectName }}</p>
              <div class="flex gap-2 mt-2 text-xs text-slate-500">
                <span>{{ assignment.county }}</span
                ><span>•</span><span>{{ assignment.constituency }}</span
                ><span v-if="assignment.ward">•</span><span>{{ assignment.ward }}</span>
              </div>
            </div>
          </div>
        </div>
        <div class="bg-white rounded-xl border p-6">
          <h3 class="text-sm font-medium mb-4">Quick Actions</h3>
          <button
            v-if="user.role === 'COW'"
            @click="viewAssignedProject"
            class="w-full flex items-center gap-2 px-3 py-2 text-sm text-emerald-600 hover:bg-emerald-50 rounded-lg"
          >
            <FolderKanbanIcon class="w-4 h-4" /> View Assigned Project
          </button>
        </div>
      </div>
    </div>
  </div>
</template>

<script setup>
import { ref, onMounted } from "vue";
import { useRoute, useRouter, RouterLink } from "vue-router";
import { useUserStore } from "@/stores/userStore";
import { getRoleDisplayName, formatDateTime } from "@/utils/permissions";
import {
  ArrowLeft as ArrowLeftIcon,
  Clock as ClockIcon,
  FolderOpen as FolderOpenIcon,
  FolderKanban as FolderKanbanIcon,
  Copy as CopyIcon,
  AlertCircle as AlertCircleIcon,
  Loader2 as Loader2Icon,
} from "lucide-vue-next";

const route = useRoute();
const router = useRouter();
const userStore = useUserStore();

const user = ref(null);
const loading = ref(true);

const getRoleBadgeClass = (role) =>
  ({
    CS: "bg-purple-100 text-purple-700",
    RL: "bg-blue-100 text-blue-700",
    CDH: "bg-emerald-100 text-emerald-700",
    COW: "bg-amber-100 text-amber-700",
    TL: "bg-slate-100 text-slate-700",
  })[role] || "bg-slate-100";
const copyToClipboard = async (text) => {
  try {
    await navigator.clipboard.writeText(text);
  } catch (err) {
    console.error(err);
  }
};
const goBack = () => router.back();
const goToProject = (id) => router.push(`/dashboard/projects/${id}`);
const viewAssignedProject = () => {
  if (user.value.projectAssignments?.length)
    router.push(`/dashboard/projects/${user.value.projectAssignments[0].projectId}`);
};

onMounted(async () => {
  loading.value = true;
  try {
    await userStore.fetchUserById(route.params.id);
    user.value = userStore.selectedUser;
  } finally {
    loading.value = false;
  }
});
</script>
