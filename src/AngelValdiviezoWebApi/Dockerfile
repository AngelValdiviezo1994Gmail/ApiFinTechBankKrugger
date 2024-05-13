##See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.
#
#FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
#WORKDIR /app
#EXPOSE 80
#EXPOSE 443
#
#FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
#WORKDIR /src
#COPY ["src/WebEnrolAppApi/WebEnrolAppApi.csproj", "src/WebEnrolAppApi/"]
#COPY ["src/Application/Application.csproj", "src/Application/"]
#COPY ["src/Domain/Domain.csproj", "src/Domain/"]
#COPY ["src/Persistence/Persistence.csproj", "src/Persistence/"]
#RUN dotnet restore "src/WebEnrolAppApi/WebEnrolAppApi.csproj"
#COPY . .
#WORKDIR "/src/src/WebEnrolAppApi"
#RUN dotnet build "WebEnrolAppApi.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "WebEnrolAppApi.csproj" -c Release -o /app/publish
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "WebEnrolAppApi.dll"]

# Usa la imagen base de .NET Core para construir la aplicación
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env

# Establece el directorio de trabajo en /app
WORKDIR /app

# Copia el archivo .csproj y restaura las dependencias
COPY *.csproj ./
RUN dotnet restore

# Copia el resto del código y compila la aplicación
COPY . ./
RUN dotnet publish -c Release -o out

# La segunda etapa del Dockerfile usa una imagen más ligera de ASP.NET Core para reducir el tamaño final de la imagen
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "AngelValdiviezoWebApi.dll"]
