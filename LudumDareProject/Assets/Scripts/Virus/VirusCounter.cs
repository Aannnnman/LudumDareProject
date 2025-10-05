using System.Collections.Generic;
using UnityEngine;

public class VirusCounter : MonoBehaviour
{
    //[SerializeField] private Text _virusCounterText;

    public int VirusCount { get; private set; } = 0;

    private static List<int> _virusList = new List<int>();

    private void Awake()
    {
        //UpdateUI();
        CollectableVirus.OnVirusTaked += PlusVirus;
    }

    private void OnDestroy()
    {
        CollectableVirus.OnVirusTaked -= PlusVirus;
    }

    private void PlusVirus()
    {
        VirusCount++;
        _virusList.Add(VirusCount);

        for (int i = 0; i < _virusList.Count; i++)
        {
            Debug.Log(_virusList[i]);
        }
        //UpdateUI();
    }

    //private void UpdateUI()
    //{
    //    _coinCounterText.text = $"Coin: {_coinCount}";
    //}
}
