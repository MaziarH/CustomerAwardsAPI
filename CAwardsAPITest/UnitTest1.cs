using Microsoft.VisualStudio.TestTools.UnitTesting;
using CAwardsAPI;

namespace CAwardsAPITest
{
    // Based on Bankers' Rounding, greater than .5 goes to 1 otherwise 0.
    //
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        [TestCategory("Important")]
        public void LessEqual_Fifty_Rewards()
        {
            //Arrange
            double amount1 = 50.50;
            int expected = 0;

            //Act
            int actual = new CalculateRewards().GetRewards(amount1);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Important")]
        public void MoreThan_Fifty_Rewards()
        {
            //Arrange
            double amount1 = 50.51;
            int expected = 1;

            //Act
            int actual = new CalculateRewards().GetRewards(amount1);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [TestCategory("Important")]
        public void Border_FiftyHundred_Rewards()
        {
            //Arrange
            double amount1 = 100.50;
            int expected = 50;

            //Act
            int actual = new CalculateRewards().GetRewards(amount1);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [TestCategory("Important")]
        public void MoreThan_Hundred_Rewards()
        {
            //Arrange
            double amount1 = 100.51;
            int expected = 51;  // 50 + 1

            //Act
            int actual = new CalculateRewards().GetRewards(amount1);

            //Assert
            Assert.AreEqual(expected, actual);
        }


    }
}