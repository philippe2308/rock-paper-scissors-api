# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy and restore project files
COPY rock-paper-scissors-api.csproj .
RUN dotnet restore

# Copy the entire project and build
COPY . .
RUN dotnet publish -c Release -o out

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

# Expose port 80
EXPOSE 8080

# Set the entry point for the container
ENTRYPOINT ["dotnet", "rock-paper-scissors-api.dll"]