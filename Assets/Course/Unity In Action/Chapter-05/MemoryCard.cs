using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour
{
    [SerializeField] private GameObject CardBackObj = null;
    [SerializeField] private Scene_Controller_2D controller2D = null;

    public void OnMouseDown() 
    {
        if (CardBackObj.activeSelf && controller2D.canReveal) 
        {
           CardBackObj.SetActive(false);
           controller2D.CardRevealed(this);
        }
    }

    public void Unreveal() 
    {
        CardBackObj.SetActive(true);
    }

    
    private int _id;

    public int id {
        get {return _id;}
    }

    public void SetCard(int id, Sprite image) 
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }



}
