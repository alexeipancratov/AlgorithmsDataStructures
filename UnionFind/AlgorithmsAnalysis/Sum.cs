namespace AlgorithmsDataStructures.AlgorithmsAnalysis
{
    public static class Sum
    {
        // How many elements sum to 0? N
        public static int OneSum(int[] elements)
        {
            int count = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] == 0)
                {
                    count++;
                }
            }

            return count;
        }

        // How many pairs sum to 0? N^2
        public static int TwoSum(int[] elements)
        {
            int count = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = i + 1; j < elements.Length; j++)
                {
                    if (elements[i] + elements[j] == 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        // How many triplets sum to 0? N^3
        public static int ThreeSum(int[] elements)
        {
            int count = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = i + 1; j < elements.Length; j++)
                {
                    for (int k = j + 1; k < elements.Length; k++)
                    {
                        if (elements[i] + elements[j] + elements[k] == 0)
                        {
                            count++;
                        }
                    }
                }
            }

            return count;
        }
    }
}
