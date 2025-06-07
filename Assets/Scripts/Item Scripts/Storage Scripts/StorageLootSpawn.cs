using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class StorageLootSpawn : MonoBehaviour
{
    [Header("Ëטסע גûןאהאולûץ ןנוהלועמג")]
    [SerializeField] private List<GameObject> _prefabSpawnList;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Instantiate(_prefabSpawnList[0], this.transform.position, Quaternion.identity);
            Destroy(this);
        }
    }
}
