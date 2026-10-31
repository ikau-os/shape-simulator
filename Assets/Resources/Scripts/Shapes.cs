using Unity.VisualScripting;
using UnityEngine;

public class Shapes : MonoBehaviour
{
    private AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!audioSource.isPlaying)
        {
            // 6741
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Deleter"))
        {
            Destroy(gameObject);
        }
    }
}
