using UnityEngine;

// Ensure the component is present on the gameobject the script is attached to
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    // Local rigidbody variable to hold a reference to the attached Rigidbody2D component
    new Rigidbody2D rigidbody2D;

    void Awake()
    {
        // Setup Rigidbody for frictionless top down movement and dynamic collision
        rigidbody2D = GetComponent<Rigidbody2D>();

        rigidbody2D.isKinematic = false;
        rigidbody2D.angularDrag = 0.0f;
        rigidbody2D.gravityScale = 0.0f;
    }

    void Update()
    {
        // Get direction to mouse position
        Vector3 targetDirection = GetTargetDirection();
        Rotate(targetDirection);
    }

    Vector3 GetTargetDirection()
    {
        // Get the difference between current location and mouse world position
        return Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
    }

    void Rotate(Vector2 targetDirection)
    {
        // Set rigidbody rotation based on direction to target
        rigidbody2D.rotation = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;// Convert radians to angle in degrees
    }
}
