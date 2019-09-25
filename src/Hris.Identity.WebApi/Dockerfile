FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Hris.Identity.WebApi/Hris.Identity.WebApi.csproj", "Hris.Identity.WebApi/"]
COPY ["Hris.Common/Hris.Common.csproj", "Hris.Common/"]
RUN dotnet restore "Hris.Identity.WebApi/Hris.Identity.WebApi.csproj"
COPY . .
WORKDIR "/src/Hris.Identity.WebApi"
RUN dotnet build "Hris.Identity.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Hris.Identity.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Hris.Identity.WebApi.dll"]