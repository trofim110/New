FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["one/one.csproj", "one/"]
RUN dotnet restore "one/one.csproj"
COPY . .
WORKDIR "/src/one"
RUN dotnet build "one.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "one.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "one.dll"]
