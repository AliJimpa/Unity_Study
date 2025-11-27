using UnityEngine;
using System.Collections;

public class PlayerCharacter_UI : MonoBehaviour {
	private int _health;

	void Start() {
		_health = 5;
	}

	public void Hurt(int damage) {
		_health -= damage;
		Debug.Log("Health: " + _health);
	}
}
