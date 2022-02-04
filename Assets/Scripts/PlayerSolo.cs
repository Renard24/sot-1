using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSolo : MonoBehaviour
{
    private Move2D move;
    private Shoot2D shooter;
    // Start is called before the first frame update
    private void Awake()
    {
        move = GetComponent<Move2D>();
        shooter = GetComponent<Shoot2D>();
    }

    // Update is called once per frame
    private void OnMove(InputValue value)
    {
        move.direction = value.Get<Vector2>();
    }

    private void OnFire()
    {
        shooter.Shoot();
    }
}

