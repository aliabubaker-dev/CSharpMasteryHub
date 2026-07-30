FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY CSharpMasteryHub/CSharpMasteryHub.csproj ./CSharpMasteryHub/
RUN dotnet restore ./CSharpMasteryHub/CSharpMasteryHub.csproj

COPY . .
WORKDIR /src/CSharpMasteryHub
RUN dotnet publish -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime
WORKDIR /app

# Disable file watching - THIS FIXES THE ISSUE
ENV DOTNET_USE_POLLING_FILE_WATCHER=false
ENV ASPNETCORE_ENVIRONMENT=Production

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "CSharpMasteryHub.dll"]