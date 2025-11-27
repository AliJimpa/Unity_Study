using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider UI;
    public int Health_ = 3;
    public int PoinValue =1;

    private void Start() {
        UI.maxValue = Health_;
        UI.value = Health_;
    }

    public void GetDamage()
    {
        int NewHealth = Health_ -1;
        if (NewHealth < 0)
        {
            Destroy(gameObject);
            SpawnManager manage = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
            manage.SetPointGame(PoinValue);

        }else{
            Health_ = NewHealth;
            UI.value = Health_;
        }

    }

    
}
