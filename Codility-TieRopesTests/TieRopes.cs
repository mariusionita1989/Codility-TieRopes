using Codility_TieRopes;

namespace Codility_TieRopesTests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(4, new[] { 1, 2, 3, 4, 1, 1, 3 }, 3)]
        [InlineData(2, new[] { 2, 2, 2, 2 }, 4)]
        [InlineData(5, new[] { 1, 2, 3, 4, 1, 1, 3 }, 2)]
        [InlineData(1, new[] { 1, 1, 1, 1, 1, 1, 1 }, 7)]
        public void TestSolution(int K, int[] A, int expected)
        {
            var solution = new Solution();
            int result = solution.solution(K, A);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestSolutionWithEmptyArray()
        {
            var solution = new Solution();
            int[] emptyArray = new int[0];
            int result = solution.solution(1, emptyArray);
            Assert.Equal(0, result);
        }

        [Fact]
        public void TestSolutionWithKGreaterThanAllRopes()
        {
            var solution = new Solution();
            int[] A = { 1, 2, 3, 4 };
            int result = solution.solution(10, A);
            Assert.Equal(1, result);
        }

        [Fact]
        public void TestSolutionWithKEqualToOne()
        {
            var solution = new Solution();
            int[] A = { 1, 2, 3, 4, 1, 1, 3 };
            int result = solution.solution(1, A);
            Assert.Equal(A.Length, result);
        }
    }
}