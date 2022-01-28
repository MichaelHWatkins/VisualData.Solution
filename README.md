# _Data Reporting Application - Covid-19/USA statistics_

#### By:
* _Albert Lee_
* _Karen Axon_
* _Michael Watkins_
* _Ella Tanttu_

#### _An mvc web application that successfully displays United States Covid-19 data called from the covidactnow.com API, along with the latest relevant news articles called from NewsAPI.org._

## Technologies Used:
* _HTML_
* _C#_
* _CSS_
* _Markdown_
* _Bootstrap_
* _HtmlHelper_
* _EntityFrameworkCore_
* _Razor View Engine_
* _ASP.Net Core MVC_
* _covidactnow.com API_
* _NewsAPI.org_

## Description

This mvc application consists of three separate pages— Home, Resources, and Newsfeed. On load, the home page presents up-to-date National covid vaccine data, death statistics, and individual state data for Alaska, Colorado, Oregon, Georgia and Washington. The Resources page offers local resources for both the states of Oregon and Washington, along with federal level informational sites about masks and quarantine protocol. The final page— the Newsfeed page, displays the latest Covid-related news.

## Setup/Installation Requirements

* _Install .NET Framework_
* _Navigate to https://github.com/MichaelHWatkins/VisualData.Solution_
* _Click on the green "Code" button and copy the repository URL or click on the copy button_
* _Open the terminal on your desktop_
* _Once in the terminal, use it to navigate to your desktop folder_
* _Once inside your desktop folder, use the command "git clone https://github.com/MichaelHWatkins/VisualData.Solution"_
* _After cloning the project, navigate into it using the command `"cd VisualData.Solution"`_
* _Use the command `"git remote -v"` to confirm the creation of the new local repository_
* _Open the project with the code editor of your choice_
* _Navigate to VisualData directory and enter command `"dotnet restore"`_
* _Obtain api keys from CovidActNow and NewsApi websites by setting up accounts with each respective website._
* _In EnvironmentVariables add your api keys to the corresponding api variables._
```
   public static string ApiKey = "[YOUR-COVIDACTNOW-API-KEY-HERE]";
   public static string ApiNews = "[YOUR-NEWS-API-KEY-HERE]";
```

## Using the Application
After following the Setup/Installation steps above:
 * Navigate to the root directory.
 * Start the application in a server with the command _`"dotnet run"`_.

## Known Bugs

* _No known bugs_

## License

[MIT](https://opensource.org/licenses/MIT)

Copyright (c) 2022 Karen Axon, Albert Lee, Ella Tanttu, Michael Watkins

## Contact Information

Karen Axon: <kaxonwa@gmail.com>\
Albert Lee: <leesga8@gmail.com>\
Ella Tanttu: <ellajtanttu@gmail.com>\
Michael Watkins: <michaelhugheswatkins@gmail.com>

