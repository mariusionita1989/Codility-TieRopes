using System.Runtime.CompilerServices;

namespace Codility_TieRopes
{
    public class Solution
    {
        private const int RANGE_LOWEST_VALUE = 1;
        private const int RANGE_HIGHEST_VALUE = 100000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int K, int[] A)
        {
            int count = 0;  
            int currentLength = 0;  
            int N = A.Length;

            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE &&  // N>=1 and N<=100000
                K >= RANGE_LOWEST_VALUE && K <= RANGE_HIGHEST_VALUE * 10000) // k>=1 and K<=100000*10000 = 1000000000
            {
                for (int i = 0; i < N; i++)
                {
                    currentLength += A[i];
                    if (currentLength >= K)
                    {
                        count++;  // Increment the count when the currentLength is greater than or equal to K
                        currentLength = 0;  // Reset the currentLength
                    }
                }
            }
            
            return count;
        }
    }
}
