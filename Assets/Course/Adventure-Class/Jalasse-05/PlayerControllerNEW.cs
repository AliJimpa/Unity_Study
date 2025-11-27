using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;


public class PlayerControllerNEW : MonoBehaviour
{
    private NavMeshAgent nav = null;

    public Camera camera1;

    

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0) )
        {
            RaycastHit hit;
            Ray ray = camera1.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray,out hit,1000f))
            {
                nav.SetDestination(hit.point);
            }
        }
        
    }

    ///EventSystem.current.IsPointerOverGameObject()==false

}
