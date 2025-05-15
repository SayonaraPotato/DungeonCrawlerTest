using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Animator _animator;
    [SerializeField] private GameObject _weapon;
    [SerializeField] private GameObject _playerTexture;

    private Vector2 _direction;
    private Rigidbody2D _rb;
    private Vector2 _mouseDirection;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        _mouseDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        _direction.x = Input.GetAxisRaw("Horizontal");
        _direction.y = Input.GetAxisRaw("Vertical");

        _animator.SetFloat("Horizontal", _direction.x);
        _animator.SetFloat("Vertical", _direction.y);
        _animator.SetFloat("Speed", _direction.sqrMagnitude);

        if (_direction.x < 0)
        {
            _playerTexture.transform.localScale = new Vector3(-1.5f, 1, 1);
            //if (Input.GetAxisRaw("Fire1") != 1)
                //_weapon.transform.localScale = new Vector3(-1, 1, 1);
        }

        if (_direction.x > 0)
        {
            _playerTexture.transform.localScale = new Vector3(1.5f, 1, 1);
            //if(Input.GetAxisRaw("Fire1") != 1)
                //_weapon.transform.localScale = new Vector3(1, 1, 1);
        }

    }

    void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + _direction * _speed * Time.fixedDeltaTime);
    }
}
