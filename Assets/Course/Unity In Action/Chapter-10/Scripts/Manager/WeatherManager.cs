using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WeatherManager : MonoBehaviour, IGameManager2 {
	public ManagerStatus2 status {get; private set;}

	//public float cloudValue {get; private set;}

	private NetworkService _network;

	public void Startup(NetworkService service) {
		Debug.Log("Weather manager starting...");

		_network = service;
		StartCoroutine(_network.GetWeatherXML(OnXMLDataLoaded));
		status = ManagerStatus2.Initializing;
	}

	public void OnXMLDataLoaded(string data) {
 		Debug.Log(data);
		status = ManagerStatus2.Started;
	}


}
	
