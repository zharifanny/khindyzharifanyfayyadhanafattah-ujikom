using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public Camera[] cameras;
    //base kamera awal
    private int cameraIndex = 0; 

    void Start()
    {
        ActivateCamera(cameraIndex);
    }


    void ActivateCamera(int index)
    {
        cameras[index].gameObject.SetActive(true);
    }

    public void ChangeCamera()
    {
        cameras[cameraIndex].gameObject.SetActive(false);

        cameraIndex = 1;

        ActivateCamera(cameraIndex);
    }

    public void ShowUI()
    {
        

    }

}