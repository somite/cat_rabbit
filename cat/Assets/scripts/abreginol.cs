
using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class abreginol : baseanimal
{
    [Header("是否視力良好")]
    public bool goodEyes;

    private SpriteRenderer spr;
    private void Awake()
    {

        spr = GetComponent<SpriteRenderer>();
        if (goodEyes) spr.color = new Color(0.5f, 0.5f, 0.5f);
    }

    //複寫副類別
    protected override void FindTarget()
    {
        GameObject[] originaltarget = GameObject.FindGameObjectsWithTag(targetName);

       if (speed==10&&!goodEyes)
        {
            var newTarget =originaltarget.ToList().Where(x => !x.GetComponent<frog>().haveColor && x.GetComponent<baseanimal>().speed == 10);

            targets = newTarget.ToArray();
        }
       else if (speed==8&& goodEyes)
        {
            var newTarget = originaltarget.ToList().Where(x => x.GetComponent<frog>().haveColor && x.GetComponent<baseanimal>().speed == 8);

            targets = newTarget.ToArray();
        }
        FindnearTarget();
    }
}
