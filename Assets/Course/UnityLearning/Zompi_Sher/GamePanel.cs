using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePanel : MonoBehaviour
{ 
    
    public int selectedOBJ;
    public bool Userandom;
    public List<GameObject> BaseData;
    public float PowerImpuls;
    private GameObject TargetOBJ;

    // Start is called before the first frame update
    void Start()
    {
       TargetOBJ = BaseData[selectedOBJ];
    }

    // Update is called once per frame
    void Update()
    {
        if(Userandom)
        {
            TargetOBJ = BaseData[1];
        }
        
     InputManager();

    }



    void InputManager()
    {
         if (Input.GetKeyDown(KeyCode.W))
        {
            AddForce(TargetOBJ,-PowerImpuls,PowerImpuls,0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            AddForce(TargetOBJ,0,0,-PowerImpuls);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            AddForce(TargetOBJ,PowerImpuls,0,0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            AddForce(TargetOBJ,0,0,PowerImpuls);
        }
    }



    void AddForce(GameObject GO1 , float X1 , float Y1 , float Z1)
    {
        Rigidbody rb = GO1.GetComponent<Rigidbody> ();
        rb.AddForce(X1, Y1 , Z1 , ForceMode.Impulse);
    }




}
