FROM microsoft/dotnet:1.1
MAINTAINER codeyu

COPY src /app/src
COPY RealWorld.sln /app/RealWorld.sln
COPY NuGet.config /app/NuGet.config
WORKDIR /app

RUN dotnet restore

WORKDIR /app/src/NancyRealWorld
RUN dotnet build

VOLUME /output
ENTRYPOINT ["dotnet", "run"]