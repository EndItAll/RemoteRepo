using UnityEngine;
using System.Collections;

namespace EndItAll.ItemSystem
{
    public interface IISEquipable
    {
        ISEquipmentSlot EquipmentSlot { get; }
        bool Equip();
    }
}
