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


  
