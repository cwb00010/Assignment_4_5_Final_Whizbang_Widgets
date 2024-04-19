# Project Overall README

## Assignment 4 API's README

### 1. Add A Seed (`spInsertSeed`) (Will Bruton)

This page allows users to input data about the seeds they use and observations regarding them. Users can provide a seed ID, seed name, and ideal planting temperature. They can also specify if the seed performs differently at various temperatures and provide other ideal temperatures for the seed. The output would be that a seed entity was created and added to the database. 

### 2. Find a User (`spGetUserDetailsByCity`) (Will Bruton)

This page enables users to search for other users based on city. Users would perform this by adding in a CityID. The return would be UserID's, Usernames, and their farm type. For example, users can search for farmers in Billings, Montana by inputting the CityID and finding out what users are farming in that area.

### 3. Add a City (`spInsertCity`)(Austin Bartley)

Users can use this page to add a city that is not already in the system. For instance, a user living in ThatSmallTown, ZipCode, BigState, CoolCountry, can add their city into the system to provide more data for the site.

### 4. Create a Profile (`spInsertUser`)(Austin Bartley)

This page allows users to insert their details to create a profile for themselves within the application. They can create a username and provide details regarding their farm and location. Address-related information is only as specific as the city to protect users' privacy.

### 5. Add a Hurricane (`spInsertHurricane`)

Users can add details about a hurricane in their area on this page. The information can later be used to analyze hurricane trends in the area. Hurricanes would be identified by an ID number and a name.

### 6. Add a Tornado (`spInsertTornado`)

Similar to the Hurricane page, users can add a tornado to the application occurring in their area. The tornado would be associated with a tornado ID number and its respective category/size. Tornadoes typically do not have names.

### 7. Weather Data (External API connecting Weather Info)

An external API connects to the basic weather page to provide weather data and information for the area. Users can view the weather for the area similar to a normal weather app.

## Assignment 5 Razor Pages README

### 1. Privacy Page (Will Bruton)

This page just provides a basic privacy policy for the site that users can have access to and read. Here users can be aware of the policy at all times and can protect both us and the user. 


### 2. Users Page (Will Bruton)

The goal of this page is to provide a page where users can look at a list of other users based on CityID, username, and farm type. Depending on the amount of users this lsit could be massive. The hope would be to add some sort of filter system for users to limit the results.


### 3. Add City Page (Austin Bartley)

This page allows users to add a city. It inludes a form with inpit fields for the city name, state, and country. After the fact it displays a message and re direts the user back to the same page.


###4 Greetings page (Austin Bartley)

This page is very simple. It greets the users with a message depending on the time of day. I wanted to add this to be more welcoming in our website.



## Final Overall README

### Description

This application aims to establish a platform where farmers can access weather forecasts, climate patterns, and planting advice. Additionally, it facilitates content generation through forum posts and enables users to contribute new data to the site's database. The aim is to develop a nationwide, and eventually global, community where farmers can engage with one another and swiftly access pertinent information.

### Deployment Guide

#### SQL Server Management Studio

Start by opening a new file in SQL Server Management Studio. From there go to this link (https://github.com/cwb00010/Assignment_3_WhizBang_Widgets/tree/main). Here you will find the code you need to create the database. You can either clone this repository or you can go individually and copy and paste over. You can start with DBCreation.sql followed by InsertDataClean. From there, you can go through each of the posted stored procedures. After completing these steps, you can move to visual studios to start creating the site itself. For any documentation on this section, check in the README file listed. It will give more details as to what the contents include.

#### Visual Studios 2022

Start by creating a new project in Visual Studios. Visual Studios will give you many of the basic pages and tools you need to start. From there go to this link (https://github.com/cwb00010/Homework2Bruton/tree/master/Homework2Bruton). In this repository, you will find the code needed to create the various pages like the home page. Along with those pages, you will have the basic starter pages that are provided in the initial creation of the project. Like in the previous section, there is a README that breaks down the various self-created pages, research, citations, and more for users to read. 

From this point, you can start work on the API creation based on the stored procedures you created in SQL Server. To start, will create a joint project within the previous one you created. For example, the first project is called the FarmMaxSite. This next project is called FarmMaxSiteAPI. At this link (https://github.com/cwb00010/Assignment_4_5_Final_Whizbang_Widgets), you will find all of the final code you need to create your APIs along with any code needed to create your razor pages. Like before, it will contain code that will be provided upon creation.  Each of the developers worked on two of the API's and two razor pages. You will find their code in their respective folders. The data, entities, controllers, properties, razor pages, and repositories need to be created yourself using C#. The order is not as important as long as all these pages are connected correctly. The README will also have documentation for the APIs and the pages. 

#### Short Falls to Avoid | Need to Know

When creating this make sure you maintain organization within your projects. This will make creation easier along with easier navigation among your code. If working with others, make sure you have consistent communication among your other developers. Try to make sure all your code is unified and similar in coding style. Also, know that this is a major work in progress. It does not work perfectly and still throws errors here and there throughout. Everything prior to API creation should be in good shape. After that, there was trouble with API creation and coding after. 

### Contact Info

We are more than happy to answer any questions in regards to the applications and its coding. 
To contact us please reach out at these emails:
Will Bruton|cwb00010@mix.wvu.edu
Austin Bartely|agb00017@mix.wvu.edu
Dylan Bryson|db00069@mix.wvu.edu
