FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 53445
EXPOSE 44387

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["GoCD_Poc.Api/GoCD_Poc.Api.csproj", "GoCD_Poc.Api/"]
RUN dotnet restore "GoCD_Poc.Api/GoCD_Poc.Api.csproj"
COPY . .
WORKDIR "/src/GoCD_Poc.Api"
RUN dotnet build "GoCD_Poc.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "GoCD_Poc.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "GoCD_Poc.Api.dll"]