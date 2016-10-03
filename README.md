# Project - MVC WebAPI & AngularJS

      __                 __     _      ___           
      \ \ _ __ _ __   /\ \ \___| |_   /   \_____   __
       \ \ '__| '_ \ /  \/ / _ \ __| / /\ / _ \ \ / /
    /\_/ / |  | |_) / /\  /  __/ |_ / /_//  __/\ V / 
    \___/|_|  | .__/\_\ \/ \___|\__/___,' \___| \_/  
              |_|                                    
    

###Purpose: 

Display a list of holiday attractions so users can search and add them to their Favourite list. 
They can then view their current list of favourites and remove them from this list if they wish.

They can also search, filter by continent and order attractions by title, price and country.


###Features:

 - Form Validation for Contact Page - Does not send email (Mailservice) but will return success if the fields are valid.
 - Uses Ninject (MVC5 & WebApi) as IoC container for Dependency Injection (constructor Injection).
 - Mobile and tablet friendly, responsive design - automatically adjusts layout.

###Database Set Up Instructions:

 - Default connection in Web.config - (localdb)/ProjectsV13 - ensure able to connect to (localdb) in SQL Server Explorer, or change connection string to your desired server.

 - Ensure migrations enabled for solution by running 'Enable-Migrations' on Package Manager Console.

 - Run 'Update-Database' on Package Manager Console to create and seed Database.

 - Run the application.

###Please Note:

 - Uses CDN to load a few scripts so you'll need to be connected to Internet for them to load properly.

 - If you experience any layout, format issues on the initial application start or page load, please just reload the tab/ page (F5 in browser).

###ToDo:

 - Pagination
 - Login & Register
 - Jasmine JS unit tests
 - NUnit .Net Unit tests

###Developed Using:
 - Visual Studio 2015 Community Edition (Update 3)
 - Web Essentials 2015.3
 - Resharper 10 (2016.2)
 - ASP.NET MVC, Entity Framework 6, HTML5
 - Angular 1.5x
 - Bootstrap (BootStrapWrap - AppStrap theme - Responsive design - Mobile/Tablet friendly)