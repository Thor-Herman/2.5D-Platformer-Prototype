using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    private Text _coinsText;

    public void Start() {
        _coinsText = transform.Find("CoinsText").GetComponent<Text>();
    }

    public void updateCoins(int coins) {
        _coinsText.text = "Coins: " + coins.ToString();
    }
}
