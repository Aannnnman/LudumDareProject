using System;
using UnityEngine;
using UnityEngine.UI;

public class LetterButton : MonoBehaviour
{
    public static event Action OnLetterClick;

    [SerializeField] private Button _letterButton;
    [SerializeField] private Text _letterButtonText;
    [SerializeField] private Text _letterText;
    [SerializeField] private Color _changeColor;
    [SerializeField] private string _whatInLetterText;
    [SerializeField] private string _from;
    [SerializeField] private string _data;
    [SerializeField] private string _toWhom;
    [SerializeField] private string _top;
    [SerializeField] private Text[] _letterTextParts;
    [SerializeField] private Text[] _letterButtonsTexts;

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
        OnLetterClick?.Invoke();
        _letterButtonText.color = _changeColor;

        foreach (var letterTextPart in _letterTextParts)
        {
            letterTextPart.gameObject.SetActive(true);
        }

        _letterText.text = _whatInLetterText;
        _letterTextParts[0].text = $"From: {_from}";
        _letterTextParts[1].text = $"Data: {_data}";
        _letterTextParts[2].text = $"To Whom: {_toWhom}";
        _letterTextParts[3].text = $"Top: {_top}";

        //foreach (var letterButtonText in _letterButtonsTexts)
        //{
        //    letterButtonText.color = _originColor;
        //}
    }
}
