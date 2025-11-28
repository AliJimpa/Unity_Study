using RealMethod;
using UnityEngine;
using UnityEngine.UI;

public class ServiceUser : MonoBehaviour
{
    [Button]
    private void AddTimerService()
    {
        Game.AddService<TimeService>(this);
    }

    [Button]
    private void SpawnEmptyWidget()
    {
        Spawn.Widget<Image>("Ali");
    }
}
