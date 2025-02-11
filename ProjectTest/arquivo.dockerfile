# Use a imagem oficial do .NET SDK como base para o build
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

# Defina o diretório de trabalho
WORKDIR /app

# Copie o projeto e restaure as dependências
COPY . .
RUN dotnet restore

# Compile o projeto
RUN dotnet build -c Release -o /app/build

# Publique a aplicação
RUN dotnet publish -c Release -o /app/publish

# Use a imagem oficial do .NET runtime para executar o app
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS final

WORKDIR /app

# Exponha a porta 80 para a aplicação
EXPOSE 80

# Defina o ponto de entrada para o .NET
ENTRYPOINT ["dotnet", "ProjectTest.dll"]
