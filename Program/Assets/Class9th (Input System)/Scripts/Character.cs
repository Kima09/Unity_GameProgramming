using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Vector3 direction;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");

        direction.z = Input.GetAxisRaw("Vertical");

        direction.Normalize();  
        
        transform.position = transform.position + direction*speed*Time.deltaTime;
    }
}
