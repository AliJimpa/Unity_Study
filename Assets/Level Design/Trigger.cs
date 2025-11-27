using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject Faz2;
    private void OnTriggerEnter(Collider other) {
        if (Operator.instance.EV01 == 15)
        {
            Faz2.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
