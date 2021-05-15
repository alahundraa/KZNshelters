FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["KZNshelter/KZNshelter.csproj", "KZNshelter/"]
RUN dotnet restore "KZNshelter/KZNshelter.csproj"
COPY . .
WORKDIR "/src/KZNshelter"
RUN dotnet build "KZNshelter.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "KZNshelter.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "KZNshelter.dll"]
