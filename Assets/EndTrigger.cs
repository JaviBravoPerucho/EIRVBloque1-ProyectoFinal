using StarterAssets;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public AudioSource source;
    public AudioClip sound;

    public FirstPersonController controller;

    public GameObject endTitle;

    private void OnTriggerEnter(Collider other)
    {
        source.PlayOneShot(sound);
        GetComponent<BoxCollider>().enabled = false;
        controller.enabled = false;
        endTitle.SetActive(true);
        endTitle.GetComponent<FadeInUI>().AparecerDesdeLaNada();
        Cursor.lockState = CursorLockMode.None;
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
