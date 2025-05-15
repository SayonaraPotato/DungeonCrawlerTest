using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _playerStats._coins += 1;
    }
}
