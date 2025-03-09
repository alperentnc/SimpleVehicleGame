using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new(0, 2, 2);
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
