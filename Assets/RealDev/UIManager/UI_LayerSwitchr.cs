using RealMethod;
using UnityEngine;

public class UI_LayerSwitchr : MonoBehaviour, IWidget
{
    public string L1 = "Layer_1";
    public string L2 = "Layer_2";
    public float time = 1;


    private HUDManager HUD;
    MonoBehaviour IWidget.GetWidgetClass()
    {
        return this;
    }
    void IWidget.SceneInitialized(UIManager manager)
    {
        if (manager is HUDManager mymanager)
        {
            HUD = mymanager;
        }
    }


    private void Start()
    {
        HUD.SwitchLayer(L1, L2, time);
    }


}
