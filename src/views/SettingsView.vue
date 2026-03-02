<template>
  <div class="space-y-6">
    <div>
      <h1 class="text-2xl font-semibold text-slate-900 mb-1">Settings</h1>
      <p class="text-slate-600">Manage your account and system settings</p>
    </div>

    <!-- Profile -->
    <div class="bg-white rounded-lg border border-slate-200 p-6">
      <h3 class="text-lg font-medium text-slate-900 mb-4">Profile Settings</h3>
      <div class="space-y-4">
        <div>
          <label class="block text-sm text-slate-700 mb-2">Full Name</label>
          <input type="text" :value="userStore.currentUser.name" class="w-full max-w-md px-3 py-2 border border-slate-300 rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500 text-sm" />
        </div>
        <div>
          <label class="block text-sm text-slate-700 mb-2">Email Address</label>
          <input type="email" :value="userStore.currentUser.email" class="w-full max-w-md px-3 py-2 border border-slate-300 rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500 text-sm" />
        </div>
        <button class="px-4 py-2 bg-emerald-600 hover:bg-emerald-700 text-white rounded-lg transition-colors text-sm">Save Changes</button>
      </div>
    </div>

    <!-- Security -->
    <div class="bg-white rounded-lg border border-slate-200 p-6">
      <div class="flex items-center gap-2 mb-4">
        <ShieldIcon class="w-5 h-5 text-slate-600" />
        <h3 class="text-lg font-medium text-slate-900">Security Settings</h3>
      </div>
      <div class="space-y-4">
        <div class="flex items-center justify-between py-3 border-b border-slate-200">
          <div>
            <p class="text-sm font-medium text-slate-900">Two-Factor Authentication</p>
            <p class="text-xs text-slate-600">Add an extra layer of security to your account</p>
          </div>
          <div class="flex items-center gap-2">
            <span v-if="userStore.currentUser.has2FA" class="text-xs text-emerald-600">● Enabled</span>
            <span v-else class="text-xs text-slate-500">Disabled</span>
            <button class="px-3 py-1.5 border border-slate-300 text-slate-700 hover:bg-slate-50 rounded-lg text-sm transition-colors">
              {{ userStore.currentUser.has2FA ? 'Disable' : 'Enable' }}
            </button>
          </div>
        </div>
        <div class="flex items-center justify-between py-3 border-b border-slate-200">
          <div>
            <p class="text-sm font-medium text-slate-900">Change Password</p>
            <p class="text-xs text-slate-600">Update your password regularly for security</p>
          </div>
          <button class="px-3 py-1.5 border border-slate-300 text-slate-700 hover:bg-slate-50 rounded-lg text-sm transition-colors">Change</button>
        </div>
        <div class="flex items-center justify-between py-3">
          <div>
            <p class="text-sm font-medium text-slate-900">Active Sessions</p>
            <p class="text-xs text-slate-600">Manage devices logged into your account</p>
          </div>
          <button class="px-3 py-1.5 border border-slate-300 text-slate-700 hover:bg-slate-50 rounded-lg text-sm transition-colors">View</button>
        </div>
      </div>
    </div>

    <!-- Notifications -->
    <div class="bg-white rounded-lg border border-slate-200 p-6">
      <div class="flex items-center gap-2 mb-4">
        <BellIcon class="w-5 h-5 text-slate-600" />
        <h3 class="text-lg font-medium text-slate-900">Notification Preferences</h3>
      </div>
      <div class="space-y-4">
        <div v-for="pref in notifPrefs" :key="pref.key" class="flex items-center justify-between">
          <div>
            <p class="text-sm font-medium text-slate-900">{{ pref.label }}</p>
            <p class="text-xs text-slate-600">{{ pref.desc }}</p>
          </div>
          <label class="relative inline-block w-12 h-6 cursor-pointer">
            <input type="checkbox" class="sr-only peer" :checked="pref.enabled" @change="pref.enabled = !pref.enabled" />
            <div class="w-full h-full bg-slate-300 peer-checked:bg-emerald-600 rounded-full transition-colors"></div>
            <div class="absolute left-1 top-1 w-4 h-4 bg-white rounded-full peer-checked:translate-x-6 transition-transform"></div>
          </label>
        </div>
      </div>
    </div>

    <!-- System Settings -->
    <div class="bg-white rounded-lg border border-slate-200 p-6">
      <div class="flex items-center gap-2 mb-4">
        <DatabaseIcon class="w-5 h-5 text-slate-600" />
        <h3 class="text-lg font-medium text-slate-900">System Settings</h3>
      </div>
      <div class="space-y-4">
        <div>
          <label class="block text-sm text-slate-700 mb-2">Default View</label>
          <select class="w-full max-w-md px-3 py-2 border border-slate-300 rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500 text-sm">
            <option>Regional View</option>
            <option>County View (Nakuru)</option>
          </select>
        </div>
        <div>
          <label class="block text-sm text-slate-700 mb-2">Date Format</label>
          <select class="w-full max-w-md px-3 py-2 border border-slate-300 rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500 text-sm">
            <option>DD/MM/YYYY</option>
            <option>MM/DD/YYYY</option>
            <option>YYYY-MM-DD</option>
          </select>
        </div>
        <div>
          <label class="block text-sm text-slate-700 mb-2">Currency Display</label>
          <select class="w-full max-w-md px-3 py-2 border border-slate-300 rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500 text-sm">
            <option>KES (Kenyan Shilling)</option>
            <option>USD (US Dollar)</option>
          </select>
        </div>
      </div>
    </div>

    <!-- Security Info -->
    <div class="bg-slate-50 border border-slate-200 rounded-lg p-6">
      <h3 class="text-lg font-medium text-slate-900 mb-4">Security Status</h3>
      <div class="grid grid-cols-1 md:grid-cols-2 gap-4">
        <div v-for="item in securityItems" :key="item.title" class="flex items-start gap-3">
          <div class="w-8 h-8 bg-emerald-100 rounded-lg flex items-center justify-center flex-shrink-0">
            <component :is="item.icon" class="w-4 h-4 text-emerald-600" />
          </div>
          <div>
            <p class="text-sm font-medium text-slate-900 mb-1">{{ item.title }}</p>
            <p class="text-xs text-slate-600">{{ item.desc }}</p>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script setup>
import { ref } from 'vue'
import { Shield as ShieldIcon, Bell as BellIcon, Database as DatabaseIcon, Lock as LockIcon, Globe as GlobeIcon } from 'lucide-vue-next'
import { useUserStore } from '../stores/userStore.js'

const userStore = useUserStore()

const notifPrefs = ref([
  { key: 'email', label: 'Email Notifications', desc: 'Receive updates via email', enabled: true },
  { key: 'status', label: 'Project Status Updates', desc: 'Get notified of project changes', enabled: true },
  { key: 'reports', label: 'Report Submissions', desc: 'Alerts for new weekly reports', enabled: true }
])

const securityItems = [
  { icon: LockIcon, title: 'Password Hashing', desc: 'Passwords are encrypted using bcrypt with salt rounds' },
  { icon: ShieldIcon, title: 'JWT Authentication', desc: 'Secure token-based authentication for all sessions' },
  { icon: GlobeIcon, title: 'Geo-Limited Access', desc: 'Site uploads restricted to verified locations' },
  { icon: DatabaseIcon, title: 'Rate Limiting', desc: 'API protection against brute force attacks' }
]
</script>
