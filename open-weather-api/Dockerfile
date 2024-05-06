# Baseado em https://github.com/dotnet/dotnet-docker/blob/main/samples/README.md
# Primeiro estágio: Construção
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiar arquivos csproj e restaurar como camadas distintas para melhor aproveitamento do cache
COPY ["openweatherapi/openweatherapi.csproj", "openweatherapi/"]
COPY ["openweatherapplication/openweatherapplication.csproj", "openweatherapplication/"]
COPY ["openweatherdomain/openweatherdomain.csproj", "openweatherdomain/"]
COPY ["openweatherinfrastructure/openweatherinfrastructure.csproj", "openweatherinfrastructure/"]
COPY ["openweathercommon/openweathercommon.csproj", "openweathercommon/"]
RUN dotnet restore "openweatherapi/openweatherapi.csproj"

# Copiar os arquivos do projeto e publicar
COPY . .
WORKDIR "/src/openweatherapi"
RUN dotnet publish -c Release --no-restore -o /app/publish

# Segundo estágio: Configuração do ambiente de execução
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

# Exposição das portas (HTTP e HTTPS)
EXPOSE 5000
EXPOSE 5001

# Copiar o certificado de desenvolvimento para o contêiner
COPY --from=build /src/openweatherapi/cert/development_certificate.pfx /app/cert/

# Configurar variáveis de ambiente para o Kestrel usar o certificado HTTPS
ENV ASPNETCORE_Kestrel__Certificates__Default__Path="/app/cert/development_certificate.pfx"
ENV ASPNETCORE_Kestrel__Certificates__Default__Password="123456"

# Copiar os arquivos publicados do estágio de construção
COPY --from=build /app/publish .

# Configurar o ponto de entrada da aplicação
ENTRYPOINT ["dotnet", "openweatherapi.dll"]
#ENTRYPOINT ["bash"]