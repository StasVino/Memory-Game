# Memory Game
**About**
The goal of this project is create a windowed application of a memory game, with multipul board configuration, image cards, player versus player and player vs ai.


**The Methods**

We use C# built in window form class
* GameManager - a windows form that manages the game/turns, the UI, bottoms-events, activates all other classes  
* GameLogic - the class the game is played on, stores the current game data and dectates game logic, 
* GameButton - a class inheriting a button controller, modifide to include pictures
* AILogic - in charge of Ai memory and picture picking logic

other miscellaneous classes play minor roles as game actors, such as Coordinate, player, FormGameSetup and FormGameOver  

**Results**

![image](https://user-images.githubusercontent.com/78749321/135668412-90189d95-3538-438b-834f-a9147a3bbb8b.png)
![image](https://user-images.githubusercontent.com/78749321/135668279-9c590ebe-c842-4f0a-8571-f67b0c22612b.png)
