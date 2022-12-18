#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Case_Study_Lwam_Teklay/Case_Study_Lwam_Teklay.csproj", "Case_Study_Lwam_Teklay/"]
RUN dotnet restore "Case_Study_Lwam_Teklay/Case_Study_Lwam_Teklay.csproj"
COPY . .
WORKDIR "/src/Case_Study_Lwam_Teklay"
RUN dotnet build "Case_Study_Lwam_Teklay.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Case_Study_Lwam_Teklay.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Case_Study_Lwam_Teklay.dll"]