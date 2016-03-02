FROM microsoft/aspnet:1.0.0-rc1-update1-coreclr

MAINTAINER Maurice de Beijer <maurice.de.beijer@gmail.com>

COPY ./project.json ./app/
 
WORKDIR ./app
RUN dnu restore

COPY . ./app

EXPOSE 5000

CMD ["--server.urls", "http://*:5000"]
ENTRYPOINT ["dnx", "web"]
