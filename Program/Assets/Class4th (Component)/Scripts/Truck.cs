using UnityEngine;

public class Truck : MonoBehaviour
{
    [SerializeField] Rigidbody rigidBody;

    [SerializeField] GameObject[] wheels;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
        for (int i = 0; i < wheels.Length; i++)
        {
            Debug.Log(wheels[i].name);

        }

        rigidBody.useGravity = false;
    }
}


