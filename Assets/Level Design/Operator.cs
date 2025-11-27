using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operator : MonoBehaviour
{
    public static Operator instance;
    public GameObject Door01;
    public int EV01;
    public GameObject Obj01;
    public GameObject Door02;
    public int EV02;
    public GameObject Obj02;
    public GameObject Door03;
    public int EV03;
    public GameObject Obj03;
    public List<GameObject> Parametr;

    private int VVC = 0;

    private void Awake() {
        instance = this;
    }
    public void Iamdone(int door)
    {
        switch (door)
        {
            case 1:
                EV01--;
                if (EV01 == 0)
                {
                    Door01.SetActive(false);
                    Obj01.SetActive(true);
                }
                break;
            case 2:
                EV02--;
                if (EV02 == 0)
                {
                    Door02.SetActive(false);
                    Obj02.SetActive(true);
                }
                break;
            case 3:
                EV03--;
                if (EV03 == 0)
                {
                    Door03.SetActive(false);
                    Obj03.SetActive(true);
                }
                break;
            default:
                break;
        }
    }

    public void Imindor3()
    {
        VVC++;
        if (VVC < Parametr.Count)
        {
            Parametr[VVC].SetActive(true);
        }
        print(VVC + "//" + EV03);
    }




}
