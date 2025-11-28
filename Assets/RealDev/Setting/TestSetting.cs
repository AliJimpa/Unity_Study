using RealMethod;
using UnityEngine;

public class TestSetting : MonoBehaviour
{
    public RealMethod.DataManager saveSysmte;
    public UI_GameSetting setting;

    [Button]
    private void SaveSetting()
    {
        saveSysmte.SaveFile(setting.file);
    }
}
