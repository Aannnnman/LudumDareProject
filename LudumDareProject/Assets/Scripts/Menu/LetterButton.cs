using UnityEngine;
using UnityEngine.UI;

public class LetterButton : MonoBehaviour
{
    [SerializeField] private Button _letterButton;
    [SerializeField] private Text _letterButtonText;
    [SerializeField] private Text _letterText;
    [SerializeField] private Color _changeColor;
    [SerializeField] private string _whatInLetterText;

    private Color _originColor;

    private void OnEnable()
    {
        _originColor = _letterButtonText.color;
        _letterButton.onClick.AddListener(ShowLetterText);
    }

    private void OnDisable()
    {
        _letterButton.onClick.RemoveListener(ShowLetterText);
    }

    private void ShowLetterText()
    {
        _letterButton.interactable = false;
        _letterButtonText.color = _changeColor;
        _letterText.gameObject.SetActive(true);
        _letterText.text = _whatInLetterText;
    }
}
