using UnityEngine;
using System.Collections;

public class PlatformerPlayer : MonoBehaviour {
	public float speed = 4.5f;
	public float jumpForce = 12.0f;

	private BoxCollider2D _box;
	private Rigidbody2D _body;
	private Animator _anim;

	// Use this for initialization
	void Start() {
		_box = GetComponent<BoxCollider2D>();
		_body = GetComponent<Rigidbody2D>();
		_anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update() {

		//Get Input & Set MovementScale and put on Physics_Velocity
		float deltaX = Input.GetAxis("Horizontal") * speed;
		Vector2 movement = new Vector2(deltaX, _body.linearVelocity.y);
		_body.linearVelocity = movement;

		//Find Revers of Is_In_Air
		Vector3 max = _box.bounds.max;
		Vector3 min = _box.bounds.min;
		Vector2 corner1 = new Vector2(max.x, min.y - .1f);
		Vector2 corner2 = new Vector2(min.x, min.y - .2f);
		Collider2D hit = Physics2D.OverlapArea(corner1, corner2);
		bool grounded = false;
		if (hit != null) {
			grounded = true;
		}

		//Gravity set nun for Slope
		_body.gravityScale = (grounded && Mathf.Approximately(deltaX, 0)) ? 0 : 1;

		//if was grounded and press space Jump
		if (grounded && Input.GetKeyDown(KeyCode.Space)) {
			_body.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
		}

		//Attach to platform
		MovingPlatform platform = null;
		if (hit != null) {
			platform = hit.GetComponent<MovingPlatform>();
		}
		if (platform != null) {
			transform.parent = platform.transform;
		} else {
			transform.parent = null;
		}
		

		//Set Animation Parametr
		_anim.SetFloat("speed", Mathf.Abs(deltaX));

		//Set Curect Scale
		Vector3 pScale = Vector3.one;
		if (platform != null) {
			pScale = platform.transform.localScale;
		}
		//if deltaX have Larg Distance withe Ziro So 
		if (!Mathf.Approximately(deltaX, 0)) {
			transform.localScale = new Vector3(Mathf.Sign(deltaX) / pScale.x, 1/pScale.y, 1);
		}


	}
}
