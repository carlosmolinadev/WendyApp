WendyApp

Framework DotNet 5

Build solution

Change connection string to your database in appsettings.json in the server project

(Make sure to create WENDY scheme first and drop all the tables in database, Update-Database will recreate the DB based on the context mapping)
Run the Package Manager windows and run the following commands

Add-Migration (Nombre de su migracion)

Update-Database
  
Run project and go to the following URL to test the endpoints: https://localhost:5001/swagger or change your port depending where the app will run

