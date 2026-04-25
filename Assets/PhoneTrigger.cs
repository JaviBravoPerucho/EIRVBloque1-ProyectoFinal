using UnityEngine;
using UnityEngine.InputSystem;

public class PhoneTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject pressECall;

    public AudioSource audio;
    public AudioClip Sonido;

    float elapsedTime = 0;
    float soundTime = 21.5f;
    bool startTime = false;

    public GameObject Arboles;
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
            startTime = true;
        }
        if (startTime)
        {
            elapsedTime += Time.deltaTime;
            if(elapsedTime > soundTime)
            {
                Arboles.SetActive(true);
                startTime = false;
            }
        }
    }
}
