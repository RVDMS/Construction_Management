FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY . .

# ONLY restore API project
RUN dotnet restore ./RVDMS.Server/RVDMS.Api.csproj

# ONLY publish API project
RUN dotnet publish ./RVDMS.Server/RVDMS.Api.csproj -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://0.0.0.0:8080
EXPOSE 8080

ENTRYPOINT ["dotnet", "RVDMS.Api.dll"]