using UnityEngine;
using UnityEngine.InputSystem;
public class InputMovment : MonoBehaviour
{
    [SerializeField, Tooltip("speed")] float movementSpeed;
    [SerializeField] InputAction move = new InputAction(
        type: InputActionType.Value, expectedControlType: nameof(Vector2));
    [SerializeField] Camera cam;
    Rigidbody2D rb;
    Vector2 moveDirection;
    Vector2 mousePos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        move.Enable();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = move.ReadValue<Vector2>();
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    void FixedUpdate(){
        rb.MovePosition(rb.position + moveDirection * movementSpeed * Time.fixedDeltaTime);
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
    }
}
