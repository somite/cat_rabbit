using UnityEngine;

public class frog : baseanimal
{
    [Header("是否有保護色")]
    public bool haveColor;

    private SpriteRenderer spr;

    //喚醒事件在start之前一次
    private void Awake()
    {
        //取得變色元件
        spr = GetComponent<SpriteRenderer>();

        //如果有保護色就宣染為灰色
        if (haveColor) spr.color = new Color(0.5f, 0.5f, 0.5f);
    }
}
