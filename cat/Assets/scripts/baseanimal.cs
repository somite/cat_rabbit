using UnityEngine;
//引用系統list
using System.Collections.Generic;

using System.Linq;

public class baseanimal : MonoBehaviour
{
    [Header("行動速度")]
    public float speed;
    [Header("吃東西的時間")]
    public float eatime;
    [Header("生命沒吃到會死")]
    public float lifetime;
    [Header("吃幾隻會生下一隻")]
    public int eatCount;
    [Header("追蹤目標")]
    public string targetName;
    [Header("目標物件陣列")]
    public GameObject[] targets;
    [Header("目標的距離")]
    public List<float> targetsDistanics;
    [Header("吃幾隻會死亡")]
    public int countEatToDie;
    //統計吃幾隻
    private int countEatTotal;



    private Transform target;

    //原始標籤
    private string tagOriginal;

    private int eatTargetCount;
    //是否正在吃東西
    private bool isEating;
    /// <summary>
    /// 
    /// 搜尋目標
    /// </summary>
    /// 允許被子類別複寫
    protected virtual void FindTarget()
    {
        //遊戲物件陣列
        targets = GameObject.FindGameObjectsWithTag(targetName);
        FindnearTarget();
    }

    protected void FindnearTarget()
    {
        if (targets.Length == 0) return;
        //刪除清單資料
        targetsDistanics.Clear();
        for (int i = 0; i < targets.Length; i++)
        {
            float dis = Vector2.Distance(transform.position, targets[i].transform.position);
            targetsDistanics.Add(dis);
        }
        float min = targetsDistanics.Min();
        print("最近距離" + min);
        int index = targetsDistanics.IndexOf(min);
        print("編號" + index);
        target = targets[index].transform;
    }

    private void track()
    {
        if (target)
        {
            target.tag = "Untagged";
            //變形的二維向量
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            float dis = Vector2.Distance(transform.position, target.position);
            if (dis <= 0&& !isEating) EatTarget();
        }
        else FindTarget();
    }

    private void EatTarget()
    {
        isEating = true;
        Destroy(target.gameObject, eatime);

        CancelInvoke("Dead");
        Invoke("Dead", lifetime);
        Invoke("Spawn", eatime);

        countEatTotal++;

        if (countEatTotal == countEatToDie) Dead();
    }

    private void Spawn()
    {
        //不是在吃東西
        isEating = false;
        //吃目標的數量遞增
        eatTargetCount++;

        if(eatTargetCount%eatCount==0)
        {

            Invoke("SpawnDelay", 0.5f);
        }
    }

    private void SpawnDelay()
    {
            Vector2 pos = transform.position;
            pos.x = +Random.Range(-2f, 2f);
            //生成下一隻
            GameObject temp = Instantiate(gameObject, pos, Quaternion.identity);
            temp.tag = tagOriginal;
    }

    private void Dead()
    {
        //如果目標物存在就將目標物的標籤恢復
        if (target) target.tag = targetName;
        Destroy(gameObject);
    }

    private void Start()
    {
        tagOriginal = tag;
        FindTarget();
        Invoke("Dead", lifetime);
    }


    private void Update()
    {
        //如果沒有目標 就 再搜尋目標
        if (!target) FindTarget();

        track();
    }

    private void OnDestroy()
    {
        if (target) target.tag = targetName;
    }
}
