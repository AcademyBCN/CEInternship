# INTERNSHIP CLOUD ENGINEERING TECHNICAL SCENARIO 
## Introduction 
This exercise provides an opportunity for you to display your problem-solving and coding skills. During your interview, we would like you to present your solution, explain your approach, and highlight any noteworthy aspects of your code. The goal is not to find a right or wrong answer, but to understand your development skills, problem-solving strategies, and ability to discuss the advantages and disadvantages of your approach. Please ensure you read all the instructions before you begin.

To resolve this problem, no previous experience with the technologies used is required. We have ensured that you also have access to useful documentation.

If you haven't had the opportunity to work with Azure Functions or JSON before, don't worry! We understand that everyone comes from different backgrounds and experiences. Below are some beginner-friendly tutorials that can help you get started:
-	[Run a C# Azure function using Visual Studio locally](https://learn.microsoft.com/en-us/azure/azure-functions/functions-create-your-first-function-visual-studio) 
    - If you have not used Azure Functions before, we strongly suggest you watch the introductory video within the tutorial and create one from scratch (no Azure subscription is required).
    - You should ignore from the *“Publish the project to Azure”* section.
-	[How to write .NET objects as JSON (serialize)](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/how-to)
-	[How to customize property names and values with System.Text.Json](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/customize-properties?pivots=dotnet-8-0)
-	[How to read JSON as .NET objects (deserialize)](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/deserialization)
 
## Scenario 
We are developing an Azure Function that retrieves information about the Star Wars universe. We have already developed the first endpoint and need your assistance in completing the subsequent endpoints. The Azure Function is being developed in C#, and we are sourcing the information from the Star Wars API. 
### Tasks 
Please complete the following tasks:
-	**Film Endpoint**: Develop an endpoint that returns all the films, sorted by release date. The endpoint should return a JSON object with the following information:
    - Title
    - Episode number
    - Director
    - Producer
    - Release date

Example of JSON response
```
[
  {
    "title": "A New Hope"
    "episode_number": 4,
    "director": "George Lucas"
    "producer": "Gary Kurtz, Rick McCallum" ,
    "release_date": "1977-05-25"
  },
  {
    ...
  },
  ...
]
```
 

-	**Character Endpoint**: Develop an endpoint that returns information about a character when its ID is specified. The endpoint should return a JSON object which contains the properties of the character, specifying as well:
    - The home world’s name
    - The names of all the movies they appear in
    - The species name
    - Their vehicles’ names
    - The names of all the starships they have been associated with

Example of JSON response
```
{
  "name": "Luke Skywalker",
  "hair_color": "blond",
  "height": "172",
  "mass": "77"
  "homeworld": "Tatooine"
  "films": [
    "A New Hope",
    "The Empire Strikes Back",
    "Return of the Jedi",
    "Revenge of the Sith"
  ],
  "species": [],
  "vehicles": [
    " Snowspeeder",
    "Imperial Speeder Bike"
  ],
  "starships": [
    "X-wing",
    "Imperial shuttle"
  ]
}
```


### Additional Tasks 
Once the mandatory tasks are completed, consider the following enhancements:
-	Develop an additional endpoint that could be beneficial for the API users.
-	Implement logging for all actions taken in each endpoint, such as each API call. Save these logs into a file, ensuring the start and end times are recorded.
## Considerations
There is no need to deploy your solution; you can demonstrate it running on your local machine during the interview.
-	Where implementation details are not specified, you have the freedom to decide your approach.
-	During the interview, we will discuss your solutions and explore your approach to the tasks.
-	We do not expect your code to be perfect. Your code will serve as a basis for our discussion, and we are interested in understanding your approach to coding solutions.
-	There is no need to prepare a slide presentation unless you prefer to do so.
