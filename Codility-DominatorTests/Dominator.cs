using Codility_Dominator;

namespace Codility_DominatorTests
{
    public class SolutionTests
    {
        [Fact]
        public void TestDominatorExists()
        {
            // Arrange
            int[] input = { 3, 4, 3, 2, 3, -1, 3, 3 };
            Solution solution = new Solution();

            // Act
            int result = solution.solution(input);

            // Assert
            Assert.InRange(result, 0, 7);
        }

        [Fact]
        public void TestNoDominator()
        {
            // Arrange
            int[] input = { 1, 2, 3, 4, 5, 6 };
            Solution solution = new Solution();

            // Act
            int result = solution.solution(input);

            // Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void TestEmptyArray()
        {
            // Arrange
            int[] input = new int[0];
            Solution solution = new Solution();

            // Act
            int result = solution.solution(input);

            // Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void TestSingleElementArray()
        {
            // Arrange
            int[] input = { 42 };
            Solution solution = new Solution();

            // Act
            int result = solution.solution(input);

            // Assert
            Assert.Equal(0, result);
        }
    }
}