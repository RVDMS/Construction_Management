// types.js - Data definitions

export const PROJECT_STATUSES = {
  ON_TRACK: 'on-track',
  SLOW_PROGRESS: 'slow-progress',
  BEHIND_SCHEDULE: 'behind-schedule'
}

export const USER_ROLES = {
  PRINCIPAL_SECRETARY: 'principal-secretary',
  REGIONAL_LEAD: 'regional-lead',
  COUNTY_DIRECTOR: 'county-director',
  CLERK_OF_WORKS: 'clerk-of-works',
  CONSULTANT: 'consultant'
}

export const projects = [
  {
    id: '1',
    name: 'Bahati Phase 1',
    ward: 'Bahati',
    subcounty: 'Nakuru East',
    contractor: 'Peter Lokong',
    contractorContact: '+254 722 345 678',
    contractSum: 45000000,
    consultant: 'Frank Asuza',
    consultantContact: '+254 733 456 789',
    clusterSupervisor: 'Nicholas Ogajo',
    clerkOfWorks: 'Dominic Chebon',
    status: 'on-track',
    completionPercentage: 67,
    budgetSpent: 30000000,
    startDate: '2025-03-15',
    expectedCompletion: '2026-09-15',
    lastUpdated: '2026-02-10',
    coordinates: { lat: -0.3031, lng: 36.0800 },
    physicalLocation: 'Plot LR/3458, Bahati Township'
  },
  {
    id: '2',
    name: 'Lanet Phase 2',
    ward: 'Lanet/Umoja',
    subcounty: 'Nakuru West',
    contractor: 'Summit Builders Co.',
    contractorContact: '+254 711 234 567',
    contractSum: 52000000,
    consultant: 'ProDesign Associates',
    consultantContact: '+254 720 567 890',
    clusterSupervisor: 'Nicholas Ogajo',
    clerkOfWorks: 'Grace Wanjiru',
    status: 'slow-progress',
    completionPercentage: 42,
    budgetSpent: 28000000,
    startDate: '2025-05-01',
    expectedCompletion: '2026-11-01',
    lastUpdated: '2026-02-09',
    coordinates: { lat: -0.2827, lng: 36.0756 },
    physicalLocation: 'Lanet Barracks Road, Block C'
  },
  {
    id: '3',
    name: 'Kaptembwo Housing Estate',
    ward: 'Kaptembwo',
    subcounty: 'Nakuru East',
    contractor: 'Green Valley Construction',
    contractorContact: '+254 734 567 890',
    contractSum: 38000000,
    consultant: 'Urban Planning Partners',
    consultantContact: '+254 712 345 678',
    clusterSupervisor: 'Nicholas Ogajo',
    clerkOfWorks: 'Daniel Kipchoge',
    status: 'behind-schedule',
    completionPercentage: 28,
    budgetSpent: 18000000,
    startDate: '2025-04-10',
    expectedCompletion: '2026-08-10',
    lastUpdated: '2026-02-11',
    coordinates: { lat: -0.3100, lng: 36.0650 },
    physicalLocation: 'Kaptembwo, Section 7'
  },
  {
    id: '4',
    name: 'Nakuru Town East Apartments',
    ward: 'Nakuru East',
    subcounty: 'Nakuru Town East',
    contractor: 'Heritage Contractors Ltd',
    contractorContact: '+254 723 678 901',
    contractSum: 60000000,
    consultant: 'Precision Engineering',
    consultantContact: '+254 731 234 567',
    clusterSupervisor: 'Nicholas Ogajo',
    clerkOfWorks: 'Lucy Nyambura',
    status: 'on-track',
    completionPercentage: 75,
    budgetSpent: 48000000,
    startDate: '2025-01-20',
    expectedCompletion: '2026-07-20',
    lastUpdated: '2026-02-12',
    coordinates: { lat: -0.2905, lng: 36.0821 },
    physicalLocation: 'Off Kenyatta Avenue, CBD'
  },
  {
    id: '5',
    name: 'Menengai View Estate',
    ward: 'Menengai West',
    subcounty: 'Nakuru West',
    contractor: 'Skyline Developers',
    contractorContact: '+254 745 890 123',
    contractSum: 41000000,
    consultant: 'Landmark Consultancy',
    consultantContact: '+254 721 456 789',
    clusterSupervisor: 'Nicholas Ogajo',
    clerkOfWorks: 'Samuel Omondi',
    status: 'on-track',
    completionPercentage: 58,
    budgetSpent: 24000000,
    startDate: '2025-06-01',
    expectedCompletion: '2026-12-01',
    lastUpdated: '2026-02-10',
    coordinates: { lat: -0.2700, lng: 36.0600 },
    physicalLocation: 'Menengai Crater Road'
  },
  {
    id: '6',
    name: 'Pipeline Estate Phase 1',
    ward: 'Pipeline',
    subcounty: 'Nakuru Town West',
    contractor: 'Premier Housing Ltd',
    contractorContact: '+254 710 234 567',
    contractSum: 35000000,
    consultant: 'Capital Projects Consult',
    consultantContact: '+254 722 789 012',
    clusterSupervisor: 'Nicholas Ogajo',
    clerkOfWorks: 'Michael Otieno',
    status: 'slow-progress',
    completionPercentage: 35,
    budgetSpent: 16000000,
    startDate: '2025-07-15',
    expectedCompletion: '2027-01-15',
    lastUpdated: '2026-02-08',
    coordinates: { lat: -0.3150, lng: 36.0700 },
    physicalLocation: 'Pipeline, off Nakuru-Nairobi Highway'
  }
]

export const auditLogs = [
  {
    id: '1',
    user: 'Dr. James Kariuki',
    role: 'regional-lead',
    action: 'Viewed project details - Bahati Phase 1',
    timestamp: '2026-02-12 09:15:23',
    ipAddress: '105.163.0.45',
    location: 'Nakuru, Kenya'
  },
  {
    id: '2',
    user: 'Grace Wanjiru',
    role: 'clerk-of-works',
    action: 'Uploaded weekly report - Lanet Phase 2',
    timestamp: '2026-02-12 08:30:12',
    ipAddress: '105.163.1.89',
    location: 'Nakuru, Kenya'
  },
  {
    id: '3',
    user: 'Eng. Mary Wambui',
    role: 'county-director',
    action: 'Updated project status - Bahati Phase 1',
    timestamp: '2026-02-11 14:22:45',
    ipAddress: '105.163.0.112',
    location: 'Nakuru, Kenya'
  },
  {
    id: '4',
    user: 'BuildTech Consultants',
    role: 'consultant',
    action: 'Issued instruction - Bahati Phase 1',
    timestamp: '2026-02-11 11:05:30',
    ipAddress: '105.163.2.78',
    location: 'Nairobi, Kenya'
  },
  {
    id: '5',
    user: 'Dr. James Kariuki',
    role: 'regional-lead',
    action: 'Exported regional report',
    timestamp: '2026-02-10 16:45:18',
    ipAddress: '105.163.0.45',
    location: 'Nakuru, Kenya'
  },
  {
    id: '6',
    user: 'Daniel Kipchoge',
    role: 'clerk-of-works',
    action: 'Uploaded weekly report - Kaptembwo Housing Estate',
    timestamp: '2026-02-10 10:20:55',
    ipAddress: '105.163.3.34',
    location: 'Nakuru, Kenya'
  },
  {
    id: '7',
    user: 'Lucy Nyambura',
    role: 'clerk-of-works',
    action: 'Uploaded progress photos - Nakuru Town East Apartments',
    timestamp: '2026-02-09 15:33:12',
    ipAddress: '105.163.1.156',
    location: 'Nakuru, Kenya'
  }
]

export const weeklyReports = [
  {
    id: '1',
    projectId: '1',
    uploadedBy: 'John Mwangi',
    uploadDate: '2026-02-10',
    progressPercentage: 67,
    notes: 'Foundation work completed. Starting on first floor columns. Weather conditions favorable.',
    photos: ['photo1.jpg', 'photo2.jpg'],
    geotagged: true
  },
  {
    id: '2',
    projectId: '2',
    uploadedBy: 'Grace Wanjiru',
    uploadDate: '2026-02-09',
    progressPercentage: 42,
    notes: 'Delays due to material shortage. Contractor has confirmed delivery by end of week.',
    photos: ['photo3.jpg'],
    geotagged: true
  }
]

export const users = [
  {
    id: '0',
    name: 'Charles M. Hinga',
    email: 'ps@housing.go.ke',
    password: 'PS@1234',
    role: 'principal-secretary',
    has2FA: true
  },
  {
    id: '1',
    name: 'Richard Tuta',
    email: 'r.tuta@housing.go.ke',
    password: 'Regional@1234',
    role: 'regional-lead',
    has2FA: true,
    region: 'South Rift'
  },
  {
    id: '2',
    name: 'Nicholas Ogajo',
    email: 'n.ogajo@housing.go.ke',
    password: 'Director@1234',
    role: 'county-director',
    has2FA: true,
    county: 'Nakuru'
  },
  {
    id: '3',
    name: 'Dominic Chebon',
    email: 'd.chebon@housing.go.ke',
    password: 'Clerk@1234',
    role: 'clerk-of-works',
    has2FA: false
  },
  {
    id: '4',
    name: 'Grace Wanjiru',
    email: 'g.wanjiru@housing.go.ke',
    password: 'Clerk@1234',
    role: 'clerk-of-works',
    has2FA: false
  },
  {
    id: '5',
    name: 'Frank Asuza',
    email: 'f.asuza@consultants.co.ke',
    password: 'Consult@1234',
    role: 'consultant',
    has2FA: false
  }
]
