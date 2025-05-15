using UnityEngine;

public class ChestBehaviour : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _animator.SetFloat("isOpen", 1);
        }
    }
}
