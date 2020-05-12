using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private CamSettings settings;
    [SerializeField] private Camera cam;

    public Transform targetOne = null;
    public Transform targetTwo = null;

    //Imaginary point directly in the middle between the players
    private Vector2 targetPosition;

    private void FixedUpdate()
    {
        //recalculate and store the target position.
        targetPosition = CalcTargetPosition();
        //see if the camera needs to zoom out
        TestForZoom();
        //set the camera position
        transform.position = new Vector3(targetPosition.x, targetPosition.y, transform.position.z);
    }

    private void TestForZoom()
    {
        // calculate the viewport distance between the playerOne's and the playerTwo's positions
        Vector2 playerOneViewport = Camera.main.WorldToViewportPoint(targetOne.position);
        Vector2 playerTwoViewport = Camera.main.WorldToViewportPoint(targetTwo.position);
        float viewportDistance = Vector2.Distance(playerOneViewport, playerTwoViewport);

        // If the viewport distance between the players is too big, zoom out
        if (viewportDistance > settings.maxViewportDistance)
        {
            if (cam.orthographicSize + settings.zoomSpeed < settings.zoomLevelMax)
            {
                cam.orthographicSize += settings.zoomSpeed;//zoom out
            }
        }

        else if (viewportDistance < settings.minViewportDistance)
        {
            if (cam.orthographicSize - settings.zoomSpeed > settings.zoomLevelMin)
            {
                cam.orthographicSize -= settings.zoomSpeed;//zoom out
            }
        }
        
    }

    private Vector2 CalcTargetPosition()
    {
        // Calculate the distance bewteen the players
        // return the point which is exactly in the middle of the players
        Vector3 dist = targetTwo.position - targetOne.position;
        Vector2 pos = targetOne.position + (dist * 0.5f);
        return pos;
    }
}
