using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour
{
    public float moveSpeed = 3.0f;
    public Rigidbody2D player;
    public GameObject bullet;
    public float jumpSpeed = 3.0f;
    public Animator animator;
    

    void Update()
    {
      
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
            animator.SetInteger("state", 3);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
            animator.SetInteger("state", 3);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            player.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
        }
        else if (Input.GetKeyDown(KeyCode.RightShift) || Input.GetKeyDown(KeyCode.LeftShift))
        {
           
            animator.SetInteger("state", 4);
            Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        }
        else
        {
            animator.SetInteger("state", 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "obstacle")
        {
            Application.LoadLevel(0);
        }
        else if(collision.gameObject.tag == "Respawn")
        {
            Application.LoadLevel(0);
        }
    }
}
