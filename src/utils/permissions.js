// permissions.js

export const rolePermissions = {
  'principal-secretary': [
    'view_all_projects', 'edit_projects', 'add_reports', 'view_all_reports',
    'download_reports', 'view_audit_logs', 'manage_users', 'view_settings', 'edit_settings'
  ],
  'regional-lead': [
    'view_all_projects', 'edit_projects', 'add_reports', 'view_all_reports',
    'download_reports', 'view_audit_logs', 'manage_users', 'view_settings', 'edit_settings'
  ],
  'county-director': [
    'view_county_projects', 'edit_projects', 'add_reports', 'view_all_reports',
    'download_reports', 'manage_county_users', 'view_settings', 'edit_settings'
  ],
  'clerk-of-works': [
    'view_own_projects', 'add_reports', 'view_own_reports', 'download_reports', 'view_settings'
  ],
  'consultant': [
    'view_own_projects', 'add_reports', 'view_own_reports', 'download_reports', 'view_settings'
  ]
}

export function hasPermission(user, permission) {
  const permissions = rolePermissions[user.role] || []
  return permissions.includes(permission)
}

export function canAccessPage(user, page) {
  switch (page) {
    case 'dashboard': return true
    case 'projects':
      return hasPermission(user, 'view_all_projects') ||
             hasPermission(user, 'view_county_projects') ||
             hasPermission(user, 'view_own_projects')
    case 'reports':
      return hasPermission(user, 'view_all_reports') || hasPermission(user, 'view_own_reports')
    case 'audit-logs':
      return hasPermission(user, 'view_audit_logs')
    case 'users':
      return hasPermission(user, 'manage_users') || hasPermission(user, 'manage_county_users')
    case 'settings':
      return hasPermission(user, 'view_settings')
    default:
      return false
  }
}

export function getRoleName(role) {
  const names = {
    'principal-secretary': 'Super Admin',
    'regional-lead': 'Super Admin',
    'county-director': 'Admin',
    'clerk-of-works': 'User',
    'consultant': 'User'
  }
  return names[role] || 'User'
}

export function getRoleDisplayName(role) {
  return role.split('-').map(w => w.charAt(0).toUpperCase() + w.slice(1)).join(' ')
}

export function getAccessibleProjects(user, allProjects) {
  switch (user.role) {
    case 'principal-secretary':
    case 'regional-lead':
      return allProjects
    case 'county-director':
      if (user.county) {
        return allProjects.filter(p =>
          p.subcounty.includes(user.county) || p.ward.includes(user.county)
        )
      }
      return allProjects
    case 'clerk-of-works':
      return allProjects.filter(p => p.clerkOfWorks === user.name)
    case 'consultant':
      return allProjects.filter(p => p.consultant === user.name)
    default:
      return []
  }
}

export function getStatusColor(status) {
  const colors = {
    'on-track': 'bg-emerald-100 text-emerald-700 border-emerald-200',
    'slow-progress': 'bg-amber-100 text-amber-700 border-amber-200',
    'behind-schedule': 'bg-red-100 text-red-700 border-red-200'
  }
  return colors[status] || ''
}

export function getStatusBannerColor(status) {
  const colors = {
    'on-track': 'bg-emerald-50 border-emerald-200 text-emerald-900',
    'slow-progress': 'bg-amber-50 border-amber-200 text-amber-900',
    'behind-schedule': 'bg-red-50 border-red-200 text-red-900'
  }
  return colors[status] || ''
}

export function getStatusLabel(status) {
  const labels = {
    'on-track': 'On Track',
    'slow-progress': 'Slow Progress',
    'behind-schedule': 'Behind Schedule'
  }
  return labels[status] || status
}

export function getRoleBadgeColor(role) {
  const colors = {
    'regional-lead': 'bg-purple-100 text-purple-700 border-purple-200',
    'county-director': 'bg-blue-100 text-blue-700 border-blue-200',
    'clerk-of-works': 'bg-emerald-100 text-emerald-700 border-emerald-200',
    'consultant': 'bg-amber-100 text-amber-700 border-amber-200',
    'principal-secretary': 'bg-slate-100 text-slate-700 border-slate-200'
  }
  return colors[role] || 'bg-slate-100 text-slate-700 border-slate-200'
}
