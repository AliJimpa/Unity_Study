using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharater2 : MonoBehaviour
{
    public void Hurt(int damage) {
        Managers4.Player.ChangeHealth(-damage);
    }

}
