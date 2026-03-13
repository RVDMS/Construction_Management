<template>
  <div class="space-y-4 md:space-y-6">
    <!-- Header -->
    <div>
      <h1 class="text-xl md:text-2xl font-semibold text-slate-900 dark:text-white mb-1">{{ dashboardTitle }}</h1>
      <p class="text-sm md:text-base text-slate-600 dark:text-slate-400">{{ dashboardDesc }}</p>
    </div>

    <!-- Role Badge -->
    <div class="bg-emerald-50 dark:bg-emerald-900/20 border border-emerald-200 dark:border-emerald-800 rounded-lg p-3 md:p-4 flex items-center gap-3">
      <CheckCircleIcon class="w-5 h-5 text-emerald-600" />
      <div>
        <p class="text-xs md:text-sm text-emerald-900">
          Viewing as: <span class="font-semibold">{{ userStore.currentUser.name }}</span>
        </p>
        <p class="text-xs text-emerald-700">Role: {{ getRoleName(userStore.currentUser.role) }}</p>
      </div>
    </div>

    <!-- KPI Cards -->
    <div class="grid grid-cols-2 lg:grid-cols-4 gap-3 md:gap-4">
      <div class="bg-white dark:bg-slate-800 rounded-lg border border-slate-200 p-4 md:p-6">
        <div class="flex items-center justify-between mb-2">
          <span class="text-slate-600 text-xs md:text-sm">Total Projects</span>
          <FolderKanbanIcon class="w-5 h-5 text-slate-400" />
        </div>
        <p class="text-2xl md:text-3xl font-light text-slate-900">{{ userProjects.length }}</p>
        <p class="text-xs md:text-sm text-slate-500 mt-1">Across 6 wards</p>
      </div>

      <div class="bg-white dark:bg-slate-800 rounded-lg border border-emerald-200 p-4 md:p-6">
        <div class="flex items-center justify-between mb-2">
          <span class="text-slate-600 text-xs md:text-sm">On Track</span>
          <TrendingUpIcon class="w-5 h-5 text-emerald-600" />
        </div>
        <p class="text-3xl font-light text-emerald-700">{{ onTrackCount }}</p>
        <p class="text-xs md:text-sm text-emerald-600 mt-1">Meeting milestones</p>
      </div>

      <div class="bg-white dark:bg-slate-800 rounded-lg border border-amber-200 p-4 md:p-6">
        <div class="flex items-center justify-between mb-2">
          <span class="text-slate-600 text-xs md:text-sm">Slow Progress</span>
          <ClockIcon class="w-5 h-5 text-amber-600" />
        </div>
        <p class="text-3xl font-light text-amber-700">{{ slowProgressCount }}</p>
        <p class="text-xs md:text-sm text-amber-600 mt-1">Requires attention</p>
      </div>

      <div class="bg-white dark:bg-slate-800 rounded-lg border border-red-200 p-4 md:p-6">
        <div class="flex items-center justify-between mb-2">
          <span class="text-slate-600 text-xs md:text-sm">Behind Schedule</span>
          <AlertCircleIcon class="w-5 h-5 text-red-600" />
        </div>
        <p class="text-3xl font-light text-red-700">{{ behindScheduleCount }}</p>
        <p class="text-xs md:text-sm text-red-600 mt-1">Urgent action needed</p>
      </div>
    </div>

    <!-- Charts Row -->
    <div class="grid grid-cols-1 lg:grid-cols-2 gap-4 md:p-6">
      <!-- Progress Chart -->
      <div class="bg-white dark:bg-slate-800 rounded-lg border border-slate-200 p-4 md:p-6">
        <h3 class="text-lg font-medium text-slate-900 mb-4">Average Progress Over Time</h3>
        <canvas ref="progressChartRef" class="w-full" height="120"></canvas>
      </div>

      <!-- Budget Chart -->
      <div class="bg-white dark:bg-slate-800 rounded-lg border border-slate-200 p-4 md:p-6">
        <h3 class="text-lg font-medium text-slate-900 mb-4">Budget Utilization (KES Millions)</h3>
        <canvas ref="budgetChartRef" class="w-full" height="120"></canvas>
      </div>
    </div>

    <!-- Map / Site Cards -->
    <div class="bg-white dark:bg-slate-800 rounded-lg border border-slate-200 p-4 md:p-6">
      <h3 class="text-lg font-medium text-slate-900 mb-4">Project Sites – Nakuru County</h3>
      <div class="bg-slate-100 dark:bg-slate-700 rounded-lg h-64 md:h-80 flex items-center justify-center relative overflow-hidden">
        <div class="absolute inset-0 opacity-10">
          <svg class="w-full h-full" viewBox="0 0 800 400">
            <path d="M100,100 L200,80 L300,120 L400,90 L500,130 L600,100 L700,150 L700,300 L600,280 L500,310 L400,290 L300,320 L200,290 L100,300 Z" fill="#10b981" opacity="0.3"/>
          </svg>
        </div>
        <div class="relative z-10 grid grid-cols-2 md:grid-cols-3 gap-3 md:gap-4 w-full max-w-4xl px-4 md:px-8">
          <RouterLink
            v-for="project in userProjects"
            :key="project.id"
            :to="`/dashboard/projects/${project.id}`"
            class="bg-white dark:bg-slate-800 p-3 md:p-4 rounded-lg shadow-sm border border-slate-200 hover:shadow-md transition-shadow"
          >
            <div class="flex items-start gap-2 mb-2">
              <MapPinIcon class="w-4 h-4 text-emerald-600 mt-0.5 flex-shrink-0" />
              <div class="min-w-0">
                <p class="text-xs md:text-sm font-medium text-slate-900 truncate">{{ project.name }}</p>
                <p class="text-xs text-slate-500">{{ project.ward }}</p>
              </div>
            </div>
            <span :class="['inline-flex items-center px-2 py-1 rounded text-xs border', getStatusColor(project.status)]">
              {{ getStatusLabel(project.status) }}
            </span>
          </RouterLink>
        </div>
      </div>
    </div>

    <!-- Projects Table -->
    <div class="bg-white dark:bg-slate-800 rounded-lg border border-slate-200">
      <div class="p-4 md:p-6 border-b border-slate-200">
        <h3 class="text-lg font-medium text-slate-900">All Projects</h3>
      </div>
      <div class="overflow-x-auto">
        <table class="w-full min-w-[600px]">
          <thead class="bg-slate-50 border-b border-slate-200">
            <tr>
              <th class="px-6 py-3 text-left text-xs md:text-sm text-slate-700">Project Name</th>
              <th class="px-6 py-3 text-left text-xs md:text-sm text-slate-700">Ward</th>
              <th class="px-6 py-3 text-left text-xs md:text-sm text-slate-700">Contractor</th>
              <th class="px-6 py-3 text-left text-xs md:text-sm text-slate-700">Status</th>
              <th class="px-6 py-3 text-left text-xs md:text-sm text-slate-700">% Complete</th>
              <th class="px-6 py-3 text-left text-xs md:text-sm text-slate-700">Budget vs Spent</th>
              <th class="px-6 py-3 text-left text-xs md:text-sm text-slate-700">Last Updated</th>
            </tr>
          </thead>
          <tbody class="divide-y divide-slate-200">
            <tr
              v-for="project in userProjects"
              :key="project.id"
              class="hover:bg-slate-50 cursor-pointer"
              @click="router.push(`/dashboard/projects/${project.id}`)"
            >
              <td class="px-4 md:px-6 py-3 md:py-4 text-xs md:text-sm font-medium text-slate-900">{{ project.name }}</td>
              <td class="px-4 md:px-6 py-3 md:py-4 text-xs md:text-sm text-slate-600">{{ project.ward }}</td>
              <td class="px-4 md:px-6 py-3 md:py-4 text-xs md:text-sm text-slate-600">{{ project.contractor }}</td>
              <td class="px-4 md:px-6 py-3 md:py-4">
                <span :class="['inline-flex px-2.5 py-1 rounded-full text-xs border', getStatusColor(project.status)]">
                  {{ getStatusLabel(project.status) }}
                </span>
              </td>
              <td class="px-4 md:px-6 py-3 md:py-4 text-xs md:text-sm text-slate-900">
                <div class="flex items-center gap-2">
                  <div class="flex-1 bg-slate-200 rounded-full h-2 max-w-[60px] md:max-w-[100px]">
                    <div class="bg-emerald-600 h-2 rounded-full" :style="{ width: `${project.completionPercentage}%` }"></div>
                  </div>
                  <span>{{ project.completionPercentage }}%</span>
                </div>
              </td>
              <td class="px-4 md:px-6 py-3 md:py-4 text-xs md:text-sm text-slate-600">
                <div class="font-medium text-slate-900">KES {{ (project.budgetSpent / 1000000).toFixed(1) }}M</div>
                <div class="text-xs text-slate-500">of {{ (project.contractSum / 1000000).toFixed(1) }}M</div>
              </td>
              <td class="px-4 md:px-6 py-3 md:py-4 text-xs md:text-sm text-slate-600">{{ formatDate(project.lastUpdated) }}</td>
            </tr>
          </tbody>
        </table>
      </div>
    </div>
  </div>
</template>

<script setup>
import { ref, computed, onMounted } from 'vue'
import { RouterLink, useRouter } from 'vue-router'
import {
  TrendingUp as TrendingUpIcon,
  AlertCircle as AlertCircleIcon,
  Clock as ClockIcon,
  FolderKanban as FolderKanbanIcon,
  MapPin as MapPinIcon,
  CheckCircle as CheckCircleIcon
} from 'lucide-vue-next'
import { Chart, registerables } from 'chart.js'
import { useUserStore } from '../stores/userStore.js'
import { projects } from '../data/mockData.js'
import { getAccessibleProjects, getStatusColor, getStatusLabel, getRoleName } from '../utils/permissions.js'

Chart.register(...registerables)

const userStore = useUserStore()
const router = useRouter()
const progressChartRef = ref(null)
const budgetChartRef = ref(null)

const userProjects = computed(() => getAccessibleProjects(userStore.currentUser, projects))
const onTrackCount = computed(() =>
  userProjects.value.filter(p => p.status === 'on-track').length
)
const slowProgressCount = computed(() =>
  userProjects.value.filter(p => p.status === 'slow-progress').length
)
const behindScheduleCount = computed(() =>
  userProjects.value.filter(p => p.status === 'behind-schedule').length
)
const dashboardTitle = computed(() => {
  switch (userStore.currentUser.role) {
    case 'regional-lead': return 'Regional Overview'
    case 'county-director': return 'County Director Dashboard'
    case 'clerk-of-works': return 'My Projects – Clerk of Works'
    case 'consultant': return 'Consultant Dashboard'
    default: return 'Dashboard'
  }
})

const dashboardDesc = computed(() => {
  switch (userStore.currentUser.role) {
    case 'regional-lead': return 'Comprehensive dashboard for all housing projects in Nakuru County'
    case 'county-director': return 'Project oversight and coordination for Nakuru County'
    case 'clerk-of-works': return `Projects assigned to ${userStore.currentUser.name}`
    case 'consultant': return `Projects managed by ${userStore.currentUser.name}`
    default: return 'Project management overview'
  }
})

function formatDate(d) {
  return new Date(d).toLocaleDateString()
}

const progressData = {
  labels: ['Aug', 'Sep', 'Oct', 'Nov', 'Dec', 'Jan', 'Feb'],
  datasets: [{
    label: 'Progress %',
    data: [15, 22, 31, 38, 45, 51, 55],
    borderColor: '#10b981',
    backgroundColor: 'rgba(16,185,129,0.15)',
    fill: true,
    tension: 0.4
  }]
}

const budgetData = {
  labels: projects.map(p => p.name.split(' ')[0]),
  datasets: [
    {
      label: 'Allocated',
      data: projects.map(p => p.contractSum / 1000000),
      backgroundColor: '#cbd5e1'
    },
    {
      label: 'Spent',
      data: projects.map(p => p.budgetSpent / 1000000),
      backgroundColor: '#10b981'
    }
  ]
}

onMounted(() => {
  new Chart(progressChartRef.value, {
    type: 'line',
    data: progressData,
    options: { responsive: true, plugins: { legend: { display: false } }, scales: { y: { beginAtZero: true } } }
  })
  new Chart(budgetChartRef.value, {
    type: 'bar',
    data: budgetData,
    options: { responsive: true, scales: { y: { beginAtZero: true } } }
  })
})
</script>
