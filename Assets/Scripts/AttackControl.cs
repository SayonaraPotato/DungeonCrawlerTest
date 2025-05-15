using UnityEngine;

public class AttackControl : MonoBehaviour
{
    

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 vector3;

        vector3.x = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
        vector3.y = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
        vector3.z = 1;

        transform.position = vector3;
    }
}
