
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    //欄位
    //時間
    //int整數
    //float浮點數

    //欄位
    //類型  名稱  指定值;
    //public顯示在面板
    public float interval = 2.5f;
    //存放物件可以用GameObject
    public GameObject apple;

    //事件
    //開始事件
    private void Start()
    {
        //輸出API
        spawn();
    }
    //自訂函式
    //語法
    public void spawn()
    {
        Instantiate(apple);
    }



        }
