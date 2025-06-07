using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    [SerializeField] private EnemyStats _enemyStats;
    private int _enemyHealth;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Weapon")
        {
            _enemyHealth = _enemyStats.GetCurrentHealth();
            if (_enemyHealth - 10 <= 0)
            {
                Destroy(gameObject);
            }
            else
                _enemyStats.SetCurrentHealth(_enemyHealth - 10);
        }
    }
}
