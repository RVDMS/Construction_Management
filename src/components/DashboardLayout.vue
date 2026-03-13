<template>
  <div class="h-screen flex flex-col bg-slate-50 dark:bg-slate-900 transition-colors duration-200 overflow-hidden">
    <!-- Top Header -->
    <header class="bg-white dark:bg-slate-800 border-b border-slate-200 dark:border-slate-700 sticky top-0 z-40 transition-colors duration-200">
      <div class="flex items-center justify-between px-4 md:px-6 py-3">
        <!-- Left: Logos + Region -->
        <div class="flex flex-col sm:flex-row items-start sm:items-center gap-2 sm:gap-3">

          <!-- Mobile hamburger -->
          <button
            @click="sidebarOpen = !sidebarOpen"
            class="lg:hidden p-2 rounded-lg hover:bg-slate-100 dark:hover:bg-slate-700 transition-colors"
          >
            <MenuIcon v-if="!sidebarOpen" class="w-5 h-5 text-slate-600 dark:text-slate-400" />
            <XIcon v-else class="w-5 h-5 text-slate-600 dark:text-slate-400" />
          </button>
          <div class="flex items-center gap-2">
            <!-- Ministry logo: always visible -->
            <img src="@/assets/logos/Ministry+SDHUD_Logo.jpg" alt="Ministry Logo" class="h-8 w-8 md:h-10 md:w-10 object-contain" />

            <!-- Other logos: hidden on small screens -->
            <img src="@/assets/logos/AHB_Logo.jpg" alt="AHB Logo" class="hidden md:block h-8 w-8 md:h-10 md:w-10 object-contain" />
            <img src="@/assets/logos/Boma Yangu_Logo.jpg" alt="Boma Yangu Logo" class="hidden md:block h-7 w-7 md:h-9 md:w-9 object-contain" />
          </div>

          <div class="ml-3 hidden sm:block">
            <p class="text-sm font-semibold text-slate-900 dark:text-white leading-tight">
              {{ headerTitle }}
            </p>
            <p class="text-xs text-slate-600 dark:text-slate-400">{{ headerSubtitle }}</p>
          </div>
        </div>

        <div class="flex items-center gap-2 md:gap-3">
          <button
            @click="themeStore.toggleTheme()"
            :title="themeStore.isDark ? 'Switch to Light Mode' : 'Switch to Dark Mode'"
            class="p-2 rounded-lg hover:bg-slate-100 dark:hover:bg-slate-700 transition-colors"
          >
            <SunIcon v-if="themeStore.isDark" class="w-5 h-5 text-amber-400" />
            <MoonIcon v-else class="w-5 h-5 text-slate-600 dark:text-slate-400" />
          </button>

          <!-- Notification bell -->
          <button class="relative p-2 hover:bg-slate-100 rounded-lg transition-colors">
            <BellIcon class="w-5 h-5 text-slate-600" />
            <span class="absolute top-1 right-1 w-2 h-2 bg-red-500 rounded-full"></span>
          </button>

          <!-- Profile dropdown -->

          <div class="relative" ref="profileMenuRef">
            <button
              @click="showProfileMenu = !showProfileMenu"
              class="flex items-center gap-3 px-3 py-2 hover:bg-slate-100 rounded-lg transition-colors"
            >
              <div class="text-right">
                <p class="text-sm font-medium text-slate-900">{{ userStore.currentUser.name }}</p>
                <p class="text-xs text-slate-600">
                  {{ getRoleDisplayName(userStore.currentUser.role) }}
                  <span v-if="userStore.currentUser.has2FA" class="ml-2 text-emerald-600">● 2FA</span>
                </p>
                <p v-if="userLocation" class="text-xs text-slate-500">📍 {{ userLocation }}</p>
              </div>
              <ChevronDownIcon class="w-4 h-4 text-slate-600" />
            </button>
             
            <!-- Dropdown menu -->
            
            <Transition name="dropdown">
              <div v-if="showProfileMenu" class="absolute right-0 mt-2 w-64 bg-white rounded-lg shadow-lg border border-slate-200 py-2 z-50">
                <div class="px-4 py-2 border-b border-slate-200">
                  <p class="text-xs text-slate-500 mb-1">Current Profile</p>
                  <p class="text-sm font-medium text-slate-900">{{ userStore.currentUser.name }}</p>
                  <p class="text-xs text-slate-600">{{ getRoleDisplayName(userStore.currentUser.role) }}</p>
                </div>

                <!-- Switch profile section - we do away with this for now -->
                 <!--
                <div class="px-4 py-2 border-b border-slate-200">
                  <p class="text-xs text-slate-500 mb-2">Switch Profile</p>
                  <div class="space-y-1">
                    <button
                      v-for="user in userStore.allUsers"
                      :key="user.id"
                      @click="switchProfile(user.id)"
                      :class="['w-full text-left px-3 py-2 rounded flex items-center gap-2 text-sm transition-colors',
                        userStore.currentUser.id === user.id ? 'bg-emerald-50 text-emerald-700' : 'hover:bg-slate-50 text-slate-700'
                      ]"
                    >
                      <UserCircleIcon class="w-4 h-4" />
                      <div class="flex-1 min-w-0">
                        <p class="truncate">{{ user.name }}</p>
                        <p class="text-xs text-slate-500">{{ getRoleDisplayName(user.role) }}</p>
                      </div>
                    </button>
                  </div>
                </div> 
              -->

                <div class="px-4 py-3 border-b border-slate-200 dark:border-slate-700 flex items-center justify-between">
                  <div class="flex items-center gap-2 text-sm text-slate-700 dark:text-slate-300">
                    <SunIcon v-if="themeStore.isDark" class="w-4 h-4 text-amber-400" />
                    <MoonIcon v-else class="w-4 h-4 text-slate-500" />
                    <span>{{ themeStore.isDark ? 'Light Mode' : 'Dark Mode' }}</span>
                  </div>

                  <button
                    @click="themeStore.toggleTheme()"
                    :class="[
                      'relative inline-flex w-11 h-6 rounded-full transition-colors duration-300',
                      themeStore.isDark ? 'bg-emerald-500' : 'bg-slate-300'
                    ]"
                  >
                    <span
                      :class="[
                        'absolute top-1 left-1 w-4 h-4 bg-white rounded-full shadow transition-transform duration-300',
                        themeStore.isDark ? 'translate-x-5' : 'translate-x-0'
                      ]"
                    ></span>
                  </button>
                </div>

                <RouterLink
                  to="/dashboard/settings"
                  @click="showProfileMenu = false"
                  class="flex items-center gap-3 px-4 py-2 hover:bg-slate-50 text-slate-700 text-sm"
                >
                  <SettingsIcon class="w-4 h-4" />
                  Settings
                </RouterLink>
                <hr class="my-1 border-slate-200" />
                <RouterLink
                  to="/login"
                  class="flex items-center gap-3 px-4 py-2 hover:bg-slate-50 text-red-600 text-sm"
                >
                  <LogOutIcon class="w-4 h-4" />
                  Logout
                </RouterLink>
              </div>
            </Transition>
          </div>
        </div>
      </div>
    </header>

    <div class="flex flex-1 relative overflow-hidden">
      <!-- Mobile Overlay -->
      <Transition name="fade">
        <div
          v-if="sidebarOpen"
          class="lg:hidden fixed inset-0 bg-black/50 z-40 top-[57px]"
          @click="sidebarOpen = false"
        ></div>
      </Transition>
      <!-- Sidebar -->
      <aside :class="[
        'bg-white dark:bg-slate-800 border-r border-slate-200 dark:border-slate-700 transition-transform duration-300 z-30 flex-shrink-0',
        'fixed top-[73px] bottom-0 w-72 flex flex-col overflow-hidden z-50',
        'lg:sticky lg:top-[57px] lg:h-[calc(100vh-57px)] lg:w-64 lg:translate-x-0 lg:z-30',
        sidebarOpen ? 'translate-x-0' : '-translate-x-full lg:translate-x-0'
      ]">
        <div class="flex-1 overflow-y-auto">
        <nav class="p-4 space-y-1 pb-6">
          <RouterLink
            v-for="item in visibleNavItems"
            :key="item.name"
            :to="item.href"
            @click="sidebarOpen = false"
            :class="['flex items-center gap-3 px-4 py-3 rounded-lg transition-colors text-sm',
              isActiveRoute(item.href)
                ? 'bg-emerald-50 dark:bg-emerald-900/30 text-emerald-700 dark:text-emerald-400 font-medium'
                : 'text-slate-700 dark:text-slate-300 hover:bg-slate-50 dark:hover:bg-slate-700'
            ]"
          >
            <component :is="item.icon" class="w-5 h-5" />
            <span>{{ item.name }}</span>
          </RouterLink>

          <!-- Counties Section -->
          <div v-if="showCounties" class="pt-4">
            <p class="px-4 text-xs text-slate-500 mb-2 uppercase tracking-wide">Counties</p>
            <RouterLink
              v-for="county in featuredCounties"
              :key="county"
              :to="`/dashboard/counties/${county}`"
              class="flex items-center gap-3 px-4 py-3 rounded-lg text-slate-700 hover:bg-slate-50 text-sm"
            >
              <MapPinIcon class="w-4 h-4" />
              {{ county }}
            </RouterLink>

            <div v-if="moreCounties.length > 0">
              <button
                @click="showMoreCounties = !showMoreCounties"
                class="w-full flex items-center justify-between gap-3 px-4 py-3 rounded-lg text-slate-700 hover:bg-slate-50 text-sm"
              >
                <div class="flex items-center gap-1 w-2 md:w-auto">
                  <MapPinIcon class="w-4 h-4" />
                  More Counties ({{ moreCounties.length }})
                </div>
                <ChevronDownIcon :class="['w-4 h-4 transition-transform', showMoreCounties ? 'rotate-180' : '']" />
              </button>
              <div v-if="showMoreCounties" class="pl-8 space-y-1">
                <RouterLink
                  v-for="county in moreCounties"
                  :key="county"
                  :to="`/dashboard/counties/${county}`"
                  class="block px-4 py-2 text-sm text-slate-600 hover:bg-slate-50 rounded-lg"
                >
                  {{ county }}
                </RouterLink>
              </div>
            </div>
          </div>
        </nav>
        </div>

        <!-- Security status widget -removed 
        <div class="mx-4 mt-6 p-4 bg-emerald-50 dark:bg-emerald-900/20 rounded-lg border border-emerald-200 dark:border-emerald-800">
          <div class="flex items-center gap-2 mb-2">
            <ShieldIcon class="w-4 h-4 text-emerald-600" />
            <span class="text-sm font-medium text-emerald-900">Security Status</span>
          </div>
          <ul class="text-xs text-emerald-700 space-y-1">
            <li>● JWT Authentication</li>
            <li>● 2FA Enabled</li>
            <li>● Geo-Limiting Active</li>
            <li>● Rate Limiting On</li>
          </ul>
        </div>
        -->
      </aside>

      <!-- Main content -->
      <main class="flex-1 p-4 md:p-6 min-w-0 min-h-0 overflow-y-auto">
        <RouterView />
      </main>
    </div>
  </div>
</template>

<script setup>
import { ref, computed, onMounted, onUnmounted } from 'vue'
import { RouterLink, RouterView, useRoute } from 'vue-router'
import { useThemeStore } from '../stores/themeStore.js'
import {
  LayoutDashboard as LayoutDashboardIcon,
  FolderKanban as FolderKanbanIcon,
  FileText as FileTextIcon,
  History as HistoryIcon,
  Users as UsersIcon,
  Settings as SettingsIcon,
  Bell as BellIcon,
  ChevronDown as ChevronDownIcon,
  Shield as ShieldIcon,
  LogOut as LogOutIcon,
  UserCircle as UserCircleIcon,
  MapPin as MapPinIcon,
  Sun as SunIcon,
  Moon as MoonIcon,
  Menu as MenuIcon,
  X as XIcon
} from 'lucide-vue-next'
import { useUserStore } from '../stores/userStore.js'
import { canAccessPage, getRoleDisplayName } from '../utils/permissions.js'
import { getAccessibleCounties } from '../data/counties.js'

const userStore = useUserStore()
const themeStore = useThemeStore()
const route = useRoute()
const showProfileMenu = ref(false)
const showMoreCounties = ref(false)
const sidebarOpen = ref(false)
const userLocation = ref('Nakuru, Kenya')
const profileMenuRef = ref(null)

const navItems = [
  { name: 'Dashboard', href: '/dashboard', icon: LayoutDashboardIcon, page: 'dashboard' },
  { name: 'Projects', href: '/dashboard/projects', icon: FolderKanbanIcon, page: 'projects' },
  { name: 'Reports', href: '/dashboard/reports', icon: FileTextIcon, page: 'reports' },
  { name: 'Audit Logs', href: '/dashboard/audit-logs', icon: HistoryIcon, page: 'audit-logs' },
  { name: 'Users / Roles', href: '/dashboard/users', icon: UsersIcon, page: 'users' },
  { name: 'Settings', href: '/dashboard/settings', icon: SettingsIcon, page: 'settings' }
]

const visibleNavItems = computed(() =>
  navItems.filter(item => canAccessPage(userStore.currentUser, item.page))
)

const showCounties = computed(() =>
  ['principal-secretary', 'regional-lead'].includes(userStore.currentUser.role)
)

const accessibleCounties = computed(() =>
  getAccessibleCounties(userStore.currentUser.role, userStore.currentUser.region, userStore.currentUser.county)
)

const featuredCounties = computed(() => accessibleCounties.value.slice(0, 3))
const moreCounties = computed(() => accessibleCounties.value.slice(3))

const headerTitle = computed(() => {
  const u = userStore.currentUser
  if (u.role === 'principal-secretary') return 'National Dashboard'
  if (u.role === 'regional-lead' && u.region) return `${u.region} Region`
  if (u.county) return `${u.county} County`
  return 'Regional Dashboard'
})

const headerSubtitle = computed(() => {
  const u = userStore.currentUser
  if (u.role === 'principal-secretary') return 'All 47 Counties'
  if (u.role === 'regional-lead') return `${accessibleCounties.value.length} Counties`
  return 'County View'
})

function isActiveRoute(href) {
  if (href === '/dashboard') return route.path === '/dashboard'
  return route.path.startsWith(href)
}
/*
function switchProfile(userId) {
  userStore.switchUser(userId)
  showProfileMenu.value = false
}
*/
// Close dropdown on outside click
function handleClickOutside(e) {
  if (profileMenuRef.value && !profileMenuRef.value.contains(e.target)) {
    showProfileMenu.value = false
  }
}

onMounted(() => {
  document.addEventListener('click', handleClickOutside)
  // Geolocation
  if (navigator?.geolocation) {
    navigator.geolocation.getCurrentPosition(
      pos => {
        userLocation.value = `${pos.coords.latitude.toFixed(4)}, ${pos.coords.longitude.toFixed(4)}`
      },
      () => { userLocation.value = 'Nakuru, Kenya' },
      { enableHighAccuracy: false, timeout: 10000, maximumAge: 60000 }
    )
  }
})

onUnmounted(() => {
  document.removeEventListener('click', handleClickOutside)
})
</script>

<style scoped>
.dropdown-enter-active,
.dropdown-leave-active {
  transition: opacity 0.15s ease, transform 0.15s ease;
}
.dropdown-enter-from,
.dropdown-leave-to {
  opacity: 0;
  transform: translateY(-4px);
}
.fade-enter-active,
.fade-leave-active {
  transition: opacity 0.2s ease;
}

.fade-enter-from,
.fade-leave-to {
  opacity: 0;
}
</style>