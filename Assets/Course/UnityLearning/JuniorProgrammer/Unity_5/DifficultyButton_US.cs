using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton_US : MonoBehaviour
{
    public float dificaltyvalue;

    private Button DButton;
    private GameManagerUS5 gamemanger_;
    
    // Start is called before the first frame update
    void Start()
    {
        DButton = GetComponent<Button>();
        gamemanger_ = GameObject.Find("GameManager").GetComponent<GameManagerUS5>();
        DButton.onClick.AddListener(setdificulty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setdificulty()
    {
        gamemanger_.StartGame(dificaltyvalue);
    }
}
