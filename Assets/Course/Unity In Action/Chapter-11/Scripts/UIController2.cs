using UnityEngine;
using System.Collections;
public class UIController2 : MonoBehaviour {
    [SerializeField] private SettingsPoupup2 popup = null;


    void Start() {
        popup.gameObject.SetActive(false);
    }

    void Update() {

        if (Input.GetKeyDown(KeyCode.M)) {
            bool isShowing = popup.gameObject.activeSelf;
            popup.gameObject.SetActive(!isShowing);

            if (isShowing) {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            } else {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }

        }

    }



}