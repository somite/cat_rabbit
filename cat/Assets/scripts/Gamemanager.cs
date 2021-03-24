
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public static int appleFirst;
    public static float appleInterval;

    public static int frogHaveColor;
    public float frogHaveColorLife;
    public int frogHaveColorEAT;

    public static int frogNoColor;
    public float frogNoColorLife;
    public int frogNoColorEAT;

    public static int aboiginalHaveColor;
    public float aboiginalHaveColorLife;
    public int aboiginalHaveColorEAT;

    public static int aboiginalNoColor;
    public float aboiginalNoColorLife;
    public int aboiginalNoColorEAT;

    [Header("青蛙保護色")]
    public frog objFrogHaveColor;
    [Header("青蛙跑得快")]
    public frog objFrogNoColor;
    [Header("原住民眼睛好")]
    public abreginol objAboriginalGoodEye;
    [Header("原住民跑得快")]
    public abreginol objAboriginalBadEye;



    public void AppleFirst(string getValue)
    {
        
        appleFirst = Int32.Parse(getValue);

    }

    public void AppleInterval(string getValue)
    {

        appleInterval = Single.Parse(getValue);

    }
    //青蛙保護色
    public void FrogHaveColor(string getValue)
    {

        frogHaveColor = Int32.Parse(getValue);
    }

    public void FrogHaveColorLife(string getValue)
    {

        frogHaveColorLife = Single.Parse(getValue);
        objFrogHaveColor.lifetime = frogHaveColorLife;
    }

    public void FrogHaveColorEAT(string getValue)
    {

        frogHaveColorEAT = Int32.Parse(getValue);
        objFrogHaveColor.eatCount = frogHaveColorEAT;
    }
    //青蛙跑得快
    public void FrogNoColor(string getValue)
    {

        frogNoColor = Int32.Parse(getValue);
       
    }

    public void FrogNoColorLife(string getValue)
    {

        frogNoColorLife = Single.Parse(getValue);
        objFrogNoColor.lifetime = frogNoColorLife;
    }

    public void FrogNoColorEAT(string getValue)
    {

        frogNoColorEAT = Int32.Parse(getValue);
         objFrogNoColor.eatCount = frogNoColorEAT;

    }
        //原住民眼睛好
        public void AboiginalHaveColor(string getValue)
    {

        aboiginalHaveColor = Int32.Parse(getValue);
    }

    public void AboiginalHaveColorLife(string getValue)
    {

        aboiginalHaveColorLife = Single.Parse(getValue);
        objAboriginalGoodEye.lifetime = aboiginalHaveColorLife;
    }

    public void AboiginalHaveColorEAT(string getValue)
    {

        aboiginalHaveColorEAT = Int32.Parse(getValue);
        objAboriginalGoodEye.eatCount = aboiginalHaveColorEAT;
    }
//原住民跑得快
    public void AboiginalNoColor(string getValue)
        {

        aboiginalNoColor = Int32.Parse(getValue);
        }

    public void AboiginalNoColorLife(string getValue)
        {

        aboiginalNoColorLife = Single.Parse(getValue);
        objAboriginalBadEye.lifetime = aboiginalNoColorLife;
        }

    public void AboiginalNoColorEAT(string getValue)
        {

        aboiginalNoColorEAT = Int32.Parse(getValue);
        objAboriginalBadEye.eatCount = aboiginalNoColorEAT;
        }

    //載入場景
    public void loadScene()
    {
        SceneManager.LoadScene("遊戲場景");
    }

    public void UseFaulPlay()
    {
        appleFirst =  40;
        appleInterval = 0.05f;

        frogNoColor = 6;
        objFrogNoColor.lifetime = 2;
        objFrogNoColor.eatCount = 2;

        frogHaveColor = 6;
        objFrogHaveColor.lifetime = 2;
        objFrogHaveColor.eatCount = 2;

        aboiginalNoColor = 1;
        objAboriginalBadEye.lifetime = 3;
        objAboriginalBadEye.eatCount = 12;


        aboiginalHaveColor = 1;
        objAboriginalGoodEye.lifetime = 3;
        objAboriginalGoodEye.eatCount = 12;

        loadScene();

    }


    }
