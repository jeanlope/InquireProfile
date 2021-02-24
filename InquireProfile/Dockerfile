#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["InquireProfile/InquireProfile.csproj", "InquireProfile/"]
RUN dotnet restore "InquireProfile/InquireProfile.csproj"
COPY . .
WORKDIR "/src/InquireProfile"
RUN dotnet build "InquireProfile.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "InquireProfile.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "InquireProfile.dll"]