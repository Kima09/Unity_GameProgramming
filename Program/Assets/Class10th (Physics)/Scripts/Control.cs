using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField] Vector3 direction;
    [SerializeField] float power;
    [SerializeField] ForceMode forceMode;
    [SerializeField] Rigidbody rigidBody;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
        forceMode = ForceMode.Force;
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        direction.Normalize();

    }

    private void FixedUpdate()
    {
        rigidBody.AddForce(direction * power, forceMode);
    }
}
