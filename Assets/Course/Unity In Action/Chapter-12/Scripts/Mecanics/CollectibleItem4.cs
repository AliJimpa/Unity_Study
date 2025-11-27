using UnityEngine;
using System.Collections;

public class CollectibleItem4 : MonoBehaviour {
	[SerializeField] private string itemName = null;

	void OnTriggerEnter(Collider other) {
		Managers4.Inventory.AddItem(itemName);
		Destroy(this.gameObject);
	}
}
