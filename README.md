# BobsStoreSln
Student Project demo based on the Pro ASP.NET book by Adam Freeman.

## Create Solution and Projects

    dotnet new globaljson --sdk-version 3.1.101 --output BobsStoreSln/OutdoorProducts
    dotnet new web --no-https --output BobsStoreSln/OutdoorProducts --framework netcoreapp3.1
    dotnet new sln -o BobsStoreSln
    dotnet sln BobsStoreSln add BobsStoreSln/OutdoorProducts 
    dotnet new xunit -o BobsStoreSln/OutdoorProducts.Tests --framework netcoreapp3.1
    dotnet sln BobsStoreSln add BobsStoreSln/OutdoorProducts.Tests 
    dotnet add BobsStoreSln/OutdoorProducts.Tests reference BobsStoreSln/OutdoorProducts

## Screenshots

![image](https://github.com/HedgeHodge/BobsStoreSln/blob/master/OutdoorProducts/Capture1.PNG?raw=true)
![image](https://github.com/HedgeHodge/BobsStoreSln/blob/master/OutdoorProducts/Capture2.PNG?raw=true)
![image](https://github.com/HedgeHodge/BobsStoreSln/blob/master/OutdoorProducts/Capture3.PNG?raw=true)
![image](https://github.com/HedgeHodge/BobsStoreSln/blob/master/OutdoorProducts/Capture4.PNG?raw=true)
