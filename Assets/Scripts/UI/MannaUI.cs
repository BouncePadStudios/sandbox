using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MannaUI : MonoBehaviour
{
    public int playerId;
    public TextMeshProUGUI mannaText;

    private void Start()
    {
        EventSystemUI.current.onMannaChanged += MannaChanged;
    }
    private void OnDisable()
    {
        EventSystemUI.current.onMannaChanged -= MannaChanged;
    }

    private void MannaChanged(int id, int manna)
    {
        if (playerId == id)
            mannaText.text = manna.ToString();
    }

}