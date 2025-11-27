using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Dialog : MonoBehaviour
{

    public GameObject DialogPanel;
    public Text TextMessage;

    public void ShowMessage (string _message)
    {
        DialogPanel.SetActive(true);
        TextMessage.text = _message;
    }



}
