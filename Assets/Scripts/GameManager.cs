using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager Current;

    [SerializeField] private PlayerSpawner playerSpawner = null;

    [SerializeField] private int gameTimer = 300; //5 minutes in seconds 
    private bool canRunTimerJob = true;
    private bool gameStarted = true; //SET TO FALSE WHEN IMPLEMENTING A MENU

    private void Awake()
    {
        if (Current == null)//makes the script a singleton
        {
            Current = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        playerSpawner.SpawnPlayers();
    }

    private void Update()
    {
        if (canRunTimerJob && gameStarted)
            StartCoroutine(CountDown());
    }

    private IEnumerator CountDown()
    {
        canRunTimerJob = false;
        yield return new WaitForSecondsRealtime(1f);
        gameTimer -= 1;
        EventSystemUI.current.ChangeTimeUI(gameTimer);
        canRunTimerJob = true;
    }




}
