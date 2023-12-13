using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioEventResponder : MonoBehaviour
{
    [SerializeField] AudioClip[] soundToPlay;
    AudioSource audioSource;
    public int audInList;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySound(int audInList)
    {
        audioSource.PlayOneShot(soundToPlay[audInList]);
    }
}
