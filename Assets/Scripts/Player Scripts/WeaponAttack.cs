using UnityEngine;
using UnityEngine.Animations;

public class WeaponAttack : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private GameObject _activeWeapon;

    private void FixedUpdate()
    {
        _animator.SetFloat("IsAttack", Input.GetAxisRaw("Fire1"));

        Vector3 _difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        _difference.Normalize();

        float _rotZ = Mathf.Atan2(_difference.y, _difference.x) * Mathf.Rad2Deg;
        _activeWeapon.transform.rotation = Quaternion.Euler(0f, 0f, _rotZ );
    }
}
