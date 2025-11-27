using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMaterialWithMouse : MonoBehaviour
{
     Material m_Material;

    void Start()
    {
        //Fetch the Material from the Renderer of the GameObject
        m_Material = GetComponent<Renderer>().material;
        print("Materials " + Resources.FindObjectsOfTypeAll(typeof(Material)).Length);
    }

    void Update()
    {
        
    }

    void OnMouseOver()
    {
        // Change the Color of the GameObject when the mouse hovers over it
        m_Material.color = Color.red;
    }

    void OnMouseExit()
    {
        //Change the Color back to white when the mouse exits the GameObject
        m_Material.color = Color.white;
    }

    
    
}
