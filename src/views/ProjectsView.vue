<template>
  <div class="space-y-6">
    <div>
      <h1 class="text-2xl font-semibold text-slate-900 mb-1">Projects</h1>
      <p class="text-slate-600">All housing projects in Nakuru County</p>
    </div>

    <div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6">
      <RouterLink
        v-for="project in accessibleProjects"
        :key="project.id"
        :to="`/dashboard/projects/${project.id}`"
        class="bg-white rounded-lg border border-slate-200 hover:shadow-lg transition-shadow p-6 block"
      >
        <div class="flex items-start justify-between mb-4">
          <div>
            <h3 class="text-lg font-medium text-slate-900 mb-1">{{ project.name }}</h3>
            <div class="flex items-center gap-1 text-sm text-slate-600">
              <MapPinIcon class="w-3 h-3" />
              {{ project.ward }}
            </div>
          </div>
          <span :class="['px-2.5 py-1 rounded-full text-xs border flex-shrink-0', getStatusColor(project.status)]">
            {{ getStatusLabel(project.status) }}
          </span>
        </div>

        <div class="space-y-3">
          <div>
            <p class="text-xs text-slate-500 mb-1">Contractor</p>
            <p class="text-sm text-slate-900">{{ project.contractor }}</p>
          </div>

          <div>
            <div class="flex items-center justify-between text-xs text-slate-600 mb-1">
              <span>Progress</span>
              <span>{{ project.completionPercentage }}%</span>
            </div>
            <div class="bg-slate-200 rounded-full h-2">
              <div class="bg-emerald-600 h-2 rounded-full transition-all" :style="{ width: `${project.completionPercentage}%` }"></div>
            </div>
          </div>

          <div class="flex items-center justify-between pt-3 border-t border-slate-200">
            <div>
              <p class="text-xs text-slate-500">Budget</p>
              <p class="text-sm font-medium text-slate-900">KES {{ (project.contractSum / 1000000).toFixed(1) }}M</p>
            </div>
            <div class="text-right">
              <p class="text-xs text-slate-500">Spent</p>
              <p class="text-sm font-medium text-emerald-700">
                {{ ((project.budgetSpent / project.contractSum) * 100).toFixed(0) }}%
              </p>
            </div>
          </div>
        </div>
      </RouterLink>
    </div>
  </div>
</template>

<script setup>
import { computed } from 'vue'
import { RouterLink } from 'vue-router'
import { MapPin as MapPinIcon } from 'lucide-vue-next'
import { useUserStore } from '../stores/userStore.js'
import { projects } from '../data/mockData.js'
import { getAccessibleProjects, getStatusColor, getStatusLabel } from '../utils/permissions.js'

const userStore = useUserStore()
const accessibleProjects = computed(() => getAccessibleProjects(userStore.currentUser, projects))
</script>
