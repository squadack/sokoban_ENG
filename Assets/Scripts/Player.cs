using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2Int direction;
        // if (Input.GetKeyDown(KeyCode.W)) {

        // }
        //TODO get move direction as Vector2Int
        gameController.TryMovePlayer(direction);
    }
}
