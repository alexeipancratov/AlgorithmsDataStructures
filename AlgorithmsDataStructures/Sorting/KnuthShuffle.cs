using System;

namespace AlgorithmsDataStructures.Sorting
{
    class KnuthShuffle<T> : BaseSort<T>
        where T: IComparable<T>
    {
        public override void Sort(T[] elements)
        {
            var random = new Random();
            for (int i = 0; i < elements.Length; i++)
            {
                int index = random.Next(i + 1);
                Exchange(elements, i, index);
            }
        }
    }
}
