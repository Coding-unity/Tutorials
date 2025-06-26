using UnityEngine;

public class BIrdMovement : MonoBehaviour
{
[Header("VALUES")]
[SerializeField] private float velocity = 1.2f;
[SerializeField] private float rotationVal = 10f;

private Rigidbody2D rb;
private AudioSource audio;

private void Start()
{
    rb = GetComponent<Rigidbody2D>();
    audio = GetComponent<AudioSource>();
}

private void Update()
{
    if(Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.Space))
    {
     rb.linearVelocity = velocity * Vector3.up;
    }
}

private void FixedUpdate()
{
    transform.rotation = Quaternion.Euler(0f,0f,rb.linearVelocity.y * rotationVal);
}

private void OnCollisionEnter2D(Collision2D col)
{
    GameManager.instance.GameOver();
    audio.Play();
}
}
