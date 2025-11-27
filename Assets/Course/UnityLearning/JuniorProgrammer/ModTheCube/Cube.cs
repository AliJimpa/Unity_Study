using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;


    private Material material;
    private Vector3 rotatespeed;
    
    void Start()
    {
        InvokeRepeating("SetNewData" , 1 , 1.5f );
        material = Renderer.material;
    }
    
    void SetNewData()
    {
        transform.position = new Vector3( Random.Range(-2,2) , Random.Range(-2,2) , Random.Range(-2,2));
        transform.localScale = new Vector3( Random.Range(1f,2f) , Random.Range(1f,2f) , Random.Range(1f,2f) ) * 2;
        rotatespeed =  new Vector3( Random.Range(-100,100) * Time.deltaTime, 0.0f, 0.0f );
        material.color = new Color ( Random.Range(0.0f , 1.0f) , Random.Range(0.0f , 1.0f) , Random.Range(0.0f , 1.0f) ,Random.Range(0.0f , 1.0f));

    }

    private void Update() {
        transform.Rotate(rotatespeed);
    }




}
