using UnityEngine;
using UnityEngine.UI;

public class VirusController : MonoBehaviour
{
    [SerializeField] private IconVirus _iconVirus;
    [SerializeField] private Button _iconVirusButton;

    private void Awake()
    {
        ActiveIcon();
    }

    private void OnEnable()
    {
        _iconVirusButton.onClick.AddListener(DeylaedActiveIcon);
    }

    private void OnDisable()
    {
        _iconVirusButton.onClick.RemoveListener(DeylaedActiveIcon);
    }

    private void ActiveIcon()
    {
        _iconVirus.gameObject.SetActive(true);
    }

    private void DeylaedActiveIcon()
    {
        Invoke(nameof(ActiveIcon), 15f);
    }

}
