using System;
using UnityEngine;

public class EnemyGetDamage : MonoBehaviour
{
    [SerializeField] private int _enemyHP = 10;

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Weapon" && Input.GetAxisRaw("Fire1") == 1)
            _enemyHP--;
        if(_enemyHP == 0)
            Destroy(gameObject);
    }
}
