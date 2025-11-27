using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick_Obj : MonoBehaviour
{

    public Varibale_Game.Obj Type;

    private int EmptyIndex = -1;
    
   

    private void OnTriggerEnter(Collider other)
    {
        if (other !=null  &&  other.tag == "Player")
        {
            if (isvalidinventory())
            {
                Manager_Base.Instance.AddObject(Type , EmptyIndex);
                Destroy(gameObject);
            }else{
                StartCoroutine(ShowMesageImergenci());
            }
        }
        

    }





    private bool isvalidinventory()
    {
        bool rtx = false;
        EmptyIndex = -1;
        for (int i = 0; i < 3; i++)
        {
            if(i == 0 && Manager_Base.Instance.Value1 == Varibale_Game.Obj.Empty){rtx = true; EmptyIndex = 1; }
            if(i == 1 && Manager_Base.Instance.Value2 == Varibale_Game.Obj.Empty){rtx = true; EmptyIndex = 2; }
            if(i == 2 && Manager_Base.Instance.Value3 == Varibale_Game.Obj.Empty){rtx = true; EmptyIndex = 3; }
        }
        return rtx;
    }



    

    private IEnumerator ShowMesageImergenci()
    {
        Manager_Base.Instance.DialogRefrense.ShowMessage("Inventory Shoma Fazaye Kafi Nadarad");
        yield return new WaitForSeconds(5);
        Manager_Base.Instance.DialogRefrense.CloseMessage();
    }





}
