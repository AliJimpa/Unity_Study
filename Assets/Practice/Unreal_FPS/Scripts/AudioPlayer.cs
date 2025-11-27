using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public KeyCode SelectInput;
    public AudioClip clip;
    public float volume=1;
    

    void Update()
    {   if (Input.GetKeyDown(SelectInput))
        {
          AudioSource.PlayClipAtPoint(clip, transform.position, volume);
        }
    }

}
