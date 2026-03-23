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

    <div v-if="project.isAtRisk" class="bg-red-50 border border-red-200 rounded-xl p-4">
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

    <div class="grid grid-cols-1 lg:grid-cols-3 gap-6">
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
              <p class="text-lg font-semibold">KES {{ formatCurrency(project.contractSum) }}</p>
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
              <p class="text-sm">{{ project.totalWeeklyReports || 0 }} total</p>
            </div>
          </div>
        </div>
      </div>
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
  </div>
</template>

<script setup>
import { ref, computed, onMounted } from "vue";
import { useRoute, useRouter, RouterLink } from "vue-router";
import { useProjectStore } from "@/stores/projectStore";
import { getStatusBadgeClass, formatCurrency } from "@/utils/permissions";
import {
  ArrowLeft as ArrowLeftIcon,
  MapPin as MapPinIcon,
  Users as UsersIcon,
  AlertCircle as AlertCircleIcon,
  Loader2 as Loader2Icon,
} from "lucide-vue-next";

const route = useRoute();
const router = useRouter();
const projectStore = useProjectStore();

const project = ref(null);
const loading = ref(true);

const progressCircleColor = computed(() => {
  const progress = project.value?.currentPhysicalProgress || 0;
  if (progress >= 75) return "#10b981";
  if (progress >= 50) return "#f59e0b";
  return "#ef4444";
});

const goBack = () => router.back();

onMounted(async () => {
  loading.value = true;
  try {
    await projectStore.fetchProjectById(route.params.id);
    project.value = projectStore.selectedProject;
  } finally {
    loading.value = false;
  }
});
</script>
