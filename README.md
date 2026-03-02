# Affordable Housing Programme – Nakuru Dashboard (Vue.js)

A full conversion of the React/Figma design to Vue 3 with the same features, data, and role-based access.

## Tech Stack

| Original (React) | Vue Equivalent |
|---|---|
| React + TypeScript | **Vue 3** (Composition API) |
| React Router | **Vue Router 4** |
| React Context | **Pinia** store |
| recharts | **Chart.js + vue-chartjs** |
| shadcn/ui | Tailwind CSS (custom) |
| lucide-react | **lucide-vue-next** |

---

## Setup Instructions

### Prerequisites
- **Node.js** v18 or higher
- **npm** v9 or higher

> **Windows users**: Before running, enable long path support in PowerShell (as Administrator):
> ```powershell
> New-ItemProperty -Path "HKLM:\SYSTEM\CurrentControlSet\Control\FileSystem" -Name "LongPathsEnabled" -Value 1 -PropertyType DWORD -Force
> ```
> Then restart your machine.

### Installation

```bash
# 1. Move to a short path (recommended on Windows)
#    Copy the folder to somewhere like: C:\projects\dashboard

# 2. Install dependencies
npm install

# 3. Start dev server
npm run dev
```

Open your browser at **http://localhost:5173**

### Build for Production

```bash
npm run build
npm run preview
```

---

## Project Structure

```
src/
├── main.js                  # App entry point
├── App.vue                  # Root component
├── styles.css               # Tailwind + global styles
├── router/
│   └── index.js             # Vue Router configuration
├── stores/
│   └── userStore.js         # Pinia user state (replaces React Context)
├── data/
│   ├── mockData.js          # All mock data (projects, users, audit logs)
│   └── counties.js          # Kenya counties data
├── utils/
│   └── permissions.js       # RBAC helpers + status utilities
├── components/
│   └── DashboardLayout.vue  # Sidebar + top nav layout
└── views/
    ├── LoginView.vue
    ├── DashboardView.vue
    ├── ProjectsView.vue
    ├── ProjectDetailView.vue
    ├── ReportsView.vue
    ├── AuditLogsView.vue
    ├── UsersView.vue
    ├── SettingsView.vue
    └── NotFoundView.vue
```

---

## Features

- ✅ **Login with 2FA simulation**
- ✅ **Role-based navigation** (PS, Regional Lead, County Director, Clerk of Works, Consultant)
- ✅ **Switch user profiles** from top-right dropdown
- ✅ **Dashboard** with KPI cards, Chart.js charts, and project site map
- ✅ **Projects list** (filtered by role)
- ✅ **Project detail** with tabbed view (Overview, Reports, Instructions, Documents, Audit)
- ✅ **Weekly report upload** form
- ✅ **Reports page** with filters + export buttons
- ✅ **Audit logs** with search + filter
- ✅ **User management** with permissions matrix
- ✅ **Settings** (profile, security, notifications, system)
- ✅ **Geolocation** detection in header
- ✅ **County navigation** for PS and Regional Lead roles

---

## Troubleshooting

**`npm install` fails with TAR_ENTRY_ERROR**
- Delete `node_modules` and `package-lock.json`, then retry
- Move the project to a shorter path (e.g., `C:\projects\dashboard`)
- Enable long path support (see setup above)
- Temporarily disable antivirus real-time protection during install

**Port already in use**
```bash
npm run dev -- --port 3000
```
