<template>
  <div class="space-y-6">
    <div>
      <h1 class="text-2xl font-semibold text-slate-900 mb-1">Audit Logs</h1>
      <p class="text-slate-600">Track all user activities and system events</p>
    </div>

    <!-- Filters -->
    <div class="bg-white rounded-lg border border-slate-200 p-6">
      <div class="flex items-center gap-2 mb-4">
        <FilterIcon class="w-5 h-5 text-slate-600" />
        <h3 class="text-lg font-medium text-slate-900">Filters</h3>
      </div>
      <div class="grid grid-cols-1 md:grid-cols-3 gap-4">
        <div>
          <label class="block text-sm text-slate-700 mb-2">Search Action</label>
          <div class="relative">
            <SearchIcon class="absolute left-3 top-1/2 -translate-y-1/2 w-4 h-4 text-slate-400" />
            <input v-model="searchTerm" type="text" placeholder="Search actions..."
              class="w-full pl-10 pr-4 py-2 border border-slate-300 rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500 text-sm" />
          </div>
        </div>
        <div>
          <label class="block text-sm text-slate-700 mb-2">User</label>
          <select v-model="selectedUser" class="w-full px-3 py-2 border border-slate-300 rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500 text-sm">
            <option value="all">All Users</option>
            <option v-for="user in uniqueUsers" :key="user" :value="user">{{ user }}</option>
          </select>
        </div>
        <div>
          <label class="block text-sm text-slate-700 mb-2">Date From</label>
          <input v-model="dateFrom" type="date" class="w-full px-3 py-2 border border-slate-300 rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500 text-sm" />
        </div>
      </div>
    </div>

    <!-- Table -->
    <div class="bg-white rounded-lg border border-slate-200">
      <div class="p-6 border-b border-slate-200 flex items-center justify-between">
        <h3 class="text-lg font-medium text-slate-900">Activity Log</h3>
        <span class="text-sm text-slate-600">{{ filteredLogs.length }} entries</span>
      </div>
      <div class="overflow-x-auto">
        <table class="w-full">
          <thead class="bg-slate-50 border-b border-slate-200">
            <tr>
              <th class="px-6 py-3 text-left text-sm text-slate-700">User</th>
              <th class="px-6 py-3 text-left text-sm text-slate-700">Role</th>
              <th class="px-6 py-3 text-left text-sm text-slate-700">Action</th>
              <th class="px-6 py-3 text-left text-sm text-slate-700">Timestamp</th>
              <th class="px-6 py-3 text-left text-sm text-slate-700">IP Address</th>
              <th class="px-6 py-3 text-left text-sm text-slate-700">Location</th>
            </tr>
          </thead>
          <tbody class="divide-y divide-slate-200">
            <tr v-for="log in filteredLogs" :key="log.id" class="hover:bg-slate-50">
              <td class="px-6 py-4 text-sm font-medium text-slate-900">{{ log.user }}</td>
              <td class="px-6 py-4">
                <span :class="['inline-flex px-2 py-1 rounded-full text-xs border', getRoleBadgeColor(log.role)]">
                  {{ getRoleDisplayName(log.role) }}
                </span>
              </td>
              <td class="px-6 py-4 text-sm text-slate-700">{{ log.action }}</td>
              <td class="px-6 py-4 text-sm text-slate-600">{{ log.timestamp }}</td>
              <td class="px-6 py-4 text-sm text-slate-600 font-mono">{{ log.ipAddress }}</td>
              <td class="px-6 py-4 text-sm text-slate-600">{{ log.location }}</td>
            </tr>
          </tbody>
        </table>
      </div>
    </div>

    <!-- Security Notice -->
    <div class="bg-emerald-50 border border-emerald-200 rounded-lg p-4">
      <div class="flex items-start gap-3">
        <HistoryIcon class="w-5 h-5 text-emerald-600 mt-0.5" />
        <div>
          <p class="text-sm font-medium text-emerald-900 mb-1">Audit Log Security</p>
          <p class="text-xs text-emerald-700">All actions are logged with timestamps, IP addresses, and geolocation data. Logs are immutable and stored securely for compliance purposes.</p>
        </div>
      </div>
    </div>
  </div>
</template>

<script setup>
import { ref, computed } from 'vue'
import { Filter as FilterIcon, Search as SearchIcon, History as HistoryIcon } from 'lucide-vue-next'
import { auditLogs } from '../data/mockData.js'
import { getRoleBadgeColor, getRoleDisplayName } from '../utils/permissions.js'

const searchTerm = ref('')
const selectedUser = ref('all')
const dateFrom = ref('')

const uniqueUsers = [...new Set(auditLogs.map(l => l.user))]

const filteredLogs = computed(() => auditLogs.filter(log => {
  if (searchTerm.value && !log.action.toLowerCase().includes(searchTerm.value.toLowerCase())) return false
  if (selectedUser.value !== 'all' && log.user !== selectedUser.value) return false
  return true
}))
</script>
