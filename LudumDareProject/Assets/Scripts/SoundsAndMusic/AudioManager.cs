using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance {  get; private set; }

    [Range(0f, 1f)]
    [SerializeField] private float _globalVolume;

    private List<AudioSource> _audioSources = new List<AudioSource>();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }

        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void Start()
    {
        FindAllAudioSources();
        ApplyVolumeToAll();
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        FindAllAudioSources();
        ApplyVolumeToAll();
    }

    private void FindAllAudioSources()
    {
        _audioSources.Clear();
        AudioSource[] foundSources = FindObjectsOfType<AudioSource>();
        _audioSources.AddRange(foundSources);
    }

    private void ApplyVolumeToAll()
    {
        foreach (AudioSource source in _audioSources)
        {
            if (source != null)
                source.volume = _globalVolume;
        }
    }

    public void SetGlobalVolume(float volume)
    {
        _globalVolume = Mathf.Clamp01(volume);
        ApplyVolumeToAll();
    }

    public float GetGlobalVolume()
    {
        return _globalVolume;
    }
}
