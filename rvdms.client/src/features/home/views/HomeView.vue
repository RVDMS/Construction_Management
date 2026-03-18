<template>
  <div class="min-h-screen bg-slate-50">
    <!-- Hero Section with Logos -->
    <section
      class="relative bg-gradient-to-br from-slate-900 via-slate-800 to-emerald-900 text-white overflow-hidden"
    >
      <!-- Background Pattern -->
      <div class="absolute inset-0 opacity-5">
        <div
          class="absolute inset-0"
          style="
            background-image: url(&quot;data:image/svg+xml,%3Csvg width='60' height='60' viewBox='0 0 60 60' xmlns='http://www.w3.org/2000/svg'%3E%3Cg fill='none' fill-rule='evenodd'%3E%3Cg fill='%23ffffff' fill-opacity='0.4'%3E%3Cpath d='M36 34v-4h-2v4h-4v2h4v4h2v-4h4v-2h-4zm0-30V0h-2v4h-4v2h4v4h2V6h4V4h-4zM6 34v-4H4v4H0v2h4v4h2v-4h4v-2H6zM6 4V0H4v4H0v2h4v4h2V6h4V4H6z'/%3E%3C/g%3E%3C/g%3E%3C/svg%3E&quot;);
          "
        ></div>
      </div>

      <div class="container mx-auto px-4 sm:px-6 lg:px-8 py-12 sm:py-16 lg:py-20 relative">
        <!-- Logos Display - Prominently Featured -->
        <div class="flex flex-col items-center justify-center mb-10 sm:mb-16">
          <!-- Main Logos Row -->
          <div class="flex flex-wrap items-center justify-center gap-8 sm:gap-12 lg:gap-16 mb-6">
            <!-- Ministry Logo - Largest -->
            <div class="text-center">
              <div
                class="bg-white/10 backdrop-blur-lg rounded-2xl p-4 sm:p-6 border border-white/20"
              >
                <img
                  :src="ministryLogo"
                  alt="Ministry of Housing"
                  class="h-16 sm:h-20 lg:h-24 w-auto object-contain"
                />
              </div>
              <p class="text-xs text-emerald-300 mt-2 font-medium">
                Ministry of Lands, Public Works,<br />Housing and Urban Development
              </p>
            </div>

            <!-- AHB Logo -->
            <div class="text-center">
              <div
                class="bg-white/10 backdrop-blur-lg rounded-2xl p-4 sm:p-6 border border-white/20"
              >
                <img :src="ahbLogo" alt="AHB" class="h-14 sm:h-16 lg:h-20 w-auto object-contain" />
              </div>
              <p class="text-xs text-emerald-300 mt-2 font-medium">Affordable Housing Board</p>
            </div>

            <!-- Boma Yangu Logo -->
            <div class="text-center">
              <div
                class="bg-white/10 backdrop-blur-lg rounded-2xl p-4 sm:p-6 border border-white/20"
              >
                <img
                  :src="bomaLogo"
                  alt="Boma Yangu"
                  class="h-12 sm:h-14 lg:h-16 w-auto object-contain"
                />
              </div>
              <p class="text-xs text-emerald-300 mt-2 font-medium">Boma Yangu Initiative</p>
            </div>
          </div>

          <!-- Tagline -->
          <div class="text-center max-w-3xl mx-auto">
            <h1 class="text-2xl sm:text-3xl lg:text-4xl font-bold mb-3">
              Rift Valley Region Housing Progress<br />Monitoring System
            </h1>
            <p class="text-sm sm:text-base text-emerald-100/80 mb-6">
              Internal Staff Portal • Project Tracking • Real-time Reporting
            </p>

            <!-- Login Button -->
            <button
              @click="navigateToLogin"
              class="inline-flex items-center gap-2 px-8 py-4 bg-emerald-600 hover:bg-emerald-500 text-white font-medium rounded-xl transition-all transform hover:scale-105 shadow-lg text-base sm:text-lg"
            >
              <LockIcon class="w-5 h-5" />
              Access Staff Portal
              <ArrowRightIcon class="w-5 h-5" />
            </button>

            <p class="text-xs text-emerald-200/60 mt-4">
              Authorized personnel only • Geo-validated access • Secure JWT authentication
            </p>
          </div>
        </div>
      </div>

      <!-- Curved Bottom -->
      <div class="absolute bottom-0 left-0 right-0">
        <svg
          class="w-full h-8 sm:h-12 text-slate-50"
          viewBox="0 0 1440 100"
          fill="none"
          xmlns="http://www.w3.org/2000/svg"
        >
          <path d="M0 100L1440 0V100H0Z" fill="currentColor" />
        </svg>
      </div>
    </section>

    <!-- Quick Stats Bar -->
    <section class="bg-white border-b border-slate-200">
      <div class="container mx-auto px-4 sm:px-6 lg:px-8">
        <div class="grid grid-cols-2 sm:grid-cols-4 gap-4 py-6">
          <div class="text-center">
            <div class="text-2xl sm:text-3xl font-bold text-emerald-600">24</div>
            <div class="text-xs sm:text-sm text-slate-600">Active Projects</div>
          </div>
          <div class="text-center">
            <div class="text-2xl sm:text-3xl font-bold text-emerald-600">847</div>
            <div class="text-xs sm:text-sm text-slate-600">Units Under Construction</div>
          </div>
          <div class="text-center">
            <div class="text-2xl sm:text-3xl font-bold text-emerald-600">156</div>
            <div class="text-xs sm:text-sm text-slate-600">Field Staff</div>
          </div>
          <div class="text-center">
            <div class="text-2xl sm:text-3xl font-bold text-emerald-600">5</div>
            <div class="text-xs sm:text-sm text-slate-600">Counties</div>
          </div>
        </div>
      </div>
    </section>

    <!-- Staff Hierarchy Section -->
    <section class="py-16 sm:py-20">
      <div class="container mx-auto px-4 sm:px-6 lg:px-8">
        <div class="text-center mb-12">
          <h2 class="text-2xl sm:text-3xl font-bold text-slate-900 mb-3">Staff Access Hierarchy</h2>
          <p class="text-sm sm:text-base text-slate-600 max-w-2xl mx-auto">
            Role-based permissions for secure project tracking and reporting across the Rift Valley
            region
          </p>
        </div>

        <!-- Regional Lead - Top Level -->
        <div class="max-w-md mx-auto mb-8">
          <div
            class="bg-gradient-to-r from-purple-600 to-purple-700 text-white rounded-2xl p-6 text-center shadow-xl"
          >
            <div class="flex justify-center mb-3">
              <div class="p-3 bg-white/20 rounded-full">
                <UsersIcon class="w-8 h-8" />
              </div>
            </div>
            <h3 class="text-xl font-bold mb-1">Regional Lead</h3>
            <p class="text-sm text-purple-100 mb-3">Oversight of all Rift Valley Projects</p>
            <div class="flex flex-wrap gap-2 justify-center">
              <span class="px-3 py-1 bg-white/20 rounded-full text-xs">View All Projects</span>
              <span class="px-3 py-1 bg-white/20 rounded-full text-xs">Staff Management</span>
              <span class="px-3 py-1 bg-white/20 rounded-full text-xs">Resource Allocation</span>
              <span class="px-3 py-1 bg-white/20 rounded-full text-xs">Regional Reports</span>
            </div>
          </div>
        </div>

        <!-- Middle Management Row -->
        <div class="grid md:grid-cols-2 gap-6 mb-8">
          <!-- County Director of Housing -->
          <div
            class="bg-white rounded-xl border border-slate-200 p-6 shadow-sm hover:shadow-md transition-shadow"
          >
            <div class="flex items-start gap-4">
              <div class="p-3 bg-blue-100 rounded-lg">
                <Building2Icon class="w-6 h-6 text-blue-600" />
              </div>
              <div class="flex-1">
                <div class="flex items-center justify-between mb-2">
                  <h3 class="text-lg font-semibold text-slate-900">County Director of Housing</h3>
                  <span class="text-xs px-2 py-1 bg-blue-100 text-blue-700 rounded-full"
                    >County Level</span
                  >
                </div>
                <p class="text-sm text-slate-600 mb-3">Manage projects within specific county</p>
                <div class="flex flex-wrap gap-2">
                  <span class="text-xs px-2 py-1 bg-slate-100 text-slate-600 rounded"
                    >County Projects</span
                  >
                  <span class="text-xs px-2 py-1 bg-slate-100 text-slate-600 rounded"
                    >Budget Tracking</span
                  >
                  <span class="text-xs px-2 py-1 bg-slate-100 text-slate-600 rounded"
                    >Local Staff</span
                  >
                  <span class="text-xs px-2 py-1 bg-slate-100 text-slate-600 rounded"
                    >County Reports</span
                  >
                </div>
              </div>
            </div>
          </div>

          <!-- Technical Lead -->
          <div
            class="bg-white rounded-xl border border-slate-200 p-6 shadow-sm hover:shadow-md transition-shadow"
          >
            <div class="flex items-start gap-4">
              <div class="p-3 bg-amber-100 rounded-lg">
                <HardHatIcon class="w-6 h-6 text-amber-600" />
              </div>
              <div class="flex-1">
                <div class="flex items-center justify-between mb-2">
                  <h3 class="text-lg font-semibold text-slate-900">Technical Lead</h3>
                  <span class="text-xs px-2 py-1 bg-amber-100 text-amber-700 rounded-full"
                    >Technical</span
                  >
                </div>
                <p class="text-sm text-slate-600 mb-3">Technical oversight and quality control</p>
                <div class="flex flex-wrap gap-2">
                  <span class="text-xs px-2 py-1 bg-slate-100 text-slate-600 rounded"
                    >Quality Assurance</span
                  >
                  <span class="text-xs px-2 py-1 bg-slate-100 text-slate-600 rounded"
                    >Technical Reports</span
                  >
                  <span class="text-xs px-2 py-1 bg-slate-100 text-slate-600 rounded"
                    >Inspections</span
                  >
                  <span class="text-xs px-2 py-1 bg-slate-100 text-slate-600 rounded"
                    >Standards</span
                  >
                </div>
              </div>
            </div>
          </div>
        </div>

        <!-- Cluster Supervisor & Clerk of Works -->
        <div class="grid md:grid-cols-2 gap-6">
          <!-- Cluster Supervisor -->
          <div
            class="bg-white rounded-xl border border-slate-200 p-6 shadow-sm hover:shadow-md transition-shadow"
          >
            <div class="flex items-start gap-4">
              <div class="p-3 bg-emerald-100 rounded-lg">
                <MapPinIcon class="w-6 h-6 text-emerald-600" />
              </div>
              <div class="flex-1">
                <div class="flex items-center justify-between mb-2">
                  <h3 class="text-lg font-semibold text-slate-900">Cluster Supervisor</h3>
                  <span class="text-xs px-2 py-1 bg-emerald-100 text-emerald-700 rounded-full"
                    >Supervisory</span
                  >
                </div>
                <p class="text-sm text-slate-600 mb-3">
                  Oversee multiple projects within a cluster
                </p>
                <div class="flex flex-wrap gap-2">
                  <span class="text-xs px-2 py-1 bg-slate-100 text-slate-600 rounded"
                    >Cluster Projects</span
                  >
                  <span class="text-xs px-2 py-1 bg-slate-100 text-slate-600 rounded"
                    >Team Supervision</span
                  >
                  <span class="text-xs px-2 py-1 bg-slate-100 text-slate-600 rounded"
                    >Progress Reports</span
                  >
                  <span class="text-xs px-2 py-1 bg-slate-100 text-slate-600 rounded"
                    >Site Visits</span
                  >
                </div>
              </div>
            </div>
          </div>

          <!-- Clerk of Works -->
          <div
            class="bg-white rounded-xl border border-slate-200 p-6 shadow-sm hover:shadow-md transition-shadow"
          >
            <div class="flex items-start gap-4">
              <div class="p-3 bg-slate-100 rounded-lg">
                <ClipboardCheckIcon class="w-6 h-6 text-slate-600" />
              </div>
              <div class="flex-1">
                <div class="flex items-center justify-between mb-2">
                  <h3 class="text-lg font-semibold text-slate-900">Clerk of Works</h3>
                  <span class="text-xs px-2 py-1 bg-slate-100 text-slate-700 rounded-full"
                    >Field</span
                  >
                </div>
                <p class="text-sm text-slate-600 mb-3">On-site daily progress reporting</p>
                <div class="flex flex-wrap gap-2">
                  <span class="text-xs px-2 py-1 bg-slate-100 text-slate-600 rounded"
                    >Daily Reports</span
                  >
                  <span class="text-xs px-2 py-1 bg-slate-100 text-slate-600 rounded"
                    >Photo Uploads</span
                  >
                  <span class="text-xs px-2 py-1 bg-slate-100 text-slate-600 rounded"
                    >Material Tracking</span
                  >
                  <span class="text-xs px-2 py-1 bg-slate-100 text-slate-600 rounded"
                    >Site Diary</span
                  >
                </div>
              </div>
            </div>
          </div>
        </div>

        <!-- Hierarchy Connection Lines (Decorative) -->
        <div class="hidden lg:block relative h-20 mt-8">
          <div
            class="absolute top-0 left-1/2 w-0.5 h-full bg-gradient-to-b from-purple-600 to-transparent"
          ></div>
          <div
            class="absolute top-0 left-1/3 w-0.5 h-1/2 bg-gradient-to-b from-blue-600 to-transparent"
          ></div>
          <div
            class="absolute top-0 left-2/3 w-0.5 h-1/2 bg-gradient-to-b from-amber-600 to-transparent"
          ></div>
        </div>
      </div>
    </section>

    <!-- System Modules Preview -->
    <section class="bg-slate-100 py-16 sm:py-20">
      <div class="container mx-auto px-4 sm:px-6 lg:px-8">
        <div class="text-center mb-12">
          <h2 class="text-2xl sm:text-3xl font-bold text-slate-900 mb-3">System Modules</h2>
          <p class="text-sm sm:text-base text-slate-600">
            Access features based on your role permissions
          </p>
        </div>

        <div class="grid sm:grid-cols-2 lg:grid-cols-4 gap-6">
          <div class="bg-white p-6 rounded-xl shadow-sm">
            <div class="w-12 h-12 bg-emerald-100 rounded-lg flex items-center justify-center mb-4">
              <MapPinIcon class="w-6 h-6 text-emerald-600" />
            </div>
            <h3 class="font-semibold text-slate-900 mb-2">Project Tracking</h3>
            <p class="text-sm text-slate-600 mb-3">
              Real-time progress monitoring of all housing projects
            </p>
            <span class="text-xs text-emerald-600 font-medium">All roles</span>
          </div>

          <div class="bg-white p-6 rounded-xl shadow-sm">
            <div class="w-12 h-12 bg-emerald-100 rounded-lg flex items-center justify-center mb-4">
              <ClipboardCheckIcon class="w-6 h-6 text-emerald-600" />
            </div>
            <h3 class="font-semibold text-slate-900 mb-2">Report Submission</h3>
            <p class="text-sm text-slate-600 mb-3">Daily/weekly reports with photo documentation</p>
            <span class="text-xs text-emerald-600 font-medium"
              >Clerk of Works, Cluster Supervisor</span
            >
          </div>

          <div class="bg-white p-6 rounded-xl shadow-sm">
            <div class="w-12 h-12 bg-emerald-100 rounded-lg flex items-center justify-center mb-4">
              <BarChart3Icon class="w-6 h-6 text-emerald-600" />
            </div>
            <h3 class="font-semibold text-slate-900 mb-2">Analytics Dashboard</h3>
            <p class="text-sm text-slate-600 mb-3">
              Regional performance metrics and budget tracking
            </p>
            <span class="text-xs text-emerald-600 font-medium">Regional Lead, County Director</span>
          </div>

          <div class="bg-white p-6 rounded-xl shadow-sm">
            <div class="w-12 h-12 bg-emerald-100 rounded-lg flex items-center justify-center mb-4">
              <UsersIcon class="w-6 h-6 text-emerald-600" />
            </div>
            <h3 class="font-semibold text-slate-900 mb-2">Team Management</h3>
            <p class="text-sm text-slate-600 mb-3">Staff assignments and task delegation</p>
            <span class="text-xs text-emerald-600 font-medium"
              >Regional Lead, Cluster Supervisor</span
            >
          </div>
        </div>
      </div>
    </section>

    <!-- Login CTA -->
    <section class="py-16 sm:py-20">
      <div class="container mx-auto px-4 sm:px-6 lg:px-8">
        <div
          class="bg-gradient-to-r from-emerald-600 to-emerald-700 rounded-3xl p-8 sm:p-12 text-center text-white shadow-xl"
        >
          <h2 class="text-2xl sm:text-3xl font-bold mb-3">
            Access the Rift Valley Housing Tracker
          </h2>
          <p class="text-emerald-100 mb-6 max-w-2xl mx-auto">
            Secure login required. Your access level determines available projects and reporting
            capabilities.
          </p>
          <button
            @click="navigateToLogin"
            class="inline-flex items-center gap-2 px-8 py-4 bg-white text-emerald-700 font-medium rounded-xl hover:bg-slate-100 transition-all transform hover:scale-105 shadow-lg"
          >
            <LogInIcon class="w-5 h-5" />
            Login to Staff Portal
          </button>
          <p class="text-xs text-emerald-200 mt-4">
            Geo-validation required • JWT secured • Role-based permissions
          </p>
        </div>
      </div>
    </section>

    <!-- Footer -->
    <footer class="bg-slate-900 text-white py-8">
      <div class="container mx-auto px-4 sm:px-6 lg:px-8">
        <div class="flex flex-col md:flex-row items-center justify-between gap-4">
          <div class="flex items-center gap-3">
            <img :src="bomaLogo" alt="Boma Yangu" class="h-8 w-8 object-contain" />
            <span class="text-sm font-medium">Rift Valley Housing Tracker v2.0</span>
          </div>
          <div class="text-xs text-slate-400 text-center">
            © {{ new Date().getFullYear() }} Ministry of Lands, Public Works, Housing and Urban
            Development<br />
            All rights reserved. Authorized access only.
          </div>
          <div class="flex gap-4 text-xs text-slate-500">
            <span>Secure System</span>
            <span>•</span>
            <span>Staff Portal</span>
            <span>•</span>
            <span>v2.0</span>
          </div>
        </div>
      </div>
    </footer>
  </div>
</template>

<script setup>
import { useRouter } from "vue-router";
import {
  LockIcon,
  ArrowRightIcon,
  LogInIcon,
  MapPinIcon,
  UsersIcon,
  Building2Icon,
  HardHatIcon,
  ClipboardCheckIcon,
  BarChart3Icon,
} from "lucide-vue-next";

// Import logos
import ministryLogo from "@/assets/logos/ministry.jpg";
import ahbLogo from "@/assets/logos/ahb.jpg";
import bomaLogo from "@/assets/logos/boma-yangu.jpg";

const router = useRouter();

const navigateToLogin = () => {
  router.push("/login");
};
</script>
