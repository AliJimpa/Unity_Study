using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(DataManager))]
[RequireComponent(typeof(PlayerManager4))]
[RequireComponent(typeof(InventoryManager4))]
[RequireComponent(typeof(NetworkService4))]
[RequireComponent(typeof(MissionManager))]
public class Managers4 : MonoBehaviour {
	public static DataManager Data {get; private set;}
	public static PlayerManager4 Player {get; private set;}
	public static InventoryManager4 Inventory {get; private set;}
	public static NetworkService4 network {get; private set;}
	public static MissionManager Mission {get; private set;}
	

	private List<IGameManager4> _startSequence;
	
	void Awake() {
		DontDestroyOnLoad(gameObject);

		Data = GetComponent<DataManager>();
		Player = GetComponent<PlayerManager4>();
		Inventory = GetComponent<InventoryManager4>();
		network = GetComponent<NetworkService4>();
		Mission = GetComponent<MissionManager>();

		_startSequence = new List<IGameManager4>();
		_startSequence.Add(Player);
		_startSequence.Add(Inventory);
		_startSequence.Add(Mission);
		_startSequence.Add(Data);

		StartCoroutine(StartupManagers());
	}

	private IEnumerator StartupManagers() {

		foreach (IGameManager4 manager in _startSequence) {
			manager.Startup(network);
		}

		yield return null;

		int numModules = _startSequence.Count;
		int numReady = 0;
		
		while (numReady < numModules) {
			int lastReady = numReady;
			numReady = 0;
			
			foreach (IGameManager4 manager in _startSequence) {
				if (manager.status == ManagerStatus4.Started) {
					numReady++;
				}
			}
			
			if (numReady > lastReady) {
				Debug.Log("Progress: " + numReady + "/" + numModules);
				Messenger<int, int>.Broadcast(StartupEvent.MANAGERS_PROGRESS, numReady, numModules);
			}
			yield return null;
		}
		
		Debug.Log("All managers started up");
		Messenger.Broadcast(StartupEvent.MANAGERS_STARTED);
	}
}
