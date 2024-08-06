# Services Marketplace Application

# Getting Started

This project is built using the ASP.NET Core with React template found here: [ASP.Net with React](https://learn.microsoft.com/en-us/visualstudio/javascript/tutorial-asp-net-core-with-react?view=vs-2022). Follow the steps below to set up and run the project on your local machine using Visual Studio 2022 Community Edition.

## Prerequisites

Before you begin, ensure you have the following installed:

- Visual Studio 2022 Community Edition
- .NET 8.0 SDK
- Node.js (which includes npm, the Node package manager)

## Installation

### Step 1: Install Visual Studio 2022 Community Edition

1. Download and install [Visual Studio 2022 Community Edition](https://visualstudio.microsoft.com/vs/community/).
2. During the installation, select the following workloads:
   - **ASP.NET and web development**
   - **.NET desktop development**

### Step 2: Install .NET 7.0 SDK

1. Download and install the [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0).

### Step 3: Install Node.js

1. Download and install [Node.js](https://nodejs.org/). The LTS (Long Term Support) version is recommended.
2. Verify the installation by running the following commands in your terminal or command prompt:
   ```sh
   node -v
   npm -v

## Project Setup

### Step 1: Clone the Repository

Clone this repository to your local machine using the terminal or command prompt:
```sh
git clone https://github.com/grtn316/servicemarketplaceapp.git
cd servicemarketplaceapp
```

### Step 2: Open the Project in Visual Studio

1. Open Visual Studio 2022.
2. Select **File > Open > Project/Solution**.
3. Navigate to the cloned repository folder and select the `.sln` file to open the project.

### Step 3: Restore .NET and Node.js Dependencies

1. Open the **Package Manager Console** in Visual Studio (**Tools > NuGet Package Manager > Package Manager Console**).
2. Run the following command to restore .NET dependencies:
   ```sh
   dotnet restore
   ```
3. Open the terminal in Visual Studio (**View > Terminal**).
4. Navigate to the `ClientApp` directory:
   ```sh
   cd ClientApp
   ```
5. Run the following command to install Node.js dependencies:
   ```sh
   npm install
   ```

## Running the Project

### Step 1: Build and Run the Project

1. In Visual Studio, set the startup project to the ServiceMarketplace project.
2. Press **F5** or click the **Run** button to build and run the project.

### Step 2: Access the Application

Once the project is running, open your web browser and navigate to `https://localhost:7008/`.

## Troubleshooting

- Ensure all prerequisites are installed correctly.
- If you encounter any issues, try restarting Visual Studio and your machine.
- Check the terminal or command prompt for any error messages and address them accordingly.

## Additional Resources

- [ASP.NET Core Documentation](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-7.0)
- [React Documentation](https://reactjs.org/docs/getting-started.html)
- [Visual Studio Documentation](https://docs.microsoft.com/en-us/visualstudio/?view=vs-2022)