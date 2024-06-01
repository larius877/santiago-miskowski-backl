# netcore-demo

This API uses a local MySQL database engine that run in a Docker container, to run the DB:

docker run --name sql-demo -e MYSQL_ROOT_PASSWORD=REDACTED -p 3306:3306 -d mysql:latest

This API uses EF Core:

Useful commands for manipulate scaffolding entities in database:

-Change example(removes color property from cars entity): 

dotnet ef migrations add RemovesColorFromCars

-To applies changes: 

dotnet ef database update

