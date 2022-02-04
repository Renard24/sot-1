using UnityEngine.InputSystem;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    private Shoot2D shooter;
    private PV life;
    // Start is called before the first frame update
    private void Awake()
    {
        shooter = GetComponent<Shoot2D>();
        life = GetComponent<PV>();
    }

    private void Start()
    {
        GetComponent<PlayerInput>().SwitchCurrentActionMap("Player2");

    }
    private void OnFire()
    {
        shooter.Shoot();
    }
}
 