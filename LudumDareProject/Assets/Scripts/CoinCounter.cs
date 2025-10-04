using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    [SerializeField] private Text _coinCounterText;

    private int _coinCount = 0;

    private void Awake()
    {
        UpdateUI();
        Coin.OnCoinTaked += PlusCoin;
    }

    private void OnDestroy()
    {
        Coin.OnCoinTaked -= PlusCoin;
    }

    private void PlusCoin()
    {
        _coinCount++;
        UpdateUI();
    }

    private void UpdateUI()
    {
        _coinCounterText.text = $"Coin: {_coinCount}";
    }
}
