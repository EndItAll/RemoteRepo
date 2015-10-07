using UnityEngine;
using System.Collections;

namespace EndItAll.ItemSystem
{
    public interface IISObject
    {
        //name
        //value - money
        //icon
        //burden
        //qualitylevel
        string Name { get; set; }
        int Value { get; set; }
        Sprite Icon { get; set; }
        int Burden { get; set; }
        ISQuality Quality { get; set; }


        //these go to other item interfaces
        //questItem flag
    }
}