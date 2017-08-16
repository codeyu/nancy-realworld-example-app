FROM microsoft/dotnet:1.1.2-runtime-nanoserver
MAINTAINER codeyu

WORKDIR /app
COPY src/NancyRealWorld/bin/Release/netcoreapp1.1/win10-x64/ .

VOLUME C:/output
ENTRYPOINT ["dotnet", "NancyRealWorld.dll"]