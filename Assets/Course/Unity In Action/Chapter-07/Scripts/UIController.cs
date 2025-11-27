using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIController : MonoBehaviour {
	[SerializeField] private Text scoreLabel = null;
	[SerializeField] private SettingsPopup settingsPopup =null;
	private int _score;

	void Awake() {
		Messenger.AddListener(GameEvent.ENEMY_HIT, OnEnemyHit);
	}
	void OnDestroy() {
		Messenger.RemoveListener(GameEvent.ENEMY_HIT, OnEnemyHit);
	}

	void Start() {
		_score = 0;
		scoreLabel.text = _score.ToString();
		settingsPopup.Start();
		settingsPopup.Close();
	}

	private void OnEnemyHit() {
		_score += 1;
		scoreLabel.text = _score.ToString();
	}

	public void OnOpenSettings() {
		settingsPopup.Open();
	}

	private void MouseCrruser(bool Set){
		Cursor.visible = Set;
	}

	void Update()
	{
		if(Input.GetMouseButtonDown(1)){
			print("fdgdg");
		}
	}

}
