using UnityEngine;
using System.Collections;

public class GameStatus : MonoBehaviour
{

    private float deltaTime;
    private string FPS;

    void Update()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        float fps = 1.0f / deltaTime;
        FPS = Mathf.Ceil(fps).ToString();
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 100, 25), FPS);
        GUI.Box(new Rect(10, 35, 100, 25), deltaTime.ToString());
    }

    

}