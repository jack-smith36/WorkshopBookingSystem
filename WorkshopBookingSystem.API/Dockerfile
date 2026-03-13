FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY ["WorkshopBookingSystem.sln", "."]
COPY ["WorkshopBookingSystem.API/WorkshopBookingSystem.API.csproj", "WorkshopBookingSystem.API/"]
COPY ["WorkshopBookingSystem.Application/WorkshopBookingSystem.Application.csproj", "WorkshopBookingSystem.Application/"]
COPY ["WorkshopBookingSystem.Domain/WorkshopBookingSystem.Domain.csproj", "WorkshopBookingSystem.Domain/"]
COPY ["WorkshopBookingSystem.Infrastructure/WorkshopBookingSystem.Infrastructure.csproj", "WorkshopBookingSystem.Infrastructure/"]
RUN dotnet restore "WorkshopBookingSystem.API/WorkshopBookingSystem.API.csproj"

COPY . .
WORKDIR "/src/WorkshopBookingSystem.API"
RUN dotnet publish "WorkshopBookingSystem.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 8080
ENTRYPOINT ["dotnet", "WorkshopBookingSystem.API.dll"]

