using UnityEngine;

public class Player : MonoBehaviour
{
public float JumpForce;
public float MoveForce;

private Rigidbody2D rb;

private void Awake() => rb = GetComponent<Rigidbody2D>();

private void Update()
{
    if(Input.GetKeyDown(KeyCode.Space))
    {
        rb.AddForce(Vector2.up * JumpForce,ForceMode2D.Impulse);
    }

    else if(Input.GetKey(KeyCode.D))
    {
        rb.AddForce(Vector2.right * MoveForce, ForceMode2D.Impulse);
    }

        else if(Input.GetKey(KeyCode.A))
    {
        rb.AddForce(Vector2.left * MoveForce, ForceMode2D.Impulse);
    }
}
}
