using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private float offset = 90f;

    Camera cam;

    private void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        Vector3 difference = cam.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angle + offset);
    }
}
