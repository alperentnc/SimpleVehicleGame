using UnityEngine;

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
            camNumber = 1;
        }
        else
        {
            mainCam.SetActive(true);
            secondCam.SetActive(false);
            camNumber = 0;
        }
        
    }
}
