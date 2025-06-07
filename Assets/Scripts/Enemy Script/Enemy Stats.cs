using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    [SerializeField] private int _maxHealth = 10;
    [SerializeField]
    private int _currentHealth;

    public int GetCurrentHealth()
    {
        return _currentHealth;
    }
    public void SetCurrentHealth(int _changedHealth)
    {
        _currentHealth = _changedHealth;
    }
    private void Start()
    {
        _currentHealth = _maxHealth;
    }
}
