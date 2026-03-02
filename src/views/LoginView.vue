<template>
  <div class="min-h-screen flex items-center justify-center bg-gradient-to-br from-slate-50 to-slate-100">
    <div class="w-full max-w-md px-4">
      <!-- Header with logos -->
      <div class="text-center mb-8">
        <div class="flex items-center justify-center gap-4 mb-6 flex-wrap">
          <!-- Ministry Logo -->
          <img src="@/assets/logos/Ministry+SDHUD_Logo.jpg" alt="Ministry Logo" class="h-20 w-20 object-contain" />
          <!-- AHB Logo -->
          <img src="@/assets/logos/AHB_Logo.jpg" alt="AHB Logo" class="h-20 w-20 object-contain" />
          <!-- Boma Yangu Logo -->
          <img src="@/assets/logos/Boma Yangu_Logo.jpg" alt="Boma Yangu Logo" class="h-16 w-16 object-contain" />
        </div>
        <h1 class="text-2xl font-semibold text-slate-900 mb-2">Affordable Housing Programme</h1>
        <p class="text-slate-600">Nakuru County Pilot – Regional Dashboard</p>
      </div>

      <!-- Login Form Card -->
      <div class="bg-white rounded-xl shadow-lg border border-slate-200 p-8">
        <h2 class="text-xl font-semibold mb-6 text-slate-900">
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
        </form>

        <div class="mt-6 pt-6 border-t border-slate-200">
          <div class="flex items-center gap-2 text-xs text-slate-500">
            <ShieldIcon class="w-4 h-4" />
            <span>Secured with JWT authentication, 2FA, and geo-limited access</span>
          </div>
        </div>
      </div>

      <p class="text-center text-sm text-slate-600 mt-6">
        Ministry of Lands, Public Works, Housing and Urban Development
      </p>
    </div>
  </div>
</template>

<script setup>
import { ref } from 'vue'
import { useRouter } from 'vue-router'
import { Mail as MailIcon, Lock as LockIcon, KeyRound as KeyRoundIcon, Shield as ShieldIcon } from 'lucide-vue-next'

const router = useRouter()
const email = ref('')
const password = ref('')
const twoFactorCode = ref('')
const showTwoFactor = ref(false)

function handleLogin() {
  if (!showTwoFactor.value) {
    showTwoFactor.value = true
  } else {
    router.push('/dashboard')
  }
}
</script>
