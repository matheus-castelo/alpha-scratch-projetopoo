# Etapa de build: utiliza a imagem do .NET 8 SDK para restaurar, compilar e publicar a aplicação
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Copia o arquivo csproj e restaura as dependências
COPY *.csproj ./
RUN dotnet restore

# Copia os demais arquivos e publica a aplicação
COPY . ./
RUN dotnet publish -c Release -o out

# Etapa final: utiliza a imagem do .NET 8 ASP.NET Core para rodar a aplicação
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Define a variável de ambiente para utilizar a porta 5000
ENV ASPNETCORE_URLS=http://+:5000

# Copia os arquivos publicados da etapa de build
COPY --from=build-env /app/out ./

# Instala o utilitário sqlite3 (se necessário para uso em runtime)
RUN apt-get update && apt-get install -y sqlite3 && rm -rf /var/lib/apt/lists/*

# Define o entrypoint da aplicação (ajuste "YourAppName.dll" para o nome correto do seu projeto)
ENTRYPOINT ["dotnet", "FFCE.dll"]
