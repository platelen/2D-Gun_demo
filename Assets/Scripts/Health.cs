using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int _health;

    public void TakeDamage(int dmg)
    {
        _health -= dmg;
        if (_health <= 0)
            Destroy(gameObject);
    }
}
