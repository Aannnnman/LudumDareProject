using System;
using UnityEngine;
using UnityEngine.UI;

public class MusicVolumeControl : MonoBehaviour
{
    [SerializeField] private AudioSource _musicSource;
    [SerializeField] private Slider _volumeSlider;

    private void Awake()
    {
        _volumeSlider.value = _musicSource.volume;

        _volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    private void OnDestroy()
    {
        _volumeSlider.onValueChanged.RemoveListener(SetVolume);
    }

    private void SetVolume(float volume)
    {
        _musicSource.volume = volume;
    }

    public float GetSoundVolume()
    {
        return _musicSource.volume;
    }
}
