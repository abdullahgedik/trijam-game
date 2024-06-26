using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private int damage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            collision.gameObject.GetComponent<Health>().TakeDamage(damage);
        }
    }
}
