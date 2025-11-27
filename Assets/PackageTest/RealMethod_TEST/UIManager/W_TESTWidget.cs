using RealMethod;
using UnityEngine;

public class W_TESTWidget : MonoBehaviour, IWidget
{

    public MonoBehaviour GetWidgetClass()
    {
        return this;
    }
    public void SceneInitialized(UIManager manager)
    {
        Debug.Log(name);
    }
}
