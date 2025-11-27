using UnityEngine;
using System.Collections;

public class WeatherController : MonoBehaviour {
	[SerializeField] private Material sky = null;
	[SerializeField] private Light sun = null;
	
	private float _fullIntensity;
	private float _cloudValue = 0f;

	
	
	
	// Use this for initialization
	void Start() {
		_fullIntensity = sun.intensity;
	}
	
	private void Update() {
		SetOvercast(_cloudValue);
		_cloudValue += 0.005f;
	}
	
	private void SetOvercast(float value) {
		sky.SetFloat("_Blend", value);
		sun.intensity = _fullIntensity - (_fullIntensity * value);
	}
}
