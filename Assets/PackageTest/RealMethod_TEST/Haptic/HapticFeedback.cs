using RealMethod;
using UnityEngine;

public class HapticFeedback : MonoBehaviour
{
    //public string ConfigName;
    public HapticConfig MyConfig;
    // public HapticManager haptic;


    // [Button]
    // private void PlayConfig()
    // {
    //     haptic.Play(MyConfig);
    // }
    [Button]
    private void PlayConfigName()
    {
        var provider = Spawn.Haptic(MyConfig);
        provider.Play();
    }
}
