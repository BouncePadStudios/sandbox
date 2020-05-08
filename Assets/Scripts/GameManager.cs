using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerSpawner playerSpawner;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        playerSpawner.SpawnPlayers();
    }
    
}
