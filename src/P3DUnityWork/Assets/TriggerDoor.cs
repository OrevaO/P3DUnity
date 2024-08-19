using UnityEngine;

public class TriggerDoor : MonoBehaviour
{
    private Animator _doorAnimator;  // Reference to the Animator component attached to the door
   

    void Start()
    {
        
        _doorAnimator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider belong to the player
        if (other.CompareTag("Player"))
        {
            // Trigger the door to open
            _doorAnimator.SetTrigger("Open");
        }
    } 

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _doorAnimator.SetTrigger("Close");
        }
    }
}