using UnityEngine;

[CreateAssetMenu(menuName ="PLayerInfo")]
public class PlayerInfo : ScriptableObject
{
    public enum PlayerChoice { Water, Fire, Earth, Air };

    PlayerChoice playerOneChoice = PlayerChoice.Water;
    PlayerChoice playerTwoChoice = PlayerChoice.Water;

    public bool playerOneJoined = false;
    public bool playerTwoJoined = false;
    public int numPlayers = 0;

}
