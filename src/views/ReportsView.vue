<template>
  <div class="space-y-6">
    <div class="flex items-center justify-between">
      <div>
        <h1 class="text-2xl font-semibold text-slate-900 mb-1">Reports</h1>
        <p class="text-slate-600">Generate and export project reports</p>
      </div>
      <RouterLink
        v-if="hasPermission(userStore.currentUser, 'add_reports')"
        to="/dashboard/reports/add"
        class="flex items-center gap-2 px-4 py-2 bg-emerald-600 hover:bg-emerald-700 text-white rounded-lg transition-colors text-sm"
      >
        <PlusIcon class="w-4 h-4" />
        Add Report
      </RouterLink>
    </div>

    <!-- Filters -->
    <div class="bg-white rounded-lg border border-slate-200 p-6">
      <div class="flex items-center gap-2 mb-4">
        <FilterIcon class="w-5 h-5 text-slate-600" />
        <h3 class="text-lg font-medium text-slate-900">Filters</h3>
      </div>
      <div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-4">
        <div>
          <label class="block text-sm text-slate-700 mb-2">County</label>
          <select class="w-full px-3 py-2 border border-slate-300 rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500 text-sm">
            <option>Nakuru County</option>
          </select>
        </div>
        <div>
          <label class="block text-sm text-slate-700 mb-2">Ward</label>
          <select v-model="selectedWard" class="w-full px-3 py-2 border border-slate-300 rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500 text-sm">
            <option value="all">All Wards</option>
            <option v-for="ward in wards" :key="ward" :value="ward">{{ ward }}</option>
          </select>
        </div>
        <div>
          <label class="block text-sm text-slate-700 mb-2">Status</label>
          <select v-model="selectedStatus" class="w-full px-3 py-2 border border-slate-300 rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500 text-sm">
            <option value="all">All Status</option>
            <option value="on-track">On Track</option>
            <option value="slow-progress">Slow Progress</option>
            <option value="behind-schedule">Behind Schedule</option>
          </select>
        </div>
        <div>
          <label class="block text-sm text-slate-700 mb-2">Date From</label>
          <input v-model="dateFrom" type="date" class="w-full px-3 py-2 border border-slate-300 rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500 text-sm" />
        </div>
      </div>
      <div class="flex gap-3 mt-4">
        <button @click="exportReport('pdf')" class="flex items-center gap-2 px-4 py-2 bg-emerald-600 hover:bg-emerald-700 text-white rounded-lg transition-colors text-sm">
          <DownloadIcon class="w-4 h-4" />
          Export PDF
        </button>
        <button @click="exportReport('excel')" class="flex items-center gap-2 px-4 py-2 bg-blue-600 hover:bg-blue-700 text-white rounded-lg transition-colors text-sm">
          <DownloadIcon class="w-4 h-4" />
          Export Excel
        </button>
      </div>
    </div>

    <!-- Stats -->
    <div class="grid grid-cols-1 md:grid-cols-4 gap-4">
      <div class="bg-white rounded-lg border border-slate-200 p-4">
        <p class="text-sm text-slate-600 mb-1">Filtered Projects</p>
        <p class="text-2xl font-light text-slate-900">{{ filteredProjects.length }}</p>
      </div>
      <div class="bg-white rounded-lg border border-emerald-200 p-4">
        <p class="text-sm text-slate-600 mb-1">Avg. Completion</p>
        <p class="text-2xl font-light text-emerald-700">{{ avgCompletion }}%</p>
      </div>
      <div class="bg-white rounded-lg border border-slate-200 p-4">
        <p class="text-sm text-slate-600 mb-1">Total Budget</p>
        <p class="text-2xl font-light text-slate-900">{{ totalBudget }}M</p>
      </div>
      <div class="bg-white rounded-lg border border-slate-200 p-4">
        <p class="text-sm text-slate-600 mb-1">Total Spent</p>
        <p class="text-2xl font-light text-slate-900">{{ totalSpent }}M</p>
      </div>
    </div>

    <!-- Table -->
    <div class="bg-white rounded-lg border border-slate-200">
      <div class="p-6 border-b border-slate-200">
        <h3 class="text-lg font-medium text-slate-900">Report Data</h3>
      </div>
      <div class="overflow-x-auto">
        <table class="w-full">
          <thead class="bg-slate-50 border-b border-slate-200">
            <tr>
              <th class="px-6 py-3 text-left text-sm text-slate-700">Project</th>
              <th class="px-6 py-3 text-left text-sm text-slate-700">Ward</th>
              <th class="px-6 py-3 text-left text-sm text-slate-700">Status</th>
              <th class="px-6 py-3 text-left text-sm text-slate-700">Completion</th>
              <th class="px-6 py-3 text-left text-sm text-slate-700">Budget</th>
              <th class="px-6 py-3 text-left text-sm text-slate-700">Spent</th>
              <th class="px-6 py-3 text-left text-sm text-slate-700">Last Updated</th>
            </tr>
          </thead>
          <tbody class="divide-y divide-slate-200">
            <tr v-for="project in filteredProjects" :key="project.id" class="hover:bg-slate-50">
              <td class="px-6 py-4 text-sm font-medium text-slate-900">{{ project.name }}</td>
              <td class="px-6 py-4 text-sm text-slate-600">{{ project.ward }}</td>
              <td class="px-6 py-4">
                <span :class="['inline-flex px-2 py-1 rounded-full text-xs border', getStatusColor(project.status)]">
                  {{ getStatusLabel(project.status) }}
                </span>
              </td>
              <td class="px-6 py-4 text-sm text-slate-900">{{ project.completionPercentage }}%</td>
              <td class="px-6 py-4 text-sm text-slate-900">KES {{ (project.contractSum / 1000000).toFixed(1) }}M</td>
              <td class="px-6 py-4 text-sm text-slate-900">KES {{ (project.budgetSpent / 1000000).toFixed(1) }}M</td>
              <td class="px-6 py-4 text-sm text-slate-600">{{ new Date(project.lastUpdated).toLocaleDateString() }}</td>
            </tr>
          </tbody>
        </table>
      </div>
    </div>
  </div>
</template>

<script setup>
import { ref, computed } from 'vue'
import { RouterLink } from 'vue-router'
import { Filter as FilterIcon, Download as DownloadIcon, Plus as PlusIcon } from 'lucide-vue-next'
import { useUserStore } from '../stores/userStore.js'
import { projects } from '../data/mockData.js'
import { getStatusColor, getStatusLabel, hasPermission } from '../utils/permissions.js'

const userStore = useUserStore()
const selectedStatus = ref('all')
const selectedWard = ref('all')
const dateFrom = ref('')

const wards = [...new Set(projects.map(p => p.ward))]

const filteredProjects = computed(() => projects.filter(p => {
  if (selectedStatus.value !== 'all' && p.status !== selectedStatus.value) return false
  if (selectedWard.value !== 'all' && p.ward !== selectedWard.value) return false
  return true
}))

const avgCompletion = computed(() =>
  Math.round(filteredProjects.value.reduce((a, p) => a + p.completionPercentage, 0) / filteredProjects.value.length)
)
const totalBudget = computed(() => (filteredProjects.value.reduce((a, p) => a + p.contractSum, 0) / 1000000).toFixed(1))
const totalSpent = computed(() => (filteredProjects.value.reduce((a, p) => a + p.budgetSpent, 0) / 1000000).toFixed(1))

function exportReport(format) {
  alert(`Exporting report as ${format.toUpperCase()}...`)
}
</script>
