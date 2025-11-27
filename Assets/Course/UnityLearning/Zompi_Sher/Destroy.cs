using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    Material m_Material;
    public KeyCode  SelectInput;

    // Start is called before the first frame update
    void Start()
    {
        m_Material = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(SelectInput))
        {
            Destroy(gameObject);
        }

    }

    void OnDestroy()
        {
          Destroy(m_Material);
        }



}
