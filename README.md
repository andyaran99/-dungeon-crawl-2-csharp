# Dungeon Crawl 

## Premise

My task was to create a roguelike. I deviate from the rules below. Roguelikes are one of the oldest types of video games. The earliest ones were made in the 70s, and they were inspired a lot by tabletop RPGs. Roguelikes usually have the following features in common.

-They are tile-based.
-The game is divided into turns, that is, you take one action, then the other entities (monsters, allies, and so on, controlled by the CPU) take one.
-The task is usually to explore a labyrinth and retrieve some treasure from its bottom.
-They feature permadeath: if you die, it's game over, you need to start from the beginning again.
-They rely heavily on procedural generation: Levels, monster placement, items, and so on are randomized, so the game does not get boring.





## What I learned?

- Get more practice in OOP.
- Understand design patterns: layer separation. (All of the game logic, such as player movement, game rules, and so on), is in the logic package, completely independent of user interface code. In principle, you could implement a completely different interface, such as terminal, web, Virtual Reality, and so on, for the same logic code.)
- Serialize objects.
- Communicate with databases.
- Write unit tests for your classes.
- Understand the **Data Access Object** design pattern.



## Creation process

1. Analyze the project

Understand the existing code, classes, and tests so you can make changes. Do this before planning anyything else. It helps you understand what is going on. A class diagram is created in a digialized format which contains the following.

2. Restrict movement
Create a game logic which restricts the movement of the player so they cannot run into walls and monsters.

3. Dungeon items
There are items lying around the dungeon. They are visible in the GUI.

4. Pick up items
Create a feature that allows the hero to pick up an item.

5. Show picked up items

6. Attack monsters
Make the hero able to attack monsters by moving into them.

7. Doors and keys
Create doors in the dungeon that are opened using keys.

8.Different monsters
Create three different monster types with different behaviors.

9. Better movement AI
Create a more sophisticated movement AI.

10. Allow the user to save the current state of the game in a database. Extend the given schema if needed.




## General requirements
1. Clone the repository from github
2. Install Unity
3. Open the folder containing the repository with Unity Hub 
4. Run the project



## Game Controlls
Movement: W, A, S, D;
Pick up Items: E
Open Inventory: I
Save Game: K
Load Game: L

Hint: Save and Load To eliminate tough monsters


## In Game Image
![Capture9](https://github.com/andyaran99/-dungeon-crawl-2-csharp/assets/106445157/9c32e543-dc31-458d-950f-77482a816260)



