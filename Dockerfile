FROM microsoft/dotnet:3.1-sdk
WORKDIR /test-app/

COPY /CRUD/*.csproj ./
RUN dotnet restore

COPY . ./test-app
RUN dotnet build -c Release
ENTRYPOINT ["dotnet", "run", "-c", "Release", "--no-build"]