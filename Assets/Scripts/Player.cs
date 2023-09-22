using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 7f;

    void Update()
    {
        Move();
    }

    void Move()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        transform.position += new Vector3(moveX, moveY, 0) * speed * Time.deltaTime;
    }
}
