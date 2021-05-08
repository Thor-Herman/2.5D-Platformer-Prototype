using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    private Text _coinsText, _livesText;

    public void Start() {
        _coinsText = transform.Find("CoinsText").GetComponent<Text>();
        _livesText = transform.Find("LivesText").GetComponent<Text>();
    }

    public void updateCoins(int coins) {
        _coinsText.text = "Coins: " + coins.ToString();
    }

    public void updateLives(int lives) {
        _livesText.text = "Lives: " + lives.ToString();
    }
}
