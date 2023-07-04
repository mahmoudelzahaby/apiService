#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# Stage 1: Build the application
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# Copy and restore dependencies
COPY ["salemVentures.csproj", "salemVentures/"]
RUN dotnet restore "salemVentures/salemVentures.csproj"

# Copy the rest of the source code and build
COPY . .
WORKDIR "/src/salemVentures"

# Add a sample Main method to avoid build errors
RUN echo "class Program { static void Main(string[] args) { } }" > Program.cs

# Build the application
RUN dotnet build "salemVentures.csproj" -c Release -o /app/build

# Stage 2: Publish the application
FROM build AS publish
RUN dotnet publish "salemVentures.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Stage 3: Final runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS final
WORKDIR /app

# Copy the published output from the previous stage
COPY --from=publish /app/publish .

# Expose the necessary ports
EXPOSE 80
EXPOSE 443

# Set the entry point to start the application
ENTRYPOINT ["dotnet", "salemVentures.dll"]


