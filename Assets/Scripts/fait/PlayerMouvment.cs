using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMouvment : MonoBehaviour
{
    private Move2D move;
    private Rigidbody2D rb;
    public float Speed = 10f;
    private ZQSD playerInput;

    
    public void Awake()
    {
        playerInput = new ZQSD();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        Vector2 moveInput = playerInput.PlayerSolo.Mouv.ReadValue<Vector2>();
        rb.velocity = moveInput * Speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SpeedBonus"))
        {
            Speed = Speed + 5;
            Destroy(other.gameObject);
        }
    }
}