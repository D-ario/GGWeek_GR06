using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private float dirX;
    private float dirY;
    public float moveSpeed = 10f;
    private SpriteRenderer rend;
    private bool canHide = false;
    private bool hiding = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rend = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        dirX = Input.GetAxis("Horizontal") * moveSpeed; 
        dirY = Input.GetAxis("Vertical") * moveSpeed;
        if (canHide && Input.GetKey("l"))
        {
            Physics2D.IgnoreLayerCollision(6, 7, true);
            rend.sortingOrder = 0;
            hiding = true;
            
        }
        else
        {
            Physics2D.IgnoreLayerCollision(6, 7, false);
            rend.sortingOrder = 2;
            hiding = false;
        }
    }

    private void FixedUpdate()
    {
        if (!hiding)
            rb.velocity = new Vector2(dirX ,dirY);
       
        else
            rb.velocity = Vector2.zero;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       if (other.gameObject.name.Equals("placeToHide"))
        {
            canHide = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name.Equals("placeToHide")) {
            canHide = false;


        }


    }
}
