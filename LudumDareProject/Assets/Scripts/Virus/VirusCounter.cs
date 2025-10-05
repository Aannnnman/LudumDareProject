using System.Collections.Generic;
using UnityEngine;

public class VirusCounter : MonoBehaviour
{
    private static VirusCounter _instance;

    public int VirusCount { get; private set; } = 0;

    private static List<int> _virusList = new List<int>();

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (_instance != this)
        {
            Destroy(gameObject);
        }

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
    }
}
