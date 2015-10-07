using UnityEngine;
using System.Collections;



namespace EndItAll.ItemSystem
{
    public interface IISWeapon
    {
        int MinDamage { get; set; }
        int Attack();

    }
}