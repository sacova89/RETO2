using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline: MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Hola");
            animator.Play("Jump", 0);
            collision.GetComponent<Rigidbody2D>().velocity = new Vector2 (collision.GetComponent<Rigidbody2D>().velocity.x, 6);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Adios");
    }
}
