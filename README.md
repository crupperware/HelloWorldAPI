# HelloWorldAPI

Console applicaiton will run a loop asking for you to press any key to get a greeting. 
The app will then call the API and return the Hello World Message.

The API application has 2 main layers the controller layer that exposes the available data calls and 
the service layer that does the data accesss and manipulation.

Connection to an MSSQL database could be added easily through including entity framework and then using the 
services layer to access the data from the entity frame work layer. The same could be done for other database
engines with the creation of access layers to them. 

The base URI for the connection of the console app to the API can be changed in the app.config file by modifying the 
API_BaseURI key. This will allow for the console app to connect to the API if the address changes at deployment.

The console app and the API communicate through data transfer objects. Theses mirroed classes allow for easy json or xml 
data transfer that is quickly serializable. This allows the API to expose data and have the requester conform to the 
json (or xml) received without needing to be coupled to a common package of models. 


Note if you go to the API home page it will give you a live status of the API if it is running or not running.
