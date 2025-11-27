using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_US : MonoBehaviour
{
    public float minspeed = 12;
    public float maxspeed = 16;
    public float maxtorque = 10;
    public float xrange = 4;
    public float yspawnpos = -6;
    public int pointValue = 5;
    public ParticleSystem Explotioneffect;


    private Rigidbody targetRB;
    private GameManagerUS5 gameManager;


    // Start is called before the first frame update
    void Start()
    {
        targetRB = GetComponent<Rigidbody>();
        targetRB.AddForce(RandomForce(), ForceMode.Impulse);
        targetRB.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        transform.position = RandomSpawnPos();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManagerUS5>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minspeed, maxspeed);
    }
    float RandomTorque()
    {
        return Random.Range(-maxtorque, maxtorque);
    }
    Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xrange, xrange), yspawnpos);
    }

    private void OnMouseDown()
    {
        if (gameManager.IsActive)
        {
            Destroy(gameObject);
            Instantiate(Explotioneffect, transform.position, Explotioneffect.transform.rotation);
            pointValue += 5;
            gameManager.Updatescore(pointValue);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if (!gameObject.CompareTag("Bad"))
        {
            gameManager.GameOver();
        }
    }

    public void DestroyTarget()
    {
        if (gameManager.IsActive)
        {
            Destroy(gameObject);
            Instantiate(Explotioneffect, transform.position,Explotioneffect.transform.rotation);
            gameManager.Updatescore(pointValue);
        }
    }

}
