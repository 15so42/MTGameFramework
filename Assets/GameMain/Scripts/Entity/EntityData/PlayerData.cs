using System.Collections;
using System.Collections.Generic;
using GameMain;
using UnityEngine;

public class PlayerData : TargetableObjectData
{
   

    public PlayerData(int entityId, int typeId, CampType camp=CampType.Player) : base(entityId, typeId, camp)
    {
    }

    public override int MaxHP { get; }
}
