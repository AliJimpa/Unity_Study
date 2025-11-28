using RealMethod;
using UnityEngine;

public class ScneLoader : MonoBehaviour
{
    public SceneReference Target;


    [Button]
    private void OpenTargetScene()
    {
        Game.OpenScene(Target);
    }
    [Button]
    private void OpenScene0()
    {
        Game.OpenScene(0);
    }
    [Button]
    private void OnpeScene1()
    {
        Game.OpenScene(1);
    }
    [Button]
    private void OnpeScene2()
    {
        Game.OpenScene(2);
    }



}
