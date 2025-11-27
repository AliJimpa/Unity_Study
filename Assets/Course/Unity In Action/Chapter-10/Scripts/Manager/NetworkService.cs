using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System;
public class NetworkService {
 	private const string xmlApi = "http://irangdi.ircg.ir/";

 	private IEnumerator CallAPI(string url, Action<string> callback) {

 		using (UnityWebRequest request = UnityWebRequest.Get(url)) {

 			//yield return request.Send();
			 yield return 0;

 			//   >>>if (request.isNetworkError) {<<
			if(request.result == UnityWebRequest.Result.ConnectionError){
 				Debug.LogError("network problem: " + request.error);
 			} else {
		 		if (request.responseCode != (long)System.Net.HttpStatusCode.OK) {
 					Debug.LogError("response error: " + request.responseCode);
 				} else {
 					callback(request.downloadHandler.text);
 				}
 			}

		}

	}

 	public IEnumerator GetWeatherXML(Action<string> Test) {
 	return CallAPI(xmlApi, Test);
 	}



}