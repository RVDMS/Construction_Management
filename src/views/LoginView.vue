<template>
  <div class="min-h-screen flex items-center justify-center bg-gradient-to-br from-slate-50 to-slate-100 dark:from-slate-900 dark:to-slate-800 px-4 py-8">
    <div class="w-full max-w-md">
      <!-- Header with logos -->
      <div class="text-center mb-6 md:mb-8">
        <div class="flex items-center justify-center gap-3 md:gap-4 mb-4 md:mb-6 flex-wrap">
          <!-- Ministry Logo placeholder -->
          <img :src="ministryLogo" alt="Ministry Logo" class="h-12 w-12 md:h-14 md:w-14 object-contain" />
          <img :src="ahbLogo" alt="AHB Logo" class="h-12 w-12 md:h-14 md:w-14 object-contain" />
          <img :src="bomaLogo" alt="Boma Yangu Logo" class="h-10 w-10 md:h-12 md:w-12 object-contain" />
        </div>
        <h1 class="text-xl md:text-2xl font-semibold text-slate-900 mb-1 md:mb-2">Affordable Housing Programme</h1>
        <p class="text-slate-600">Nakuru County Pilot – Regional Dashboard</p>
      </div>

      <!-- Test Credentials Panel -->
      <div class="bg-slate-800 rounded-xl border border-slate-700 p-4 mb-6">
        <div class="flex items-center justify-between cursor-pointer" @click="showCredentials = !showCredentials">
          <div class="flex items-center gap-2">
            <KeyRoundIcon class="w-4 h-4 text-amber-400" />
            <p class="text-sm font-medium text-amber-400">Test Login Credentials</p>
          </div>
          <ChevronDownIcon :class="['w-4 h-4 text-slate-400 transition-transform duration-200', showCredentials ? 'rotate-180' : '']" />
        </div>

        <div v-if="showCredentials" class="mt-3 space-y-2">
          <button
            v-for="cred in testCredentials"
            :key="cred.email"
            @click="fillCredentials(cred)"
            class="w-full text-left px-3 py-2.5 bg-slate-700 hover:bg-slate-600 rounded-lg transition-colors group"
          >
            <div class="flex items-center justify-between">
              <div>
                <p class="text-sm font-medium text-white">{{ cred.name }}</p>
                <p class="text-xs text-slate-400">{{ cred.email }}</p>
              </div>
              <span class="text-xs px-2 py-1 rounded-full border flex-shrink-0 ml-2" :class="roleColors[cred.role]">
                {{ roleLabel[cred.role] }}
              </span>
            </div>
            <p class="text-xs text-slate-500 mt-1 group-hover:text-slate-400">
              Password: <span class="font-mono text-slate-300">{{ cred.password }}</span>
            </p>
          </button>
        </div>
      </div>

      <!-- Login Form Card -->
      <div class="bg-white dark:bg-slate-800 rounded-xl shadow-lg border border-slate-200 dark:border-slate-700 p-6 md:p-8">
        <h2 class="text-lg md:text-xl font-semibold mb-5 md:mb-6 text-slate-900 dark:text-white">
          {{ showTwoFactor ? 'Two-Factor Authentication' : 'Secure Login' }}
        </h2>

        <form @submit.prevent="handleLogin" class="space-y-5">
          <!-- Email + Password -->
          <template v-if="!showTwoFactor">
            <div>
              <label class="block text-sm mb-2 text-slate-700">Email Address</label>
              <div class="relative">
                <MailIcon class="absolute left-3 top-1/2 -translate-y-1/2 w-5 h-5 text-slate-400" />
                <input
                  v-model="email"
                  type="email"
                  placeholder="your.email@housing.go.ke"
                  class="w-full pl-11 pr-4 py-2.5 border border-slate-300 rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500 focus:border-transparent"
                  required
                />
              </div>
            </div>

            <div>
              <label class="block text-sm mb-2 text-slate-700">Password</label>
              <div class="relative">
                <LockIcon class="absolute left-3 top-1/2 -translate-y-1/2 w-5 h-5 text-slate-400" />
                <input
                  v-model="password"
                  type="password"
                  placeholder="Enter your password"
                  class="w-full pl-11 pr-4 py-2.5 border border-slate-300 rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500 focus:border-transparent"
                  required
                />
              </div>
            </div>
          </template>

          <!-- 2FA -->
          <template v-else>
            <div>
              <label class="block text-sm mb-2 text-slate-700">Enter 6-Digit Code</label>
              <div class="relative">
                <KeyRoundIcon class="absolute left-3 top-1/2 -translate-y-1/2 w-5 h-5 text-slate-400" />
                <input
                  v-model="twoFactorCode"
                  type="text"
                  placeholder="000000"
                  maxlength="6"
                  class="w-full pl-11 pr-4 py-2.5 border border-slate-300 rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500 focus:border-transparent text-center text-lg tracking-widest"
                  required
                />
              </div>
              <p class="text-sm text-slate-500 mt-2">Enter the code from your authenticator app</p>
            </div>
          </template>

          <button
            type="submit"
            class="w-full bg-emerald-600 hover:bg-emerald-700 text-white py-2.5 rounded-lg transition-colors font-medium"
          >
            {{ showTwoFactor ? 'Verify & Login' : 'Continue' }}
          </button>

          <button
            v-if="showTwoFactor"
            type="button"
            @click="showTwoFactor = false"
            class="w-full text-slate-600 hover:text-slate-900 text-sm"
          >
            Back to login
          </button>

          <!-- Error message -->
          <div v-if="errorMsg" class="text-sm text-red-600 bg-red-50 border border-red-200 rounded-lg px-4 py-2">
            {{ errorMsg }}
          </div>
        </form>

        <div class="mt-5 md:mt-6 pt-5 md:pt-6 border-t border-slate-200 dark:border-slate-700">
          <div class="flex items-center gap-2 text-xs text-slate-500">
            <ShieldIcon class="w-4 h-4" />
            <span>Secured with JWT authentication, 2FA, and geo-limited access</span>
          </div>
        </div>
      </div>

      <p class="text-center text-xs md:text-sm text-slate-600 dark:text-slate-400 mt-4 md:mt-6">
        Ministry of Lands, Public Works, Housing and Urban Development
      </p>
    </div>
  </div>
</template>

<script setup>
import { useUserStore } from '../stores/userStore.js'
import { ref } from 'vue'
import { useRouter } from 'vue-router'
import { login } from '../services/api.js'
import {
  Mail as MailIcon,
  Lock as LockIcon,
  KeyRound as KeyRoundIcon,
  Shield as ShieldIcon,
  ChevronDown as ChevronDownIcon
} from 'lucide-vue-next'

import ministryLogo from '@/assets/logos/Ministry+SDHUD_Logo.jpg'
import ahbLogo from '@/assets/logos/AHB_Logo.jpg'
import bomaLogo from '@/assets/logos/Boma Yangu_Logo.jpg'

const router = useRouter()
const userStore = useUserStore()
const email = ref('')
const password = ref('')
const twoFactorCode = ref('')
const showTwoFactor = ref(false)
const showCredentials = ref(false)
const errorMsg = ref('')

const testCredentials = [
  { name: 'Charles M. Hinga',  email: 'ps@housing.go.ke',          password: 'PS@1234',       role: 'principal-secretary' },
  { name: 'Richard Tuta',      email: 'r.tuta@housing.go.ke',      password: 'Regional@1234', role: 'regional-lead'       },
  { name: 'Nicholas Ogajo',    email: 'n.ogajo@housing.go.ke',     password: 'Director@1234', role: 'county-director'     },
  { name: 'Dominic Chebon',    email: 'd.chebon@housing.go.ke',    password: 'Clerk@1234',    role: 'clerk-of-works'      },
  { name: 'Grace Wanjiru',     email: 'g.wanjiru@housing.go.ke',   password: 'Clerk@1234',    role: 'clerk-of-works'      },
  { name: 'Frank Asuza',       email: 'f.asuza@consultants.co.ke', password: 'Consult@1234',  role: 'consultant'          },
]

const roleLabel = {
  'principal-secretary': 'Principal Sec.',
  'regional-lead':       'Regional Lead',
  'county-director':     'County Director',
  'clerk-of-works':      'Clerk of Works',
  'consultant':          'Consultant',
}

const roleColors = {
  'principal-secretary': 'bg-slate-100 text-slate-700 border-slate-300',
  'regional-lead':       'bg-purple-100 text-purple-700 border-purple-300',
  'county-director':     'bg-blue-100 text-blue-700 border-blue-300',
  'clerk-of-works':      'bg-emerald-100 text-emerald-700 border-emerald-300',
  'consultant':          'bg-amber-100 text-amber-700 border-amber-300',
}

function fillCredentials(cred) {
  email.value         = cred.email
  password.value      = cred.password
  showTwoFactor.value = false
  errorMsg.value      = ''   // <-- Clears previous errors
  showCredentials.value = false // <-- Optionally hide credentials after filling
}

function handleLogin() {
  errorMsg.value = ''

  if (!showTwoFactor.value) {
    // Validate email + password using userStore
    const ok = userStore.login(email.value, password.value)
    if (!ok) {
      errorMsg.value = userStore.loginError
      return
    }

    // Users with 2FA go to 2FA screen; others go to dashboard
    if (userStore.currentUser.has2FA) {
      showTwoFactor.value = true
    } else {
      router.push('/dashboard')
    }
  } else {
    // 2FA step — accept any 6-digit code for now
    if (twoFactorCode.value.length === 6) {
      router.push('/dashboard')
    } else {
      errorMsg.value = 'Please enter a valid 6-digit code.'
    }
  }
}
</script>

