<!--
*** Thanks for checking out this testproject
-->

<!-- TABLE OF CONTENTS -->
## Table of Contents

* [About the Project](#about-the-project)
  * [Built With](#built-with)
* [Getting Started](#getting-started)


<!-- ABOUT THE PROJECT -->
## About The Project

### Built With
* [Miscrosoft Visual studio 2019 community edition](https://visualstudio.microsoft.com/vs/community/)
* [Target Framework: .NET Core 3.1]
* [Microsoft.NET.Test.Sdk 16.4.0]
* [NUnit 3.12.0]
* [NUnit3TestAdapter 3.15.1]
* [SpecFlow 3.4.3]
* [SpecFlow.Assist.Dynamic 1.4.2]
* [SpecFlow.NUnit 3.4.3]
* [SpecFlow.Tools.MsBuild.Generation]


<!-- GETTING STARTED -->
## Getting Started

To get a local copy up and running follow these simple steps.

1. Get a free API Key and token from Trello at [https://trello.com/app-key](https://trello.com/app-key)
and follow the instructions to create an account and get the key and token.

2. After you logged in with your credentials in your new account on Trello, create a board with the name: Rein Test Knab 

3. Open Visual studio and click under File menu: Clone repository

4. In the popup screen provide this url:
```
https://github.com/ReinLun/ReinTestKnab.git
```
5. Check your source location (the folder where it will be saved) and click on: Clone

6. Open the cloned solution in Visual studio

7. Double click WorkWithCardsOnTrelloSteps.cs in the solution explorer

8. Enter your API key and token in the next 2 fields:
```
public static string ApiKey = "Vul hier de APIKey in";
public static string Token =  "Vul hier het Token in";

```

9. Save the class.

10. Open the Test explorer and run the test

