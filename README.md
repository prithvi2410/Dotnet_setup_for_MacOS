Welocome to My Github Repo Dotnet_setup_for_MacOS :)

THIS IS A SAMPLE DOTNET CORE WEB API PROJECT WITH SQL SERVER(DOCKER). THIS IS TO SETUP THIS ON A MACOS
*******************************************************************************************************

We all know that .NET CORE is a cross-platform(ie: runs natively on all OS) but the problem is with SQL SERVER and legendary SSMS,these only run on WINDOWS OS :(

If you are a mac user, no worries..we have a alternative solution to that.

We are going to replace these with,
SQL SERVER -> Containarised SQL SERVER image in Docker
SSMS       -> Azure Data Studios

Prequsites:(Download and install)
1. Docker Desktop
2. Azure Data Studios

Docker Setup:
*************
Run the below command in the mac tereminal:
docker run -e "ACCEPT_EULA=1" -e "MSSQL_SA_PASSWORD=Password@123" -e "MSSQL_PID=Developer" -e "MSSQL_USER=SA" -p 1433:1433 -d --name=sql mcr.microsoft.com/azure-sql-edge

Check you docker desktop, it should have a SQL SERVER container which is up and running.

Azure Data Studio Setup:
*************
1. Click New -> New Connection
2. Server name -> localhost
3. Authentication type -> SQL LOGIN(Default)
4. Username -> SA
5. Password -> Password@123

Thats it! you have created a base setup for SQL server and Azure Data Studios

//TL;DR
//What this does?


