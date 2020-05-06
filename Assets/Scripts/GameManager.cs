using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerSpawner playerSpawner;

    // Start is called before the first frame update
    void Awake()
    {
        playerSpawner.SpawnPlayers();
    }

}
