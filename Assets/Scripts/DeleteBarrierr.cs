using Unity.VisualScripting;
using UnityEngine;

public class DeleteBarrierr : MonoBehaviour
{

    public Collider2D other;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Collision.Equals(gameObject,other))
        {
            gameObject.SetActive(false);
        }
    }



    



}
