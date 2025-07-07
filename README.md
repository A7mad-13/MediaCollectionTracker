# Media Collection Tracker

An ASP.NET MVC app to manage movies, music, and games with search and status tracking.

# 🎞️ Media Collection Tracker (ASP.NET Core MVC)

This is a simple web application built with **ASP.NET Core MVC** and **Entity Framework Core**, allowing users to manage a personal media collection including Movies, Music, and Games.

---

## 🚀 Features

- ✅ Add, Edit, and Delete media items
- 🔍 Search by Title, Creator, or Genre
- 📦 Categories: Movie, Music, Game
- 📌 Track status: Owned, Wishlist, Completed, etc.
- 🎨 Clean Razor-based UI (Bootstrap-ready)
- 🗃️ SQL Server + Entity Framework (Code First)

---

## 🏗️ Technologies Used

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server LocalDB
- Razor Views
- Visual Studio Code
- Git + GitHub

---

## 💻 Setup Instructions

### Prerequisites
- [.NET SDK 7 or later](https://dotnet.microsoft.com/)
- SQL Server LocalDB (or full SQL Server)
- Git

### Getting Started

```bash
# Clone the repository
git clone https://github.com/A7mad-13/MediaCollectionTracker.git
cd MediaCollectionTracker

# Restore dependencies
dotnet restore

# Update the connection string in appsettings.json if needed
# Ensure MediaDB database exists locally

# Run the app
dotnet run

