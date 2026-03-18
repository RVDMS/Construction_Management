<!-- src/views/dashboard/ClerkDashboard.vue -->
<template>
  <div class="min-h-screen bg-slate-50">
    <!-- Loading State -->
    <div v-if="loading" class="flex items-center justify-center min-h-screen">
      <div class="text-center">
        <Loader2Icon class="w-8 h-8 animate-spin text-emerald-600 mx-auto mb-4" />
        <p class="text-slate-600">Loading your project dashboard...</p>
      </div>
    </div>

    <!-- No Project Assigned -->
    <div v-else-if="!myProject" class="flex items-center justify-center min-h-screen">
      <div class="text-center max-w-md mx-auto p-6">
        <div
          class="w-20 h-20 bg-amber-100 rounded-full flex items-center justify-center mx-auto mb-4"
        >
          <AlertCircleIcon class="w-10 h-10 text-amber-600" />
        </div>
        <h2 class="text-xl font-semibold text-slate-900 mb-2">No Project Assigned</h2>
        <p class="text-slate-600 mb-6">
          You don't have any project assigned to you yet. Please contact your administrator or
          cluster supervisor.
        </p>
        <button
          @click="refreshProject"
          class="inline-flex items-center gap-2 px-4 py-2 bg-emerald-600 text-white rounded-lg hover:bg-emerald-700 transition-colors"
        >
          <RefreshCwIcon class="w-4 h-4" />
          Refresh
        </button>
      </div>
    </div>

    <!-- Project Dashboard -->
    <div v-else class="p-4 md:p-6 max-w-7xl mx-auto space-y-6">
      <!-- Header with Welcome and Quick Actions -->
      <div class="flex flex-col md:flex-row md:items-center md:justify-between gap-4">
        <div>
          <div class="flex items-center gap-3 mb-1">
            <h1 class="text-2xl md:text-3xl font-semibold text-slate-900">
              {{ myProject.name }}
            </h1>
            <span
              :class="[
                'px-3 py-1 rounded-full text-xs font-medium',
                getStatusBadgeClass(myProject.progressStatus),
              ]"
            >
              {{ myProject.progressStatus }}
            </span>
          </div>
          <p class="text-slate-600">Tender: {{ myProject.tenderNumber }}</p>
        </div>

        <!-- User Menu with Dropdown -->
        <div class="flex items-center gap-2">
          <!-- Refresh Button -->
          <button
            @click="refreshProject"
            class="p-2 text-slate-600 hover:text-emerald-600 hover:bg-emerald-50 rounded-lg transition-colors"
            title="Refresh Dashboard"
          >
            <RefreshCwIcon class="w-5 h-5" />
          </button>

          <!-- Profile Dropdown -->
          <div class="relative" ref="dropdownRef">
            <button
              @click="showProfileDropdown = !showProfileDropdown"
              class="flex items-center gap-2 px-3 py-2 bg-white border border-slate-200 rounded-lg hover:bg-slate-50 transition-colors"
            >
              <div class="w-8 h-8 bg-emerald-100 rounded-full flex items-center justify-center">
                <span class="text-sm font-medium text-emerald-700">
                  {{ userInitials }}
                </span>
              </div>
              <div class="hidden md:block text-left">
                <p class="text-sm font-medium text-slate-900">
                  {{ user?.fullName || "Clerk of Works" }}
                </p>
                <p class="text-xs text-slate-500">{{ userRoleLabel }}</p>
              </div>
              <ChevronDownIcon class="w-4 h-4 text-slate-400" />
            </button>

            <!-- Dropdown Menu -->
            <div
              v-if="showProfileDropdown"
              class="absolute right-0 mt-2 w-48 bg-white rounded-lg shadow-lg border border-slate-200 py-1 z-50"
            >
              <RouterLink
                to="/profile"
                class="flex items-center gap-2 px-4 py-2 text-sm text-slate-700 hover:bg-slate-50 w-full text-left"
                @click="showProfileDropdown = false"
              >
                <UserIcon class="w-4 h-4" />
                My Profile
              </RouterLink>

              <button
                @click="logout"
                class="flex items-center gap-2 px-4 py-2 text-sm text-red-600 hover:bg-red-50 w-full text-left"
              >
                <LogOutIcon class="w-4 h-4" />
                Logout
              </button>
            </div>
          </div>
        </div>
      </div>

      <!-- Key Metrics Cards -->
      <div class="grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-4 gap-4">
        <!-- Progress Card -->
        <div class="bg-white rounded-xl border border-slate-200 p-5 shadow-sm">
          <div class="flex items-center justify-between mb-3">
            <div class="p-2 bg-emerald-100 rounded-lg">
              <TrendingUpIcon class="w-5 h-5 text-emerald-700" />
            </div>
            <span class="text-xs font-medium px-2 py-1 bg-slate-100 rounded-full">Current</span>
          </div>
          <p class="text-2xl font-bold text-slate-900">{{ myProject.currentPhysicalProgress }}%</p>
          <p class="text-sm text-slate-500 mt-1">Physical Progress</p>
          <div class="mt-3 bg-slate-200 rounded-full h-2">
            <div
              class="h-2 rounded-full transition-all"
              :class="progressBarClass"
              :style="{ width: `${myProject.currentPhysicalProgress}%` }"
            ></div>
          </div>
          <p class="text-xs text-slate-400 mt-2">
            Last update: {{ formatDate(myProject.lastProgressUpdate) }}
          </p>
        </div>

        <!-- Time Card -->
        <div class="bg-white rounded-xl border border-slate-200 p-5 shadow-sm">
          <div class="flex items-center justify-between mb-3">
            <div class="p-2 bg-blue-100 rounded-lg">
              <CalendarIcon class="w-5 h-5 text-blue-700" />
            </div>
            <span class="text-xs font-medium px-2 py-1 bg-slate-100 rounded-full"
              >{{ myProject.daysRemaining }} days left</span
            >
          </div>
          <p class="text-2xl font-bold text-slate-900">{{ myProject.timeElapsedPercentage }}%</p>
          <p class="text-sm text-slate-500 mt-1">Time Elapsed</p>
          <div class="mt-3 bg-slate-200 rounded-full h-2">
            <div
              class="bg-blue-600 h-2 rounded-full"
              :style="{ width: `${myProject.timeElapsedPercentage}%` }"
            ></div>
          </div>
          <p class="text-xs text-slate-400 mt-2">Target: {{ formatDate(myProject.endDate) }}</p>
        </div>

        <!-- Budget Card -->
        <div class="bg-white rounded-xl border border-slate-200 p-5 shadow-sm">
          <div class="flex items-center justify-between mb-3">
            <div class="p-2 bg-purple-100 rounded-lg">
              <DollarSignIcon class="w-5 h-5 text-purple-700" />
            </div>
            <span class="text-xs font-medium px-2 py-1 bg-slate-100 rounded-full">Contract</span>
          </div>
          <p class="text-2xl font-bold text-slate-900">
            KES {{ formatCurrency(myProject.contractSum) }}
          </p>
          <p class="text-sm text-slate-500 mt-1">Contract Sum</p>
          <div class="flex justify-between text-xs mt-3">
            <span class="text-slate-600"
              >Remaining: KES {{ formatCurrency(myProject.remainingBudget) }}</span
            >
            <span class="text-emerald-600"
              >{{
                (
                  ((myProject.contractSum - myProject.remainingBudget) / myProject.contractSum) *
                  100
                ).toFixed(1)
              }}% spent</span
            >
          </div>
        </div>

        <!-- Reports Card -->
        <div class="bg-white rounded-xl border border-slate-200 p-5 shadow-sm">
          <div class="flex items-center justify-between mb-3">
            <div class="p-2 bg-amber-100 rounded-lg">
              <FileTextIcon class="w-5 h-5 text-amber-700" />
            </div>
            <span class="text-xs font-medium px-2 py-1 bg-slate-100 rounded-full">Total</span>
          </div>
          <p class="text-2xl font-bold text-slate-900">{{ reports.length }}</p>
          <p class="text-sm text-slate-500 mt-1">Weekly Reports</p>
          <p class="text-xs text-slate-400 mt-3">
            Last report:
            {{ reports.length > 0 ? formatDate(reports[0].createdAt) : "No reports yet" }}
          </p>
        </div>
      </div>

      <!-- Status Alert if Project is At Risk -->
      <div v-if="myProject.isAtRisk" class="bg-red-50 border border-red-200 rounded-xl p-4">
        <div class="flex items-start gap-3">
          <div class="p-1 bg-red-100 rounded-full">
            <AlertCircleIcon class="w-5 h-5 text-red-600" />
          </div>
          <div class="flex-1">
            <h4 class="text-sm font-medium text-red-800">
              Project Alert: {{ myProject.progressStatus }}
            </h4>
            <p class="text-sm text-red-700 mt-1">
              This project is {{ myProject.progressStatus.toLowerCase() }} by
              {{ Math.abs(myProject.variance) }}%. {{ myProject.daysRemaining }} days remaining to
              complete {{ (100 - myProject.currentPhysicalProgress).toFixed(1) }}% of work.
            </p>
          </div>
        </div>
      </div>

      <!-- Main Content Tabs -->
      <div class="bg-white rounded-xl border border-slate-200 shadow-sm overflow-hidden">
        <!-- Tab Navigation -->
        <div class="border-b border-slate-200 px-4">
          <nav class="flex gap-2 overflow-x-auto py-2">
            <button
              v-for="tab in tabs"
              :key="tab.id"
              @click="activeTab = tab.id"
              :class="[
                'flex items-center gap-2 px-4 py-2 rounded-lg text-sm font-medium transition-colors whitespace-nowrap',
                activeTab === tab.id
                  ? 'bg-emerald-50 text-emerald-700'
                  : 'text-slate-600 hover:bg-slate-50',
              ]"
            >
              <component :is="tab.icon" class="w-4 h-4" />
              {{ tab.label }}
              <span
                v-if="tab.badge"
                class="ml-1 px-1.5 py-0.5 text-xs bg-emerald-100 text-emerald-700 rounded-full"
              >
                {{ tab.badge }}
              </span>
            </button>
          </nav>
        </div>

        <!-- Tab Content -->
        <div class="p-6">
          <!-- OVERVIEW TAB -->
          <div v-if="activeTab === 'overview'" class="space-y-6">
            <!-- Progress Chart -->
            <div>
              <h3 class="text-sm font-medium text-slate-900 mb-4">Progress Overview</h3>
              <div class="grid grid-cols-1 lg:grid-cols-3 gap-6">
                <!-- Gauge Chart for Progress -->
                <div class="lg:col-span-1 bg-slate-50 rounded-lg p-4 flex flex-col items-center">
                  <div class="relative w-40 h-40">
                    <svg class="w-full h-full" viewBox="0 0 100 100">
                      <!-- Background circle -->
                      <circle
                        cx="50"
                        cy="50"
                        r="45"
                        fill="none"
                        stroke="#e2e8f0"
                        stroke-width="10"
                      />
                      <!-- Progress circle -->
                      <circle
                        cx="50"
                        cy="50"
                        r="45"
                        fill="none"
                        :stroke="progressCircleColor"
                        stroke-width="10"
                        stroke-linecap="round"
                        :stroke-dasharray="283"
                        :stroke-dashoffset="283 - (283 * myProject.currentPhysicalProgress) / 100"
                        transform="rotate(-90 50 50)"
                      />
                      <!-- Center text -->
                      <text
                        x="50"
                        y="50"
                        text-anchor="middle"
                        dominant-baseline="middle"
                        class="text-2xl font-bold"
                        fill="#1e293b"
                      >
                        {{ myProject.currentPhysicalProgress }}%
                      </text>
                    </svg>
                  </div>
                  <p class="text-sm text-slate-600 mt-2">Physical Progress</p>
                  <p class="text-xs text-slate-500">Target: 100%</p>
                </div>

                <!-- Progress vs Time Chart -->
                <div class="lg:col-span-2 bg-slate-50 rounded-lg p-4">
                  <h4 class="text-sm font-medium text-slate-900 mb-3">Progress vs Time</h4>
                  <div class="h-48 relative">
                    <!-- Simple bar chart representation -->
                    <div
                      class="absolute bottom-0 left-0 right-0 flex items-end justify-around h-40"
                    >
                      <!-- Planned Progress Bar -->
                      <div class="flex flex-col items-center w-20">
                        <div class="text-xs text-slate-600 mb-1">Planned</div>
                        <div
                          class="w-12 bg-blue-200 rounded-t-lg relative"
                          :style="{ height: plannedProgressHeight + 'px' }"
                        >
                          <div
                            class="absolute -top-6 left-1/2 transform -translate-x-1/2 text-xs font-medium"
                          >
                            {{ plannedProgress }}%
                          </div>
                        </div>
                      </div>

                      <!-- Actual Progress Bar -->
                      <div class="flex flex-col items-center w-20">
                        <div class="text-xs text-slate-600 mb-1">Actual</div>
                        <div
                          class="w-12 bg-emerald-600 rounded-t-lg relative"
                          :style="{ height: actualProgressHeight + 'px' }"
                        >
                          <div
                            class="absolute -top-6 left-1/2 transform -translate-x-1/2 text-xs font-medium"
                          >
                            {{ myProject.currentPhysicalProgress }}%
                          </div>
                        </div>
                      </div>

                      <!-- Variance Indicator -->
                      <div class="flex flex-col items-center w-20">
                        <div class="text-xs text-slate-600 mb-1">Variance</div>
                        <div
                          class="w-12 rounded-t-lg relative"
                          :class="varianceClass"
                          :style="{ height: varianceHeight + 'px' }"
                        >
                          <div
                            class="absolute -top-6 left-1/2 transform -translate-x-1/2 text-xs font-medium whitespace-nowrap"
                          >
                            {{ myProject.variance }}%
                          </div>
                        </div>
                      </div>
                    </div>

                    <!-- Y-axis labels -->
                    <div
                      class="absolute left-0 top-0 bottom-0 flex flex-col justify-between text-xs text-slate-400"
                    >
                      <span>100%</span>
                      <span>75%</span>
                      <span>50%</span>
                      <span>25%</span>
                      <span>0%</span>
                    </div>
                  </div>
                  <p class="text-xs text-slate-500 mt-4 text-center">
                    Based on time elapsed: {{ myProject.timeElapsedPercentage }}% of timeline
                    completed
                  </p>
                </div>
              </div>
            </div>

            <!-- Project Details Grid -->
            <div class="grid grid-cols-1 md:grid-cols-2 gap-6">
              <!-- Location Details -->
              <div class="bg-slate-50 rounded-lg p-4">
                <h4 class="text-sm font-medium text-slate-900 mb-3 flex items-center gap-2">
                  <MapPinIcon class="w-4 h-4 text-emerald-600" />
                  Site Location
                </h4>
                <div class="space-y-2 text-sm">
                  <p><span class="text-slate-500">Ward:</span> {{ myProject.ward }}</p>
                  <p>
                    <span class="text-slate-500">Constituency:</span>
                    {{ myProject.constituency || "N/A" }}
                  </p>
                  <p><span class="text-slate-500">County:</span> {{ myProject.county || "N/A" }}</p>
                  <p>
                    <span class="text-slate-500">Cluster:</span> {{ myProject.cluster || "N/A" }}
                  </p>
                  <div class="pt-2 border-t border-slate-200">
                    <p class="text-xs text-slate-500">
                      GPS: {{ myProject.latitude.toFixed(6) }}, {{ myProject.longitude.toFixed(6) }}
                    </p>
                    <p class="text-xs text-slate-500">
                      Site Radius: {{ myProject.radiusInMeters }}m
                    </p>
                  </div>
                </div>
              </div>

              <!-- Project Team -->
              <div class="bg-slate-50 rounded-lg p-4">
                <h4 class="text-sm font-medium text-slate-900 mb-3 flex items-center gap-2">
                  <UsersIcon class="w-4 h-4 text-emerald-600" />
                  Project Team
                </h4>
                <div class="space-y-3">
                  <div>
                    <p class="text-xs text-slate-500">Contractor</p>
                    <p class="text-sm font-medium">
                      {{ myProject.contractorName || "Not assigned" }}
                    </p>
                  </div>
                  <div>
                    <p class="text-xs text-slate-500">Consultant</p>
                    <p class="text-sm font-medium">
                      {{ myProject.consultantName || "Not assigned" }}
                    </p>
                  </div>
                  <div>
                    <p class="text-xs text-slate-500">Technical Lead</p>
                    <p class="text-sm font-medium">
                      {{ myProject.technicalLead || "Not assigned" }}
                    </p>
                  </div>
                  <div v-if="myProject.clusterSupervisors?.length">
                    <p class="text-xs text-slate-500">Cluster Supervisor(s)</p>
                    <p
                      v-for="(cs, index) in myProject.clusterSupervisors"
                      :key="index"
                      class="text-sm font-medium"
                    >
                      {{ cs }}
                    </p>
                  </div>
                </div>
              </div>
            </div>

            <!-- Budget Breakdown -->
            <div class="bg-slate-50 rounded-lg p-4">
              <h4 class="text-sm font-medium text-slate-900 mb-3">Budget Breakdown</h4>
              <div class="grid grid-cols-1 sm:grid-cols-3 gap-4">
                <div>
                  <p class="text-xs text-slate-500 mb-1">Contract Sum</p>
                  <p class="text-lg font-semibold text-slate-900">
                    KES {{ formatCurrency(myProject.contractSum) }}
                  </p>
                </div>
                <div>
                  <p class="text-xs text-slate-500 mb-1">Estimated Spent</p>
                  <p class="text-lg font-semibold text-emerald-700">
                    KES {{ formatCurrency(myProject.contractSum - myProject.remainingBudget) }}
                  </p>
                </div>
                <div>
                  <p class="text-xs text-slate-500 mb-1">Remaining Budget</p>
                  <p class="text-lg font-semibold text-blue-700">
                    KES {{ formatCurrency(myProject.remainingBudget) }}
                  </p>
                </div>
              </div>
            </div>
          </div>

          <!-- REPORTS TAB -->
          <div v-if="activeTab === 'reports'" class="space-y-6">
            <!-- Upload Section with Geolocation -->
            <div class="bg-slate-50 rounded-lg p-5 border border-slate-200">
              <h3 class="text-sm font-medium text-slate-900 mb-4 flex items-center gap-2">
                <UploadIcon class="w-4 h-4 text-emerald-600" />
                Upload Weekly Report
              </h3>

              <!-- Geolocation Status -->
              <div
                class="mb-4 p-3 rounded-lg flex items-start gap-2"
                :class="
                  isWithinGeofence
                    ? 'bg-emerald-50 border border-emerald-200'
                    : 'bg-amber-50 border border-amber-200'
                "
              >
                <MapPinIcon
                  :class="isWithinGeofence ? 'text-emerald-600' : 'text-amber-600'"
                  class="w-5 h-5 flex-shrink-0"
                />
                <div class="flex-1">
                  <p
                    class="text-sm font-medium"
                    :class="isWithinGeofence ? 'text-emerald-800' : 'text-amber-800'"
                  >
                    {{ locationStatus }}
                  </p>
                  <p v-if="!isWithinGeofence && locationError" class="text-xs text-amber-700 mt-1">
                    {{ locationError }}
                  </p>
                  <button
                    v-if="!isWithinGeofence"
                    @click="checkGeolocation"
                    class="mt-2 text-xs bg-white px-3 py-1 rounded-full border border-amber-300 hover:bg-amber-50"
                  >
                    Retry Location Check
                  </button>
                </div>
              </div>

              <!-- Report Form -->
              <form @submit.prevent="submitReport" class="space-y-4">
                <div class="grid grid-cols-1 md:grid-cols-2 gap-4">
                  <div>
                    <label class="block text-sm text-slate-700 mb-1">Report Title</label>
                    <input
                      v-model="reportForm.title"
                      type="text"
                      class="w-full px-3 py-2 border border-slate-300 rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500"
                      placeholder="e.g., Week 12 Progress Report"
                      required
                    />
                  </div>
                  <div>
                    <label class="block text-sm text-slate-700 mb-1">Progress Percentage</label>
                    <input
                      v-model.number="reportForm.progress"
                      type="number"
                      min="0"
                      max="100"
                      step="0.1"
                      class="w-full px-3 py-2 border border-slate-300 rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500"
                      :class="{
                        'border-amber-500':
                          reportForm.progress <= myProject.currentPhysicalProgress &&
                          reportForm.progress > 0,
                      }"
                      required
                    />
                    <p
                      v-if="
                        reportForm.progress <= myProject.currentPhysicalProgress &&
                        reportForm.progress > 0
                      "
                      class="text-xs text-amber-600 mt-1"
                    >
                      Progress must be greater than current ({{
                        myProject.currentPhysicalProgress
                      }}%)
                    </p>
                    <p v-else class="text-xs text-slate-500 mt-1">
                      Current progress: {{ myProject.currentPhysicalProgress }}%
                    </p>
                  </div>
                </div>

                <div>
                  <label class="block text-sm text-slate-700 mb-1">Description</label>
                  <textarea
                    v-model="reportForm.description"
                    rows="3"
                    class="w-full px-3 py-2 border border-slate-300 rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500"
                    placeholder="Describe this week's progress, challenges, and achievements..."
                    required
                  ></textarea>
                </div>

                <div>
                  <label class="block text-sm text-slate-700 mb-1">
                    Report File (PDF or Excel)
                    <span class="text-xs text-slate-500 ml-1">(Max 10MB)</span>
                  </label>
                  <input
                    ref="fileInput"
                    type="file"
                    accept=".pdf,.xls,.xlsx,.xlsm"
                    @change="handleFileChange"
                    class="w-full text-sm text-slate-600 file:mr-4 file:py-2 file:px-4 file:rounded-lg file:border-0 file:bg-emerald-50 file:text-emerald-700 hover:file:bg-emerald-100"
                    :disabled="!isWithinGeofence"
                    required
                  />
                  <p v-if="fileError" class="text-xs text-red-600 mt-1">{{ fileError }}</p>
                </div>

                <button
                  type="submit"
                  :disabled="
                    !isWithinGeofence ||
                    submitting ||
                    !selectedFile ||
                    reportForm.progress <= myProject.currentPhysicalProgress
                  "
                  class="w-full bg-emerald-600 hover:bg-emerald-700 text-white py-3 rounded-lg transition-colors disabled:opacity-50 disabled:cursor-not-allowed flex items-center justify-center gap-2"
                >
                  <Loader2Icon v-if="submitting" class="w-4 h-4 animate-spin" />
                  {{ submitting ? "Submitting..." : "Submit Weekly Report" }}
                </button>
              </form>
            </div>

            <!-- Reports List -->
            <div>
              <div class="flex items-center justify-between mb-4">
                <h3 class="text-sm font-medium text-slate-900">All Weekly Reports</h3>
                <span class="text-xs bg-slate-100 px-2 py-1 rounded-full">
                  {{ reports.length }} total
                </span>
              </div>

              <div v-if="reportsLoading" class="text-center py-8">
                <Loader2Icon class="w-8 h-8 animate-spin text-emerald-600 mx-auto" />
              </div>

              <div
                v-else-if="reports.length === 0"
                class="text-center py-12 bg-slate-50 rounded-lg"
              >
                <FileTextIcon class="w-12 h-12 mx-auto mb-3 text-slate-300" />
                <p class="text-slate-600">No weekly reports yet</p>
                <p class="text-xs text-slate-400 mt-2">
                  Upload your first report using the form above
                </p>
              </div>

              <div v-else class="space-y-3">
                <div
                  v-for="report in reports"
                  :key="report.id"
                  class="p-4 border border-slate-200 rounded-lg hover:shadow-sm transition-shadow bg-white"
                >
                  <div class="flex items-start justify-between">
                    <div class="flex-1">
                      <div class="flex items-center gap-3 mb-2">
                        <h4 class="text-sm font-medium text-slate-900">{{ report.title }}</h4>
                        <span
                          class="text-xs bg-emerald-100 text-emerald-700 px-2 py-0.5 rounded-full"
                        >
                          {{ report.progress }}% Complete
                        </span>
                      </div>
                      <p class="text-xs text-slate-500 mb-2">
                        {{ formatDate(report.createdAt) }} • {{ report.createdByName || "You" }}
                      </p>
                      <p class="text-sm text-slate-600 mb-3">{{ report.description }}</p>

                      <div class="flex items-center gap-4">
                        <a
                          :href="report.filePath"
                          target="_blank"
                          class="text-xs text-emerald-600 hover:text-emerald-700 flex items-center gap-1"
                        >
                          <ExternalLinkIcon class="w-3 h-3" />
                          View Report
                        </a>
                        <span
                          v-if="report.isGeoValidated"
                          class="text-xs text-emerald-600 flex items-center gap-1"
                        >
                          <MapPinIcon class="w-3 h-3" />
                          Geo-verified
                        </span>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>

          <!-- DOCUMENTS TAB - Keeping for future use -->
          <div v-if="activeTab === 'documents'" class="text-center py-12">
            <FolderOpenIcon class="w-12 h-12 mx-auto mb-3 text-slate-300" />
            <p class="text-slate-600">Project documents will appear here</p>
            <p class="text-xs text-slate-400 mt-2">Contracts, drawings, and other project files</p>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script setup>
import { ref, computed, onMounted } from "vue";
import { useRouter } from "vue-router";
import { useToast } from "vue-toastification";
import {
  Loader2 as Loader2Icon,
  AlertCircle as AlertCircleIcon,
  RefreshCw as RefreshCwIcon,
  TrendingUp as TrendingUpIcon,
  Calendar as CalendarIcon,
  DollarSign as DollarSignIcon,
  FileText as FileTextIcon,
  MapPin as MapPinIcon,
  Upload as UploadIcon,
  Users as UsersIcon,
  ExternalLink as ExternalLinkIcon,
  FolderOpen as FolderOpenIcon,
  ChevronDown as ChevronDownIcon,
  User as UserIcon,
  LogOut as LogOutIcon,
} from "lucide-vue-next";
import { onClickOutside } from "@vueuse/core";
import { useAuthStore } from "@/stores/AuthStore";
import { useProjectStore } from "@/stores/projectStore";
import apiClient from "@/services/apiClient";

const router = useRouter();
const toast = useToast();
const authStore = useAuthStore();
const projectStore = useProjectStore();

// State
const activeTab = ref("overview");
const reports = ref([]);
const reportsLoading = ref(false);
const submitting = ref(false);
const fileInput = ref(null);
const selectedFile = ref(null);
const fileError = ref("");
const locationStatus = ref("Checking your location...");
const locationError = ref("");
const isWithinGeofence = ref(false);
const currentLocation = ref(null);
const showProfileDropdown = ref(false);
const dropdownRef = ref(null);

// Tabs configuration - REMOVED instructions tab
const tabs = [
  { id: "overview", label: "Overview", icon: FileTextIcon },
  {
    id: "reports",
    label: "Weekly Reports",
    icon: UploadIcon,
    badge: computed(() => reports.value.length),
  },
  { id: "documents", label: "Documents", icon: FolderOpenIcon },
];

// Report form
const reportForm = ref({
  title: "",
  progress: 0,
  description: "",
});

// Computed
const user = computed(() => authStore.user);
const myProject = computed(() => projectStore.myProject);
const loading = computed(() => projectStore.loading);

// Chart calculations
const plannedProgress = computed(() => {
  return Math.min(myProject.value?.timeElapsedPercentage || 0, 100);
});

const plannedProgressHeight = computed(() => {
  return (plannedProgress.value / 100) * 160;
});

const actualProgressHeight = computed(() => {
  return ((myProject.value?.currentPhysicalProgress || 0) / 100) * 160;
});

const varianceHeight = computed(() => {
  const variance = Math.abs(myProject.value?.variance || 0);
  return (Math.min(variance, 100) / 100) * 160;
});

const varianceClass = computed(() => {
  const variance = myProject.value?.variance || 0;
  return variance >= 0 ? "bg-emerald-200" : "bg-red-200";
});

const progressCircleColor = computed(() => {
  const progress = myProject.value?.currentPhysicalProgress || 0;
  if (progress >= 75) return "#10b981";
  if (progress >= 50) return "#f59e0b";
  return "#ef4444";
});

const progressBarClass = computed(() => {
  if (myProject.value?.isAtRisk) return "bg-red-600";
  if (myProject.value?.variance < -10) return "bg-amber-600";
  return "bg-emerald-600";
});

const userInitials = computed(() => {
  if (!user.value) return "U";
  const first = user.value.firstName?.charAt(0) || "";
  const last = user.value.lastName?.charAt(0) || "";
  return (first + last).toUpperCase() || "U";
});

const userRoleLabel = computed(() => {
  const role = authStore.userRole;
  const roles = {
    CS: "Principal Secretary",
    RL: "Regional Lead",
    CDH: "County Director",
    COW: "Clerk of Works",
    TL: "Technical Lead",
  };
  return roles[role] || role || "User";
});

// Click outside to close dropdown
onClickOutside(dropdownRef, () => {
  showProfileDropdown.value = false;
});

// Methods
const formatCurrency = (value) => {
  if (!value) return "0";
  if (value >= 1000000) {
    return `${(value / 1000000).toFixed(2)}M`;
  }
  return value.toLocaleString();
};

const formatDate = (dateString) => {
  if (!dateString) return "N/A";
  return new Date(dateString).toLocaleDateString("en-KE", {
    year: "numeric",
    month: "short",
    day: "numeric",
  });
};

const getStatusBadgeClass = (status) => {
  const classes = {
    Delayed: "bg-red-100 text-red-700 border border-red-200",
    Slow: "bg-amber-100 text-amber-700 border border-amber-200",
    OnTrack: "bg-emerald-100 text-emerald-700 border border-emerald-200",
    Ahead: "bg-blue-100 text-blue-700 border border-blue-200",
    Completed: "bg-slate-100 text-slate-700 border border-slate-200",
  };
  return classes[status] || "bg-slate-100 text-slate-700 border border-slate-200";
};

const refreshProject = async () => {
  await projectStore.fetchMyProject();
  if (myProject.value) {
    await Promise.all([fetchReports(), checkGeolocation()]);
    toast.success("Dashboard refreshed");
  }
};

const fetchReports = async () => {
  if (!myProject.value) return;

  reportsLoading.value = true;
  try {
    const response = await apiClient.get(`/Reports/project/${myProject.value.id}`);
    reports.value = response.data || [];
  } catch (error) {
    console.error("Error loading reports:", error);
    reports.value = [];
  } finally {
    reportsLoading.value = false;
  }
};

const checkGeolocation = async () => {
  if (!myProject.value) return;

  try {
    locationStatus.value = "Getting your location...";

    const position = await authStore.getCurrentPosition();
    const { latitude, longitude } = position.coords;
    currentLocation.value = { latitude, longitude };

    // For now, assume within geofence - your backend will validate
    isWithinGeofence.value = true;
    locationStatus.value = "✓ Location detected - you can upload reports";
  } catch (error) {
    console.error("Geolocation error:", error);
    isWithinGeofence.value = false;
    locationStatus.value = "⚠ Location unavailable";
    locationError.value = "Please enable GPS and refresh";
  }
};

const handleFileChange = (event) => {
  const file = event.target.files[0];
  fileError.value = "";

  if (!file) {
    selectedFile.value = null;
    return;
  }

  const validTypes = [".pdf", ".xls", ".xlsx", ".xlsm"];
  const extension = "." + file.name.split(".").pop().toLowerCase();

  if (!validTypes.includes(extension)) {
    fileError.value = "Only PDF and Excel files are allowed";
    event.target.value = "";
    selectedFile.value = null;
    return;
  }

  if (file.size > 10 * 1024 * 1024) {
    fileError.value = "File size must be less than 10MB";
    event.target.value = "";
    selectedFile.value = null;
    return;
  }

  selectedFile.value = file;
};

const submitReport = async () => {
  if (!isWithinGeofence.value) {
    toast.error("You must be within the project site to submit a report");
    return;
  }

  if (!selectedFile.value) {
    fileError.value = "Please select a file";
    return;
  }

  if (reportForm.value.progress <= myProject.value.currentPhysicalProgress) {
    toast.error(
      `Progress must be greater than current (${myProject.value.currentPhysicalProgress}%)`,
    );
    return;
  }

  submitting.value = true;

  try {
    // Get fresh location
    const position = await authStore.getCurrentPosition();
    const { latitude, longitude } = position.coords;

    const formData = new FormData();
    formData.append("Title", reportForm.value.title);
    formData.append("Description", reportForm.value.description);
    formData.append("Progress", reportForm.value.progress);
    formData.append("ProjectId", myProject.value.id);
    formData.append("SubmissionLatitude", latitude);
    formData.append("SubmissionLongitude", longitude);
    formData.append("File", selectedFile.value);

    const response = await apiClient.post("/Reports", formData, {
      headers: {
        "Content-Type": "multipart/form-data",
      },
    });

    const { isSuccess, error, value } = response.data;

    if (!isSuccess) {
      throw new Error(error || "Failed to submit report");
    }

    toast.success("Report submitted successfully!");

    // Reset form
    reportForm.value = {
      title: "",
      progress: 0,
      description: "",
    };
    selectedFile.value = null;
    if (fileInput.value) {
      fileInput.value.value = "";
    }

    // Refresh data
    await Promise.all([fetchReports(), projectStore.fetchMyProject()]);
  } catch (error) {
    console.error("Error submitting report:", error);
    toast.error(error.response?.data?.error || error.message || "Failed to submit report");
  } finally {
    submitting.value = false;
  }
};

const logout = () => {
  authStore.logout();
  router.push("/login");
};

// Initialize
onMounted(async () => {
  await projectStore.fetchMyProject();
  if (myProject.value) {
    await Promise.all([fetchReports(), checkGeolocation()]);
  }
});
</script>
