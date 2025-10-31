using UnityEngine;

public class FollowMouse2D : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    public bool carpet_mount = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            carpet_mount = !carpet_mount;
        }
        
        
        if (carpet_mount == true)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = transform.position.z;
            transform.position = Vector3.Lerp(transform.position, mousePosition, moveSpeed * Time.deltaTime);
        }
            
    }
}