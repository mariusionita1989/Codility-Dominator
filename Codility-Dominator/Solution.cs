using System.Runtime.CompilerServices;

namespace Codility_Dominator
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 0;
        public const int RANGE_HIGHEST_VALUE = 100000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int[] A)
        {
            int N = A.Length;
            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE) 
            {
                if (N == 0)
                    return -1;

                int candidate = A[0];
                int count = 1;

                for (int i = 1; i < N; i++)
                {
                    if (count == 0)
                    {
                        candidate = A[i];
                        count = 1;
                    }
                    else if (candidate == A[i])
                        count++;
                    else
                        count--;
                }

                count = 0;
                int candidateIndex = -1;
                for (int i = 0; i < N; i++)
                {
                    if (A[i] == candidate)
                    {
                        count++;
                        candidateIndex = i;
                    }
                }

                if (count > N / 2)
                    return candidateIndex;

                return -1;
            }

            return -1;
        }
    }
}
