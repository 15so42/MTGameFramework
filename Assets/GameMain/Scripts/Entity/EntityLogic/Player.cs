using System.Collections;
using System.Collections.Generic;
using GameMain;
using UnityEngine;

public class Player : Entity
{
    private PlayerData PlayerData;
  
    //也没啥需要加载的
    protected override void OnShow(object userData)
    {
        base.OnShow(userData);
        Debug.Log("玩家生成");
    }
}
