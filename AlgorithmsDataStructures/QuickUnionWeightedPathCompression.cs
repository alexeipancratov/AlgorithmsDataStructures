﻿namespace AlgorithmsDataStructures
{
    public class QuickUnionWeightedPathCompression : IUnionFind
    {
        private readonly int[] _parents;
        private readonly int[] _treeSizes;

        public QuickUnionWeightedPathCompression(int numberOfElements)
        {
            _parents = new int[numberOfElements];
            _treeSizes = new int[numberOfElements];

            for (int i = 0; i < numberOfElements; i++)
            {
                _parents[i] = i;
                _treeSizes[i] = 1;
            }
        }

        public bool AreConnected(int p, int q) => GetRoot(p) == GetRoot(q);

        public void Union(int p, int q)
        {
            int pRoot = GetRoot(p);
            int qRoot = GetRoot(q);
            int nodeToMove;
            int nodeToAttachTo;

            if (_treeSizes[pRoot] >= _treeSizes[qRoot])
            {
                nodeToMove = qRoot;
                nodeToAttachTo = pRoot;
                _treeSizes[pRoot] += _treeSizes[qRoot];
            }
            else
            {
                nodeToMove = pRoot;
                nodeToAttachTo = qRoot;
                _treeSizes[qRoot] += _treeSizes[pRoot];
            }

            _parents[nodeToMove] = nodeToAttachTo;
        }

        private int GetRoot(int i)
        {
            while (_parents[i] != i)
            {
                _parents[i] = _parents[_parents[i]]; // As a side effect optimization compress the path by setting the parent to grandparent.
                i = _parents[i];
            }

            return i;
        }
    }
}
