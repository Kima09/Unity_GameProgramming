using UnityEngine;

public class Mouse : MonoBehaviour
{
    [SerializeField] Ray ray;
    [SerializeField] float duration = 1.0f;
    [SerializeField] RaycastHit raycastHit;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out raycastHit, Mathf.Infinity))
            {
                Debug.DrawLine(ray.origin, raycastHit.point, Color.green, duration);
            }

        }
    }
}
