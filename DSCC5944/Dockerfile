#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["DSCC5944/DSCC5944.csproj", "DSCC5944/"]
RUN dotnet restore "DSCC5944/DSCC5944.csproj"
COPY . .
WORKDIR "/src/DSCC5944"
RUN dotnet build "DSCC5944.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DSCC5944.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DSCC5944.dll"]