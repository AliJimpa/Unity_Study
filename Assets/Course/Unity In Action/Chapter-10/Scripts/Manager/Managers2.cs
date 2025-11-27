using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(WeatherManager))] 
public class Managers2 : MonoBehaviour {
    public static WeatherManager Weather {get; private set;}
    private List<IGameManager2> _startSequence;

    void Awake() {
        Weather = GetComponent<WeatherManager>();
        _startSequence = new List<IGameManager2>();
        _startSequence.Add(Weather);
        StartCoroutine(StartupManagers());
    }
    private IEnumerator StartupManagers() {
        NetworkService network = new NetworkService();
        foreach (IGameManager2 manager in _startSequence) {
            manager.Startup(network);
        }

        yield return null;

        int numModules = _startSequence.Count;
        int numReady = 0;

        while (numReady < numModules) {
            int lastReady = numReady;
            numReady = 0;
            foreach (IGameManager2 manager in _startSequence) {
                if (manager.status == ManagerStatus2.Started) {
                    numReady++;
                }
            }
            if (numReady > lastReady)
                Debug.Log("Progress: " + numReady + "/" + numModules);
            yield return null;
        }

        Debug.Log("All managers started up");
    }



}