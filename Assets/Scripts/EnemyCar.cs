using UnityEngine;

public class EnemyCar : MonoBehaviour
{
    private float speed;
    void Start()
    {
        speed = Random.Range(3f, 12f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
