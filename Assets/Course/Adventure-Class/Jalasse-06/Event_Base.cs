using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Event_Base : MonoBehaviour
{

    public void Exit()
    {
       Application.Quit();
    }


    public void LoadSceneEvent(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }


    
        
    


}
