using UnityEngine;
using UnityEngine.UI;

public class VolumeSliderController : MonoBehaviour
{
    [SerializeField] private Slider _volumeSlider;

    private void OnEnable()
    {
        _volumeSlider.value = AudioManager.Instance.GetGlobalVolume();
        _volumeSlider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    private void OnSliderValueChanged(float value)
    {
        AudioManager.Instance.SetGlobalVolume(value);
    }
}
