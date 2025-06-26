using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
[Header("REFERENCES")] 
[SerializeField] private GameObject pipePrefab;

[Header("VALUES")]
[SerializeField] private float height;
[SerializeField] private float maxTime;

private float timer;
private GameObject destructPrefab;

private void Reset()
{
    height = 1f;
    maxTime = 1.5f;
}

private void Start()
{
    PipeCreator();
}

private void Update()
{
    if(timer > maxTime)
    {
     PipeCreator();
     timer = 0f;
    }

    timer += Time.deltaTime;
}

private void PipeCreator()
{
    Vector3 movement = new Vector3(0f,Random.Range(-height,height));
    Vector3 spawnPos = transform.position + movement;

    destructPrefab = Instantiate(pipePrefab,spawnPos,Quaternion.identity);

    Destroy(destructPrefab,10f);
}
}
