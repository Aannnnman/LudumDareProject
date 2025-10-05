using UnityEngine;
using UnityEngine.UI;

public class IconVirus : MonoBehaviour
{
    [SerializeField] private GameObject _iconVirus;
    [SerializeField] private Button _iconVirusButton;

    private void OnEnable()
    {
        _iconVirusButton.onClick.AddListener(DelayedActiveIcon);
        _iconVirusButton.onClick.AddListener(CloseIcon);
        ActiveIcon();
    }

    private void OnDisable()
    {
        _iconVirusButton.onClick.RemoveListener(DelayedActiveIcon);
        _iconVirusButton.onClick.RemoveListener(CloseIcon);
    }

    private void CloseIcon()
    {
        _iconVirus.SetActive(false);
    }

    private void ActiveIcon()
    {
        _iconVirus.SetActive(true);
    }

    private void DelayedActiveIcon()
    {
        Invoke(nameof(ActiveIcon), 15f);
    }
}
