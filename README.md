# Local Businesses API

#### By _**Phil Curran**_

#### A queryable REST-ful API for local businesses, built with C# / .Net / Swagger.

## Technologies Used

* C#
* .Net 6.0
* MySql 8.0 & MySql Workbench
* Swagger

## Description

This API is a RESTful API for local businesses.  
You can enter business details like name, address, phone number, website address, and others, and query the API for any of the available data for each business.

## Setup/Installation Requirements

* Install or Update MySql to version 8.0
* Install or Update .net to 5.0
* Clone the repo: [link](https://github.com/phil-curran/BusinessLookup)
* Create an <code>appsettings.json</code> file in your root directory and add the following code:

```json
{
  "ConnectionStrings": {
    "ConnectionString": "server=localhost;user id=[ user id ];password=[ user password ];port=3306;database=[ database name ];"
  }
}
```
* Update the appsettings.json file by replacing the <code>[ user id ]</code> and <code>[ user password ]</code> above with your MySql user id and password, and a preferred database name in <code>[ database name ]</code>
* Navigate to the root directory of the project
* Create an initial database migration for the project: <code>dotnet ef migrations add InitialCreate</code>
* Update the database: <code>dotnet ef database update</code>
* Use MySql Workbench to verify that the database table has been created
* Install dependencies: <code>dotnet restore</code>
* Build & check for errors: <code>dotnet build</code>
* Run the project: <code>dotnet watch run</code>
* Check out the API with [Swagger](https://localhost:5001/swagger/index.html)

## Using the API

Endpoints are documented on the Swagger page and include:

### GET: /api/Businesses
* GETs all of the businesses in the database

### POST: /api/Businesses
* POSTs a new business entry to the database

### GET by Business Id: /api/Businesses/{id}
* GETs a specific business entry by id

### PUT by Business Id: /api/Businesses/{id}
* PUTs a specific business entry by id
* Requires a JSON payload with all fields in the model

### DELETE by Business Id: /api/Businesses/{id}
* DELETEs a specific business entry by id

## Known Bugs

* None

## Contact Me

Let me know what you think! pecurran@hotmail.com

## License

_MIT_

Copyright (c) 2022 / Phil Curran
