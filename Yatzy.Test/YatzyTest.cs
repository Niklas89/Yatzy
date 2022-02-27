using Xunit;

namespace Yatzy.Test
{
    public class YatzyTest
    {
        [Theory]
        [InlineData(2, 3, 4, 5, 1, 15)]
        [InlineData(3, 3, 4, 5, 1, 16)]
        public void Add_MultipleNumbers_Chance_ReturnsScoreSumAllDice(int value1, int value2, int value3, int value4, int value5, int expected)
        {
            var actual = Yatzy.ChanceScoreSumAllDice(value1, value2, value3, value4, value5);
            Assert.Equal(expected, actual);
        }
        
        // Testing the Yatzy method
        [Theory]
        [InlineData(4, 4, 4, 4, 4, 50)]
        [InlineData(6, 6, 6, 6, 6, 50)]
        [InlineData(6, 6, 6, 6, 3, 0)]
        public void Add_MultipleNumbers_Yatzy_ReturnsScoreFifty(int value1, int value2, int value3, int value4, int value5, int expected)
        {
            var actual = Yatzy.YatzyScoreFifty(value1, value2, value3, value4, value5);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2, 3, 4, 5, 1)]
        [InlineData(1, 2, 1, 4, 5, 2)]
        [InlineData(6, 2, 2, 4, 5, 0)]
        [InlineData(1, 2, 1, 1, 1, 4)]
        public void Add_MultipleNumbers_ReturnsScoreSumDiceWithOnes(int value1, int value2, int value3, int value4, int value5, int expected)
        {
            var actual = Yatzy.ScoreSumDiceWithOnes(value1, value2, value3, value4, value5);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2, 3, 2, 6, 4)]
        [InlineData(2, 2, 2, 2, 2, 10)]
        public void Add_MultipleNumbers_ReturnsScoreSumDiceWithTwos(int value1, int value2, int value3, int value4, int value5, int expected)
        {
            var actual = Yatzy.ScoreSumDiceWithTwos(value1, value2, value3, value4, value5);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2, 3, 2, 3, 6)]
        [InlineData(2, 3, 3, 3, 3, 12)]
        public void Add_MultipleNumbers_ReturnsScoreSumDiceWithThrees(int value1, int value2, int value3, int value4, int value5, int expected)
        {
            var actual = Yatzy.ScoreSumDiceWithThrees(value1, value2, value3, value4, value5);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 4, 4, 5, 5, 12)]
        [InlineData(4, 4, 5, 5, 5, 8)]
        [InlineData(4, 5, 5, 5, 5, 4)]
        public void Add_MultipleNumbers_ReturnsScoreSumDiceWithFours(int value1, int value2, int value3, int value4, int value5, int expected)
        {
            var actual = Yatzy.ScoreSumDiceWithFours(value1, value2, value3, value4, value5);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 4, 4, 5, 5, 10)]
        [InlineData(4, 4, 5, 5, 5, 15)]
        [InlineData(4, 5, 5, 5, 5, 20)]
        public void Add_MultipleNumbers_ReturnsScoreSumDiceWithFives(int value1, int value2, int value3, int value4, int value5, int expected)
        {
            var actual = Yatzy.ScoreSumDiceWithFives(value1, value2, value3, value4, value5);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 4, 4, 5, 5, 0)]
        [InlineData(4, 4, 6, 5, 5, 6)]
        [InlineData(6, 5, 6, 6, 5, 18)]
        public void Add_MultipleNumbers_ReturnsScoreSumDiceWithSixes(int value1, int value2, int value3, int value4, int value5, int expected)
        {
            var actual = Yatzy.ScoreSumDiceWithSixes(value1, value2, value3, value4, value5);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 4, 3, 5, 6, 6)]
        [InlineData(5, 3, 3, 3, 5, 10)]
        [InlineData(5, 3, 6, 6, 5, 12)]
        public void Add_MultipleNumbers_ReturnsScoreSumHighestPair(int value1, int value2, int value3, int value4, int value5, int expected)
        {
            var actual = Yatzy.ScoreSumHighestPair(value1, value2, value3, value4, value5);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 3, 5, 4, 5, 16)]
        [InlineData(3, 3, 5, 5, 5, 16)]
        public void Add_MultipleNumbers_ReturnsScoreSumTwoPair(int value1, int value2, int value3, int value4, int value5, int expected)
        {
            var actual = Yatzy.ScoreSumTwoPair(value1, value2, value3, value4, value5);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 3, 3, 3, 5, 12)]
        [InlineData(5, 5, 5, 4, 5, 20)]
        [InlineData(3, 3, 3, 3, 3, 12)]
        public void Add_MultipleNumbers_ReturnsScoreSumFourOfAKind(int value1, int value2, int value3, int value4, int value5, int expected)
        {
            var actual = Yatzy.ScoreSumFourOfAKind(value1, value2, value3, value4, value5);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 3, 3, 4, 5, 9)]
        [InlineData(5, 3, 5, 4, 5, 15)]
        [InlineData(3, 3, 3, 3, 5, 9)]
        public void Add_MultipleNumbers_ReturnsScoreSumThreeOfAKind(int value1, int value2, int value3, int value4, int value5, int expected)
        {
            var actual = Yatzy.ScoreSumThreeOfAKind(value1, value2, value3, value4, value5);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2, 3, 4, 5, 15)]
        [InlineData(2, 3, 4, 5, 1, 15)]
        [InlineData(1, 2, 2, 4, 5, 0)]
        public void Add_MultipleNumbers_ReturnsScoreFifteenSmallStraight(int value1, int value2, int value3, int value4, int value5, int expected)
        {
            var actual = Yatzy.ScoreFifteenSmallStraight(value1, value2, value3, value4, value5);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, 2, 3, 4, 5, 20)]
        [InlineData(2, 3, 4, 5, 6, 20)]
        [InlineData(1, 2, 2, 4, 5, 0)]
        public void Add_MultipleNumbers_ReturnsScoreTwentyLargeStraight(int value1, int value2, int value3, int value4, int value5, int expected)
        {
            var actual = Yatzy.ScoreTwentyLargeStraight(value1, value2, value3, value4, value5);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, 2, 2, 2, 6, 18)]
        [InlineData(2, 3, 4, 5, 6, 0)]
        public void Add_MultipleNumbers_ReturnsFullHouseScoreSumAllDice(int value1, int value2, int value3, int value4, int value5, int expected)
        {
            var actual = Yatzy.FullHouseScoreSumAllDice(value1, value2, value3, value4, value5);
            Assert.Equal(expected, actual);
        }
    }
}