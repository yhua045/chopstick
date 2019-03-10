FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY src/*.csproj ./api/
WORKDIR /app/api
RUN dotnet restore

# copy everything else and build app
COPY src/. .
WORKDIR /app/api
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS runtime
WORKDIR /app
COPY --from=build /app/api/out ./
ENTRYPOINT ["dotnet", "Chopstick.dll"]