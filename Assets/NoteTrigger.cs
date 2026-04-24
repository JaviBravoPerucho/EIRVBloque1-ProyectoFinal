using UnityEngine;
using UnityEngine.InputSystem;

public class NoteTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject pressERead;

    [SerializeField]
    GameObject pressESave;

    [SerializeField]
    GameObject noteUI;

    [SerializeField]
    GameObject noteObject;

    public AudioSource fuenteDeAudio;
    public AudioClip sonidoCoger;
    public AudioClip sonidoDejar;

    private void OnTriggerEnter(Collider other)
    {
        pressERead.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        pressERead.SetActive(false);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pressERead.activeSelf && Keyboard.current.eKey.wasPressedThisFrame)
        {
            noteObject.SetActive(false);
            noteUI.SetActive(true);
            pressERead.SetActive(false);
            pressESave.SetActive(true);
            fuenteDeAudio.PlayOneShot(sonidoCoger);
        }else if(pressESave.activeSelf && Keyboard.current.eKey.wasPressedThisFrame)
        {
            noteUI.SetActive(false);
            pressESave.SetActive(false);
            fuenteDeAudio.PlayOneShot(sonidoDejar);
        }
    }
}
