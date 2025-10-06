using UnityEngine;
using UnityEngine.UI;

public class Mail : MonoBehaviour
{
    [SerializeField] private Text _mailText;
    [SerializeField] private GameObject[] _toOnLetters;

    private VirusCounter _virusCounter;
    private Color _originColor;

    private void OnEnable()
    {
        _virusCounter = FindFirstObjectByType<VirusCounter>();
        _originColor = _mailText.color;
        MailCheck();
    }

    private void MailCheck()
    {
        for (int i = 0; i <= _virusCounter.VirusCount && i < _toOnLetters.Length; i++)
        {
            _toOnLetters[i].SetActive(true);
        }
    }

    private void ChangeMailTextColor(Color color)
    {
        _mailText.color = color;
    }

    private void OnObjects()
    {
        foreach (GameObject obj in _toOnLetters)
        {
            obj.SetActive(true);
        }
    }
}
