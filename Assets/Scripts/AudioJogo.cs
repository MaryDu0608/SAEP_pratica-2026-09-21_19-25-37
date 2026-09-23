using UnityEngine;

public class AudioJogo : MonoBehaviour
{
    [SerializeField] public AudioClip somMenu;

    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        if (somMenu != null && audioSource != null)
        {
            audioSource.PlayOneShot(somMenu);
        }
    }

    
    void Update()
    {
        
    }
}
