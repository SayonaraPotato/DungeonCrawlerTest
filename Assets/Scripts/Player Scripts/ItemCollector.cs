using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Item")
        {
            Debug.Log("–¿¡Œ“¿≈“");
        }
    }
}
