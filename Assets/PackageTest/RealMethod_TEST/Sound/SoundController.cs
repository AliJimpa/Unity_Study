using RealMethod;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public RealMethod.AudioManager audioManager;
    public AudioClip clip;
    public Transform pivot;
    public bool AutoDesttroy;


    [Button]
    private void PlaySound2D()
    {
        audioManager.PlaySound2D(clip);
    }
    [Button]
    private void PlaySound3D()
    {
        audioManager.PlaySound(clip, pivot.position);
    }
    [Button]
    private void PlaySound3DAttach()
    {
        audioManager.PlaySound(clip, Vector3.one, pivot);
    }
    [Button]
    private void ClearCache()
    {
        Game.World.GetManager<RealMethod.AudioManager>()?.Clear();
    }
}
