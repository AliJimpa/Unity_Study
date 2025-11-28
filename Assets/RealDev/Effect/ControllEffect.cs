using RealMethod;
using UnityEngine;

public class ControllEffect : MonoBehaviour
{
    public EffectPlayer MyEffect;

    [Button]
    private void PlayEffect()
    {
        MyEffect.Play();
    }
    [Button]
    private void PauseEffect()
    {
        MyEffect.Pause();
    }
    [Button]
    private void ClearEffect()
    {
        MyEffect.Stop();
    }

}
