import { createRouter, createWebHistory } from 'vue-router'
import LoginView from '../views/LoginView.vue'
import DashboardLayout from '../components/DashboardLayout.vue'
import DashboardView from '../views/DashboardView.vue'
import ProjectsView from '../views/ProjectsView.vue'
import ProjectDetailView from '../views/ProjectDetailView.vue'
import ReportsView from '../views/ReportsView.vue'
import AuditLogsView from '../views/AuditLogsView.vue'
import UsersView from '../views/UsersView.vue'
import SettingsView from '../views/SettingsView.vue'
import NotFoundView from '../views/NotFoundView.vue'

const routes = [
  { path: '/', redirect: '/login' },
  { path: '/login', component: LoginView },
  {
    path: '/dashboard',
    component: DashboardLayout,
    children: [
      { path: '', component: DashboardView },
      { path: 'projects', component: ProjectsView },
      { path: 'projects/:id', component: ProjectDetailView },
      { path: 'reports', component: ReportsView },
      { path: 'audit-logs', component: AuditLogsView },
      { path: 'users', component: UsersView },
      { path: 'settings', component: SettingsView }
    ]
  },
  { path: '/:pathMatch(.*)*', component: NotFoundView }
]

const router = createRouter({
  history: createWebHistory(),
  routes
})

export default router
