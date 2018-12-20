FROM microsoft/dotnet:2.2-sdk AS build-env
WORKDIR /app

COPY *.csproj .
RUN dotnet restore

COPY . .
RUN dotnet publish -c Release -o /out

FROM microsoft/dotnet:2.2-aspnetcore-runtime
COPY --from=build-env /out .

EXPOSE 5000/tcp

ENTRYPOINT ["dotnet", "WebApi.dll"]