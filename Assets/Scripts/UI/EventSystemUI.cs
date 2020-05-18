using System;
using UnityEngine;

public class EventSystemUI : MonoBehaviour
{
    public static EventSystemUI current;

    private void Awake()
    {
        current = this;
    }

    //define UI events that the UI scripts can subscribe to and that the gameObjects can notifty
    public event Action<int, int> onHealthChanged;
    public void ChangeHealth(int id, int health)
    {
        onHealthChanged?.Invoke(id, health);
    }

    public event Action<int, int> onMannaChanged;
    public void ChangeManna(int id, int manna)
    {
        onMannaChanged?.Invoke(id, manna);
    }

    public event Action<int> onTimeChanged;
    public void ChangeTimeUI(int time)
    {
        onTimeChanged?.Invoke(time);
    }
}
