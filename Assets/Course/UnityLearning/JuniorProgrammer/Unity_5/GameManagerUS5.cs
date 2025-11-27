using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManagerUS5 : MonoBehaviour
{

    public List<GameObject> targets;
    public float spawnrate = 1.0f;
    public TMP_Text scoreText;
    public TMP_Text gameoverText;
    public bool IsActive;
    public GameObject ButonR;
    public GameObject Titlescreen;
    public GameObject Pausescrenn;


    private int score;
    private bool ispause = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void StartGame(float dif)
    {
        spawnrate = dif;
        Titlescreen.SetActive(false);
        IsActive = true;
        StartCoroutine(SpawnTarget());
        Updatescore(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Pause( ispause == true ? false : true );
        }

    }

    public void Updatescore(int a)
    {
        score = a;
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        gameoverText.gameObject.SetActive(true);
        ButonR.SetActive(true);
        IsActive = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    IEnumerator SpawnTarget()
    {
        while (IsActive)
        {
            yield return new WaitForSeconds(spawnrate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }

    public void Pause(bool a1)
    {
        if (a1)
        {
            Pausescrenn.SetActive(true);
            Time.timeScale = 0;
            ispause = true;
        }
        else
        {
            Pausescrenn.SetActive(false);
            Time.timeScale = 1;
            ispause = false; 
        }
    }


}
