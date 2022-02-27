using System;

namespace Yatzy
{
    public class Yatzy
    {
        protected int[] Dice;

        public Yatzy(params int[] Dice)
        {
            Dice.CopyTo(Dice,0);
        }

        // Chance: The player scores the sum of all dice, no matter what they read.
        public static int ChanceScoreSumAllDice(params int[] Dice)
        {
            int sum = 0;
            // Add all the values in the Dice array to the sum variable.
            for (int i = 0; i < Dice.Length; i++)
                sum += Dice[i];
            return sum;
        }

        // Yatzy: If all dices have the same number, the player scores 50 points.
        public static int YatzyScoreFifty(params int[] Dice)
        {
            int sameNumber = Dice[0];
            // Check if the first value of the Dice array is not equal to the other numbers.
            // If it isn't we return 0, else we return 50.
            for (int i = 0; i < Dice.Length; i++)
                if (Dice[i] != sameNumber)
                    return 0;
            return 50;
        }

        // Ones: the sum of dices with number 1
        public static int ScoreSumDiceWithOnes(params int[] Dice)
        {
            int sum = 0;
            // Add all the values equal to 1 in the array to the sum.
            for (int i = 0; i < Dice.Length; i++)
                if (Dice[i] == 1)
                    sum++;
            return sum;
        }


        // Twos: the sum of dices with number 2
        public static int ScoreSumDiceWithTwos(params int[] Dice)
        {
            int sum = 0;
            // Add all the values equal to 2 in the array to the sum.
            for (int i = 0; i < Dice.Length; i++)
                if (Dice[i] == 2)
                    sum += 2;
            return sum;
        }

        // Threes: the sum of dices with number 3
        public static int ScoreSumDiceWithThrees(params int[] Dice)
        {
            int sum = 0;
            // Add all the values equal to 3 in the array to the sum.
            for (int i = 0; i < Dice.Length; i++)
                if (Dice[i] == 3)
                    sum += 3;
            return sum;
        }

        // Fours: the sum of dices with number 4
        public static int ScoreSumDiceWithFours(params int[] Dice)
        {
            int sum = 0;
            // Add all the values equal to 4 in the array to the sum.
            for (int i = 0; i < Dice.Length; i++)
                if (Dice[i] == 4)
                    sum += 4;
            return sum;
        }

        // Fives: the sum of dices with number 5
        public static int ScoreSumDiceWithFives(params int[] Dice)
        {
            int sum = 0;
            // Add all the values equal to 5 in the array to the sum.
            for (int i = 0; i < Dice.Length; i++)
                if (Dice[i] == 5)
                    sum += 5;
            return sum;
        }

        // Sixes: the sum of dices with number 6
        public static int ScoreSumDiceWithSixes(params int[] Dice)
        {
            int sum = 0;
            // Add all the values equal to 6 in the array to the sum.
            for (int i = 0; i < Dice.Length; i++)
                if (Dice[i] == 6)
                    sum += 6;
            return sum;
        }

        // Pair: The player scores the sum of the two highest matching dice
        public static int ScoreSumHighestPair(params int[] Dice)
        {
            // Declare a second array were we'll store the sum of each pair of matching dice.
            int[] diceCounts = new int[Dice.Length];
            // Add the sum of each pair in the diceCounts array.
            for (int i = 0; i < Dice.Length; i++)
                for (int j = i+1; j < Dice.Length; j++)
                    if(Dice[i] == Dice[j])
                        diceCounts[i] = Dice[i] * 2;

            int max = 0;
            // Return the maximum value found in the diceCounts array.
            for (int i = 0; i < Dice.Length; i++)
                if (diceCounts[i] > max)
                    max = diceCounts[i];

            return max;
        }

        // Two pairs: If there are two pairs of dice with the same number, the player scores the sum of these dices
        public static int ScoreSumTwoPair(params int[] Dice)
        {
            int[] diceCounts = new int[Dice.Length+1];
            // Add "1" to the each index in diceCounts array corresponding to a value in the Dice array,
            // " -1 ", because the values of each dice can go up to 6, whereas we have an array length of 5.
            for (int j = 0; j < Dice.Length; j++)
                diceCounts[Dice[j] - 1]++;
            
            int numberOfPairs = 0;
            int sum = 0;
            int diceLength = Dice.Length + 1;
            // If the for loop finds 2 or more of the same dice we increment the numberOfPairs variable
            // and add the value of the dice to the sum.
            for (int i = 0; i < diceLength; i += 1)
                if (diceCounts[diceLength - i - 1] >= 2)
                {
                    numberOfPairs++;
                    sum += diceLength - i;
                }

            // We multiply the sum of the two dices found by two
            // because we want the sum of the two pairs and we return the sum.
            return sum * 2;
        }

        // 4 of a kind: at least 4 dices the same, the player scores the sum of these dices
        public static int ScoreSumFourOfAKind(params int[] Dice)
        {
            int[] diceCounts = new int[Dice.Length + 1];
            for (int j = 0; j < Dice.Length; j++)
                diceCounts[Dice[j] - 1]++;

            // If the for loop finds the value 4 or above in diceCounts it means we have 4 of a kind
            // and we return the value of that dice multiplied by 4.
            for (var i = 0; i < Dice.Length + 1; i++)
                if (diceCounts[i] >= 4)
                    return (i + 1) * 4;

            return 0;
        }

        // 3 of a kind: at least 3 dices the same, the player scores the sum of these dices
        public static int ScoreSumThreeOfAKind(params int[] Dice)
        {
            int[] diceCounts = new int[Dice.Length + 1];
            for (int j = 0; j < Dice.Length; j++)
                diceCounts[Dice[j] - 1]++;

            // If the for loop finds the value 3 or above in diceCounts it means we have 3 of a kind
            // and we return the value of that dice multiplied by 3.
            for (var i = 0; i < Dice.Length + 1; i++)
                if (diceCounts[i] >= 3)
                    return (i + 1) * 3;
            return 0;
        }

        // Small straight: if the dice read 1,2,3,4,5, the player scores 15 
        public static int ScoreFifteenSmallStraight(params int[] Dice)
        {
            int sum = 0;
            // Loop through the Dice array and add every value to the sum variable.
            for (int i = 0; i < Dice.Length; i++)
                sum += Dice[i];

            // Check if sum equals 15 and return 15, else return 0.
            if (sum == 15)
                return sum;

            return 0;
        }

        // Large straight: if the dice read 2,3,4,5,6, the player scores 20
        public static int ScoreTwentyLargeStraight(params int[] Dice)
        {
            int sum = 0;
            // Loop through the Dice array and add every value to the sum variable.
            for (int i = 0; i < Dice.Length; i++)
                sum += Dice[i];

            // Check if sum equals 20 and return 20, else return 0.
            if (sum == 20)
                return sum;

            return 0;
        }

        // Full house: If the dice are two of a kind and three of a kind, the player scores the sum of all the dices
        public static int FullHouseScoreSumAllDice(params int[] Dice)
        {
            // If the dice two of a kind and three of a kind have been found we'll set them to true
            bool isTwoOfAKind = false;
            bool isThreeOfAKind = false;

            // The value of the dice two of a kind and three of a kind will be stored inside these two variables
            int diceTwoOfAKind = 0;
            int diceThreeOfAKind = 0;

            // add "1" to each index in diceCounts array corresponding to the values in the Dice array
            int[] diceCounts = new int[Dice.Length + 1];
            for (int j = 0; j < Dice.Length; j++)
                diceCounts[Dice[j] - 1]++;

            // Loop through the number of same dices we have in diceCounts
            for (int i = 0; i < Dice.Length+1; i++)
            {
                // if there are two of the same dice, isTwoOfAKind equals true
                // and we add the value of this dice inside diceTwoOfAKind
                if (diceCounts[i] == 2)
                {
                    isTwoOfAKind = true;
                    diceTwoOfAKind = i + 1;
                }
                // if there are two of the same dice, isThreeOfAKind equals true
                // and we add the value of this dice inside diceThreeOfAKind
                else if (diceCounts[i] == 3)
                {
                    isThreeOfAKind = true;
                    diceThreeOfAKind = i + 1;
                }
            }

            // If the dice are two of a kind and three of a kind are both true,
            // we multiply the value of two of a kind by two and three of a kind by three, and return the sum.
            if (isTwoOfAKind && isThreeOfAKind)
                return diceTwoOfAKind * 2 + diceThreeOfAKind * 3;

            /// If the dice are two of a kind and three of a kind are both false, we return zero.
            return 0;

            
        }

        public static void Main(String[] args)
        {

        }
    }
}