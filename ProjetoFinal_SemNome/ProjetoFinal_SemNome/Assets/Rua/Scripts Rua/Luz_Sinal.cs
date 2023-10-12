using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBlinker : MonoBehaviour
{
    public Light targetLight; // A luz que você deseja piscar
    public float blinkInterval = 1.0f; // Intervalo de piscar em segundos

    private float nextBlinkTime;
    private bool isLightOn = true;

    private void Awake()
    {
        nextBlinkTime = Time.time + blinkInterval;
    }

    private void Update()
    {
        if (Time.time >= nextBlinkTime)
        {
            isLightOn = !isLightOn; // Inverte o estado da luz
            targetLight.enabled = isLightOn;
            nextBlinkTime = Time.time + blinkInterval;
        }
    }
}
