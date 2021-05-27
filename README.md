# Sample demonstration of [WebAPI](https://www.tutorialsteacher.com/webapi/what-is-web-api) in [.NET Core](https://www.tutorialsteacher.com/core/dotnet-core), as explained in [this tutorial by Microsoft](https://docs.microsoft.com/en-us/learn/modules/build-web-api-aspnet-core/)

# We have a website serving pizzas

## A pizza has 4 fields:
- **ID** is the id we use to identify it
- **Name** is name of the pizza ("pepperoni", "margarita", etc.)
- **Calories** stores how many calories this pizza has
- **Price** is the price of one portion 

## We have a website serving pizzas. We can create, read, update and delete pizzas from our website
- **GET** request at *api/pizza* returns all existing pizzas
- **GET** request at *api/pizza/{id}* returns pizza with given *id*
- **POST** request at *api/pizza* takes in *name*, *calories*, *price*, and optional *id* of the new *Pizza* object and stores it
- **PUT** request at *api/pizza/{id}* assigns new *name*, *calories*, and *price* to the *Pizza* object with id of *id*
- **DELETE** request at *api/pizza/{id}* deletes the *Pizza* object with id of *id*