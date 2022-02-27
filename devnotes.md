# Yatzy
Yatzy game in C# with Unit Testing, xUnit.net

## Yatzy Rules

- Ones: the sum of dices with number 1
- Twos: the sum of dices with number 2
- Threes: the sum of dices with number 3
- Fours: the sum of dices with number 4
- Fives: the sum of dices with number 5
- Sixes: the sum of dices with number 6
- 3 of a kind: at least 3 dices the same, the player scores the sum of these dice
- 4 of a kind: at least 4 dices the same, the player scores the sum of these dice
- Two pairs: If there are two pairs of dice with the same number, the player scores the sum of these dice
- Pair: The player scores the sum of the two highest matching dice
- Full house: 3 of one number and 2 of another
- Small straight: if the dice read 1,2,3,4,5, the player scores 15 
- Large straight: if the dice read 2,3,4,5,6, the player scores 20
- Yatzy: If all dice have the same number, the player scores 50 points
- Chance: The player scores the sum of all dice, no matter what they read

[Link to the rules](https://sammancoaching.org/kata_descriptions/yatzy.html "Yatzy game at sammancoaching.org")

[Link to the original Yatzy code](https://github.com/emilybache/Yatzy-Refactoring-Kata/tree/main/csharp "Github emilybache/Yatzy-Refactoring-Kata")


## My changes in the code:

### Yatzy: Yatzy.cs
- Added comments above every function and inside every function ;
- Set the Yatzy class to static and set all functions within to static as well, because we don't need object oriented programming here, we only have to test functions.
- Delete the constructor as well. When we are in a static class we don't use a constructor, that's only needed for object oriented programming ;
- Changed each function in the code so that all functions are the same with "params int[] Dice" as parameters ;


#### Chance function line 8
- Changed name of function to "ChanceScoreSumAllDice", because it should be a verb and we should understand what it does by reading the name ;
- Deleted all the parameters in the function and replaced them with the Dice array, we declared this array in the construction.
- Made a for loop to add all the values in the array to the sum, because it takes less coding lines than adding each value one by one, and you never know if you want to add more than 5 values in the future.


#### Yatzy function line 18
- Changed function name "yatzy" to "YatzyScoreFifty", because it has to be a verb in PascalCase and not the same name as the class ;
- Deleted the foreach loop, because it's better for the perfomance only to have one loop ;
- Changed var to int, because we know they are integers ;
- In the for loop we check if the first value of the Dice array is not equal to the other numbers. If it isn't we return 0, else we return 50 ;
- Changed "i != 6" to "i < Dice.Length" in the for loop.

#### Ones function line 30
- Changed name of function to "ScoreSumDiceWithOnes", because it should be a verb and we should understand what it does by reading the name ;
- Deleted all the parameters in the function and replaced them with the Dice array.
- Made a for loop to add all the values equal to 1 in the array to the sum, because it takes less coding lines than adding each value one by one, and you never know if you want to add more than 5 values in the future ;
- Changed var sum to int sum, because we know we'll always have integers.

#### Twos function line 42
- Same changes as Ones function ;
- Changed name of function to "ScoreSumDiceWithTwos".

#### Threes function line 53
- Same changes as Ones function ;
- Changed name of function to "ScoreSumDiceWithThrees".

#### Fours function line 64
- Same changes as Ones function ;
- Changed name of function to "ScoreSumDiceWithFours".

#### Fives function line 75
- Same changes as Ones function ;
- Changed name of function to "ScoreSumDiceWithFives".

#### Sixes function line 86
- Same changes as Ones function ;
- Changed name of function to "ScoreSumDiceWithSixes".

#### ScorePair function line 97
- Changed name of function to "ScoreSumHighestPair" ;
- Deleted everything in the function and used for loops to calculate the sum of the two highest matching dice.
- Declared a second array, diceCounts, were we'll store the sum of each pair of matching dice.
- Added the sum of each pair to the diceCounts array, then loop through that array and return the maximum found ;
- Renamed the variables to make it more understandable.

#### TwoPair function line 117
- Changed name of function to "ScoreSumTwoPair" ;
- Used a for loop to add "1" to the each index in diceCounts array corresponding to a value in the Dice array, instead of adding 1 to each index one by one ;
- Renamed the variables to make it more understandable.

#### FourOfAKind function line 143
- Changed name of function to "ScoreSumFourOfAKind" ;
- Used a for loop to add "1" to each index in diceCounts array corresponding to a value in the Dice array, instead of adding 1 to each index one by one ;
- Renamed the variables to make it more understandable.

#### ThreeOfAKind function line 159
- Changed name of function to "ScoreSumThreeOfAKind" ;
- same changes as for FourOfAKind

#### SmallStraight function line 174
- Changed name of function to "ScoreFifteenSmallStraight" ;
- Deleted everything in the function and just made a for loop through the Dice array and added every value to a sum variable. Check if sum equals 15 and return 15, else return 0.

#### LargeStraight function line 189
- Changed name of function to "ScoreTwentyLargeStraight" ;
- Deleted everything in the function and just made a for loop through the Dice array and added every value to a sum variable. Check if sum equals 20 and return 20, else return 0.

#### FullHouse function line 204
- Changed name of function to "FullHouseScoreSumAllDice" ;
- Changed name of _2 and _3 variables to isTwoOfAKind and isThreeOfAKind, and changed "var" to "bool" ;
- Changed "var _2_at" to "int diceTwoOfAKind" ;
- Changed "var _3_at" to "int diceThreeOfAKind" ;
- Changed "tallies" to "diceCounts" and used for loop to add "1" to each index in diceCounts array corresponding to a value in the Dice array, instead of adding 1 to each index one by one ;
- Declared the "i" variable with "int" inside the parentheses of the for function ;
- Replaced "i != 6; i += 1" with "i < 6; i++" ;
- Deleted one for loop and put an "if" inside the first for loop.

#### Main function line 247
- Added a Main function, otherwise the project won't build.


### YatzyTest.cs

- Reorganized the functions so that they are in the same order as in the Yatzy.cs file

- Changed every function name, like "Yatzy_scores_50" function to "Add_MultipleNumbers_Yatzy_ReturnsScoreFifty", for better naming conventions. Every function in this file will start with "Add_MultipleNumbers_ReturnsScore..." because we add multiple numbers and expect a score as return value.

- Changed all functions so that they all are the same: with [Theory] instead of [Fact] and [InlineData] instead of [ClassData] for example.
- Changed [Fact] to [Theory] : xUnit uses the [Fact] attribute to denote a parameterless unit test.
In contrast, the [Theory] attribute denotes a parameterised test that is true for a subset of data. That data can be supplied in a number of ways, but the most common is with an [InlineData] attribute.
Instead of specifying the values to add (value1, value2, value3, value4, value5) in the test body, we pass those values as parameters to the test. We also pass in the expected result of the calculation, to use in the Assert.Equal() call.
...Why? 
..* Less chance to introduce a bug inside of your tests
..* Focus on the end result, rather than implementation details.


