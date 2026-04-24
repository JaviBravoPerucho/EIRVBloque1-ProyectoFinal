using UnityEngine;
using UnityEngine.InputSystem;

public class PhoneTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject pressECall;

    public AudioSource audio;
    public AudioClip Sonido;

    private void OnTriggerEnter(Collider other)
    {
        pressECall.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        pressECall.SetActive(false);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pressECall.activeSelf && Keyboard.current.eKey.wasPressedThisFrame)
        {
            audio.PlayOneShot(Sonido);
        }
    }
}
