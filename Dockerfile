FROM microsoft/aspnet:1.0.0-beta4
COPY /src/project.json /app/
WORKDIR /app
RUN dnu restore
COPY /src /app
EXPOSE 5004
ENTRYPOINT dnx . kestrel