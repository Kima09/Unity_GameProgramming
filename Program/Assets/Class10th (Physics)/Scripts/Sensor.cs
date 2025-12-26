using UnityEngine;

public class Sensor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball")
        {
            other.GetComponent<Control>().Soar();
        }
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit");
    }
}
