using UnityEngine;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour
{
    [SerializeField] private Text _levelNumberText;
    [SerializeField] private GameObject _lockIcon;
    [SerializeField] private Button _button;
    [SerializeField] private int _id;

    private VirusCounter _virusCounter;

    private void Awake()
    {
        _virusCounter = FindFirstObjectByType<VirusCounter>();
    }

    public void ActivateLevel()
    {
        ActivatedOrDisabledLevel(true, false, true);
    }

    private void ActivatedOrDisabledLevel(bool buttonIsCanClick, bool lockIconIsActive, bool levelTextNumberIsActive)
    {
        _button.interactable = buttonIsCanClick;
        _lockIcon.SetActive(lockIconIsActive);
        _levelNumberText.gameObject.SetActive(levelTextNumberIsActive);
    }
}
