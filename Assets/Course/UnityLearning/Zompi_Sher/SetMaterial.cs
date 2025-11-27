using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMaterial : MonoBehaviour
{
    public bool Run = false;
    public Shader shader;
    public Texture texture;
    public Color color;

    void Start()
    {
        Renderer rend = GetComponent<Renderer> ();
        if(Run)
        {
            rend.material = new Material(shader);
            rend.material.mainTexture = texture;
            rend.material.color = color;
        }
        
    }

}
