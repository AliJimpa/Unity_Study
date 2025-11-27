using UnityEngine;
using System.Collections;

public class DeviceTrigger2 : MonoBehaviour {
	[SerializeField] private GameObject[] targets = null;

	public bool requireKey;

	void OnTriggerEnter(Collider other) {
		if (requireKey && Managers4.Inventory.equippedItem != "key") {
			return;
		}

		foreach (GameObject target in targets) {
			target.SendMessage("Activate");
		}
	}

	void OnTriggerExit(Collider other) {
		foreach (GameObject target in targets) {
			target.SendMessage("Deactivate");
		}
	}
}
