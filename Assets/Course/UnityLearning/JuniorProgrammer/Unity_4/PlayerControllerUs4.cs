using System.Collections;
using UnityEngine;

public class PlayerControllerUs4 : MonoBehaviour
{
    public float speed;
    public bool powerup;
    public GameObject HitPower;

    private GameObject Focalpoint;
    private Rigidbody body;
    private float powerupstright = 15.0f;

    public PowerUpType currentPowerUp = PowerUpType.None;
    public GameObject rocketPrefab;
    private GameObject tmpRocket;
    private Coroutine powerupCountdown;


    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        Focalpoint = GameObject.Find("Focal Point");
        HitPower.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        body.AddForce(Focalpoint.transform.forward * speed * Input.GetAxis("Vertical"));
        body.AddForce(Focalpoint.transform.right * speed * Input.GetAxis("Horizontal"));

        if (powerup)
        {
            HitPower.transform.position = transform.position;
        }

        if (currentPowerUp == PowerUpType.Rockets && Input.GetKeyDown(KeyCode.F))
        {
            LaunchRockets();
        }


    }

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("Enemy") && currentPowerUp == PowerUpType.Pushback)
        {
            Rigidbody enemyRigidbody = other.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = other.gameObject.transform.position -
            transform.position;
            enemyRigidbody.AddForce(awayFromPlayer * powerupstright,
            ForceMode.Impulse);
            Debug.Log("Player collided with: " + other.gameObject.name + " with powerup set to " + currentPowerUp.ToString());
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PowerUp"))
        {
            powerup = true;
            currentPowerUp = other.gameObject.GetComponent<PowerUp_US>().powerUpType;
            HitPower.gameObject.SetActive(true);
            Destroy(other.gameObject);
            if (powerupCountdown != null)
            {
                StopCoroutine(powerupCountdown);
            }
            powerupCountdown = StartCoroutine(PowerupCountdownRoutine());
        }



    }

    void LaunchRockets()
    {
        foreach (var enemy in FindObjectsByType<EnemyUS>(0))
        {
            tmpRocket = Instantiate(rocketPrefab, transform.position + Vector3.up,
            Quaternion.identity);
            tmpRocket.GetComponent<Rocket_US>().Fire(enemy.transform);
        }
    }


    private IEnumerator Powerupcountdownrutine()
    {
        yield return new WaitForSeconds(7);
        powerup = false;
        HitPower.SetActive(false);
    }

    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(7);
        powerup = false;
        currentPowerUp = PowerUpType.None;
        HitPower.gameObject.SetActive(false);
    }




}
