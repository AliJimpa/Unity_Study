using RealMethod;
using UnityEngine;

public class ChangeState : MonoBehaviour
{
    public DefaulMusicState MyService;
    public DefaulMusicLayer TargetState;
    private void Awake()
    {
        MyService = Game.GetService<DefaulMusicState>();
        if (MyService != null)
            TargetState = MyService.CurrentState;
    }

    private void LateUpdate()
    {
        if (MyService != null)
        {
            if (TargetState != MyService.CurrentState)
            {
                MyService.SetState(TargetState);
            }
        }

    }

}
