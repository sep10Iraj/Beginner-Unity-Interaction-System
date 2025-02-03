using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JukeBox : InteractableObject
{

    AudioSource audioSource;
    [SerializeField]
    private List<AudioClip> Music = new List<AudioClip>();

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public override void Interact()
    {
        base.Interact();
        // this part of code will play a random music
        audioSource.clip = Music[Random.Range(0, Music.Count-1)];
        audioSource.Play();
    }
}
