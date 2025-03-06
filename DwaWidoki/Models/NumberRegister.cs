using System.Collections.Generic;

namespace DwaWidoki.Models;

public class NumberRegister : INumberRegister
{
    LinkedList<int> _numbers = new();
    
    public void AddNumber(int n)
    {
        _numbers.AddLast(n);
    }

    public ICollection<int> GetNumbers()
    {
        return _numbers;
    }
}