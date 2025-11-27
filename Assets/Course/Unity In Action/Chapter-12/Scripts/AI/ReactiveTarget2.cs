using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveTarget2 : MonoBehaviour
{
    public void ReactToHit() {
        WanderingAI2 behavior = GetComponent<WanderingAI2>();
        if (behavior != null) 
        {
            behavior.SetAlive(false);
        }

        StartCoroutine(Die());
    }



    private IEnumerator Die() {
        this.transform.Rotate(-75, 0, 0);

        yield return new WaitForSeconds(1.5f);

        Destroy(this.gameObject);
    }
    
}
