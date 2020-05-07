using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;


public class PlayerSpawner : MonoBehaviour
{

<<<<<<< HEAD
    [SerializeField] private GameObject CharacterWaterPrefab;
    [SerializeField] private GameObject CharacterFirePrefab;
    List<InputDevice> inputDevices;
=======
    [SerializeField] private PlayerController CharacterWaterPrefab;

>>>>>>> parent of 24a7475... Trying to figure out Input
    public PlayerInfo playerInfo;

    //CharacterWater characterWater;
    /*CharacterFire characterFire;
    CharacterEarth characterEarth;
    CharacterIce characterAir;*/

    private void Awake()
    {
        inputDevices = new List<InputDevice>();
    }

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

<<<<<<< HEAD
        //PlayerInput player1 = PlayerInput.Instantiate(CharacterWaterPrefab);
        //PlayerInput player2 = PlayerInput.Instantiate(CharacterFirePrefab);

        //PlayerInput player2 = PlayerInput.Instantiate(CharacterWaterPrefab, controlScheme: "Controller", pairWithDevice: Joystick.current);

=======
>>>>>>> parent of 24a7475... Trying to figure out Input
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
