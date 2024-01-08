# card-game
Card Game Project
Overview
This Card Game project is a C# application that calculates the score for a given list of playing cards based on predefined rules. The project follows the Test Driven Development (TDD) approach and includes 100% unit test coverage.

Features
Scoring Rules:

Number cards are worth their face value.
Jack (J) is worth 11 points, Queen (Q) 12 points, King (K) 13 points, and Ace (A) 14 points.
The suit of the card determines the multiplier for the card’s value:
Clubs (C): Multiply by 1
Diamonds (D): Multiply by 2
Hearts (H): Multiply by 3
Spades (S): Multiply by 4
If a Joker appears, the score for that hand is doubled.
User Interface:

Provides a user interface for entering a list of cards.
Displays the calculated score on the user interface.
Input Format:

Each card is represented by a two-character code:
The first character represents the card's value (2-9, T, J, Q, K, A).
The second character represents the card's suit (C, D, H, S).
Example: 2C for the 2 of Clubs, JS for the Jack of Spades.
Joker is represented by the code JK.
Lists of cards should be provided as a comma-separated string.
Validation:

Validates input for duplication and Joker count.
Displays appropriate error messages for invalid input.
Test Driven Development (TDD):

The code is developed using the Test Driven Development methodology.
Unit tests cover various scenarios to ensure code correctness.
How to Use
Clone the repository to your local machine.
Open the solution in your preferred C# IDE (e.g., Visual Studio).
Run the application.
Enter a comma-separated list of cards when prompted.
View the calculated score on the user interface.
Unit Tests
The project includes a comprehensive set of unit tests to validate different scenarios. Check the CardGameTests.cs file for detailed test cases.

Requirements
C# Back-End
User Interface (e.g., Console Application)
TDD Style with Unit Test Coverage
