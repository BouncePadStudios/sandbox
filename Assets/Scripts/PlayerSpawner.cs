using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerSpawner : MonoBehaviour
{

    public PlayerInputManager InputManager;

    public PlayerInfo playerInfo;

    [SerializeField] private GameObject CharacterWaterPrefab;
    [SerializeField] private GameObject CharacterFirePrefab;
  

    private void Awake()
    {

        //setup the initial prefab for player one based on the choice made in the character selection screen (set in the playerInfo scriptable obj)
        switch (playerInfo.playerOneChoice)
        {
            case PlayerChoice.Water:
                Debug.Log("Switching to Water");
                InputManager.playerPrefab = CharacterWaterPrefab;
                break;
            case PlayerChoice.Fire:
                Debug.Log("Switching to Fire");
                InputManager.playerPrefab = CharacterFirePrefab;
                break;
                /*
            case PlayerChoice.Earth:
                PlayerController PlayerOne = Instantiate(characterEarth);
                PlayerOne.Initialize(inputOne);
                break;
            case PlayerChoice.Air:
                PlayerController PlayerOne = Instantiate(characterAir);
                PlayerOne.Initialize(inputOne);
                break;
                */
        }
    }

    public void OnPlayerJoined()
    {
        Debug.Log("PlayerJoined");

        playerInfo.numPlayers = 2;
        Debug.Log(playerInfo.playerTwoChoice);
        //Now that the first player has joined, setup the next spawnable prefab to be player 2's selection
        switch (playerInfo.playerTwoChoice)
        {
            case PlayerChoice.Water:
                InputManager.playerPrefab = CharacterWaterPrefab;
                break;
            case PlayerChoice.Fire:
                InputManager.playerPrefab = CharacterFirePrefab;
                break;
                /*
            case PlayerChoice.Earth:
                PlayerController PlayerOne = Instantiate(characterEarth);
                PlayerOne.Initialize(inputOne);
                break;
            case PlayerChoice.Air:
                PlayerController PlayerOne = Instantiate(characterAir);
                PlayerOne.Initialize(inputOne);
                break;
                */
        }
    }

    public void OnPlayerLeft()
    {
        Debug.Log("PlayerLeft");
        --playerInfo.numPlayers;
    }

    private void CreatePrefab(PlayerController prefab, Transform pos)
    {
        PlayerController PlayerOne = Instantiate(prefab, pos);
    }

}
