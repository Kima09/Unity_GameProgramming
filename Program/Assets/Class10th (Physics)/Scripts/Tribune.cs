using UnityEngine;

public class Tribune : MonoBehaviour
{
    private void OnCollisionEnter()
    {
        Debug.Log("OnCollisionEnter");
    }
    private void OnCollisionStay()
    {
        Debug.Log("OnCollisionStay");
    }
    private void OnCollisionExit()
    {
        Debug.Log("OnCollisionExit");
    }
}
