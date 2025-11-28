using RealMethod;
using UnityEngine;

public class M_HapticService : HapticManager
{
    protected override void OnPlay(HapticConfig config)
    {
        Debug.Log(config.name);
    }
    protected override void OnPause(HapticConfig config)
    {
        throw new System.NotImplementedException();
    }

    protected override void OnStop(HapticConfig config)
    {
        throw new System.NotImplementedException();
    }
}
