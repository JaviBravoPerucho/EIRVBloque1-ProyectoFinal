using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    public AudioSource fuenteDeAudio;
    public AudioClip sonido;


    private void OnTriggerEnter(Collider other)
    {
        fuenteDeAudio.PlayOneShot(sonido);
        fuenteDeAudio = null;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
