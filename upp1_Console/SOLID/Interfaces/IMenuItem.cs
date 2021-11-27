using System;

namespace SOLID.Interfaces
{
    public interface IMenuItem
    {
        string Name { get; set; }
        Action RunThis { get; set; }
        int Selector { get; set; }
    }
}