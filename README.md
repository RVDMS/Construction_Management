# Rift Valley Construction Project Management System

## Project Overview

The Rift Valley Construction Project Management System is a web-based platform designed to support the planning, implementation, and monitoring of construction projects across the Rift Valley region.

The system focuses on projects managed under multiple departments, including:

- Housing Department  
- Slum Upgrade  
- Institutional Housing  
- Urban Development  

It is primarily built to assist the **Regional Lead (RL)** in overseeing projects, tracking performance, and ensuring accountability across all active construction sites.

---

## Problem Statement

Managing multiple construction projects across different counties and departments can be complex and difficult to monitor effectively. Common challenges include:

- Limited visibility into real-time project progress  
- Delayed or inconsistent reporting from site teams  
- Lack of centralized oversight  
- Difficulty tracking user activities and accountability  
- Reports submitted from outside designated project sites  

This system addresses these challenges by providing centralized monitoring, structured reporting, geofenced submissions, and role-based access control.

---

##  Key Features

### 1️⃣ Project Monitoring & Tracking
- View detailed information about each project  
- Track project status (On Track, Slow Progress, Behind Schedule)  
- Monitor implementation progress across departments  
- Access centralized project records  

### 2️⃣ Reporting System
- Clerk of Works and Cluster Supervisors can upload site reports  
- Reports include structured and detailed project updates  
- The Regional Lead can generate and review performance reports  

### 3️⃣ Geofencing for Site Reporting
- Report submission is restricted to users physically present on-site  
- Geofencing is implemented using the **Haversine Formula**  
- The system automatically disables the write/upload function if a user is outside the approved site radius  

This ensures the authenticity and accountability of field reports.

### 4️⃣ Role-Based Access Control (RBAC)
The system implements RBAC to ensure users only access what they are authorized to see or manage.

Roles include:
- Regional Lead (RL)  
- Clerk of Works  
- Cluster Supervisor  
- Other administrative roles  

Each role has specific permissions and responsibilities within the system.

### 5️⃣ Dashboards
- User dashboards for project-specific insights  
- Administrative dashboard for system-wide monitoring  
- Visual summaries of project performance and reporting metrics  

### 6️⃣ User Activity Logs
- The Regional Lead can track user logs  
- Monitor user actions for accountability and auditing  

---

## Technology Stack

The system is built using the following technologies:

### Frontend
- **Vue.js** – User interface development  
- JavaScript  
- HTML & CSS  

### Backend
- **ASP.NET Core Web API** – Business logic and API services  
- C#  

### Database
- **Microsoft SQL Server** – Data storage and management  

---

##  System Architecture Overview

The application follows a structured web architecture:

- Frontend (Vue) communicates with backend APIs  
- Backend handles business logic, authentication, geofencing validation, and reporting workflows  
- SQL Server stores project data, user information, logs, and reports  

The system ensures secure communication between components and enforces access control through role-based authorization.

---

##  Security & Control Measures

- Role-Based Access Control (RBAC)  
- Authenticated API endpoints  
- Geofencing validation before report submission  
- User activity logging for auditing purposes  

---

##  Expected Impact

This system improves:

- Transparency in project implementation  
- Real-time visibility of project progress  
- Accountability of field officers  
- Data-driven decision-making for the Regional Lead  

By centralizing project data and enforcing structured reporting, the platform enhances operational efficiency across all construction projects in the Rift Valley region.

---

##  Conclusion

The Rift Valley Construction Project Management System is a centralized, secure, and structured solution designed to improve oversight, reporting, and accountability in public construction projects. It combines modern web technologies with geospatial validation and role-based security to deliver reliable and efficient project management.
