<!-- src/views/dashboard/admin/UsersList.vue -->
<template>
  <div class="space-y-6">
    <div class="flex flex-col md:flex-row md:items-center md:justify-between gap-4">
      <div>
        <h1 class="text-2xl md:text-3xl font-semibold text-slate-900 dark:text-white">All Users</h1>
        <p class="text-slate-600 dark:text-slate-400 mt-1">
          Manage system users and their assignments
        </p>
      </div>
      <RouterLink
        to="/dashboard"
        class="inline-flex items-center gap-1 px-3 py-1.5 text-sm text-slate-600 hover:text-emerald-600 transition-colors"
      >
        <ArrowLeftIcon class="w-4 h-4" /> Back to Dashboard
      </RouterLink>
    </div>

    <!-- Filters -->
    <div
      class="bg-white dark:bg-slate-800 rounded-xl border border-slate-200 dark:border-slate-700 p-4"
    >
      <div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-4">
        <!-- Search -->
        <div>
          <label class="block text-sm text-slate-700 dark:text-slate-300 mb-1">Search</label>
          <input
            v-model="filters.searchTerm"
            type="text"
            placeholder="Name, email, phone..."
            @input="debouncedSearch"
            class="w-full px-3 py-2 border border-slate-300 dark:border-slate-600 rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500 dark:bg-slate-700 dark:text-white"
          />
        </div>

        <!-- Role Filter - Sends to API as array -->
        <div>
          <label class="block text-sm text-slate-700 dark:text-slate-300 mb-1">Role</label>
          <select
            v-model="filters.role"
            @change="applyFilters"
            class="w-full px-3 py-2 border border-slate-300 dark:border-slate-600 rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500 dark:bg-slate-700 dark:text-white"
          >
            <option value="">All Roles</option>
            <option value="COW">Clerk of Works (COW)</option>
            <option value="TL">Technical Lead (TL)</option>
            <option value="CS">Cluster Supervisor (CS)</option>
            <option value="RL">Regional Lead (RL)</option>
            <option value="CDH">County Director (CDH)</option>
          </select>
        </div>

        <!-- Status Filter -->
        <div>
          <label class="block text-sm text-slate-700 dark:text-slate-300 mb-1">Status</label>
          <select
            v-model="filters.isActive"
            @change="applyFilters"
            class="w-full px-3 py-2 border border-slate-300 dark:border-slate-600 rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500 dark:bg-slate-700 dark:text-white"
          >
            <option value="">All</option>
            <option value="true">Active</option>
            <option value="false">Inactive</option>
          </select>
        </div>

        <!-- County Filter (Optional - for future) -->
        <div>
          <label class="block text-sm text-slate-700 dark:text-slate-300 mb-1">County</label>
          <select
            v-model="filters.countyId"
            @change="applyFilters"
            class="w-full px-3 py-2 border border-slate-300 dark:border-slate-600 rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500 dark:bg-slate-700 dark:text-white"
          >
            <option value="">All Counties</option>
            <option v-for="county in counties" :key="county.id" :value="county.id">
              {{ county.name }}
            </option>
          </select>
        </div>
      </div>

      <!-- Active Filters Display -->
      <div
        v-if="hasActiveFilters"
        class="flex flex-wrap gap-2 mt-4 pt-4 border-t border-slate-200 dark:border-slate-700"
      >
        <span class="text-xs text-slate-500 dark:text-slate-400">Active filters:</span>
        <button
          v-if="filters.searchTerm"
          @click="clearFilter('searchTerm')"
          class="inline-flex items-center gap-1 px-2 py-1 bg-slate-100 dark:bg-slate-700 rounded-full text-xs"
        >
          Search: {{ filters.searchTerm }}
          <XIcon class="w-3 h-3" />
        </button>
        <button
          v-if="filters.role"
          @click="clearFilter('role')"
          class="inline-flex items-center gap-1 px-2 py-1 bg-slate-100 dark:bg-slate-700 rounded-full text-xs"
        >
          Role: {{ getRoleDisplayName(filters.role) }}
          <XIcon class="w-3 h-3" />
        </button>
        <button
          v-if="filters.isActive"
          @click="clearFilter('isActive')"
          class="inline-flex items-center gap-1 px-2 py-1 bg-slate-100 dark:bg-slate-700 rounded-full text-xs"
        >
          Status: {{ filters.isActive === "true" ? "Active" : "Inactive" }}
          <XIcon class="w-3 h-3" />
        </button>
        <button
          v-if="filters.countyId"
          @click="clearFilter('countyId')"
          class="inline-flex items-center gap-1 px-2 py-1 bg-slate-100 dark:bg-slate-700 rounded-full text-xs"
        >
          County: {{ getCountyName(filters.countyId) }}
          <XIcon class="w-3 h-3" />
        </button>
        <button @click="clearAllFilters" class="text-xs text-emerald-600 hover:text-emerald-700">
          Clear all
        </button>
      </div>
    </div>

    <!-- Users Table -->
    <div
      class="bg-white dark:bg-slate-800 rounded-xl border border-slate-200 dark:border-slate-700 shadow-sm overflow-hidden"
    >
      <div class="overflow-x-auto">
        <table class="w-full text-sm">
          <thead class="bg-slate-50 dark:bg-slate-700/50 text-slate-600 dark:text-slate-300">
            <tr>
              <th class="px-6 py-3 text-left font-medium">Name</th>
              <th class="px-6 py-3 text-left font-medium">Email</th>
              <th class="px-6 py-3 text-left font-medium">Phone</th>
              <th class="px-6 py-3 text-left font-medium">Role</th>
              <th class="px-6 py-3 text-left font-medium">Status</th>
              <th class="px-6 py-3 text-left font-medium">Projects</th>
              <th class="px-6 py-3 text-left font-medium">Last Login</th>
            </tr>
          </thead>
          <tbody class="divide-y divide-slate-200 dark:divide-slate-700">
            <tr
              v-for="user in users"
              :key="user.id"
              @click="goToUser(user.id)"
              class="hover:bg-slate-50 dark:hover:bg-slate-700/50 cursor-pointer transition-colors"
            >
              <td class="px-6 py-4">
                <div>
                  <p class="font-medium text-slate-900 dark:text-white">{{ user.fullName }}</p>
                  <p class="text-xs text-slate-500 dark:text-slate-400 mt-1">
                    ID: {{ user.id?.slice(0, 8) || "" }}...
                  </p>
                </div>
              </td>
              <td class="px-6 py-4 text-slate-700 dark:text-slate-300">{{ user.email }}</td>
              <td class="px-6 py-4 text-slate-700 dark:text-slate-300">
                {{ user.phoneNumber || "N/A" }}
              </td>
              <td class="px-6 py-4">
                <span
                  :class="[
                    'px-2 py-1 rounded-full text-xs font-medium',
                    getRoleBadgeClass(user.role),
                  ]"
                >
                  {{ getRoleDisplayName(user.role) }}
                </span>
              </td>
              <td class="px-6 py-4">
                <span
                  :class="
                    user.isActive ? 'bg-emerald-100 text-emerald-700' : 'bg-red-100 text-red-700'
                  "
                  class="px-2 py-1 rounded-full text-xs"
                >
                  {{ user.isActive ? "Active" : "Inactive" }}
                </span>
              </td>
              <td class="px-6 py-4 text-slate-700 dark:text-slate-300">
                {{ user.projectAssignments?.length || 0 }} assigned
              </td>
              <td class="px-6 py-4 text-slate-500 dark:text-slate-400 text-xs">
                {{ formatDate(user.lastLoginAt) }}
              </td>
            </tr>
            <tr v-if="users.length === 0 && !loading">
              <td colspan="7" class="px-6 py-12 text-center">
                <div class="flex flex-col items-center gap-3">
                  <UsersIcon class="w-12 h-12 text-slate-300 dark:text-slate-600" />
                  <p class="text-slate-500 dark:text-slate-400">No users found</p>
                  <button
                    @click="clearAllFilters"
                    class="text-sm text-emerald-600 hover:text-emerald-700"
                  >
                    Clear filters
                  </button>
                </div>
              </td>
            </tr>
            <tr v-if="loading">
              <td colspan="7" class="px-6 py-12 text-center">
                <Loader2Icon class="w-8 h-8 animate-spin text-emerald-600 mx-auto" />
                <p class="text-slate-500 dark:text-slate-400 mt-2">Loading users...</p>
              </td>
            </tr>
          </tbody>
        </table>
      </div>

      <!-- Pagination -->
      <div
        class="px-6 py-4 border-t border-slate-200 dark:border-slate-700 flex items-center justify-between flex-wrap gap-3"
      >
        <div class="text-sm text-slate-600 dark:text-slate-400">
          Showing {{ (pagination.pageNumber - 1) * pagination.pageSize + 1 }} -
          {{ Math.min(pagination.pageNumber * pagination.pageSize, pagination.totalRecords) }} of
          {{ pagination.totalRecords }} users
        </div>
        <div class="flex items-center gap-2">
          <button
            @click="changePage(pagination.pageNumber - 1)"
            :disabled="!pagination.hasPreviousPage"
            class="px-3 py-1 border border-slate-300 dark:border-slate-600 rounded-lg disabled:opacity-50 disabled:cursor-not-allowed hover:bg-slate-50 dark:hover:bg-slate-700 transition-colors"
          >
            Previous
          </button>
          <span class="text-sm text-slate-600 dark:text-slate-400">
            Page {{ pagination.pageNumber }} of {{ pagination.totalPages }}
          </span>
          <button
            @click="changePage(pagination.pageNumber + 1)"
            :disabled="!pagination.hasNextPage"
            class="px-3 py-1 border border-slate-300 dark:border-slate-600 rounded-lg disabled:opacity-50 disabled:cursor-not-allowed hover:bg-slate-50 dark:hover:bg-slate-700 transition-colors"
          >
            Next
          </button>
        </div>
      </div>
    </div>
  </div>
</template>

<script setup>
import { ref, computed, onMounted } from "vue";
import { useRouter, RouterLink } from "vue-router";
import { useUserStore } from "@/stores/userStore";
import { getRoleDisplayName, formatDate } from "@/utils/permissions";
import {
  ArrowLeft as ArrowLeftIcon,
  X as XIcon,
  Users as UsersIcon,
  Loader2 as Loader2Icon,
} from "lucide-vue-next";

const router = useRouter();
const userStore = useUserStore();

// State
const filters = ref({
  searchTerm: "",
  role: "",
  isActive: "",
  countyId: "",
});
const searchTimeout = ref(null);

// Counties data (from your seed data)
const counties = ref([
  { id: "20000000-0000-0000-0000-000000000001", name: "Trans-Nzoia" },
  { id: "20000000-0000-0000-0000-000000000002", name: "Uasin Gishu" },
  { id: "20000000-0000-0000-0000-000000000003", name: "Elgeyo Marakwet" },
  { id: "20000000-0000-0000-0000-000000000004", name: "Nandi" },
  { id: "20000000-0000-0000-0000-000000000005", name: "Kericho" },
  { id: "20000000-0000-0000-0000-000000000006", name: "Bomet" },
  { id: "20000000-0000-0000-0000-000000000007", name: "Nakuru" },
  { id: "20000000-0000-0000-0000-000000000008", name: "Narok" },
  { id: "20000000-0000-0000-0000-000000000009", name: "Baringo" },
  { id: "20000000-0000-0000-0000-000000000010", name: "Samburu" },
  { id: "20000000-0000-0000-0000-000000000011", name: "Turkana" },
  { id: "20000000-0000-0000-0000-000000000012", name: "West Pokot" },
]);

// Computed - Direct from store (no client-side filtering needed)
const users = computed(() => userStore.users);
const pagination = computed(() => userStore.pagination);
const loading = computed(() => userStore.loading);

const hasActiveFilters = computed(() => {
  return (
    filters.value.searchTerm ||
    filters.value.role ||
    filters.value.isActive ||
    filters.value.countyId
  );
});

// Helper to get county name
const getCountyName = (id) => {
  const county = counties.value.find((c) => c.id === id);
  return county ? county.name : id;
};

// Role badge styling
const getRoleBadgeClass = (role) => {
  const classes = {
    CS: "bg-purple-100 text-purple-700 dark:bg-purple-900/30 dark:text-purple-400",
    RL: "bg-blue-100 text-blue-700 dark:bg-blue-900/30 dark:text-blue-400",
    CDH: "bg-emerald-100 text-emerald-700 dark:bg-emerald-900/30 dark:text-emerald-400",
    COW: "bg-amber-100 text-amber-700 dark:bg-amber-900/30 dark:text-amber-400",
    TL: "bg-slate-100 text-slate-700 dark:bg-slate-700 dark:text-slate-300",
  };
  return classes[role] || "bg-slate-100 text-slate-700";
};

// Methods
const goToUser = (id) => {
  router.push(`/dashboard/users/${id}`);
};

const applyFilters = () => {
  const params = {
    pageNumber: 1,
    pageSize: pagination.value.pageSize,
    searchTerm: filters.value.searchTerm || undefined,
    role: filters.value.role || undefined,
    isActive: filters.value.isActive || undefined,
    countyId: filters.value.countyId || undefined,
  };
  userStore.fetchUsers(params);
};

const debouncedSearch = () => {
  if (searchTimeout.value) clearTimeout(searchTimeout.value);
  searchTimeout.value = setTimeout(() => {
    applyFilters();
  }, 300);
};

const clearFilter = (filter) => {
  filters.value[filter] = "";
  applyFilters();
};

const clearAllFilters = () => {
  filters.value = {
    searchTerm: "",
    role: "",
    isActive: "",
    countyId: "",
  };
  applyFilters();
};

const changePage = (page) => {
  if (page >= 1 && page <= pagination.value.totalPages) {
    userStore.fetchUsers({
      pageNumber: page,
      pageSize: pagination.value.pageSize,
      searchTerm: filters.value.searchTerm || undefined,
      role: filters.value.role || undefined,
      isActive: filters.value.isActive || undefined,
      countyId: filters.value.countyId || undefined,
    });
  }
};

// Load initial data
onMounted(() => {
  userStore.fetchUsers({ pageSize: 10 });
});
</script>
