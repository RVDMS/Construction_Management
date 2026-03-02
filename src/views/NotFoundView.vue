<template>
  <div class="min-h-screen flex items-center justify-center bg-slate-50">
    <div class="text-center">
      <h1 class="text-6xl font-light text-slate-300 mb-4">404</h1>
      <p class="text-slate-600 mb-6">Page not found</p>
      <RouterLink to="/dashboard" class="px-4 py-2 bg-emerald-600 hover:bg-emerald-700 text-white rounded-lg transition-colors text-sm">
        Back to Dashboard
      </RouterLink>
    </div>
  </div>
</template>

<script setup>
import { RouterLink } from 'vue-router'
</script>
