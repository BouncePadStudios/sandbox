using UnityEngine;

[CreateAssetMenu(menuName = "CamSettings")]
public class CamSettings : ScriptableObject
{
    [Tooltip("Maximum zoom level")]
    public float zoomLevelMax;

    [Tooltip("Maximum zoom level")]
    public float zoomLevelMin;

    [Tooltip("Sensitivity of the camera zoom")]
    public float zoomSpeed;

    [Tooltip("If the viewport distance between playerOne and playerTwo" +
                "is bigger than the Max Viewport Distance, the camera zooms out.")]
    public float maxViewportDistance = 0.6f;

    [Tooltip("If the viewport distance between playerOne and playerTwo" +
                "is smaller than the min Viewport Distance, the camera zooms in.")]
    public float minViewportDistance = 0.6f;
}
