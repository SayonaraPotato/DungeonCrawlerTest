using UnityEngine;

public class ItemCollectible : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private PlayerStats _playerStatistic;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _playerStatistic.Coins += 1;
            Destroy(gameObject);
        }
    }
}
