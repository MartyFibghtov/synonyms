#FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
#WORKDIR /source
## Copy csproj and restore as distinct layers
#COPY . .
#RUN dotnet restore "./synonyms-project.csproj"
#RUN dotnet publish "./synonyms-project.csproj" -c release -o /app --no-restore
#
#
#
#FROM mcr.microsoft.com/dotnet/aspnet:6.0
#WORKDIR /apps
#COPY --from=build /app/ .
#EXPOSE 80
#EXPOSE 443
#EXPOSE 5000
#EXPOSE 5001
#
#ENTRYPOINT ["dotnet", "synonyms-project.dll"]
## ENTRYPOINT ["dotnet", "run"]
#
#
#
#
#
#
# TODO Delete

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

EXPOSE 5000
EXPOSE 5001

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["./synonyms-project.csproj", "./"]
RUN dotnet restore "./synonyms-project.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "synonyms-project.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "synonyms-project.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "synonyms-project.dll"]