using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    public float maxX;
    public float minX;
    public float speed;
    SpriteRenderer Sr;

    // Start is called before the first frame update
    void Start()
    {
        Sr = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x < minX || transform.position.x > maxX)
        {
            speed = speed * -1;
        }

        if(speed > 0)
        {
            Sr.flipX = true;
        }
        else if(speed < 0)
        {
            Sr.flipX = false;
        }
    }
}
