using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Spawner : MonoBehaviour
{
    public GameObject PrifebOBJ;
    public Vector3[] NumberSpawn = new Vector3[]{};
    private GameObject[] OBJs = new GameObject[]{};

    // Start is called before the first frame update
    void Start()
    {
        OBJs = new GameObject[NumberSpawn.Length];
        for (int i = 0; i < OBJs.Length; i++)
        {
            GameObject NGOS = Instantiate (PrifebOBJ);
            OBJs[i] = NGOS;
            NGOS.transform.position = NumberSpawn[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
