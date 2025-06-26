using UnityEngine;

public class PipeMovement : MonoBehaviour
{
[SerializeField] private float pipeSpeed;

private void Update() => transform.position += pipeSpeed*Time.deltaTime*Vector3.left;
}
