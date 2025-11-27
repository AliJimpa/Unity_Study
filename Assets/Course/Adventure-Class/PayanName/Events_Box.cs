using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;


public class Events_Box : MonoBehaviour
{

    public GameObject Inventory_R;
    public List<Sprite> SpriteList;
    public Image V1;
    public Image V2;
    public Image V3;
    public UnityEvent AW;




    private bool BaseFlipActivity  = false;





     public void Exit()
    {
       Application.Quit();
    }


    public void LoadSceneEvent(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void FlipActivityObj(GameObject Panel)
    {
        if(BaseFlipActivity){
            Panel.SetActive(false);
            BaseFlipActivity = false;
            Manager_Base.Instance.SetInventory(false);
        }else{
            Panel.SetActive(true);
            BaseFlipActivity = true;
            Manager_Base.Instance.SetInventory(true);
        }
        
    }
    
    public void DestroyTarget(GameObject Target)
    {
        if (Target != null)
        {
            Destroy(Target, 0);
        }
        
    }
    public void DestroyComponent(Intractibel Target)
    {
        if (Target != null)
        {
            Destroy(Target, 0);
        }
        
    }


    public void DestroyTarget_F()
    {
        Manager_Base.Instance.E_MessageT(false);
        Manager_Base.Instance.IntractibleFalse();
    }


    public void PressE()
    {
        if(Manager_Base.Instance.GetEcondition())
        {
            Manager_Base.Instance.SetInventory(true);
            Inventory_R.SetActive(true);
        }else{

        }
    }



    public void InventoryUpdate()
    {
        for (int i = 0; i < 3; i++)
        {
            if (i==0)
            {
                V1.sprite = SetImage(Manager_Base.Instance.Value1);
            }
            if (i==1)
            {
                V2.sprite = SetImage(Manager_Base.Instance.Value2);
            }
            if (i==2)
            {
                V3.sprite = SetImage(Manager_Base.Instance.Value3);
            }
        }
    }



    private Sprite SetImage(Varibale_Game.Obj Target_Obj)
    {
        Sprite xs = SpriteList[0];
        switch (Target_Obj)
        {
            case Varibale_Game.Obj.Empty:
                xs = SpriteList[0];
                break;
            case Varibale_Game.Obj.Fire_Axe:
                xs = SpriteList[2];
                break;
            case Varibale_Game.Obj.Light_01:
                xs = SpriteList[3];
                break;
            case Varibale_Game.Obj.Light_02:
                xs = SpriteList[3];
                break;
            default:
                xs = SpriteList[1];
                break;
        }
        return xs;
    }



    




    public void SetRotation(GameObject Target)
    {
        Target.transform.Rotate(0,0,50);
    }




    public void EndGAme()
    {
        StartCoroutine(EndGame());
    }


    public void ClickonInventoryOption(int a1)
    {
        if (Manager_Base.Instance.IsEqual(a1))
        {
            Manager_Base.Instance.SetInventory(false);
            Inventory_R.SetActive(false);
            Manager_Base.Instance.RrmovObject(a1);
            Manager_Base.Instance.GetRefrence().DoWork();
        }else{
            Manager_Base.Instance.SetInventory(false);
            Inventory_R.SetActive(false);
            StartCoroutine(ShowMesageImergenci());
        }
        
    }


    private IEnumerator ShowMesageImergenci()
    {
        Manager_Base.Instance.DialogRefrense.ShowMessage("In Object baraye in ja nist");
        yield return new WaitForSeconds(5);
        Manager_Base.Instance.DialogRefrense.CloseMessage();
    }

    private IEnumerator EndGame()
    {
        Manager_Base.Instance.DialogRefrense.ShowMessage("THE_END");
        yield return new WaitForSeconds(5);
        Manager_Base.Instance.DialogRefrense.CloseMessage();
        yield return new WaitForSeconds(1);
        LoadSceneEvent("Menu");
    }


    
    private IEnumerator JustShowMessage()
    {
        Manager_Base.Instance.DialogRefrense.ShowMessage("Error");
        yield return new WaitForSeconds(2);
        Manager_Base.Instance.DialogRefrense.CloseMessage();
    }
    


    public void OnSubmitName(Text Textname) {
        if (Textname.text == "1212")
        {
            AW.Invoke();
        }else{
            StartCoroutine(JustShowMessage());
        }
	}














}
