using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TextDestroyTime : MonoBehaviour
{
    [SerializeField] private float _destroyTime;
    [SerializeField] private string _whatInText;

    private Text _text;

    private void OnEnable()
    {
        _text = GetComponent<Text>();
        DestroyObjectOnPlayerCollision.OnVirusDestroy += ActivateText;
    }

    private void OnDisable()
    {
        DestroyObjectOnPlayerCollision.OnVirusDestroy -= ActivateText;
    }

    private void ActivateText()
    {
        _text.text = _whatInText;
        StartCoroutine(DestroyText());
    }

    private IEnumerator DestroyText()
    {
        yield return new WaitForSeconds(_destroyTime);
        Destroy(gameObject);
    }
}
