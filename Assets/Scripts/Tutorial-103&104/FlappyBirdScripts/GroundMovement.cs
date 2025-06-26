using UnityEngine;

public class GroundMovement : MonoBehaviour
{
[Header("VALUES")]
[SerializeField] private float speed;
[SerializeField] private float minLimit;
[SerializeField] private float yMinValue;

private void Reset()
{
    speed = 1f;
    minLimit = -3f;
    yMinValue = -2f;
}

private void Update()
{
    transform.Translate(-speed * Time.deltaTime,0f,0f);

    if(transform.position.x < minLimit)
    {
     transform.position = new Vector3(0f,yMinValue,0f);
    }
}
}