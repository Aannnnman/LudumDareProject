using UnityEngine;

public class StartMusic : MonoBehaviour
{
    [SerializeField] private AudioSource _music;
    [SerializeField] private float _offMuteTime;

    private void OnEnable()
    {
        _music.mute = true;
        Invoke(nameof(OffMuteAndPlayMusic), _offMuteTime);
    }

    private void OffMuteAndPlayMusic()
    {
        _music.mute = false;
        _music.volume = AudioManager.Instance.GetGlobalVolume();
        _music.Play();
    }
}
