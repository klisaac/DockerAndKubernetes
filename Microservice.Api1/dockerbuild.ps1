# publish the application first
dotnet publish -c Release

# clean up old image and any containers (running or not)
docker stop aspnet5microservice.api1
docker rm aspnet5microservice.api1 -f 
docker rmi aspnet5microservice.api1:api1

# create new image
docker build -t aspnet5microservice.api1:api1 .

# immediately start running the container in the background (-d) (no console)
docker run  -it -p 5004:80 --name aspnet5microservice.api1  aspnet5microservice.api1:api1 

# Map host IP to a domain - so we can access local SQL server
# $localIpAddress=((ipconfig | findstr [0-9].\.)[0]).Split()[-1]
#--add-host dev.west-wind.com:$localIpAddress

#docker stop aspnet5microservice.api1
#docker rm aspnet5microservice.api1

# docker exec -it aspnet5microservice.api1  /bin/bash

# # if above doesn't work
# docker exec -it aspnet5microservice.api1  /bin/sh

#docker push 
