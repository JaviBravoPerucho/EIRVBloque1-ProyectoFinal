using UnityEngine;

public class MurmursTrigger : MonoBehaviour
{

    public AudioSource source;
    public AudioClip sound;

    private void OnTriggerEnter(Collider other)
    {
        source.PlayOneShot(sound);
        GetComponent<BoxCollider>().enabled = false;
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
