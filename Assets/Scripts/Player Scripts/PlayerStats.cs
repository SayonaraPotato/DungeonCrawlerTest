using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int _coins = 0;

    private void FixedUpdate()
    {
        _coins = CoinBehaviour._coins;
    }
}
