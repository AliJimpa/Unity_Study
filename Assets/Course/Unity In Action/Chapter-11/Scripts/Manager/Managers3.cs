using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioManager))] 
public class Managers3 : MonoBehaviour {
    public static AudioManager Audio {get; private set;}
    private List<IGameManager3> _startSequence;

    void Awake() {
        Audio = GetComponent<AudioManager>();
        _startSequence = new List<IGameManager3>();
        _startSequence.Add(Audio);
        StartCoroutine(StartupManagers());
    }
    private IEnumerator StartupManagers() {

        
        foreach (IGameManager3 manager in _startSequence) {
            manager.Startup();
        }

        yield return null;
        int numModules = _startSequence.Count;
        int numReady = 0;

        while (numReady < numModules) {
            int lastReady = numReady;
            numReady = 0;
            foreach (IGameManager3 manager in _startSequence) {
                if (manager.status == ManagerStatus3.Started) {
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