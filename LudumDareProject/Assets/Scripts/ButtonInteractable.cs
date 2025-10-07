using UnityEngine;
using UnityEngine.UI;

public class ButtonInteractable : MonoBehaviour
{
    [SerializeField] private Button[] _buttons;
    [SerializeField] private Text[] _buttonTexts;

    private VirusCounter _virusCounter;

    private void OnEnable()
    {
        _virusCounter = FindFirstObjectByType<VirusCounter>();

        InteractableFalse();
    }

    private void InteractableFalse()
    {
        switch (_virusCounter.VirusCount)
        {
            case 1:
                _buttons[0].interactable = false;
                _buttonTexts[0].color = new Color(99, 99, 99, 255);
                break;
            case 2:
                _buttons[0].interactable = false;
                _buttonTexts[0].color = new Color(99, 99, 99, 255);
                _buttons[1].interactable = false;
                _buttonTexts[1].color = new Color(99, 99, 99, 255);
                break;
            case 3:
                _buttons[0].interactable = false;
                _buttonTexts[0].color = new Color(99, 99, 99, 255);
                _buttons[1].interactable = false;
                _buttonTexts[1].color = new Color(99, 99, 99, 255);
                _buttons[2].interactable = false;
                _buttonTexts[2].color = new Color(99, 99, 99, 255);
                break;
            case 4:
                _buttons[0].interactable = false;
                _buttonTexts[0].color = new Color(99, 99, 99, 255);
                _buttons[1].interactable = false;
                _buttonTexts[1].color = new Color(99, 99, 99, 255);
                _buttons[2].interactable = false;
                _buttonTexts[2].color = new Color(99, 99, 99, 255);
                _buttons[3].interactable = false;
                _buttonTexts[3].color = new Color(99, 99, 99, 255);
                break;
            case 5:
                _buttons[0].interactable = false;
                _buttonTexts[0].color = new Color(99, 99, 99, 255);
                _buttons[1].interactable = false;
                _buttonTexts[1].color = new Color(99, 99, 99, 255);
                _buttons[2].interactable = false;
                _buttonTexts[2].color = new Color(99, 99, 99, 255);
                _buttons[3].interactable = false;
                _buttonTexts[3].color = new Color(99, 99, 99, 255);
                _buttons[4].interactable = false;
                _buttonTexts[4].color = new Color(99, 99, 99, 255);
                break;
        }
    }
}
