namespace Database.Tests {
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class DatabaseTests {
        [TestCase(new[] { 1 })]
        [TestCase(new[] { 4, 18, 17, 20, 1000 })]
        [TestCase(new[] { int.MaxValue, int.MinValue, 20 })]
        [TestCase(new int[] { })]
        public void Is_Capacity_16_Integers_Long(int[] parameters) {
            Database data = new Database(parameters);

            Assert.AreEqual(parameters.Length, data.Count);
        }

        [TestCase(
            new[] { 1, 2 },
            new[] { 10, 15 },
            4)]
        [TestCase(
            new int[] { },
            new[] { int.MinValue, int.MaxValue, 334455 },
            3)]
        [TestCase(
            new int[] { },
            new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 },
            16)]
        public void Act_WithValidData_PositiveTest(
            int[] ctorParams,
            int[] paramsToAdd,
            int expectedCount) {

            //Arrange
            Database data = new Database(ctorParams);

            //Act
            for (int i = 0; i < paramsToAdd.Length; i++) {
                data.Add(paramsToAdd[i]);
            }

            //Assert
            Assert.AreEqual(expectedCount, data.Count);
        }

        [TestCase(
            new[] { 10, 10 },
            new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 },
            1)]
        [TestCase(
            new int[] { },
            new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 },
            1)]
        public void Act_WithValidData_NegativeTest(
            int[] ctorParams,
            int[] paramsToAdd,
            int errorParam) {

            //Arrange
            Database data = new Database(ctorParams);

            //Act
            for (int i = 0; i < paramsToAdd.Length; i++) {
                data.Add(paramsToAdd[i]);
            }

            //Assert
            Assert.Throws<InvalidOperationException>(
                () => data.Add(errorParam));

        }

        [TestCase(
            new[] { 1, 2, 3 },
            new[] { 4, 5, 6 },
            2,
            4)]
        [TestCase(
            new int[] { },
            new[] { 1, 2, 3, 4, 5 },
            5,
            0)]
        public void Remove_WithValidData_ShouldPass(
            int[] ctorParams,
            int[] paramsToAdd,
            int removeCount,
            int expectedCount) {

            //Arrange
            Database data = new Database(ctorParams);

            foreach (int item in paramsToAdd) {
                data.Add(item);
            }

            //Act
            for (int i = 0; i < removeCount; i++) {
                data.Remove();
            }

            //Assert
            Assert.AreEqual(expectedCount, data.Count);
        }

        [TestCase(
            new int[] { },
            new[] { 1 },
            1,
            1)]
        public void Remove_WithInvalidData_NegativeTest(
            int[] ctorParams,
            int[] paramsToAdd,
            int removeCount,
            int removeError) {

            //Arrange
            Database data = new Database(ctorParams);

            foreach (int item in paramsToAdd) {
                data.Add(item);
            }

            //Act
            for (int i = 0; i < removeCount; i++) {
                data.Remove();
            }

            //Assert
            Assert.Throws<InvalidOperationException>(
                () => data.Remove());
        }

        [TestCase(
            new[] { 10, 10, 20 },
            new[] { 50, 40, 1000 },
            2,
            new[] { 10, 10, 20, 50 })]
        public void Fetch_WithValidData_PositiveTest(
            int[] ctorParams,
            int[] paramsToAdd,
            int removeCount,
            int[] expectedArray) {

            //Arrange
            Database data = new Database(ctorParams);

            foreach (int item in paramsToAdd) {
                data.Add(item);
            }

            for (int i = 0; i < removeCount; i++) {
                data.Remove();
            }

            //Act
            int[] actualData = data.Fetch();

            //Assert
            CollectionAssert.AreEqual(expectedArray, actualData);
            
        }

    }
}
