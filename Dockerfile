FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY CSharpMasteryHub/CSharpMasteryHub.csproj ./CSharpMasteryHub/
RUN dotnet restore ./CSharpMasteryHub/CSharpMasteryHub.csproj
COPY . .
WORKDIR /src/CSharpMasteryHub
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "CSharpMasteryHub.dll"]