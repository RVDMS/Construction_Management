<template>
  <div class="space-y-6">
    <div class="flex items-center justify-between">
      <div>
        <h1 class="text-2xl font-semibold text-slate-900 mb-1">User Management</h1>
        <p class="text-slate-600">Manage users and role-based access control</p>
      </div>
      <button @click="showAddUser = !showAddUser" class="flex items-center gap-2 px-4 py-2 bg-emerald-600 hover:bg-emerald-700 text-white rounded-lg transition-colors text-sm">
        <PlusIcon class="w-4 h-4" />
        Add User
      </button>
    </div>

    <!-- Add User Form -->
    <div v-if="showAddUser" class="bg-white rounded-lg border border-slate-200 p-6">
      <h3 class="text-lg font-medium text-slate-900 mb-4">Add New User</h3>
      <form class="space-y-4">
        <div class="grid grid-cols-1 md:grid-cols-2 gap-4">
          <div>
            <label class="block text-sm text-slate-700 mb-2">Full Name</label>
            <input type="text" placeholder="John Doe" class="w-full px-3 py-2 border border-slate-300 rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500 text-sm" />
          </div>
          <div>
            <label class="block text-sm text-slate-700 mb-2">Email Address</label>
            <input type="email" placeholder="john.doe@housing.go.ke" class="w-full px-3 py-2 border border-slate-300 rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500 text-sm" />
          </div>
          <div>
            <label class="block text-sm text-slate-700 mb-2">Role</label>
            <select class="w-full px-3 py-2 border border-slate-300 rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500 text-sm">
              <option value="">Select a role</option>
              <option value="regional-lead">Regional Lead</option>
              <option value="county-director">County Director</option>
              <option value="clerk-of-works">Clerk of Works</option>
              <option value="consultant">Consultant</option>
            </select>
          </div>
          <div>
            <label class="block text-sm text-slate-700 mb-2">Enable 2FA</label>
            <select class="w-full px-3 py-2 border border-slate-300 rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500 text-sm">
              <option value="yes">Yes</option>
              <option value="no">No</option>
            </select>
          </div>
        </div>
        <div class="flex gap-3">
          <button type="submit" class="px-4 py-2 bg-emerald-600 hover:bg-emerald-700 text-white rounded-lg transition-colors text-sm">Create User</button>
          <button type="button" @click="showAddUser = false" class="px-4 py-2 border border-slate-300 text-slate-700 hover:bg-slate-50 rounded-lg transition-colors text-sm">Cancel</button>
        </div>
      </form>
    </div>

    <!-- Users Table -->
    <div class="bg-white rounded-lg border border-slate-200">
      <div class="p-6 border-b border-slate-200">
        <h3 class="text-lg font-medium text-slate-900">All Users</h3>
      </div>
      <div class="overflow-x-auto">
        <table class="w-full">
          <thead class="bg-slate-50 border-b border-slate-200">
            <tr>
              <th class="px-6 py-3 text-left text-sm text-slate-700">Name</th>
              <th class="px-6 py-3 text-left text-sm text-slate-700">Email</th>
              <th class="px-6 py-3 text-left text-sm text-slate-700">Role</th>
              <th class="px-6 py-3 text-left text-sm text-slate-700">Phone Number</th>
              <!--<th class="px-6 py-3 text-left text-sm text-slate-700">Actions</th> -->
            </tr>
          </thead>
          <tbody class="divide-y divide-slate-200">
            <tr v-for="user in users" :key="user.id" class="hover:bg-slate-50">
              <td class="px-6 py-4 text-sm font-medium text-slate-900">{{ user.name }}</td>
              <td class="px-6 py-4 text-sm text-slate-600">{{ user.email }}</td>
              <td class="px-6 py-4">
                <span :class="['inline-flex px-2 py-1 rounded-full text-xs border', getRoleBadgeColor(user.role)]">
                  {{ getRoleDisplayName(user.role) }}
                </span>
              </td>
              <td>
                <span class="text-sm text-slate-600">{{ user.phone }}></span>
              </td>
              <!--
              <td class="px-6 py-4">
                <span v-if="user.has2FA" class="inline-flex items-center gap-1 text-xs text-emerald-700">
                  <ShieldIcon class="w-3 h-3" /> Enabled
                </span> 
                <span v-else class="text-xs text-slate-500">Disabled</span>
              </td> -->
              <td class="px-6 py-4">
                <div class="flex items-center gap-2">
                  <button class="p-1 hover:bg-slate-100 rounded transition-colors">
                    <EditIcon class="w-4 h-4 text-slate-600" />
                  </button>
                  <button class="p-1 hover:bg-red-50 rounded transition-colors">
                    <Trash2Icon class="w-4 h-4 text-red-600" />
                  </button>
                </div>
              </td>
            </tr>
          </tbody>
        </table>
      </div>
    </div>

    <!-- Role Permissions Matrix --
    <div class="bg-white rounded-lg border border-slate-200 p-6">
      <h3 class="text-lg font-medium text-slate-900 mb-4">Role Permissions Matrix</h3>
      <div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-4">
        <div v-for="(info, role) in rolePermissionsMatrix" :key="role" class="border border-slate-200 rounded-lg p-4 hover:shadow-md transition-shadow">
          <div :class="['inline-flex px-2.5 py-1 rounded-full text-xs border mb-3', getRoleBadgeColor(role)]">{{ info.label }}</div>
          <ul class="space-y-2">
            <li v-for="(perm, i) in info.permissions" :key="i" class="flex items-start gap-2 text-xs text-slate-600">
              <span class="text-emerald-600 mt-0.5">●</span>
              <span>{{ perm }}</span>
            </li>
          </ul>
        </div>
      </div>
    </div>

    -- Security Notice 
    <div class="bg-blue-50 border border-blue-200 rounded-lg p-4">
      <div class="flex items-start gap-3">
        <ShieldIcon class="w-5 h-5 text-blue-600 mt-0.5" />
        <div>
          <p class="text-sm font-medium text-blue-900 mb-1">Role-Based Access Control (RBAC)</p>
          <p class="text-xs text-blue-700">All users are assigned roles with specific permissions. Passwords are hashed using bcrypt, and admin roles require 2FA authentication. Rate limiting is enforced on all API endpoints.</p>
        </div>
      </div>
    </div>
    -->
  </div>
</template>

<script setup>
import { ref } from 'vue'
import { Plus as PlusIcon, Shield as ShieldIcon, Edit as EditIcon, Trash2 as Trash2Icon } from 'lucide-vue-next'
import { users } from '../data/mockData.js'
import { getRoleBadgeColor, getRoleDisplayName } from '../utils/permissions.js'

const showAddUser = ref(false)

const rolePermissionsMatrix = {
  'regional-lead': {
    label: 'Regional Lead',
    permissions: ['Full system access', 'View all projects', 'Manage users', 'Export reports', 'Access audit logs', 'System configuration']
  },
  'county-director': {
    label: 'County Director',
    permissions: ['County-level access', 'View county projects', 'Approve reports', 'Manage contractors', 'View audit logs']
  },
  'clerk-of-works': {
    label: 'Clerk of Works',
    permissions: ['Site-level access', 'Upload weekly reports', 'Upload progress photos', 'Update site progress', 'Geo-limited uploads only']
  },
  'consultant': {
    label: 'Consultant',
    permissions: ['Project observation access', 'Issue instructions', 'Upload documents', 'Review progress reports', 'Mark urgency levels']
  }
}
</script>
