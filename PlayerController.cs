using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float rotationSpeed = 15.0f;

    void Update()
    {
        Vector3 targetPosition = MouseInput();
        Rotate(targetPosition);
    }

    Vector3 MouseInput()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
    }

    void Rotate(Vector3 targetDirection)
    {
        float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;
        Quaternion targetRotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
}
