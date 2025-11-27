using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SettingsPopup : MonoBehaviour {
	[SerializeField] private Slider speedSlider = null;
	[SerializeField] private Text NameViewer = null ;
	
	public void Start() {
		NameViewer.text = "";
		PlayerPrefs.SetFloat("speed", 0);
		speedSlider.value = PlayerPrefs.GetFloat("speed");
	}

	public void Open() {
		gameObject.SetActive(true);
	}
	public void Close() {
		gameObject.SetActive(false);
	}

	public void OnSubmitName(Text Textname) {
		NameViewer.text = Textname.text;
	}
	
	public void OnSpeedValue() {
		float speed = speedSlider.value;
		Messenger<float>.Broadcast(GameEvent.SPEED_CHANGED, speed);
		PlayerPrefs.SetFloat("speed", speed);
	}

}
