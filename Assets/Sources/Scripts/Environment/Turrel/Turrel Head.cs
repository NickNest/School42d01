using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurrelHead : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _headColor;
    [SerializeField] private float _attackRate = 3f;
    [SerializeField] private Rigidbody2D _ammo;

    private float _currentAttackRate;

    private void Start()
    {
        _currentAttackRate = _attackRate;
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        AttackRateDown();

        if (CanAttack(collision))
        {
            Attack();
            _currentAttackRate = _attackRate;
        }
    }


    private void Attack()
    {
        Debug.Log("Атакую!");
        Rigidbody2D currentAmmo = Instantiate(_ammo, transform.position, transform.rotation);
        currentAmmo.velocity = Vector3.forward;
    }

    private void AttackRateDown()
    {
        if (!IsAttackRateUp()) 
        { 
            _currentAttackRate -= Time.deltaTime;
            Debug.Log(_currentAttackRate);
        }
            
    }


    private bool CanAttack(Collider2D collision) => IsAttackRateUp() && collision.gameObject.tag == gameObject.tag;
    private bool IsAttackRateUp() => _currentAttackRate <= 0;
}
