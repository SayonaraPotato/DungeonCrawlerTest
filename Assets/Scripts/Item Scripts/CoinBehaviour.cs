using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
    public static int _coins = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            _coins += 1;
        }
    }
}
