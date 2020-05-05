using UnityEngine;

[CreateAssetMenu(menuName = "PlayerSpawner")]
public class PlayerSpawner : ScriptableObject
{
    PlayerOneInput inputOne;
    PlayerTwoInput inputTwo;

    PlayerChoice playerOneChoice = PlayerChoice.Water;
    PlayerChoice playerTwoChoice = PlayerChoice.Water;

    public enum PlayerChoice { Water,Fire,Earth,Air };

    CharacterWater characterWater;
    /*CharacterFire characterFire;
    CharacterEarth characterEarth;
    CharacterIce characterAir;*/

    void Awake()
    {
        inputOne = (PlayerOneInput)ScriptableObject.CreateInstance(typeof(PlayerOneInput));
        inputTwo = (PlayerTwoInput)ScriptableObject.CreateInstance(typeof(PlayerTwoInput));

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
            
        

    }

    

}
