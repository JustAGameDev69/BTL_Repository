using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public int totalCoin;
    public Text coinText;
    public int playerIngameCoins;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // In level 1
    public void AddCoin()
    {
        playerIngameCoins++;
        UpdateCoinInGameText();
    }

    public void UpdateCoinInGameText()
    {
        coinText.text = playerIngameCoins.ToString();
    }

    public void SaveAndLoadCoin()
    {

        // Save when change level
        PlayerPrefs.SetInt("totalCoin", totalCoin);

        // Load when start new level
        totalCoin = PlayerPrefs.GetInt("totalCoin");

    }

    // In level 2
    public void SetupCoinText()
    {
        coinText = GetComponentInChildren<Text>();
        UpdateCoinInGameText();
    }

}
