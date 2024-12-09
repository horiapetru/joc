using UnityEngine;

public class BarrierHandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     [SerializeField] private string activatableBarrierTag = "ActivateBarrier";
    [SerializeField] private string destructibleBarrierTag = "DestroyBarrier";

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check for activatable barrier
        if (gameObject.CompareTag(activatableBarrierTag))
        {
            // Activate the barrier
            collision.gameObject.SetActive(true);
        }
        // Check for destructible barrier
        else if (gameObject.CompareTag(destructibleBarrierTag))
        {
            // Destroy the barrier
            Destroy(collision.gameObject);
            Debug.Log($"{gameObject.name} has been destroyed.");
        }
    }
}
