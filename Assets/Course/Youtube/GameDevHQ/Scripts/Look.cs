using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    [SerializeField]
    private Transform Sphear;
    public float A;
    public float B1 = 100;
    public float B2 = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Sphear.position - transform.position;
        Debug.DrawRay(transform.position , direction , Color.red);
        Quaternion Targetrotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation , Targetrotation , Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            float avarage = Mathf.Round(A * B1) / B2;
            Debug.Log(avarage);
        }
    }
}
