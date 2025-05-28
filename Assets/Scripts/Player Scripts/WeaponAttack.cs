using UnityEngine;
using UnityEngine.Animations;

public class WeaponAttack : MonoBehaviour
{
    private Vector2 _attackDirection;
    [SerializeField] private Animator _animator;
    [SerializeField] private GameObject _activeWeapon;

    void Update()
    {
        _attackDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        _animator.SetFloat("IsAttack", Input.GetAxisRaw("Fire1"));

        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();

        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        _activeWeapon.transform.rotation = Quaternion.Euler(0f, 0f, rotZ );

    }
}
