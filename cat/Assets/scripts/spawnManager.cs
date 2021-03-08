
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
    [Header("是否需要間格生成")]
    public bool needSpawn;
    [Header("目前物件的數量")]
    public int currentCount;
    //事件
    //開始事件
    private void Start()
    {
        for (int i = 0; i < count; i++)
        {
            spawn();
        }
        //重複呼叫函式名稱, 開始時間, 間隔時間
        if (needSpawn) InvokeRepeating("spawn", interval, interval);
    }
    //自訂函式
    //語法
    public void spawn()
    {
        currentCount++;
        float x = Random.Range(posMin.x, posMax.x);
        float y = Random.Range(posMin.y, posMax.y);

        Instantiate(obj,new Vector2(x,y), Quaternion.identity);
    }



        }
