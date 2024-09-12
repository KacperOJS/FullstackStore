FROM mcr.microsoft.com/dotnet/aspnet:7.0 as base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081
FROM mcr.microsoft.com/dotnet/sdk:7.0 as build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src/BackendApi
RUN dotnet build "BackendApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build as publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "BackendApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM base as final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT [ "dotnet","BackendApi.dll" ]


