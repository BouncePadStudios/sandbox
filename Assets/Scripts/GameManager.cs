using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerSpawner playerSpawner = null;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        playerSpawner.SpawnPlayers();
    }
    
}
