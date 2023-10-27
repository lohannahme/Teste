using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundDelayedPlay : MonoBehaviour
{
    public float delay = 10.0f; // Tempo de atraso em segundos
    public AudioSource audioSource; // Referência ao componente de áudio

    private bool hasPlayed = false;

    void Update()
    {
        // Verifica se o som ainda não foi reproduzido e se o tempo de atraso passou
        if (!hasPlayed && Time.time >= delay)
        {
            PlaySound();
        }
    }

    void PlaySound()
    {
        if (audioSource != null)
        {
            audioSource.Play(); // Inicia a reprodução do som
            hasPlayed = true; // Define a flag para evitar que o som seja reproduzido novamente
        }
    }
}
