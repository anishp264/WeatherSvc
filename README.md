# WeatherSvc

To containerize an asp.net application:

Install the following Nuget: Microsoft.VisualStudio.Azure.Containers.Tools.Targets

After Installing Nuget, build solution, right click on Project and select Docker Support,
select windows as OS and then the Docker file gets created automatically


docker images
cls for clear on powershell


Docker file name shall be in lower case
docker build -t weatherservicedocker:v1 -f Dockerfile . 

to run:
docker run -it --rm -p 8080:80 weatherservicedocker:v1


refer following youtube channel: https://www.youtube.com/watch?v=YWXdl68XY7U


docker build -t weatherservicedocker:v1 -f Dockerfile . 


http://localhost:8080/WeatherForecast



WeatherSvcTests


docker run --name weatherservicetestcontainer weathersvctests