using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour, IGameManager3 {
	public ManagerStatus3 status {get; private set;}

	[SerializeField] private AudioSource soundSource = null;
	[SerializeField] private AudioSource music1Source = null;
	[SerializeField] private AudioSource music2Source = null;

	[SerializeField] private string introBGMusic = null;
	[SerializeField] private string levelBGMusic = null;

	private AudioSource _activeMusic = null;
	private AudioSource _inactiveMusic = null;


	public float crossFadeRate = 1.5f;
	private bool _crossFading;

	public float soundVolume {
		get {return AudioListener.volume;}
		set {AudioListener.volume = value;}
	}

	private float _musicVolume;
	public float musicVolume {
		get {
			return _musicVolume;
		}
		set {
			_musicVolume = value;

			if (music1Source != null && !_crossFading) {
				music1Source.volume = _musicVolume;
				music2Source.volume = _musicVolume;
			}
		}
	}

	public bool soundMute {
		get {return AudioListener.pause;}
		set {AudioListener.pause = value;}
	}

	public bool musicMute {
		get {
			if (music1Source != null) {
				return music1Source.mute;
			}
			return false;
		}
		set {
			if (music1Source != null) {
				music1Source.mute = value;
				music2Source.mute = value;
			}
		}
	}

	public void Startup() {
		Debug.Log("Audio manager starting...");


		music1Source.ignoreListenerVolume = true;
		music2Source.ignoreListenerVolume = true;
		music1Source.ignoreListenerPause = true;
		music2Source.ignoreListenerPause = true;

		soundVolume = 1f;
		musicVolume = 1f;

		_activeMusic = music1Source;
		_inactiveMusic = music2Source;

		// any long-running startup tasks go here, and set status to 'Initializing' until those tasks are complete
		status = ManagerStatus3.Started;
	}
	
	// to play 2D sounds that don't have any other source
	public void PlaySound(AudioClip clip) {
		soundSource.PlayOneShot(clip);
	}

	public void PlayIntroMusic() {
		PlayMusic(Resources.Load("Music/"+introBGMusic) as AudioClip);
	}
	public void PlayLevelMusic() {
		PlayMusic(Resources.Load("Music/"+levelBGMusic) as AudioClip);
	}
	
	private void PlayMusic(AudioClip clip) {
		if (_crossFading) {return;}
		StartCoroutine(CrossFadeMusic(clip));
	}
	private IEnumerator CrossFadeMusic(AudioClip clip) {
		_crossFading = true;

		_inactiveMusic.clip = clip;
		_inactiveMusic.volume = 0;
		_inactiveMusic.Play();

		float scaledRate = crossFadeRate * _musicVolume;
		while (_activeMusic.volume > 0) {
			_activeMusic.volume -= scaledRate * Time.deltaTime;
			_inactiveMusic.volume += scaledRate * Time.deltaTime;

			yield return null;
		}

		AudioSource temp = _activeMusic;
		
		_activeMusic = _inactiveMusic;
		_activeMusic.volume = _musicVolume;

		_inactiveMusic = temp;
		_inactiveMusic.Stop();

		_crossFading = false;
	}

	public void StopMusic() {
		_activeMusic.Stop();
		_inactiveMusic.Stop();
	}
}
