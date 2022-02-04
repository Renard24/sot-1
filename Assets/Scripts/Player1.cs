using UnityEngine.InputSystem;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    private Move2D move;
  
    private void Awake()
    {
        move = GetComponent<Move2D>();
    }

    // Update is called once per frame
    private void OnMove(InputValue value)
    {
        move.direction = value.Get<Vector2>();
    }

}
