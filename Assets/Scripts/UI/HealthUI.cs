using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthUI : MonoBehaviour
{
    public int playerId;
    public TextMeshProUGUI healthText;

    // How long the UI should shake for.
    public float shakeDuration = 0.5f;

    // Amplitude of the shake. A larger value shakes the UI harder.
    public float shakeAmount = 0.9f;

    private float decreaseFactor = 1.0f;
    private float shakeTimer;


    Vector2 originalPos;

    private void Start()
    {
        EventSystemUI.current.onHealthChanged += HealthChanged;
        originalPos = transform.localPosition;
    }
    private void OnDisable()
    {
        EventSystemUI.current.onHealthChanged -= HealthChanged;
    }

    private void HealthChanged(int id, int health)
    {
        if (playerId == id)
        {
            shakeTimer = shakeDuration;//start shaking
            if (health < 0)
                healthText.text = "0"; //force non-negative values for UI
            else
                healthText.text = health.ToString();
        }
            
    }

    void Update()
    {
        if (shakeTimer > 0)
        {
            transform.localPosition = originalPos + Random.insideUnitCircle * shakeAmount;

            shakeTimer -= Time.deltaTime * decreaseFactor;
        }
        else
        {
            shakeTimer = 0f;
            transform.localPosition = originalPos;
        }
    }
}
