using System;
namespace Strategy
{
    public interface Comparable<T>
    {
        sbyte CompareTo(T a);
    }
}
