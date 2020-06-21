using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMove : MonoBehaviour
{
    public GameObject bullet;
    void Update()
    {
        if (bullet.transform.position.x < 65)
        {
            transform.Translate(Vector2.right * 3f);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }
}
