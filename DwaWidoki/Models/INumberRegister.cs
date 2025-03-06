using System.Collections.Generic;

namespace DwaWidoki.Models;

public interface INumberRegister
{
    void AddNumber(int n);
    ICollection<int> GetNumbers();
}
