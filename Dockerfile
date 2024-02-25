FROM mcr.microsoft.com/dotnet/sdk:8.0 
COPY . /app
WORKDIR /app

CMD ["dotnet", "ef", "database", "update", "&&", "dotnet", "run"]


