using System;
using Xunit;

namespace ChallengeSortNames.Tests
{
    public class SortNamesHelperTests
    {
        [Fact]
        public void SortNames_CorrectParameters_SuccessfullyOrderedNames()
        {
            var names = new string[] { "Sonia", "Maria", "Wood", "Dempster" };
            var newOrder = new int[] { 4, 1, 2, 3 };
            var orderedNames = new string[] { "Dempster", "Sonia", "Maria", "Wood" };

            var result = SortNamesHelper.SortNames(names, newOrder);

            Assert.Equal(orderedNames.Length, result.Length);
            Assert.Equal(orderedNames[0], result[0]);
        }

        [Fact]
        public void SortNames_SendFourNamesAndThreeOrderPositions_ThrowsArgumentException()
        {
            var names = new string[] { "Sonia", "Maria", "Wood", "Dempster" };
            var newOrder = new int[] { 4, 1,  };

            var exception = Assert.Throws<ArgumentException>(() => SortNamesHelper.SortNames(names, newOrder));

            Assert.Equal("The number of names is different from the number of positions to order", exception.Message);
        }

        [Fact]
        public void SortNames_SendDuplicatedOrderPositions_ThrowsArgumentException()
        {
            var names = new string[] { "Sonia", "Maria", "Wood", "Dempster" };
            var newOrder = new int[] { 4, 1, 4, 2 };

            var exception = Assert.Throws<ArgumentException>(() => SortNamesHelper.SortNames(names, newOrder));

            Assert.Equal("There are duplicate elements in the order array", exception.Message);
        }

        [Fact]
        public void SortNames_SendIndexLowerToInitialPosition_ThrowsArgumentException()
        {
            var names = new string[] { "Sonia", "Maria", "Wood", "Dempster" };
            var newOrder = new int[] { 0, 1, 2, 3 };

            var exception = Assert.Throws<ArgumentException>(() => SortNamesHelper.SortNames(names, newOrder));

            Assert.Equal("The new indexes are out of array length", exception.Message);
        }

        [Fact]
        public void SortNames_SendIndexHigherThanNumberOfNames_ThrowsArgumentException()
        {
            var names = new string[] { "Sonia", "Maria", "Wood", "Dempster" };
            var newOrder = new int[] { 5, 1, 2, 3 };

            var exception = Assert.Throws<ArgumentException>(() => SortNamesHelper.SortNames(names, newOrder));

            Assert.Equal("The new indexes are out of array length", exception.Message);
        }

        [Fact]
        public void SortNames_SendNullInNamesParameter_ThrowsArgumentException()
        {
            string[] names = null;
            var newOrder = new int[] { 5, 1, 2, 3 };

            var exception = Assert.Throws<ArgumentException>(() => SortNamesHelper.SortNames(names, newOrder));

            Assert.Equal("The names and/or new order are null", exception.Message);
        }

        [Fact]
        public void SortNames_SendNullInNewOrderParameter_ThrowsArgumentException()
        {
            var names = new string[] { "Sonia", "Maria", "Wood", "Dempster" };
            int[] newOrder = null;

            var exception = Assert.Throws<ArgumentException>(() => SortNamesHelper.SortNames(names, newOrder));

            Assert.Equal("The names and/or new order are null", exception.Message);
        }

        [Fact]
        public void SortNames_SendNullInNamesParameterAndNullInNewOrderParameter_ThrowsArgumentException()
        {
            string[] names = null;
            int[] newOrder = null;

            var exception = Assert.Throws<ArgumentException>(() => SortNamesHelper.SortNames(names, newOrder));

            Assert.Equal("The names and/or new order are null", exception.Message);
        }
    }
}

