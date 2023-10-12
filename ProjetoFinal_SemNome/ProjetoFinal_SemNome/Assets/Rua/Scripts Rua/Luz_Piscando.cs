using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkingLight : MonoBehaviour
{
    public Light spotLight; // Referência à luz spot que você deseja piscar
    public float minBlinkInterval = 0.5f; // Intervalo mínimo entre os flashes
    public float maxBlinkInterval = 2.0f; // Intervalo máximo entre os flashes
    public AudioSource lightAudioSource; // Referência ao componente de áudio da luz
    public Material materialWithEmission; // Referência ao material com o mapa de emissão

    private bool isBlinking = false;

    private void Start()
    {
        // Inicializa o primeiro flash aleatório
        StartCoroutine(BlinkRandomly());
    }

    private IEnumerator BlinkRandomly()
    {
        while (true)
        {
            // Gera um intervalo aleatório para o próximo flash
            float blinkInterval = Random.Range(minBlinkInterval, maxBlinkInterval);

            // Liga a luz
            spotLight.enabled = true;

            // Liga o som
            lightAudioSource.Play();

            // Ativa o mapa de emissão no material
            materialWithEmission.EnableKeyword("_EMISSION");

            // Aguarda por um curto período de tempo
            yield return new WaitForSeconds(blinkInterval);

            // Desliga a luz
            spotLight.enabled = false;

            // Desliga o som
            lightAudioSource.Stop();

            // Desativa o mapa de emissão no material
            materialWithEmission.DisableKeyword("_EMISSION");

            // Aguarda novamente por um curto período de tempo
            yield return new WaitForSeconds(blinkInterval);

            // Repete o processo para criar um novo flash aleatório
        }
    }
}
