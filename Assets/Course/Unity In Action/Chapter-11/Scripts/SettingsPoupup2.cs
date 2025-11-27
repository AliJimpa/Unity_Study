using UnityEngine;
using System.Collections;

public class SettingsPoupup2 : MonoBehaviour {

    [SerializeField] private AudioClip sound = null;

    public void OnSoundToggle() {
        Managers3.Audio.soundMute = !Managers3.Audio.soundMute;
        Managers3.Audio.PlaySound(sound);
    }
    public void OnSoundValue(float volume) {
        Managers3.Audio.soundVolume = volume;
    }


    public void OnPlayMusic(int selector) {
        Managers3.Audio.PlaySound(sound);
        switch (selector) {
            case 1:
                Managers3.Audio.PlayIntroMusic();
                break;
            case 2:
                Managers3.Audio.PlayLevelMusic();
                break;
            default:
                Managers3.Audio.StopMusic();
                break;
        }
    }


    public void OnMusicToggle() {
        Managers3.Audio.musicMute = !Managers3.Audio.musicMute;
        Managers3.Audio.PlaySound(sound);
    }
    public void OnMusicValue(float volume) {
        Managers3.Audio.musicVolume = volume;
    }



}