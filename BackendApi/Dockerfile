# Base image for runtime
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# SDK image for building the application
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src/BackendApi
COPY BackendApi/BackendApi.csproj ./  
RUN dotnet restore
COPY BackendApi/. ./
RUN dotnet build "BackendApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publish the application
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "BackendApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish

# Final stage to copy the published output and configure the runtime
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT [ "dotnet", "BackendApi.dll" ]





