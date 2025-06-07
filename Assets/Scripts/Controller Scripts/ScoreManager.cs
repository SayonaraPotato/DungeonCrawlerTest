using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager _scoreManager;
    private int _currentCoins = 0;

    private void Awake()
    {
        if (_scoreManager == null)
        {
            _scoreManager = this;
        }
        else
            Destroy(gameObject);
    }

    public void AddCoins(int _coins)
    {
        _currentCoins += _coins;
    }

    public int GetCoinsScore()
    {
        return _currentCoins;
    }
}
