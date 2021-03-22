
using UnityEngine;

public class spawnapple : spawnManager
{
    //喚醒在start前執行一次
    private void Awake()
    {
        interval = Gamemanager.appleInterval;
        count = Gamemanager.appleFirst;

    }
}
