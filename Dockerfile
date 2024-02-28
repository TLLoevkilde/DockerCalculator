FROM mcr.microsoft.com/dotnet/sdk:8.0

COPY . /app
WORKDIR /app

RUN dotnet restore
RUN dotnet tool install --global dotnet-ef

ENV PATH="${PATH}:/root/.dotnet/tools"

CMD ["sh", "-c", "dotnet ef database update && dotnet run"]




