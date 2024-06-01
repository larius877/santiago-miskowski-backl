# netcore-demo

This API uses EF Core:

Useful commands for manipulate scaffolding entities in database:

-Change example(removes color property from cars entity): 

dotnet ef migrations add RemovesColorFromCars

-To applies changes: 

dotnet ef database update
