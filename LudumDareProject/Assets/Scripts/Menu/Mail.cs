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
        OnObjects();
    }

    private void MailCheck()
    {
        switch (_virusCounter.VirusCount)
        {
            case 0:
                return;
            case 1:
                ChangeMailTextColor(Color.red);
                break;
            case 2:
                break;
            case 3: 
                break;
            case 4: 
                break;
            case 5:
                break;
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
