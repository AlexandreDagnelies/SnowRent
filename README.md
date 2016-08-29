There are two ways to use this application.

1 - Start your Wampserver, and change the password for the root user "root". 
	Restart your mysql server and run "SnowRent.exe"

2 - Open the file "SnowRent.sln" in your Visual Studio. 
	Go to the file "SnowRentLibrary/Enums/DataConnectionResource.cs"
	Change the value of Uid and Pwd in both places by User and Password of your db server.
	Warning the user chooses must have the right to create and modify a database and its tables.
	Start the solution directly into Visual Studio or generate an executable to use this application.
