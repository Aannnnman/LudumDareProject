using UnityEngine;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour
{
    [SerializeField] private Text _levelNumberText;
    [SerializeField] private GameObject _lockIcon;
    [SerializeField] private Button _button;

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
