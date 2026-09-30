# Lab 3 - Multi-Window Particle Game 🎮

A C# Windows Forms game created as part of Laboratory Work No. 3.

The project demonstrates how to create a multi-window application and transfer data between the main form and a settings form.

## About the Project

The game contains a number of colored particles that randomly move around the game area.

The player must click only on particles of the winning color.

- Clicking a winning-color particle removes it from the game
- Clicking a losing-color particle ends the game
- Removing all winning-color particles results in a victory

The game also includes a separate settings window where the player can configure the game parameters.

## Features

- Multi-window Windows Forms application
- Data transfer between forms
- Random particle generation
- Random particle movement
- Two particle colors
- Custom particle size
- Custom number of particles
- Winning and losing conditions
- Color selection
- Game settings
- Restarting the game
- Exit button
- Timer-based particle movement

## Game Settings

The settings form allows the user to choose:

- Number of particles
- Particle size
- Winning color
- Losing color

The selected parameters are transferred from the settings form to the main game form.

## Technologies

- C#
- .NET
- Windows Forms
- Visual Studio
- Object-Oriented Programming
- Event Handling
- Timer
- ColorDialog
- Random Number Generation

## How to Play

1. Open the application
2. Open the game settings
3. Select the number and size of particles
4. Choose the winning and losing colors
5. Start the game
6. Click only on particles of the winning color
7. Avoid particles of the losing color
8. Remove all winning particles to win the game

## Project Structure

```text
Lab3-MultiWindow-Game
│
├── Form1.cs
├── Form1.Designer.cs
├── Form1.resx
├── Form2.cs
├── Form2.Designer.cs
├── Form2.resx
├── Program.cs
├── Properties
└── Lab3-MultiWindow-Game.csproj
