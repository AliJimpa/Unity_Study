using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController2 : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab = null;
    private GameObject _enemy;


    void Update() {

        if (_enemy == null) 
        {
            _enemy = Instantiate(enemyPrefab) as GameObject;
            _enemy.transform.position = new Vector3(transform.position.x, 1, transform.position.z);
            float angle = Random.Range(0, 360);
            _enemy.transform.Rotate(0, angle, 0);
        }



    }


}
