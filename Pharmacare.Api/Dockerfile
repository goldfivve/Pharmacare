#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#FROM goldfivve/pharmacare-database AS database
#ENV ACCEPT_EULA=Y
#ENV SA_PASSWORD=P@ssw0rd
#ENV MSSQL_PID=SA
#ENV MSSQL_TCP_PORT=1433

#RUN (/opt/mssql/bin/sqlservr --accept-eula & )
#$ docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=2Secure*Password2" -p 1450:1433 --name sqlserverdb -h mysqlserver -d mcr.microsoft.com/mssql/server:2019-latest

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Pharmacare.Api/Pharmacare.Api.csproj", "Pharmacare.Api/"]
COPY ["Pharmacare.Models/Pharmacare.Models.csproj", "Pharmacare.Models/"]
COPY ["Pharmacare.Blazor/Pharmacare.Blazor.csproj", "Pharmacare.Blazor/"]
RUN dotnet restore "Pharmacare.Api/Pharmacare.Api.csproj"
RUN dotnet restore "Pharmacare.Blazor/Pharmacare.Blazor.csproj"
COPY . .
WORKDIR "/src/Pharmacare.Api"
RUN dotnet build "Pharmacare.Api.csproj" -c Release -o /app/build
RUN dotnet build "Pharmacare.Blazor.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Pharmacare.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Pharmacare.Api.dll"]