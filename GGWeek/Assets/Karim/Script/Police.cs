using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Police : MonoBehaviour
{
    private float dirX;
    public float moveSpeed = 7f;
    private Rigidbody2D rb;
    [SerializeField]
    private GameObject Gotcha;
    private Animator anim;
    

    void Start()
    {
        Gotcha.SetActive(false);
        rb = GetComponent<Rigidbody2D>();
        dirX = -1f;
        anim = GetComponent<Animator>();  
    }

  
    void Update()
    {
        if (transform.position.x < -9f)
            dirX = -1f;
        else if (transform.position.x > -9f)
            dirX = -1f;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Equals("Player"))
        { 
            Gotcha.SetActive(true);
        anim.SetBool("GotU", true);
           
        }
    }
        private void OnTriggerExit2D (Collider2D other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            Gotcha.SetActive(false);
            anim.SetBool("GotU", false);
            
        }
           
    }
}
