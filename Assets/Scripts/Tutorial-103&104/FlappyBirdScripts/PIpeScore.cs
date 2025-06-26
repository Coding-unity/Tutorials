using UnityEngine;

public class PIpeScore : MonoBehaviour
{
private AudioSource audio;

private void Awake()
{
    audio = GetComponent<AudioSource>();
}

private void OnTriggerEnter2D(Collider2D col)
{
if(col.gameObject.CompareTag("Player"))
{
    Score.instance.UpdateScore();
}
audio.Play();
}
}
