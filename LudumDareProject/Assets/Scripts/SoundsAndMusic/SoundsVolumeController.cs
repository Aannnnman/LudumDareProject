using UnityEngine;

public class SoundsVolumeController : MonoBehaviour
{
    private AudioSource[] _audioSources;

    private void OnEnable()
    {
        _audioSources = FindObjectsOfType<AudioSource>();

        foreach (AudioSource source in _audioSources)
        {
            //source.volume = MusicVolumeControl.GetSoundVolume();
        }
    }
}
