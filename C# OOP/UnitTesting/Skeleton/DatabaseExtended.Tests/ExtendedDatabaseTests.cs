namespace DatabaseExtended.Tests {

    using ExtendedDatabase;
    using NUnit.Framework;
    using System.Collections.Generic;

    [TestFixture]
    public class ExtendedDatabaseTests {
        [TestCaseSource("TestCaseConstructorData")]
        public void Test(
            Person[] people,
            int expectedCount) {
            Database database = new Database(people);

            Assert.AreEqual(expectedCount, database.Count);
        }

        public static IEnumerable<TestCaseData> TestCaseConstructorData() {
            TestCaseData[] testCases = new TestCaseData[] {
                new TestCaseData(
                    new Person[] {
                new Person(1, "Drashko"),
                new Person(2, "Stoyan")
                },
                2),

                new TestCaseData(
                new Person[] {},
                0)
            };

            foreach (var item in testCases) {
                yield return item;
            }

        }
    }
}