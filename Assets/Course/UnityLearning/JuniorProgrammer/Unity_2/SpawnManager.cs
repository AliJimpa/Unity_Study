using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animal;
    public float XRange = 10;
    public Text Txx;


    private int PointGame;

    private void Start()
    {
        InvokeRepeating("SpawnEnemy" , 2 , 1.2f);
        Txx.text = "0";
    }

    void Update()
    {

    }

    void SpawnEnemy()
    {
        int AnimalIndex = Random.Range(0, animal.Length);
        Vector3 Spannpos = new Vector3(Random.Range(-XRange, XRange), 0, transform.position.z);
        Instantiate(animal[AnimalIndex], Spannpos, animal[AnimalIndex].transform.rotation);
    }

    public void SetPointGame(int point)
    {
        PointGame = PointGame + point;
        Txx.text = PointGame.ToString();
        if (PointGame < 0)
        {
            Txx.text = "Loss";
        }
    }

}
