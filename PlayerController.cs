using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    new Rigidbody2D rigidbody2D;
    
    void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
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
