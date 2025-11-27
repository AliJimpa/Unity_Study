using UnityEngine;
using System.Collections;

public class DeviceOperator2 : MonoBehaviour {
	public float radius = 1.5f;

	void Update() {
		if (Input.GetButtonDown("Fire1")) {
			Collider[] hitColliders = Physics.OverlapSphere(transform.position, radius);
			foreach (Collider hitCollider in hitColliders) {
				Vector3 direction = hitCollider.transform.position - transform.position;
				if (Vector3.Dot(transform.forward, direction.normalized) > 0.5f) {
					hitCollider.SendMessage("Operate", SendMessageOptions.DontRequireReceiver);
				}
			}
		}
	}
}
