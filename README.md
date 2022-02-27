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


## My changes in the code:

### Yatzy: Yatzy.cs
- Added comments above every method and inside every method ;
- Changed each method in the code so that all methods are the same with "params int[] Dice" as parameters and set the Dice array in the constructor ;
- Changed all methods to "static" ;
- Changed protected "dice" name of array to "Dice", PascalCase, according to correct naming conventions:  [Link to naming conventions](https://www.c-sharpcorner.com/UploadFile/8a67c0/C-Sharp-coding-standards-and-naming-conventions/ "Naming Conventions on c-sharpcorner.com")

#### Yatzy constructor line 9
- Instead of assigning the values one by one, I used the array and used CopyTo method to copy all values to the Dice array.

#### Chance method line 15
- Changed name of method to "ChanceScoreSumAllDice", because it should be a verb and we should understand what it does by reading the name ;
- Deleted all the parameters in the method and replaced them with the Dice array, we declared this array in the construction.
- Made a for loop to add all the values in the array to the sum, because it takes less coding lines than adding each value one by one, and you never know if you want to add more than 5 values in the future.


#### Yatzy method line 25
- Changed method name "yatzy" to "YatzyScoreFifty", because it has to be a verb in PascalCase and not the same name as the class ;
- Deleted the foreach loop, because it's better for the perfomance only to have one loop ;
- Changed var to int, because we know they are integers ;
- In the for loop we check if the first value of the Dice array is not equal to the other numbers. If it isn't we return 0, else we return 50 ;
- Changed "i != 6" to "i < Dice.Length" in the for loop, we never know if we want to add more than 5 values in the future.

#### Ones method line 37
- Changed name of method to "ScoreSumDiceWithOnes", because it should be a verb and we should understand what it does by reading the name ;
- Deleted all the parameters in the method and replaced them with the Dice array.
- Made a for loop to add all the values equal to 1 in the array to the sum, because it takes less coding lines than adding each value one by one, and you never know if you want to add more than 5 values in the future ;
- Changed var sum to int sum, because we know we'll always have integers.

#### Twos method line 49
- Same changes as Ones method ;
- Changed name of method to "ScoreSumDiceWithTwos".

#### Threes method line 60
- Same changes as Ones method ;
- Changed name of method to "ScoreSumDiceWithThrees".

#### Fours method line 71
- Same changes as Ones method ;
- Added "static" to the method, because the method should not be changed or overridden ;
- Changed name of method to "ScoreSumDiceWithFours".

#### Fives method line 82
- Same changes as Ones method ;
- Added "static" to the method, because the method should not be changed or overridden ;
- Changed name of method to "ScoreSumDiceWithFives".

#### Sixes method line 93
- Same changes as Ones method ;
- Added "static" to the method, because the method should not be changed or overridden ;
- Changed name of method to "ScoreSumDiceWithSixes".

#### ScorePair method line 104
- Changed name of method to "ScoreSumHighestPair" ;
- Deleted everything in the method and used for loops to calculate the sum of the two highest matching dice.
- Declared a second array, diceCounts, were we'll store the sum of each pair of matching dice.
- Added the sum of each pair to the diceCounts array, then loop through that array and return the maximum found ;
- Renamed the variables to make it more understandable.

#### TwoPair method line 124
- Changed name of method to "ScoreSumTwoPair" ;
- Used a for loop to add "1" to the each index in diceCounts array corresponding to a value in the Dice array, instead of adding 1 to each index one by one ;
- Renamed the variables to make it more understandable.

#### FourOfAKind method line 150
- Changed name of method to "ScoreSumFourOfAKind" ;
- Used a for loop to add "1" to each index in diceCounts array corresponding to a value in the Dice array, instead of adding 1 to each index one by one ;
- Renamed the variables to make it more understandable.

#### ThreeOfAKind method line 166
- Changed name of method to "ScoreSumThreeOfAKind" ;
- same changes as for FourOfAKind

#### SmallStraight method line 181
- Changed name of method to "ScoreFifteenSmallStraight" ;
- Deleted everything in the method and just made a for loop through the Dice array and added every value to a sum variable. Check if sum equals 15 and return 15, else return 0.

#### LargeStraight method line 196
- Changed name of method to "ScoreTwentyLargeStraight" ;
- Deleted everything in the method and just made a for loop through the Dice array and added every value to a sum variable. Check if sum equals 20 and return 20, else return 0.

#### FullHouse method line 211
- Changed name of method to "FullHouseScoreSumAllDice" ;
- Changed name of _2 and _3 variables to isTwoOfAKind and isThreeOfAKind, and changed "var" to "bool" ;
- Changed "var _2_at" to "int diceTwoOfAKind" ;
- Changed "var _3_at" to "int diceThreeOfAKind" ;
- Changed "tallies" to "diceCounts" and used for loop to add "1" to each index in diceCounts array corresponding to a value in the Dice array, instead of adding 1 to each index one by one ;
- Declared the "i" variable with "int" inside the parentheses of the for method ;
- Replaced "i != 6; i += 1" with "i < Dice.Length+1; i++" ;
- Deleted one for loop and put an "if" inside the first for loop.

#### Main method line 256
- Added a Main method, otherwise the project won't build.


### YatzyTest.cs

- Reorganized the methods so that they are in the same order as in the Yatzy.cs file

- Changed every method name, like "Yatzy_scores_50" method to "Add_MultipleNumbers_Yatzy_ReturnsScoreFifty", for better naming conventions. Every method in this file will start with "Add_MultipleNumbers_ReturnsScore..." because we add multiple numbers and expect a score as return value.

- Changed all methods so that they all are the same: with [Theory] instead of [Fact] and [InlineData] instead of [ClassData] for example.
- Changed [Fact] to [Theory] : xUnit uses the [Fact] attribute to denote a parameterless unit test.
In contrast, the [Theory] attribute denotes a parameterised test that is true for a subset of data. That data can be supplied in a number of ways, but the most common is with an [InlineData] attribute.
Instead of specifying the values to add (value1, value2, value3, value4, value5) in the test body, we pass those values as parameters to the test. We also pass in the expected result of the calculation, to use in the Assert.Equal() call.
...Why? 
..* Less chance to introduce a bug inside of your tests
..* Focus on the end result, rather than implementation details.


