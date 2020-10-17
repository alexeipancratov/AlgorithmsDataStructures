﻿namespace UnionFind.Collections.Stacks
{
    public interface IStack
    {
        void Push(string element);

        string Pop();

        bool IsEmpty();
    }
}
