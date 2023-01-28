# Build stage

FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /source
COPY . .

RUN dotnet restore "./synonyms-project/synonyms-project.csproj" --disable-parallel
RUN dotnet publish "./synonyms-project/synonyms-project.csproj" -c release -o /app --no-restore

# Serve stage 
FROM mcr.microsoft.com/dotnet/aspnet:6.0 as base
WORKDIR /app
COPY --from=build /app ./

EXPOSE 80
EXPOSE 443

ENTRYPOINT ["dotnet", "synonyms-project.dll"]