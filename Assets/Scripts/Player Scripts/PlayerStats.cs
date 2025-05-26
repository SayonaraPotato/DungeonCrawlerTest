using UnityEngine;

public class PlayerStats : MonoBehaviour
{
<<<<<<< HEAD
    public int HP = 10;
    public int Coins = 0;
=======
    public static int _coins = 0;

    private void FixedUpdate()
    {
        _coins = CoinBehaviour._coins;
    }
>>>>>>> 7a549ad2f3e6e011521d5e816bf1f6638f934db9
}
