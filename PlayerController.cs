using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Update()
    {
        Vector3 targetDelta = GetTargetDelta();
        Rotate(targetDelta);
    }

    Vector3 GetTargetDelta()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
    }

    void Rotate(Vector2 rotationDelta)
    {
        rigidbody2D.rotation = Mathf.Atan2(rotationDelta.y, rotationDelta.x) * Mathf.Rad2Deg;
    }
}
