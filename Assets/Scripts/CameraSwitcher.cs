using UnityEngine;
using UnityEngine.InputSystem;

public class CameraSwitcher : MonoBehaviour
{
    public GameObject mainCam, secondCam;
    private int camNumber = 0;
    void Start()
    {
    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            ChangeCamera();
        }
    }
    public void ChangeCamera()
    {
        if (camNumber == 0)
        {
            mainCam.SetActive(false);
            secondCam.SetActive(true);
            GetComponentInParent<PlayerInput>().camera = secondCam.GetComponent<Camera>();
            camNumber = 1;
        }
        else
        {
            mainCam.SetActive(true);
            secondCam.SetActive(false);
            GetComponentInParent<PlayerInput>().camera = mainCam.GetComponent<Camera>();
            camNumber = 0;
        }
        
    }
}
