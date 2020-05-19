using System;
namespace Strategy
{
    // strategy pattern
    public interface Comparator<T>
    {
        int Compare(T o1, T o2);
    }
}
