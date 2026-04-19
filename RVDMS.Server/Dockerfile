# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy solution file (if exists)
COPY *.sln . 2>nul || true

# Copy all project files
COPY RVDMS.Server/*.csproj ./RVDMS.Server/
COPY RVDMS.Application/*.csproj ./RVDMS.Application/
COPY RVDMS.Domain/*.csproj ./RVDMS.Domain/
COPY RVDMS.Infrastructure/*.csproj ./RVDMS.Infrastructure/

# Restore dependencies
RUN dotnet restore

# Copy everything else
COPY . .

# Build and publish the API project
WORKDIR /src/RVDMS.Server
RUN dotnet publish -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://0.0.0.0:8080

EXPOSE 8080

ENTRYPOINT ["dotnet", "RVDMS.Api.dll"]