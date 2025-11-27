using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Manager_Base : MonoBehaviour
{
   
    public Varibale_Game.Obj Value1;
    public Varibale_Game.Obj Value2;
    public Varibale_Game.Obj Value3;
    public GameObject E_Message;
    public DialogConfg DialogRefrense;
    public Events_Box EventBox_R;


    public static Manager_Base Instance;

    

    private bool Econditon;
    private Varibale_Game.Obj TargetObj;
    private Intractibel Refrence;
    private bool INventory = false;



    private void Awake() {
        Instance = this;
        EventBox_R.InventoryUpdate();
    }


    public void SetIntractible( Varibale_Game.Obj a2 ,Intractibel a3) 
    {
        Econditon = true;
        TargetObj = a2;
        Refrence = a3;
    }

    public void IntractibleFalse()
    {
        Econditon = false;
    }



    public void AddObject(Varibale_Game.Obj e1 , int r1)
    {
        switch (r1)
        {
            case 1:
                Value1 = e1;
                break;
            case 2:
                Value2 = e1;
                break;
            case 3:
                Value3 = e1;
                break;
        }
        EventBox_R.InventoryUpdate();
    }

    public void RrmovObject(int t1)
    {
        switch (t1)
        {
            case 1:
                Value1 = Varibale_Game.Obj.Empty;
                break;
            case 2:
                Value2 = Varibale_Game.Obj.Empty;
                break;
            case 3:
                Value3 = Varibale_Game.Obj.Empty;
                break;
        }
        EventBox_R.InventoryUpdate();
    }


    public void E_MessageT(bool a1)
    {
        E_Message.SetActive(a1);
    }

    public bool GetEcondition()
    {
        return Econditon;
    }

    public Intractibel GetRefrence()
    {
        return Refrence;
    }

    public bool IsEqual(int s1)
    {
        bool er = false;
        switch (s1)
        {
            case 1:
                if (Value1 == TargetObj){ er = true; }else{ er = false; }
                break;
            case 2:
                if (Value2 == TargetObj){ er = true; }else{ er = false; }
                break;
            case 3:
                if (Value3 == TargetObj){ er = true; }else{ er = false; }
                break;
            default:
                er = false;
                break;
        }
        return er;
    }

    public bool IsInventoryOn()
    {
        return INventory;
    }

    public void SetInventory(bool w1)
    {
        INventory = w1;
    }






}
