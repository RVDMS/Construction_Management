<!-- src/views/dashboard/admin/ProjectDetails.vue -->
<template>
  <div v-if="loading" class="flex justify-center py-12">
    <Loader2Icon class="w-8 h-8 animate-spin text-emerald-600" />
  </div>
  <div v-else-if="!project" class="text-center py-12">
    <AlertCircleIcon class="w-12 h-12 text-slate-400 mx-auto mb-3" />
    <p>Project not found</p>
    <RouterLink to="/dashboard/projects" class="text-emerald-600 mt-2 inline-block"
      >Back to Projects</RouterLink
    >
  </div>
  <div v-else class="space-y-6">
    <!-- Header -->
    <div class="flex items-center gap-4">
      <button @click="goBack" class="p-2 hover:bg-slate-100 rounded-lg">
        <ArrowLeftIcon class="w-5 h-5" />
      </button>
      <div>
        <div class="flex items-center gap-3 flex-wrap">
          <h1 class="text-2xl font-semibold">{{ project.name }}</h1>
          <span
            :class="[
              'px-3 py-1 rounded-full text-xs font-medium',
              getStatusBadgeClass(project.progressStatus),
            ]"
            >{{ project.progressStatus }}</span
          >
        </div>
        <p class="text-slate-600 mt-1">Tender: {{ project.tenderNumber }}</p>
      </div>
    </div>

    <!-- Tabs -->
    <div class="border-b border-slate-200">
      <div class="flex gap-6 overflow-x-auto">
        <button
          @click="activeTab = 'overview'"
          :class="[
            'pb-3 px-1 text-sm font-medium transition-colors whitespace-nowrap',
            activeTab === 'overview'
              ? 'text-emerald-600 border-b-2 border-emerald-600'
              : 'text-slate-500 hover:text-slate-700',
          ]"
        >
          Overview
        </button>
        <button
          @click="activeTab = 'assignments'"
          :class="[
            'pb-3 px-1 text-sm font-medium transition-colors whitespace-nowrap',
            activeTab === 'assignments'
              ? 'text-emerald-600 border-b-2 border-emerald-600'
              : 'text-slate-500 hover:text-slate-700',
          ]"
        >
          Team Assignments
          <span
            v-if="assignments.length > 0"
            class="ml-1.5 px-1.5 py-0.5 text-xs bg-slate-100 text-slate-600 rounded-full"
          >
            {{ assignments.length }}
          </span>
        </button>
        <button
          @click="activeTab = 'reports'"
          :class="[
            'pb-3 px-1 text-sm font-medium transition-colors whitespace-nowrap',
            activeTab === 'reports'
              ? 'text-emerald-600 border-b-2 border-emerald-600'
              : 'text-slate-500 hover:text-slate-700',
          ]"
        >
          Weekly Reports
          <span
            v-if="reports.length > 0"
            class="ml-1.5 px-1.5 py-0.5 text-xs bg-slate-100 text-slate-600 rounded-full"
          >
            {{ reports.length }}
          </span>
        </button>
      </div>
    </div>

    <!-- ==================== OVERVIEW TAB ==================== -->
    <div v-if="activeTab === 'overview'" class="grid grid-cols-1 lg:grid-cols-3 gap-6">
      <!-- Left Column -->
      <div class="lg:col-span-2 space-y-6">
        <div class="bg-white rounded-xl border p-6">
          <h3 class="text-sm font-medium mb-4">Project Information</h3>
          <div class="grid grid-cols-2 gap-4">
            <div>
              <p class="text-xs text-slate-500 mb-1">Description</p>
              <p class="text-sm">{{ project.description || "No description" }}</p>
            </div>
            <div>
              <p class="text-xs text-slate-500 mb-1">Contractor</p>
              <p class="text-sm font-medium">{{ project.contractorName || "Not assigned" }}</p>
            </div>
            <div>
              <p class="text-xs text-slate-500 mb-1">Consultant</p>
              <p class="text-sm font-medium">{{ project.consultantName || "Not assigned" }}</p>
            </div>
            <div>
              <p class="text-xs text-slate-500 mb-1">Contract Sum</p>
              <p class="text-lg font-semibold">KES {{ formatCurrencyFull(project.contractSum) }}</p>
            </div>
          </div>
        </div>

        <div class="bg-white rounded-xl border p-6">
          <h3 class="text-sm font-medium mb-4 flex items-center gap-2">
            <MapPinIcon class="w-4 h-4" />Location
          </h3>
          <div class="grid grid-cols-3 gap-4">
            <div>
              <p class="text-xs text-slate-500 mb-1">County</p>
              <p class="text-sm">{{ project.county }}</p>
            </div>
            <div>
              <p class="text-xs text-slate-500 mb-1">Constituency</p>
              <p class="text-sm">{{ project.constituency }}</p>
            </div>
            <div>
              <p class="text-xs text-slate-500 mb-1">Ward</p>
              <p class="text-sm">{{ project.ward || "N/A" }}</p>
            </div>
          </div>
        </div>
      </div>

      <!-- Right Column -->
      <div class="space-y-6">
        <div class="bg-white rounded-xl border p-6 text-center">
          <div class="relative w-32 h-32 mx-auto">
            <svg viewBox="0 0 100 100">
              <circle cx="50" cy="50" r="45" fill="none" stroke="#e2e8f0" stroke-width="10" />
              <circle
                cx="50"
                cy="50"
                r="45"
                fill="none"
                :stroke="progressCircleColor"
                stroke-width="10"
                stroke-linecap="round"
                :stroke-dasharray="283"
                :stroke-dashoffset="283 - (283 * project.currentPhysicalProgress) / 100"
                transform="rotate(-90 50 50)"
              />
              <text
                x="50"
                y="50"
                text-anchor="middle"
                dominant-baseline="middle"
                class="text-2xl font-bold fill-slate-900"
              >
                {{ project.currentPhysicalProgress }}%
              </text>
            </svg>
          </div>
          <p class="text-sm text-slate-600 mt-2">Physical Progress</p>
          <div class="mt-4 space-y-2">
            <div class="flex justify-between">
              <span class="text-sm">Time Elapsed</span>
              <span>{{ project.timeElapsedPercentage }}%</span>
            </div>
            <div class="bg-slate-200 rounded-full h-2">
              <div
                class="bg-blue-500 h-2 rounded-full"
                :style="{ width: `${project.timeElapsedPercentage}%` }"
              ></div>
            </div>
            <div class="flex justify-between mt-3">
              <span class="text-sm">Variance</span>
              <span :class="project.variance >= 0 ? 'text-emerald-600' : 'text-red-600'"
                >{{ project.variance }}%</span
              >
            </div>
          </div>
        </div>

        <div class="bg-white rounded-xl border p-6">
          <h3 class="text-sm font-medium mb-3">Budget</h3>
          <div>
            <p class="text-xs text-slate-500 mb-1">Contract Sum</p>
            <p class="text-lg font-semibold">KES {{ formatCurrencyFull(project.contractSum) }}</p>
          </div>
          <div class="mt-3">
            <p class="text-xs text-slate-500 mb-1">Remaining</p>
            <p class="text-lg font-semibold text-blue-600">
              KES {{ formatCurrencyFull(project.remainingBudget) }}
            </p>
          </div>
        </div>

        <div class="bg-white rounded-xl border p-6">
          <h3 class="text-sm font-medium mb-3 flex items-center gap-2">
            <UsersIcon class="w-4 h-4" />Project Team
          </h3>
          <div class="space-y-3">
            <div>
              <p class="text-xs text-slate-500">Clerk of Works</p>
              <p class="text-sm font-medium">{{ project.clerkOfWorks || "Not assigned" }}</p>
            </div>
            <div>
              <p class="text-xs text-slate-500">Cluster Supervisor</p>
              <p class="text-sm font-medium">{{ project.clusterSupervisor || "Not assigned" }}</p>
            </div>
            <div>
              <p class="text-xs text-slate-500">Total Reports</p>
              <p class="text-sm font-medium">{{ reports.length }} submitted</p>
            </div>
          </div>
        </div>

        <div v-if="project.isAtRisk" class="bg-red-50 border border-red-200 rounded-xl p-4">
          <div class="flex gap-3">
            <AlertCircleIcon class="w-5 h-5 text-red-600 flex-shrink-0" />
            <div>
              <h4 class="text-sm font-medium text-red-800">Project at Risk</h4>
              <p class="text-sm text-red-700">
                Delayed by {{ Math.abs(project.variance) }}%.
                {{ formatRemainingTime(project.daysRemaining) }} left to complete
                {{ (100 - project.currentPhysicalProgress).toFixed(1) }}% of work.
              </p>
            </div>
          </div>
        </div>
      </div>
    </div>

    <!-- ==================== TEAM ASSIGNMENTS TAB ==================== -->
    <div v-if="activeTab === 'assignments'" class="space-y-6">
      <!-- Assign Button - ONLY for RL and SuperAdmin -->
      <div class="flex justify-end">
        <button
          v-if="userRole === 'RL' || userRole === 'SuperAdmin'"
          @click="showAssignmentModal = true"
          class="inline-flex items-center gap-2 px-4 py-2 bg-emerald-600 text-white rounded-lg hover:bg-emerald-700"
        >
          <UserPlusIcon class="w-4 h-4" />
          Assign User
        </button>
      </div>

      <!-- Current Assignments -->
      <div class="bg-white rounded-xl border overflow-hidden">
        <div class="px-6 py-4 border-b border-slate-200 bg-slate-50">
          <h3 class="text-sm font-medium">Project Assignments</h3>
          <p class="text-xs text-slate-500 mt-1">Users assigned to this project and their roles</p>
        </div>

        <div v-if="assignmentsLoading" class="p-12 text-center">
          <Loader2Icon class="w-8 h-8 animate-spin text-emerald-600 mx-auto" />
          <p class="mt-2 text-slate-500">Loading assignments...</p>
        </div>

        <div v-else-if="assignments.length === 0" class="p-12 text-center">
          <UsersIcon class="w-12 h-12 text-slate-300 mx-auto mb-3" />
          <p class="text-slate-500">No users assigned to this project yet</p>
          <p
            v-if="userRole === 'RL' || userRole === 'SuperAdmin'"
            class="text-xs text-slate-400 mt-2"
          >
            Click the "Assign User" button to add team members
          </p>
        </div>

        <div v-else class="divide-y divide-slate-200">
          <div v-for="assignment in assignments" :key="assignment.id" class="p-4">
            <div class="flex items-center justify-between">
              <div class="flex items-center gap-4 flex-1">
                <div class="w-10 h-10 bg-slate-100 rounded-full flex items-center justify-center">
                  <span class="text-sm font-medium text-slate-600">
                    {{ assignment.userName?.charAt(0) || "U" }}
                  </span>
                </div>
                <div class="flex-1">
                  <div class="flex items-center gap-2 flex-wrap">
                    <p class="font-medium text-slate-900">{{ assignment.userName }}</p>
                    <span
                      :class="[
                        'px-2 py-0.5 rounded-full text-xs font-medium',
                        getRoleBadgeClass(assignment.role),
                      ]"
                    >
                      {{ getRoleDisplayName(assignment.role) }}
                    </span>
                    <span
                      v-if="assignment.revokedAt"
                      class="px-2 py-0.5 rounded-full text-xs bg-red-100 text-red-700"
                    >
                      Revoked
                    </span>
                  </div>
                  <p class="text-xs text-slate-500 mt-0.5">{{ assignment.userEmail }}</p>
                  <!-- Phone Number - Clickable to dial -->
                  <div class="flex items-center gap-2 mt-1">
                    <a
                      v-if="assignment.userPhoneNumber"
                      :href="`tel:${assignment.userPhoneNumber}`"
                      class="text-xs text-emerald-600 hover:text-emerald-700 flex items-center gap-1"
                    >
                      <PhoneIcon class="w-3 h-3" />
                      {{ formatPhoneNumber(assignment.userPhoneNumber) }}
                    </a>
                    <span v-else class="text-xs text-slate-400">No phone number</span>
                  </div>
                  <p class="text-xs text-slate-400 mt-1">
                    Assigned: {{ formatDate(assignment.assignedAt) }}
                    <span v-if="assignment.revokedAt">
                      • Revoked: {{ formatDate(assignment.revokedAt) }}</span
                    >
                  </p>
                </div>
              </div>
              <!-- Revoke Button - ONLY for RL and SuperAdmin -->
              <button
                v-if="(userRole === 'RL' || userRole === 'SuperAdmin') && !assignment.revokedAt"
                @click="revokeAssignment(assignment.id)"
                class="text-red-600 hover:text-red-700 p-2 hover:bg-red-50 rounded-lg transition-colors"
                title="Revoke Assignment"
              >
                <Trash2Icon class="w-4 h-4" />
              </button>
            </div>
          </div>
        </div>
      </div>
    </div>

    <!-- ==================== REPORTS TAB ==================== -->
    <div v-if="activeTab === 'reports'" class="space-y-4">
      <div class="flex justify-between items-center">
        <div>
          <h3 class="text-lg font-medium">Weekly Progress Reports</h3>
          <p class="text-sm text-slate-500">
            {{ reports.length }} report{{ reports.length !== 1 ? "s" : "" }} submitted
          </p>
        </div>
        <button
          @click="exportReports"
          class="inline-flex items-center gap-2 px-4 py-2 bg-emerald-600 text-white rounded-lg hover:bg-emerald-700"
        >
          <DownloadIcon class="w-4 h-4" />
          Export All
        </button>
      </div>

      <div class="bg-white rounded-xl border overflow-hidden">
        <div v-if="reportsLoading" class="p-12 text-center">
          <Loader2Icon class="w-8 h-8 animate-spin text-emerald-600 mx-auto" />
          <p class="mt-2 text-slate-500">Loading reports...</p>
        </div>
        <div v-else-if="reports.length === 0" class="p-12 text-center">
          <FileTextIcon class="w-12 h-12 text-slate-300 mx-auto mb-3" />
          <p class="text-slate-500">No reports have been submitted for this project yet.</p>
        </div>
        <div v-else class="overflow-x-auto">
          <table class="w-full text-sm">
            <thead class="bg-slate-50">
              <tr>
                <th class="px-6 py-3 text-left font-medium text-slate-600">Report Details</th>
                <th class="px-6 py-3 text-left font-medium text-slate-600 w-24">Progress</th>
                <th class="px-6 py-3 text-left font-medium text-slate-600 w-32">Submitted</th>
                <th class="px-6 py-3 text-left font-medium text-slate-600 w-32">Submitted By</th>
                <th class="px-6 py-3 text-left font-medium text-slate-600 w-24">Status</th>
                <th class="px-6 py-3 text-left font-medium text-slate-600 w-24">Action</th>
              </tr>
            </thead>
            <tbody class="divide-y divide-slate-200">
              <tr v-for="report in reports" :key="report.id" class="hover:bg-slate-50">
                <td class="px-6 py-4">
                  <div>
                    <p class="font-medium text-slate-900">{{ report.title }}</p>
                    <p class="text-xs text-slate-500 mt-1 line-clamp-2">{{ report.description }}</p>
                  </div>
                </td>
                <td class="px-6 py-4">
                  <div class="flex items-center gap-2">
                    <span class="font-medium">{{ report.progress }}%</span>
                    <div class="w-16 bg-slate-200 rounded-full h-1.5">
                      <div
                        class="h-1.5 rounded-full"
                        :class="getReportProgressClass(report.progress)"
                        :style="{ width: `${report.progress}%` }"
                      ></div>
                    </div>
                  </div>
                </td>
                <td class="px-6 py-4 text-slate-600 text-xs">{{ formatDate(report.createdAt) }}</td>
                <td class="px-6 py-4 text-slate-600">
                  {{ report.createdByName || report.createdById?.substring(0, 8) }}
                </td>
                <td class="px-6 py-4">
                  <span
                    v-if="report.isGeoValidated"
                    class="inline-flex items-center gap-1 px-2 py-1 rounded-full text-xs font-medium bg-green-100 text-green-700"
                  >
                    <CheckCircleIcon class="w-3 h-3" /> Verified
                  </span>
                  <span
                    v-else
                    class="inline-flex items-center gap-1 px-2 py-1 rounded-full text-xs font-medium bg-amber-100 text-amber-700"
                  >
                    <AlertTriangleIcon class="w-3 h-3" /> Off-site
                  </span>
                </td>
                <td class="px-6 py-4">
                  <button
                    @click="downloadReport(report)"
                    class="text-emerald-600 hover:text-emerald-700 text-sm flex items-center gap-1"
                  >
                    <DownloadIcon class="w-4 h-4" /> Download
                  </button>
                </td>
              </tr>
            </tbody>
          </table>
        </div>
      </div>
    </div>

    <!-- ==================== ASSIGNMENT MODAL (Only for RL/SuperAdmin) ==================== -->
    <div
      v-if="showAssignmentModal && (userRole === 'RL' || userRole === 'SuperAdmin')"
      class="fixed inset-0 bg-black/50 flex items-center justify-center z-50 p-4"
      @click.self="showAssignmentModal = false"
    >
      <div class="bg-white rounded-xl max-w-md w-full p-6">
        <div class="flex justify-between items-center mb-4">
          <h3 class="text-lg font-semibold">Assign User to Project</h3>
          <button @click="showAssignmentModal = false" class="text-slate-400 hover:text-slate-600">
            <XIcon class="w-5 h-5" />
          </button>
        </div>

        <div class="space-y-4">
          <div>
            <label class="block text-sm font-medium mb-1">Role</label>
            <select
              v-model="assignmentForm.role"
              @change="onRoleChange"
              class="w-full px-3 py-2 border rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500"
            >
              <option value="">Select Role</option>
              <option value="COW">Clerk of Works (COW)</option>
              <option value="TL">Technical Lead (TL)</option>
              <option value="CS">Cluster Supervisor (CS)</option>
            </select>
          </div>

          <div>
            <label class="block text-sm font-medium mb-1">User</label>
            <select
              v-model="assignmentForm.userId"
              class="w-full px-3 py-2 border rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500"
              :disabled="!assignmentForm.role"
            >
              <option value="">Select User</option>
              <option v-for="user in assignableUsers" :key="user.id" :value="user.id">
                {{ user.name }} ({{ user.email }}) - {{ getRoleDisplayName(user.role) }}
              </option>
            </select>
            <p
              v-if="!assignmentForm.role && assignableUsers.length === 0"
              class="text-xs text-amber-600 mt-1"
            >
              Please select a role first to see available users
            </p>
          </div>

          <div class="flex gap-3 pt-4">
            <button
              @click="showAssignmentModal = false"
              class="flex-1 px-4 py-2 border rounded-lg hover:bg-slate-50"
            >
              Cancel
            </button>
            <button
              @click="submitAssignment"
              :disabled="submittingAssignment || !assignmentForm.role || !assignmentForm.userId"
              class="flex-1 px-4 py-2 bg-emerald-600 text-white rounded-lg hover:bg-emerald-700 disabled:opacity-50 disabled:cursor-not-allowed"
            >
              {{ submittingAssignment ? "Assigning..." : "Assign User" }}
            </button>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script setup>
import { ref, computed, onMounted } from "vue";
import { useRoute, useRouter, RouterLink } from "vue-router";
import { useToast } from "vue-toastification";
import { useProjectStore } from "@/stores/projectStore";
import { useAuthStore } from "@/stores/AuthStore";
import apiClient from "@/services/apiClient";
import { getStatusBadgeClass, formatDate, getRoleDisplayName } from "@/utils/permissions";
import {
  ArrowLeft as ArrowLeftIcon,
  MapPin as MapPinIcon,
  Users as UsersIcon,
  AlertCircle as AlertCircleIcon,
  Loader2 as Loader2Icon,
  Download as DownloadIcon,
  FileText as FileTextIcon,
  CheckCircle as CheckCircleIcon,
  AlertTriangle as AlertTriangleIcon,
  UserPlus as UserPlusIcon,
  Trash2 as Trash2Icon,
  X as XIcon,
  Phone as PhoneIcon,
} from "lucide-vue-next";

const route = useRoute();
const router = useRouter();
const toast = useToast();
const projectStore = useProjectStore();
const authStore = useAuthStore();

// State
const project = ref(null);
const loading = ref(true);
const activeTab = ref("overview");
const reports = ref([]);
const reportsLoading = ref(false);
const assignments = ref([]);
const assignmentsLoading = ref(false);
const assignableUsers = ref([]);
const showAssignmentModal = ref(false);
const submittingAssignment = ref(false);
const assignmentForm = ref({
  role: "",
  userId: "",
});

// Get user role from auth store
const userRole = computed(() => authStore.userRole);

const progressCircleColor = computed(() => {
  const progress = project.value?.currentPhysicalProgress || 0;
  if (progress >= 75) return "#10b981";
  if (progress >= 50) return "#f59e0b";
  return "#ef4444";
});

// Helper Functions
const formatCurrencyFull = (value) => {
  if (!value && value !== 0) return "0";
  const number = typeof value === "string" ? parseFloat(value) : value;
  return number.toLocaleString("en-KE", {
    minimumFractionDigits: 2,
    maximumFractionDigits: 2,
  });
};

const formatPhoneNumber = (phone) => {
  if (!phone) return "";
  return phone;
};

const getRemainingMonths = (days) => {
  if (!days || days <= 0) return 0;
  return days / 30.44;
};

const formatRemainingTime = (days) => {
  if (!days || days <= 0) return "Completed";
  const months = getRemainingMonths(days);
  const wholeMonths = Math.floor(months);
  const decimalMonths = months - wholeMonths;
  if (months < 1) return `${days} day${days !== 1 ? "s" : ""}`;
  if (decimalMonths > 0.85) return `${wholeMonths + 1} month${wholeMonths + 1 !== 1 ? "s" : ""}`;
  if (decimalMonths > 0.35) return `${wholeMonths}.5 month${wholeMonths !== 0 ? "s" : ""}`;
  if (decimalMonths > 0.1)
    return `${wholeMonths} month${wholeMonths !== 1 ? "s" : ""} ${Math.round(decimalMonths * 30)} days`;
  return `${wholeMonths} month${wholeMonths !== 1 ? "s" : ""}`;
};

const getReportProgressClass = (progress) => {
  if (progress < 30) return "bg-red-500";
  if (progress < 70) return "bg-amber-500";
  return "bg-emerald-500";
};

const getRoleBadgeClass = (role) => {
  const classes = {
    CS: "bg-purple-100 text-purple-700",
    RL: "bg-blue-100 text-blue-700",
    CDH: "bg-emerald-100 text-emerald-700",
    COW: "bg-amber-100 text-amber-700",
    TL: "bg-slate-100 text-slate-700",
  };
  return classes[role] || "bg-slate-100 text-slate-700";
};

const goBack = () => router.back();

// Fetch Reports
const fetchReports = async () => {
  reportsLoading.value = true;
  try {
    const response = await apiClient.get(`/Reports/project/${project.value.id}`, {
      params: { includeDeleted: false },
    });
    reports.value = response.data;
  } catch (error) {
    console.error("Failed to fetch reports:", error);
    reports.value = [];
  } finally {
    reportsLoading.value = false;
  }
};

// Fetch Assignments - THIS SHOULD WORK FOR ALL ROLES
const fetchAssignments = async () => {
  assignmentsLoading.value = true;
  try {
    const response = await apiClient.get(`/ProjectAssignments/project/${project.value.id}`);
    assignments.value = response.data || [];
    console.log("Assignments fetched:", assignments.value.length); // Debug log
  } catch (error) {
    console.error("Failed to fetch assignments:", error);
    assignments.value = [];
  } finally {
    assignmentsLoading.value = false;
  }
};

// Fetch Assignable Users (Only for RL/SuperAdmin)
const fetchAssignableUsers = async () => {
  if (!assignmentForm.value.role) return;
  try {
    const response = await apiClient.get("/ProjectAssignments/assignable-users", {
      params: { role: assignmentForm.value.role },
    });
    assignableUsers.value = response.data;
  } catch (error) {
    console.error("Failed to fetch users:", error);
    assignableUsers.value = [];
  }
};

const onRoleChange = () => {
  assignmentForm.value.userId = "";
  assignableUsers.value = [];
  if (assignmentForm.value.role) {
    fetchAssignableUsers();
  }
};

// Submit Assignment (Only for RL/SuperAdmin)
const submitAssignment = async () => {
  if (!assignmentForm.value.role || !assignmentForm.value.userId) {
    toast.error("Please select both role and user");
    return;
  }

  submittingAssignment.value = true;
  try {
    const response = await apiClient.post("/ProjectAssignments", {
      projectId: project.value.id,
      userId: assignmentForm.value.userId,
      role: assignmentForm.value.role,
    });

    if (response.data.isSuccess === false) {
      throw new Error(response.data.error);
    }

    toast.success("User assigned successfully");
    showAssignmentModal.value = false;
    assignmentForm.value = { role: "", userId: "" };
    assignableUsers.value = [];
    await fetchAssignments();
    await projectStore.fetchProjectById(project.value.id);
  } catch (error) {
    toast.error(error.message || "Failed to assign user");
  } finally {
    submittingAssignment.value = false;
  }
};

// Revoke Assignment (Only for RL/SuperAdmin)
const revokeAssignment = async (assignmentId) => {
  if (!confirm("Are you sure you want to revoke this assignment?")) return;

  try {
    await apiClient.delete(`/ProjectAssignments/${assignmentId}`);
    toast.success("Assignment revoked successfully");
    await fetchAssignments();
    await projectStore.fetchProjectById(project.value.id);
  } catch (error) {
    toast.error("Failed to revoke assignment");
  }
};

// Download Report
const downloadReport = async (report) => {
  try {
    if (report.filePath) {
      window.open(report.filePath, "_blank");
    } else {
      toast.warning("No file available for this report");
    }
  } catch (error) {
    console.error("Failed to download report:", error);
    toast.error("Failed to download report");
  }
};

// Export Reports to CSV
const exportReports = () => {
  if (reports.value.length === 0) return;

  const exportData = reports.value.map((report) => ({
    Title: report.title,
    Description: report.description,
    "Progress (%)": report.progress,
    Status: report.isGeoValidated ? "Verified" : "Off-site",
    "Submitted By": report.createdByName || report.createdById,
    "Submitted Date": formatDate(report.createdAt),
    "File Path": report.filePath,
  }));

  const headers = Object.keys(exportData[0]);
  const csvRows = [
    headers.join(","),
    ...exportData.map((row) =>
      headers
        .map((header) => {
          const value = row[header];
          return typeof value === "string" ? `"${value.replace(/"/g, '""')}"` : value;
        })
        .join(","),
    ),
  ];

  const csvContent = csvRows.join("\n");
  const blob = new Blob([csvContent], { type: "text/csv;charset=utf-8;" });
  const link = document.createElement("a");
  const url = URL.createObjectURL(blob);
  link.href = url;
  link.setAttribute("download", `${project.value.name}_reports.csv`);
  document.body.appendChild(link);
  link.click();
  document.body.removeChild(link);
  URL.revokeObjectURL(url);
  toast.success("Reports exported successfully");
};

// Initialize
onMounted(async () => {
  loading.value = true;
  try {
    await projectStore.fetchProjectById(route.params.id);
    project.value = projectStore.selectedProject;
    if (project.value) {
      await Promise.all([fetchReports(), fetchAssignments()]);
    }
  } catch (error) {
    console.error("Failed to load project:", error);
    toast.error("Failed to load project details");
  } finally {
    loading.value = false;
  }
});
</script>

<style scoped>
.line-clamp-2 {
  display: -webkit-box;
  -webkit-line-clamp: 2;
  -webkit-box-orient: vertical;
  overflow: hidden;
}
</style>
