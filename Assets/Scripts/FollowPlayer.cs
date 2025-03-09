using UnityEngine;
using UnityEngine.InputSystem;
public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0,5,-7);
    private Vector3 secondOffset = new Vector3(0, 2, 2);
    private int camNumber = 0;
    void Start()
    {
        
    }
    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown("space"))
        {
            if (camNumber == 0) { camNumber = 1; }
            else { camNumber = 0; }
        }
        if (camNumber == 0)
        {
            transform.position = player.transform.position + offset;
        }
        else
        {
            transform.position = player.transform.position + secondOffset;
        }

    }
}
