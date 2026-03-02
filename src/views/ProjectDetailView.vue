<template>
  <div v-if="project" class="space-y-6">
    <!-- Back -->
    <RouterLink to="/dashboard" class="inline-flex items-center gap-2 text-slate-600 hover:text-slate-900 text-sm">
      <ArrowLeftIcon class="w-4 h-4" />
      Back to Dashboard
    </RouterLink>

    <!-- Header -->
    <div>
      <h1 class="text-2xl font-semibold text-slate-900 mb-1">{{ project.name }}</h1>
      <p class="text-slate-600">{{ project.ward }}, {{ project.subcounty }}</p>
    </div>

    <!-- Status Banner -->
    <div :class="['rounded-lg border p-4', getStatusBannerColor(project.status)]">
      <div class="flex items-center justify-between">
        <div class="flex items-center gap-3">
          <span :class="['px-3 py-1.5 rounded-full text-sm border', getStatusColor(project.status)]">
            {{ getStatusLabel(project.status) }}
          </span>
          <span class="text-sm">65% time elapsed | {{ project.completionPercentage }}% work completed</span>
        </div>
        <AlertCircleIcon v-if="project.status === 'behind-schedule'" class="w-5 h-5" />
      </div>
    </div>

    <!-- Project Info -->
    <div class="bg-white rounded-lg border border-slate-200 p-6">
      <h3 class="text-lg font-medium text-slate-900 mb-4">Project Information</h3>
      <div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6">
        <div>
          <p class="text-sm text-slate-500 mb-1">Physical Location</p>
          <div class="flex items-start gap-2">
            <MapPinIcon class="w-4 h-4 text-slate-400 mt-0.5" />
            <p class="text-sm text-slate-900">{{ project.physicalLocation }}</p>
          </div>
          <p class="text-xs text-slate-500 mt-1">GPS: {{ project.coordinates.lat }}, {{ project.coordinates.lng }}</p>
        </div>

        <div>
          <p class="text-sm text-slate-500 mb-1">Contractor</p>
          <p class="text-sm font-medium text-slate-900">{{ project.contractor }}</p>
          <div class="flex items-center gap-2 mt-1">
            <PhoneIcon class="w-3 h-3 text-slate-400" />
            <p class="text-xs text-slate-600">{{ project.contractorContact }}</p>
          </div>
        </div>

        <div>
          <p class="text-sm text-slate-500 mb-1">Contract Sum</p>
          <div class="flex items-center gap-2">
            <DollarSignIcon class="w-4 h-4 text-slate-400" />
            <p class="text-sm font-medium text-slate-900">KES {{ (project.contractSum / 1000000).toFixed(1) }}M</p>
          </div>
        </div>

        <div>
          <p class="text-sm text-slate-500 mb-1">Consultant</p>
          <p class="text-sm font-medium text-slate-900">{{ project.consultant }}</p>
          <div class="flex items-center gap-2 mt-1">
            <PhoneIcon class="w-3 h-3 text-slate-400" />
            <p class="text-xs text-slate-600">{{ project.consultantContact }}</p>
          </div>
        </div>

        <div>
          <p class="text-sm text-slate-500 mb-1">Cluster Supervisor</p>
          <p class="text-sm font-medium text-slate-900">{{ project.clusterSupervisor }}</p>
        </div>

        <div>
          <p class="text-sm text-slate-500 mb-1">Clerk of Works</p>
          <p class="text-sm font-medium text-slate-900">{{ project.clerkOfWorks }}</p>
        </div>

        <div>
          <p class="text-sm text-slate-500 mb-1">Start Date</p>
          <div class="flex items-center gap-2">
            <CalendarIcon class="w-4 h-4 text-slate-400" />
            <p class="text-sm text-slate-900">{{ formatDate(project.startDate) }}</p>
          </div>
        </div>

        <div>
          <p class="text-sm text-slate-500 mb-1">Expected Completion</p>
          <div class="flex items-center gap-2">
            <CalendarIcon class="w-4 h-4 text-slate-400" />
            <p class="text-sm text-slate-900">{{ formatDate(project.expectedCompletion) }}</p>
          </div>
        </div>

        <div>
          <p class="text-sm text-slate-500 mb-1">Completion Progress</p>
          <div class="flex items-center gap-2">
            <TrendingUpIcon class="w-4 h-4 text-emerald-600" />
            <p class="text-sm font-medium text-slate-900">{{ project.completionPercentage }}%</p>
          </div>
          <div class="mt-2 bg-slate-200 rounded-full h-2">
            <div class="bg-emerald-600 h-2 rounded-full" :style="{ width: `${project.completionPercentage}%` }"></div>
          </div>
        </div>
      </div>
    </div>

    <!-- Tabs -->
    <div class="bg-white rounded-lg border border-slate-200">
      <div class="border-b border-slate-200">
        <div class="flex gap-1 p-2 overflow-x-auto">
          <button
            v-for="tab in tabs"
            :key="tab.key"
            @click="activeTab = tab.key"
            :class="['flex items-center gap-2 px-4 py-2 rounded-lg transition-colors text-sm whitespace-nowrap',
              activeTab === tab.key ? 'bg-emerald-50 text-emerald-700 font-medium' : 'text-slate-600 hover:bg-slate-50'
            ]"
          >
            <component :is="tab.icon" class="w-4 h-4" />
            {{ tab.label }}
          </button>
        </div>
      </div>

      <div class="p-6">
        <!-- Overview Tab -->
        <div v-if="activeTab === 'overview'" class="space-y-4">
          <h4 class="text-sm font-medium text-slate-900">Budget Breakdown</h4>
          <div class="grid grid-cols-3 gap-4">
            <div class="p-4 bg-slate-50 rounded-lg">
              <p class="text-xs text-slate-500 mb-1">Contract Sum</p>
              <p class="text-lg font-medium text-slate-900">KES {{ (project.contractSum / 1000000).toFixed(1) }}M</p>
            </div>
            <div class="p-4 bg-emerald-50 rounded-lg">
              <p class="text-xs text-slate-500 mb-1">Spent</p>
              <p class="text-lg font-medium text-emerald-700">KES {{ (project.budgetSpent / 1000000).toFixed(1) }}M</p>
            </div>
            <div class="p-4 bg-blue-50 rounded-lg">
              <p class="text-xs text-slate-500 mb-1">Remaining</p>
              <p class="text-lg font-medium text-blue-700">KES {{ ((project.contractSum - project.budgetSpent) / 1000000).toFixed(1) }}M</p>
            </div>
          </div>
        </div>

        <!-- Reports Tab -->
        <div v-else-if="activeTab === 'reports'" class="space-y-6">
          <div class="bg-slate-50 rounded-lg p-4 border border-slate-200">
            <h4 class="text-sm font-medium text-slate-900 mb-3">Upload Weekly Report</h4>
            <form @submit.prevent="submitReport" class="space-y-4">
              <div>
                <label class="block text-sm text-slate-700 mb-1">Progress Percentage</label>
                <input v-model.number="uploadProgress" type="number" min="0" max="100"
                  class="w-full px-3 py-2 border border-slate-300 rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500" required />
              </div>
              <div>
                <label class="block text-sm text-slate-700 mb-1">Notes</label>
                <textarea v-model="uploadNotes" rows="3"
                  class="w-full px-3 py-2 border border-slate-300 rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500"
                  placeholder="Describe this week's progress..." required></textarea>
              </div>
              <div>
                <label class="block text-sm text-slate-700 mb-1">Photos (Geo-tagged)</label>
                <input type="file" multiple accept="image/*"
                  class="w-full text-sm text-slate-600 file:mr-4 file:py-2 file:px-4 file:rounded-lg file:border-0 file:bg-emerald-50 file:text-emerald-700 hover:file:bg-emerald-100" />
              </div>
              <div class="flex items-center gap-2 p-3 bg-amber-50 border border-amber-200 rounded-lg">
                <AlertCircleIcon class="w-4 h-4 text-amber-600" />
                <p class="text-xs text-amber-800">Upload only enabled when within site geolocation boundary</p>
              </div>
              <button type="submit" class="w-full bg-emerald-600 hover:bg-emerald-700 text-white py-2 rounded-lg transition-colors">
                Submit Report
              </button>
            </form>
          </div>

          <div>
            <h4 class="text-sm font-medium text-slate-900 mb-3">Previous Reports</h4>
            <div class="space-y-3">
              <div v-for="report in projectReports" :key="report.id" class="p-4 border border-slate-200 rounded-lg">
                <div class="flex items-center justify-between mb-2">
                  <div class="flex items-center gap-2">
                    <div class="w-8 h-8 bg-emerald-100 rounded-full flex items-center justify-center">
                      <FileTextIcon class="w-4 h-4 text-emerald-600" />
                    </div>
                    <div>
                      <p class="text-sm font-medium text-slate-900">{{ report.uploadedBy }}</p>
                      <p class="text-xs text-slate-500">{{ formatDate(report.uploadDate) }}</p>
                    </div>
                  </div>
                  <div class="text-right">
                    <p class="text-sm font-medium text-slate-900">{{ report.progressPercentage }}%</p>
                    <p class="text-xs text-slate-500">Progress</p>
                  </div>
                </div>
                <p class="text-sm text-slate-600">{{ report.notes }}</p>
                <div v-if="report.geotagged" class="mt-2 flex items-center gap-1 text-xs text-emerald-600">
                  <MapPinIcon class="w-3 h-3" />
                  Geo-tagged
                </div>
              </div>
            </div>
          </div>
        </div>

        <!-- Other tabs -->
        <div v-else-if="activeTab === 'instructions'" class="text-center py-12 text-slate-500">
          <MessageSquareIcon class="w-12 h-12 mx-auto mb-3 text-slate-300" />
          <p>No consultant instructions yet</p>
        </div>

        <div v-else-if="activeTab === 'documents'" class="text-center py-12 text-slate-500">
          <FolderOpenIcon class="w-12 h-12 mx-auto mb-3 text-slate-300" />
          <p>No documents uploaded yet</p>
        </div>

        <div v-else-if="activeTab === 'audit'" class="text-center py-12 text-slate-500">
          <HistoryIcon class="w-12 h-12 mx-auto mb-3 text-slate-300" />
          <p>No audit logs for this project</p>
        </div>
      </div>
    </div>
  </div>

  <div v-else class="text-center py-12">
    <p class="text-slate-600">Project not found</p>
  </div>
</template>

<script setup>
import { ref, computed } from 'vue'
import { RouterLink, useRoute } from 'vue-router'
import {
  ArrowLeft as ArrowLeftIcon, MapPin as MapPinIcon, Phone as PhoneIcon,
  Calendar as CalendarIcon, DollarSign as DollarSignIcon, TrendingUp as TrendingUpIcon,
  AlertCircle as AlertCircleIcon, FileText as FileTextIcon, Upload as UploadIcon,
  MessageSquare as MessageSquareIcon, FolderOpen as FolderOpenIcon, History as HistoryIcon
} from 'lucide-vue-next'
import { projects, weeklyReports } from '../data/mockData.js'
import { getStatusColor, getStatusLabel, getStatusBannerColor } from '../utils/permissions.js'

const route = useRoute()
const activeTab = ref('overview')
const uploadProgress = ref(0)
const uploadNotes = ref('')

const project = computed(() => projects.find(p => p.id === route.params.id))
const projectReports = computed(() => weeklyReports.filter(r => r.projectId === route.params.id))

const tabs = [
  { key: 'overview', label: 'Overview', icon: FileTextIcon },
  { key: 'reports', label: `Weekly Reports (${weeklyReports.filter(r => r.projectId === route.params.id).length})`, icon: UploadIcon },
  { key: 'instructions', label: 'Instructions', icon: MessageSquareIcon },
  { key: 'documents', label: 'Documents', icon: FolderOpenIcon },
  { key: 'audit', label: 'Audit Logs', icon: HistoryIcon }
]

function formatDate(d) {
  return new Date(d).toLocaleDateString()
}

function submitReport() {
  alert('Report uploaded successfully!')
}
</script>
