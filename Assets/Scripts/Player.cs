using System.Net.Http.Headers;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Attributes")]
    [SerializeField] private float speed = 7f;

    [Header("Unity Setup reference")]
    [SerializeField] private SpriteRenderer sprite;

    void Update()
    {
        Move();
    }

    void Move()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        transform.position += new Vector3(moveX, moveY, 0) * speed * Time.deltaTime;

        if (moveX > .1f)
            sprite.flipX = false;
        else
            sprite.flipX = true;
    }
}
