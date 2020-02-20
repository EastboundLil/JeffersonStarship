using UnityEngine;

public class ShipController : MonoBehaviour
{
    public float speed = 20f;


    // Update is called once per frame
    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(castPoint, out hit, Mathf.Infinity))
            {
                transform.position = hit.point;
            }
        }
    }
}
