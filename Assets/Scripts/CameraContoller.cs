
using UnityEngine;

public class CameraContoller : MonoBehaviour
{
    public GameObject playerOne;
    public GameObject playerTwo;
    Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        Vector3 viewPos = cam.WorldToViewportPoint(playerTwo.transform.position);

        Debug.Log(viewPos);
        if (viewPos.x > 0.5F)
            print("target is on the right side!");
        else
            print("target is on the left side!");
    }
}
