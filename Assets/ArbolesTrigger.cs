using UnityEngine;

public class ArbolesTrigger : MonoBehaviour
{

    float elapsedTime = 0;
    float growingTime = 30.0f;
    float growScale = 10.0f;
    public GameObject trees;
    bool startGrow = false;

    public AudioSource source;
    public AudioClip clip;

    private void OnTriggerEnter(Collider other)
    {
        startGrow = true;
        source.PlayOneShot(clip);
        GetComponent<BoxCollider>().enabled = false;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (startGrow)
        {
            elapsedTime += Time.deltaTime;
            Debug.Log(elapsedTime);
            if (elapsedTime < growingTime)
            {
                Vector3 grow;
                grow.x = 1 + (elapsedTime / growingTime) * growScale;
                grow.y = 1 + (elapsedTime / growingTime) * growScale;
                grow.z = 1 + (elapsedTime / growingTime) * growScale;
                foreach (Transform arbol in trees.transform)
                {
                    arbol.localScale = grow;
                }
            }
            else startGrow = false;
        }
    }
}
