using UnityEngine;

[CreateAssetMenu(menuName ="PLayerInfo")]
public class PlayerInfo : ScriptableObject
{

    public PlayerChoice playerOneChoice;
    public PlayerChoice playerTwoChoice;
    public int numPlayers;
}

public enum PlayerChoice { Water, Fire, Earth, Air };
