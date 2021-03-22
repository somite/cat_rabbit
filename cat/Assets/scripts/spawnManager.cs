
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
    [Header("間隔")]
    public float interval = 2.5f;
    public GameObject obj;
    //存放物件可以用GameObject
    
    public Vector2 posMin = new Vector2(-8, -4);
    public Vector2 posMax = new Vector2(+8, +4);
    //第一次生成的數量
    public int count;

    [Header("第一次生成的間隔")]
    public float intervalfirst = 0.05f;

    [Header("是否需要間格生成")]
    public bool needSpawn;
    [Header("目前物件的數量")]
    public int currentCount;
    //事件
    //開始事件
    private void Start()
    {
       
        //重複呼叫函式名稱, 開始時間, 間隔時間
       InvokeRepeating("spawn", 0, intervalfirst);
    }
    //自訂函式
    //語法
    public void spawn()
    {
        currentCount++;
        //隨機生成地點
        float x = Random.Range(posMin.x, posMax.x);
        float y = Random.Range(posMin.y, posMax.y);

        //生成(物件, 座標, 角度)
        Instantiate(obj,new Vector2(x,y), Quaternion.identity);
        //如果 目前數量 等於 第一次生成數量
        if (currentCount==count)
        {
            CancelInvoke();
            //如果 需要持續生成 就重複呼叫
            if (needSpawn) InvokeRepeating("spawn", interval, interval);
        }
    }



        }
