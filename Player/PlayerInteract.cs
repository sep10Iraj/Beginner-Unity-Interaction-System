using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Attach this to your player  


public class PlayerInteract : MonoBehaviour
{
    public Transform InteractCheckPos;

    public LayerMask InteractableLayer;

    public float radius;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            InteractWithItems();
        }
    }

    // this function finds all Interactable objects near the player and then Interact with them by calling their interact function 
    void InteractWithItems()
    {

        Collider2D[] items = Physics2D.OverlapCircleAll(InteractCheckPos.position, radius, InteractableLayer);
        foreach (Collider2D item in items)
        {
            item.GetComponent<InteractableObject>().Interact();
        }
    }

    // this function shows the interact bounds in edit mode to arrange it with your desired size
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(InteractCheckPos.position, radius);
    }
}
