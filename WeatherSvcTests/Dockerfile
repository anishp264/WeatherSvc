# Use the official .NET Core SDK image to build the test project
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

# Copy the test project file and restore dependencies
COPY ["WeatherSvcTests.csproj", "."]
RUN dotnet restore "WeatherSvcTests.csproj"

# Copy the necessary test project files
COPY . .

# Build the test project
RUN dotnet build "WeatherSvcTests.csproj" -c Release -o /app/tests

# Set the working directory to the test project output
WORKDIR /app/tests

# Run the tests and generate the coverage report
ENTRYPOINT ["dotnet", "test", "WeatherSvcTests.csproj", \
           "--logger:trx", \
           "--results-directory:/app/tests/TestResults", \
           "/p:CollectCoverage=true", \
           "/p:CoverletOutput=/app/tests/TestResults/", \
           "/p:CoverletOutputFormat=cobertura"]
