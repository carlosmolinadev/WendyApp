# WendyApp
## Requirements

- Framework DotNet 5 [download here](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)
- Do you want to use VSCode? [watch this video](https://www.youtube.com/watch?v=FfZu7jNk-2I)

## Pre-Build solution

Change connection string to your database in `WendyApp/Server/appsettings.json` in the server project

(Make sure to create WENDY scheme first and drop all the tables in database, Update-Database will recreate the DB based on the context mapping)

- Configure database user
```sql
ALTER USER WENDY quota unlimited on USERS;

GRANT all privileges TO WENDY;
```

- Go to Server directory 

`cd ./WendyApp/Server/`

- Install Dotnet ef [Learn more...](https://docs.microsoft.com/en-us/ef/core/cli/dotnet)


`dotnet tool install --global dotnet-ef`

Run the Package Manager console and run the following commands

- Drop-Database (Confirm to drop database)

`nuget ef database drop`

- Add-Migration (If you want to add another migration use this command)

`nuget ef migrations add migrationName`

- Update-Database (This will take the latest migration and update database)

`nuget ef database update`

## Run project

- Execute `dotnet run`
- Open in your browser: https://localhost:5001/swagger