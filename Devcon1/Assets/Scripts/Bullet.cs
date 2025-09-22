using UnityEngine;
using UnityEngine.UIElements;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 20f;
    public Rigidbody2D bullet;
    private Vector3 mousePos;


    public float bulletTimer = 15f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //gets mouse position
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //calculates position
        Vector3 directionToMouse = mousePos - transform.position;
        //adds velocity
        bullet.linearVelocity = new Vector2(directionToMouse.x, directionToMouse.y).normalized * bulletSpeed;

    }

    // Update is called once per frame
    void Update()
    {
        //counts down after bullet spawn, deletes bullet after 15 sec
        bulletTimer -= Time.deltaTime;

        if (bulletTimer <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //should destroy anything with enemy?
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
    }
}
