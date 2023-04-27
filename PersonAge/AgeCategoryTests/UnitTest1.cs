using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace PersonAge
{
    [TestClass]
    public class AgeCategoryTests
    {
        [TestMethod]
        public void AgeCategoryTest1()
        {
            string input = "5";
            string expectedOutput = "Person category: Children\n";
            RunTest(input, expectedOutput);
        }

        [TestMethod]
        public void AgeCategoryTest2()
        {
            string input = "24";
            string expectedOutput = "Person category: Youth\n";
            RunTest(input, expectedOutput);
        }

        [TestMethod]
        public void AgeCategoryTest3()
        {
            string input = "35";
            string expectedOutput = "Person category: Adults\n";
            RunTest(input, expectedOutput);
        }

        [TestMethod]
        public void AgeCategoryTest4()
        {
            string input = "80";
            string expectedOutput = "Person category: Seniors\n";
            RunTest(input, expectedOutput);
        }

        [TestMethod]
        public void AgeCategoryTest5()
        {
            string input = "150";
            string expectedOutput = "Invalid age: Age must be between 1 and 130.\n";
            RunTest(input, expectedOutput);
        }

        [TestMethod]
        public void AgeCategoryTest6()
        {
            string input = "0";
            string expectedOutput = "Invalid age: Age must be between 1 and 130.\n";
            RunTest(input, expectedOutput);
        }

        [TestMethod]
        public void AgeCategoryTest7()
        {
            string input = "";
            string expectedOutput = "Invalid age: Age cannot be null or empty.\n";
            RunTest(input, expectedOutput);
        }

        [TestMethod]
        public void AgeCategoryTest8()
        {
            string input = "abc";
            string expectedOutput = "Invalid age: Age must be an integer.\n";
            RunTest(input, expectedOutput);
        }

        private void RunTest(string input, string expectedOutput)
        {
            // Arrange
            var consoleInput = new StringReader(input);
            Console.SetIn(consoleInput);
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            Program.Main(new string[] { });

            // Assert
            string actualOutput = consoleOutput.ToString();
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}