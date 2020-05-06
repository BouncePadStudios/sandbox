using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSpawner : MonoBehaviour
{

    [SerializeField] private PlayerController CharacterWaterPrefab;

    public PlayerInfo playerInfo;

    //CharacterWater characterWater;
    /*CharacterFire characterFire;
    CharacterEarth characterEarth;
    CharacterIce characterAir;*/


    public void OnPlayerJoined()
    {
        Debug.Log("PlayerJoined");
        /*
        if (playerInfo.numPlayers == 2)
            Time.timeScale = 1f;//resume game if controller disconnected and rejoined

        if (!playerInfo.playerOneJoined)
        {
            playerInfo.playerOneJoined = true;
            CreatePrefab(CharacterWaterPrefab, transform);
        }

        else
        {
            playerInfo.playerTwoJoined = true;
            CreatePrefab(CharacterWaterPrefab, transform);
        }
            

        ++playerInfo.numPlayers;
        */
    }

    public void OnPlayerLeft()
    {
        Debug.Log("PlayerLeft");
        /*
        --playerInfo.numPlayers;
        Time.timeScale = 0f;//pause game if controller disconnected
        */
    }

    public void SpawnPlayers()
    {

        //CreatePrefab(CharacterWaterPrefab, transform);
        //CreatePrefab(CharacterWaterPrefab, transform);

        /*
        switch (playerOneChoice)
        {
            case PlayerChoice.Water:
                PlayerController PlayerOne = Instantiate(characterWater);
                PlayerOne.Initialize(inputOne);
                break;
            case PlayerChoice.Fire:
                PlayerController PlayerOne = Instantiate(characterFire);
                PlayerOne.Initialize(inputOne);
                break;
            case PlayerChoice.Earth:
                PlayerController PlayerOne = Instantiate(characterEarth);
                PlayerOne.Initialize(inputOne);
                break;
            case PlayerChoice.Air:
                PlayerController PlayerOne = Instantiate(characterAir);
                PlayerOne.Initialize(inputOne);
                break;
        }

        switch (playerTwoChoice)
        {
            case PlayerChoice.Water:
                PlayerController PlayerTwo = Instantiate(characterWater);
                PlayerOne.Initialize(inputTwo);
                break;
            case PlayerChoice.Fire:
                PlayerController PlayerTwo = Instantiate(characterFire);
                PlayerOne.Initialize(inputTwo);
                break;
            case PlayerChoice.Earth:
                PlayerController PlayerTwo = Instantiate(characterEarth);
                PlayerOne.Initialize(inputTwo);
                break;
            case PlayerChoice.Air:
                PlayerController PlayerTwo = Instantiate(characterAir);
                PlayerOne.Initialize(inputTwo);
                break;
        }
            
        */

    }

    private void CreatePrefab(PlayerController prefab, Transform pos)
    {
        PlayerController PlayerOne = Instantiate(prefab, pos);
    }

}
