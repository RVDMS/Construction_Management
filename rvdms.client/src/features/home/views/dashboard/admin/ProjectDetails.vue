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
        <div class="flex items-center gap-3">
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
      <div class="flex gap-6">
        <button
          @click="activeTab = 'overview'"
          :class="[
            'pb-3 px-1 text-sm font-medium transition-colors',
            activeTab === 'overview'
              ? 'text-emerald-600 border-b-2 border-emerald-600'
              : 'text-slate-500 hover:text-slate-700',
          ]"
        >
          Overview
        </button>
        <button
          @click="activeTab = 'reports'"
          :class="[
            'pb-3 px-1 text-sm font-medium transition-colors',
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

    <!-- Overview Tab Content -->
    <div v-if="activeTab === 'overview'" class="grid grid-cols-1 lg:grid-cols-3 gap-6">
      <div class="lg:col-span-2 space-y-6">
        <!-- Project Information -->
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
              <p class="text-lg font-semibold">KES {{ formatCurrency(project.contractSum) }}</p>
            </div>
          </div>
        </div>

        <!-- Location -->
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

        <!-- Project Team -->
        <div class="bg-white rounded-xl border p-6">
          <h3 class="text-sm font-medium mb-4 flex items-center gap-2">
            <UsersIcon class="w-4 h-4" />Project Team
          </h3>
          <div class="grid grid-cols-3 gap-4">
            <div>
              <p class="text-xs text-slate-500 mb-1">Clerk of Works</p>
              <p class="text-sm">{{ project.clerkOfWorks || "Not assigned" }}</p>
            </div>
            <div>
              <p class="text-xs text-slate-500 mb-1">Technical Lead</p>
              <p class="text-sm">{{ project.technicalLead || "Not assigned" }}</p>
            </div>
            <div>
              <p class="text-xs text-slate-500 mb-1">Reports</p>
              <p class="text-sm">{{ reports.length }} total</p>
            </div>
          </div>
        </div>
      </div>

      <!-- Right Column - Progress & Budget -->
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
              <span class="text-sm">Time Elapsed</span
              ><span>{{ project.timeElapsedPercentage }}%</span>
            </div>
            <div class="bg-slate-200 rounded-full h-2">
              <div
                class="bg-blue-500 h-2 rounded-full"
                :style="{ width: `${project.timeElapsedPercentage}%` }"
              ></div>
            </div>
            <div class="flex justify-between mt-3">
              <span class="text-sm">Variance</span
              ><span :class="project.variance >= 0 ? 'text-emerald-600' : 'text-red-600'"
                >{{ project.variance }}%</span
              >
            </div>
          </div>
        </div>

        <div class="bg-white rounded-xl border p-6">
          <h3 class="text-sm font-medium mb-3">Budget</h3>
          <div>
            <p class="text-xs text-slate-500 mb-1">Contract Sum</p>
            <p class="text-lg font-semibold">KES {{ formatCurrency(project.contractSum) }}</p>
          </div>
          <div class="mt-3">
            <p class="text-xs text-slate-500 mb-1">Remaining</p>
            <p class="text-lg font-semibold text-blue-600">
              KES {{ formatCurrency(project.remainingBudget) }}
            </p>
          </div>
        </div>
      </div>
    </div>

    <!-- Reports Tab Content -->
    <div v-if="activeTab === 'reports'" class="space-y-4">
      <!-- Reports Header with Actions -->
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

      <!-- Reports Table -->
      <div class="bg-white rounded-xl border overflow-hidden">
        <div v-if="reportsLoading" class="p-12 text-center">
          <Loader2Icon class="w-8 h-8 animate-spin text-emerald-600 mx-auto" />
          <p class="mt-2 text-slate-500">Loading reports...</p>
        </div>

        <div v-else-if="reports.length === 0" class="p-12 text-center">
          <FileTextIcon class="w-12 h-12 text-slate-300 mx-auto mb-3" />
          <p class="text-slate-500">No reports have been submitted for this project yet.</p>
        </div>

        <table v-else class="w-full text-sm">
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
              <td class="px-6 py-4 text-slate-600 text-xs">
                {{ formatDate(report.createdAt) }}
              </td>
              <td class="px-6 py-4 text-slate-600">
                {{ report.createdByName || report.createdById?.substring(0, 8) }}
              </td>
              <td class="px-6 py-4">
                <span
                  v-if="report.isGeoValidated"
                  class="inline-flex items-center gap-1 px-2 py-1 rounded-full text-xs font-medium bg-green-100 text-green-700"
                >
                  <CheckCircleIcon class="w-3 h-3" />
                  Verified
                </span>
                <span
                  v-else
                  class="inline-flex items-center gap-1 px-2 py-1 rounded-full text-xs font-medium bg-amber-100 text-amber-700"
                >
                  <AlertTriangleIcon class="w-3 h-3" />
                  Off-site
                </span>
              </td>
              <td class="px-6 py-4">
                <button
                  @click="downloadReport(report)"
                  class="text-emerald-600 hover:text-emerald-700 text-sm flex items-center gap-1"
                >
                  <DownloadIcon class="w-4 h-4" />
                  Download
                </button>
              </td>
            </tr>
          </tbody>
        </table>
      </div>
    </div>

    <!-- At Risk Alert (only show if applicable) -->
    <div
      v-if="project.isAtRisk && activeTab === 'overview'"
      class="bg-red-50 border border-red-200 rounded-xl p-4"
    >
      <div class="flex gap-3">
        <AlertCircleIcon class="w-5 h-5 text-red-600" />
        <div>
          <h4 class="text-sm font-medium text-red-800">Project at Risk</h4>
          <p class="text-sm text-red-700">
            Delayed by {{ Math.abs(project.variance) }}%. {{ project.daysRemaining }} days left to
            complete {{ (100 - project.currentPhysicalProgress).toFixed(1) }}% of work.
          </p>
        </div>
      </div>
    </div>
  </div>
</template>

<script setup>
import { ref, computed, onMounted } from "vue";
import { useRoute, useRouter, RouterLink } from "vue-router";
import { useProjectStore } from "@/stores/projectStore";
import apiClient from "@/services/apiClient";
import { getStatusBadgeClass, formatCurrency, formatDate } from "@/utils/permissions";
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
} from "lucide-vue-next";

const route = useRoute();
const router = useRouter();
const projectStore = useProjectStore();

const project = ref(null);
const loading = ref(true);
const activeTab = ref("overview");
const reports = ref([]);
const reportsLoading = ref(false);

const progressCircleColor = computed(() => {
  const progress = project.value?.currentPhysicalProgress || 0;
  if (progress >= 75) return "#10b981";
  if (progress >= 50) return "#f59e0b";
  return "#ef4444";
});

const getReportProgressClass = (progress) => {
  if (progress < 30) return "bg-red-500";
  if (progress < 70) return "bg-amber-500";
  return "bg-emerald-500";
};

const goBack = () => router.back();

// Fetch reports for the project
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

// Download a single report
const downloadReport = async (report) => {
  try {
    // If you have the file stored in Cloudinary or similar
    // You can either redirect to the file URL or download via blob
    if (report.filePath) {
      // Option 1: Open in new tab
      window.open(report.filePath, "_blank");

      // Option 2: Download directly
      // const response = await apiClient.get(report.filePath, { responseType: 'blob' });
      // const url = window.URL.createObjectURL(new Blob([response.data]));
      // const link = document.createElement('a');
      // link.href = url;
      // link.setAttribute('download', `${report.title}.pdf`);
      // document.body.appendChild(link);
      // link.click();
      // link.remove();
      // window.URL.revokeObjectURL(url);
    } else {
      console.warn("No file path available for this report");
    }
  } catch (error) {
    console.error("Failed to download report:", error);
  }
};

// Export all reports as CSV/Excel
const exportReports = () => {
  if (reports.value.length === 0) return;

  // Prepare data for export
  const exportData = reports.value.map((report) => ({
    Title: report.title,
    Description: report.description,
    "Progress (%)": report.progress,
    Status: report.isGeoValidated ? "Verified" : "Off-site",
    "Submitted By": report.createdByName || report.createdById,
    "Submitted Date": formatDate(report.createdAt),
    "File Path": report.filePath,
  }));

  // Convert to CSV
  const headers = Object.keys(exportData[0]);
  const csvRows = [
    headers.join(","),
    ...exportData.map((row) =>
      headers
        .map((header) => {
          const value = row[header];
          // Escape quotes and wrap in quotes if contains comma
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
};

onMounted(async () => {
  loading.value = true;
  try {
    await projectStore.fetchProjectById(route.params.id);
    project.value = projectStore.selectedProject;
    if (project.value) {
      await fetchReports();
    }
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
