using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// every Interactable Objects should inherit from this class
public abstract class InteractableObject : MonoBehaviour
{
    // when player wants to interact, this function will be triggered
    public virtual void Interact()
    {
       
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
