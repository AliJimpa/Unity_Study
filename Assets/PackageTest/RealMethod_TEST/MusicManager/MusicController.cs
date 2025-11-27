using RealMethod;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public CompositManager Manager;
    public APrefab layerSample;
    public AudioClip clip;


    [Button]
    private void AddLayer()
    {
        Manager.AddLayer("Sample", layerSample);
    }
    [Button]
    private void RemoveLayer()
    {
        Manager.RemoveLayer("Sample");
    }
    [Button]
    private void CreateLayer()
    {
        Manager.CreateLayer(clip);
    }
}
