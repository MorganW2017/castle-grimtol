using System.Collections.Generic;
namespace CastleGrimtol.Project
{
    public interface IGame
    {
        Room ActiveRoom { get; set; }
        Player Character { get; set; }
        void Setup();
        void Reset();
        void UseItem(string itemName);
    }
}