// src/stores/projectStore.js
import { defineStore } from "pinia";
import apiClient from "@/services/apiClient";

export const useProjectStore = defineStore("project", {
  state: () => ({
    myProject: null,
    projects: [],
    selectedProject: null,
    loading: false,
    pagination: {
      pageNumber: 1,
      pageSize: 10,
      totalPages: 1,
      totalRecords: 0,
      hasNextPage: false,
      hasPreviousPage: false,
    },
  }),

  actions: {
    async fetchMyProject() {
      this.loading = true;
      try {
        const response = await apiClient.get("/Projects/my-project");
        this.myProject = response.data;
      } catch (error) {
        console.error("Failed to load project", error);
        this.myProject = null;
      } finally {
        this.loading = false;
      }
    },

    async fetchProjects(params = {}) {
      this.loading = true;
      try {
        const queryParams = {};
        if (params.pageNumber) queryParams.pageNumber = params.pageNumber;
        if (params.pageSize) queryParams.pageSize = params.pageSize;
        if (params.searchTerm) queryParams.searchTerm = params.searchTerm;
        if (params.county) queryParams.county = params.county;
        if (params.constituency) queryParams.constituency = params.constituency;
        if (params.ward) queryParams.ward = params.ward;
        if (params.progressStatus) queryParams.progressStatus = params.progressStatus;
        if (params.role) queryParams.role = params.role;
        if (params.assignedToUserId) queryParams.assignedToUserId = params.assignedToUserId;
        if (params.sortBy) queryParams.sortBy = params.sortBy;

        const response = await apiClient.get("/Projects", { params: queryParams });
        const { data, pageNumber, pageSize, totalPages, totalRecords } = response.data;

        this.projects = data || [];
        this.pagination = {
          pageNumber: pageNumber || 1,
          pageSize: pageSize || 10,
          totalPages: totalPages || 1,
          totalRecords: totalRecords || 0,
          hasNextPage: pageNumber < totalPages,
          hasPreviousPage: pageNumber > 1,
        };
      } catch (error) {
        console.error("Failed to load projects", error);
        this.projects = [];
      } finally {
        this.loading = false;
      }
    },

    async fetchProjectById(projectId) {
      this.loading = true;
      try {
        const response = await apiClient.get(`/Projects/${projectId}`);
        this.selectedProject = response.data;
      } catch (error) {
        console.error("Failed to load project details", error);
        this.selectedProject = null;
      } finally {
        this.loading = false;
      }
    },

    clearSelectedProject() {
      this.selectedProject = null;
    },
  },
});
