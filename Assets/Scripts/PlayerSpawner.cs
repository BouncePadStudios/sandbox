using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public Settings gameSettings;
    public PlayerInfo playerInfo;
    public CameraController cam;

    public Transform playerOneSpawnPos;
    public Transform playerTwoSpawnPos;

    [SerializeField] private GameObject CharacterWaterPrefab;
    [SerializeField] private GameObject CharacterFirePrefab;
    [SerializeField] private GameObject CharacterEarthPrefab;

    private GameObject PlayerOne;
    private GameObject PlayerTwo;

    private string controlType;

    public void SpawnPlayers()
    {
        if (gameSettings.usingControllers)//setup input type
            controlType = "J";
        else
            controlType = "K";

        //Spawn player one
        switch (playerInfo.playerOneChoice)
        {
            case PlayerChoice.Water:
                PlayerOne = Instantiate(CharacterWaterPrefab, playerOneSpawnPos);
                PlayerOne.GetComponent<InputHandler>().SetupInput(controlType, 1);
                break;

            case PlayerChoice.Fire:
                PlayerOne = Instantiate(CharacterFirePrefab, playerOneSpawnPos);
                PlayerOne.GetComponent<InputHandler>().SetupInput(controlType, 1);
                break;


            // Added this to test the Fighter prefab - Eren
            case PlayerChoice.Earth:
                PlayerOne = Instantiate(CharacterEarthPrefab, playerOneSpawnPos);
                PlayerOne.GetComponent<InputHandler>().SetupInput(controlType, 1);
                break;
        }

        //Spawn player two
        switch (playerInfo.playerTwoChoice)
        {
            case PlayerChoice.Water:
                PlayerTwo = Instantiate(CharacterWaterPrefab, playerTwoSpawnPos);
                PlayerTwo.GetComponent<InputHandler>().SetupInput(controlType, 2);
                break;

            case PlayerChoice.Fire:
                PlayerTwo = Instantiate(CharacterFirePrefab, playerTwoSpawnPos);
                PlayerTwo.GetComponent<InputHandler>().SetupInput(controlType, 2);
                break;

            // Added this to test the Fighter prefab - Eren
            case PlayerChoice.Earth:
                PlayerTwo = Instantiate(CharacterEarthPrefab, playerTwoSpawnPos);
                PlayerTwo.GetComponent<InputHandler>().SetupInput(controlType, 2);
                break;
        }

        cam.targetOne = PlayerOne.transform;
        cam.targetTwo = PlayerTwo.transform;

    }

}
