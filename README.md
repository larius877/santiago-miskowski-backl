# netcore-demo

## This API uses a local MySQL database engine that run in a Docker container, to run the DB use the following command:

docker run --name sql-demo -e MYSQL_ROOT_PASSWORD=REDACTED -p 3306:3306 -d mysql:latest


## This API utilizes EF Core and is launched via IISExpress in Visual Studio 2022. Useful commands for manipulating scaffolding entities in the database:

Initial create example:

dotnet ef migrations add InitialCreate

dotnet ef database update

Change example(removes color property from cars entity): 

dotnet ef migrations add RemovesColorFromCars

dotnet ef database update


