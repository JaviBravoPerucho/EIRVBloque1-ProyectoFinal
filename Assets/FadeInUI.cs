using UnityEngine;
using System.Collections;
// Necesitamos esto para interactuar con los componentes de UI
using UnityEngine.UI;

public class FadeInUI : MonoBehaviour
{
    // Tiempo en segundos que tardará en aparecer completamente
    public float duracionFade = 2.0f;

    private CanvasGroup canvasGroup;

    void Awake()
    {
        // Guardamos la referencia al Canvas Group al iniciar
        canvasGroup = GetComponent<CanvasGroup>();
        // Aseguramos que empiece invisible
        canvasGroup.alpha = 0f;
    }

    // Llama a esta función para que el objeto aparezca
    public void AparecerDesdeLaNada()
    {
        StartCoroutine(HacerFadeIn());
    }

    // Corrutina que anima el Alpha fotograma a fotograma
    private IEnumerator HacerFadeIn()
    {
        float tiempoPasado = 0f;

        while (tiempoPasado < duracionFade)
        {
            tiempoPasado += Time.deltaTime;
            // Calculamos el alpha actual basado en el tiempo
            canvasGroup.alpha = Mathf.Lerp(0f, 1f, tiempoPasado / duracionFade);
            // Esperamos al siguiente fotograma
            yield return null;
        }

        // Aseguramos que quede totalmente visible al final
        canvasGroup.alpha = 1f;
    }
}
