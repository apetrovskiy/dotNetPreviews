FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY WebAppCore21Preview2/WebAppCore21Preview2.csproj WebAppCore21Preview2/
RUN dotnet restore WebAppCore21Preview2/WebAppCore21Preview2.csproj
COPY . .
WORKDIR /src/WebAppCore21Preview2
RUN dotnet build WebAppCore21Preview2.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish WebAppCore21Preview2.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "WebAppCore21Preview2.dll"]
