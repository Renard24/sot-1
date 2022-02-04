using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerScriptPicker : MonoBehaviour
{
    public GameObject playerSolo, player1, player2;
    void Start()
    {
        if (PlayerInputManager.instance.playerCount == 1)
        {
            Instantiate(playerSolo, transform);
        }
        else
        {
            var solo = FindObjectOfType<PlayerSolo>().transform;
            var soloPosition = solo.position;
            var soloParent = solo.parent;
            Destroy(solo.gameObject);
            Instantiate(player1, soloPosition, Quaternion.identity, soloParent);
            Instantiate(player2, transform, soloParent);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
