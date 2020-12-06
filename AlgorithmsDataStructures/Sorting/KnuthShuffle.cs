using System;

namespace AlgorithmsDataStructures.Sorting
{
    public static class KnuthShuffle<T>
        where T : IComparable<T>
    {
        public static void Shuffle(T[] elements)
        {
            var random = new Random(); // you probably should choose some sophisticated seed value for more serious tasks.
            for (int i = 0; i < elements.Length; i++)
            {
                int index = random.Next(i + 1); // random between 0 and i provides the uniform randomness (0 to N on each iteration would be worse).
                Exchange(elements, i, index);
            }
        }

        private static void Exchange(T[] elements, int firstIndex, int secondIndex)
        {
            T temp = elements[firstIndex];
            elements[firstIndex] = elements[secondIndex];
            elements[secondIndex] = temp;
        }
    }
}
