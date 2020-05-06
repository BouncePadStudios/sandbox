using UnityEngine;
using UnityEngine.InputSystem;

public class GamePadChecker : MonoBehaviour
{
    public void OnDeviceLost()
    {
        Debug.Log("Device Lost");
        Time.timeScale = 0f;
    }
    public void OnDeviceRegain()
    {
        Debug.Log("Device Lost");
        Time.timeScale = 0f;
    }
}
