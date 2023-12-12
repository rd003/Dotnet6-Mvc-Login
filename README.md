# Dotnet6-Mvc-Login

👉 Now upgraded to .net 8.0

# How to run it 🐺
1. clone the project
   `https://github.com/rd003/Dotnet6-Mvc-Login.git`
2. open `appsettings.json` file and update connection string's

    "ConnectionStrings": { "conn": "data source=your_server;initial  catalog=Dotnet6MvcLogin;integrated security=true;TrustServerCertificate=True;encrypt=false" }

3. Delete `Migrations` folder
4. Open Tools > Package Manager > Package manager console
5. Run these 2 commands
    ```
     (i) add-migration init
     (ii) update-database
     ````
6. Now you can run this project

## Admin registration 💻

- Uncomment the `RegisterAdmin` method in `UserAuthenticationController`
- Run the project and hit the url `https://localhost:7198/UserAuthentication/RegisterAdmin`
- Login with these credentials `username: admin, password: Admin@12345#`
