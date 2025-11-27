using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : MonoBehaviour
{
    public GameObject Crate_;
    public GameObject Explotion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if ( Input.GetKeyDown(KeyCode.Space) )
        {
            Instantiate(Explotion , transform.position , Quaternion.identity);
            GameObject Cratert =  Instantiate(Crate_ , transform.position , Quaternion.identity) as GameObject;
            Rigidbody[] rigidbodyallchild = Cratert.GetComponentsInChildren<Rigidbody>();
            if (rigidbodyallchild.Length > 0)
            {
                foreach (var item in rigidbodyallchild)
                {
                    item.AddExplosionForce(500,transform.position , 1);
                }
            }
            Destroy(this.gameObject);
        }
    }
}
