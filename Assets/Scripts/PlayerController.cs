using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb;
    private float moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //lee el teclado: -1 (izq), 0 (quieto), 1(derecha)
        moveInput = Input.GetAxisRaw("Horizontal");

        if (moveInput > 0)
            transform.localScale = new Vector3(1, 1, 1);
        else if (moveInput < 0)
            transform.localScale = new Vector3(-1, 1, 1);
    }
    void FixedUpdate()
    {
        //el movimiento fisico va en FixedUpdate, no en Update
        rb.linearVelocity = new Vector2(moveInput * speed, rb.linearVelocity.y);
    }

}
