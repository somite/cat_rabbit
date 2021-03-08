using UnityEngine;

public class baseanimal : MonoBehaviour
{
    [Header("行動速度")]
    public float speed;
    [Header("生命")]
    public float lifetime;
    [Header("吃幾隻")]
    public int eatCount;
    [Header("追蹤目標")]
    public string targetName;
    [Header("目標物件陣列")]
    public GameObject[] targets;


    /// <summary>
    /// 搜尋目標
    /// </summary>
    private void FindTarget()
    {
       //遊戲物件陣列
       targets= GameObject.FindGameObjectsWithTag(targetName);
    }

    private void Start()
    {
        FindTarget();
    }
}
