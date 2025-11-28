using UnityEngine;
using RealMethod;

[CreateAssetMenu(fileName = "M_SettingFile", menuName = "Mustard/SettingFile", order = 1)]
public class MySettingFile : SettingFile
{
    [Header("Audio")]
    [SerializeField, Range(0f, 1f)]
    protected float musicVolume = 0.7f;
    [SerializeField, Range(0f, 1f)]
    protected float sfxVolume = 0.7f;
    [Header("Haptic")]
    [SerializeField]
    protected bool hasVibration = true;
    [SerializeField, ConditionalHide("hasVibration", true, false), Range(0f, 1f)]
    protected float vibrationPower = 0.7f;


    // SaveFile Methods
    protected override void OnStable(RealMethod.DataManager manager)
    {
        throw new System.NotImplementedException();
    }
    protected override void OnLoaded()
    {
    }
    protected override void OnDeleted()
    {
    }

    // SettingFile Methods
    protected override void SetupSettingData()
    {
        // Mixer to Data
        MixerManager Mixer = Game.FindManager<MixerManager>();
        musicVolume = NormalMixerVolume(Mixer["MusicParam"]);
        sfxVolume = NormalMixerVolume(Mixer["SFXParam"]);
    }
    protected override void ApplySettingData()
    {
        MusicManager Mixer = Game.FindManager<MusicManager>();
        Mixer["MusicParam"] = ConvertToMixerVolume(musicVolume);
        Mixer["SFXParam"] = ConvertToMixerVolume(sfxVolume);
        Mixer.Sync();
    }
    protected override void OnSettingFileSaved()
    {
    }
    protected override void OnResetSetting()
    {

    }

#if UNITY_EDITOR
    public override void OnEditorPlay()
    {
        // SetDefault Paramter
    }


#endif
}