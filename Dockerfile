  
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS development
WORKDIR /app
COPY src .
RUN dotnet publish -c Release -o out
CMD ["dotnet", "watch", "run"]


FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=development /app/out .
COPY entrypoint.sh /
RUN chmod +x /entrypoint.sh
EXPOSE 80
ENTRYPOINT /entrypoint.sh