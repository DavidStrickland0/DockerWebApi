# DockerWebApi
This is a basic webapi in a docker container requested as an example of code written to meet a specific set of requirements.

The original directions were as follows

## _Developer Test_

_The test is not meant to be a pass/failure, but rather to gauge the candidates strengths and weaknesses, specifically in the area of full stack Java development. Candidates will be considered based on their programming response and also their deliverables._

_Goal_

_Build a Restful Service written in Java or Groovy with the following endpoints:_

_GET : http://<server_url>/math/add?n1=<numeric param 1>&n2=<numeric param 2>_

_This should add numbers 1 and 2 and provide the result in JSON_


_POST : http://<server_url>/math/add	(allow for form params 1&2 in a POST body)_

_This should add two numbers from a POST body_


_GET : http://<server_url>/time/now_

_This should fetch time for MST at time of call from another service (https://www.developer.aero/WaitTime-API/Try-it-Now for YYC is a free one) and simplify the result to timezone and current time.  Return the result or the timestring in a rational JSON document._

_The service must be built using the following technologies:_

_Spring Boot_
_Gradlew (build)_
_Git (source control)_

_Please provide a Dockerfile using alpine linux:_

_Docker (optional - see below)_


## Deviations
Took a couple deviations from the defined requirements. 
First is the quite obvious deviation that I used C# instead of Java thus not using Spring Boot and Gradle. 

The provided Docker File is also a windows Docker instead of a alpine Linux docker file mostly because I cant seem to get linux to run on my system currently. Seems to be the known bug about passwords with funcky characters and didnt really want to change my password just for this sample app.

Didnt get to the Integration tests. The Logic is seperated out so Unit Tests would be fairly easy to add but didnt get it done spent to much time fighting with Docker trying to get a linux image to work. 

## Running the Sample
This sample has a AspNetCore 2.0 Docker config file. Download the code.

 cd dockerwebapi

 docker build -t dockerwebapi .

 docker run -it --rm --name DockerWebApi dockerwebapi

 docker exec DockerWebApi ipconfig

 !Record the IP Address!
  
  Open your browser and navigate to http://recordedIpAddress/swagger
  
## Some Considerations

The time endpoint likely should be cached or we could end up beating the third parties api to death. However that depends on why we are using a third party time source instead of just doing it locally. If the offset between thier time and the server time truely is that important then we could get the offset between the server time and the rest call time and then just do the math locally for the timezone and add the offset. Only going out a few times a minute to recalculate the offset. Would need more details on why this is being requested before I would be able to derive the best caching solution... if any.

Whether we secure this API with an API key and a registration system would be a business decision. Adding a Key raises the commitment bar but provides a way to perform throttling however if the APIKey registration process is to easy it can just be automated and throttling by key becomes meaningless since a new key is easy to programtically get. A robust ApiKey issue process is likely going to be harder to build and maintain then the API at this point so in the end more information would be needed to derive whether an APIKey is needed or justified.
