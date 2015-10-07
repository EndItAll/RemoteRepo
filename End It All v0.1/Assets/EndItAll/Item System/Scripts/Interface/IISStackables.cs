using UnityEngine;
using System.Collections;


namespace EndItAll.ItemSystem
{
    public interface IISStackables
    {
        int Stack(int amount); //default value of 0
        int MaxStack { get; }
    }
}