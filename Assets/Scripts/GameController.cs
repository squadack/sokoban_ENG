using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // where is the player?
    // does tile (x,y) contain a box?
    // try to move player in direction (x, y)

    public GameObject playerPrefab;
    public GameObject wallPrefab;
    public GameObject boxPrefab;
    public GameObject floorPrefab;
    public GameObject targetPrefab;

    public List<Level> levels;
    public int currentLevel = 0;

    private int correctBoxes = 0;

    private Vector2Int playerPos;
    private GameObject[,] boxes;
    private GameObject playerGameObject; //changing position of playerGameObject should change position of its object on screen

    // Start is called before the first frame update
    void Start()
    {
        levels.Add(new Level());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LoadLevel(int idx) {
        currentLevel = idx;
        Level lev = levels[currentLevel];

        boxes = new GameObject[lev.width, lev.height];

        for (int row = 0; row < lev.height; row++) {
            for (int col = 0; col < lev.levelLayout[row].Count; col++) {
                InstantiateTile(row, col);
            }
        }
        CenterMainCameraOn(lev.width / 2, lev.height / 2);
    }

    private void InstantiateTile(int row, int col) {
        //TODO Instantiate appropriate GameObjects
        // if creating a player assign its GameObject to playerGameObject;
        // if creating a box assign its GameObject to approrpriate field in boxes array
    }

    private void CenterMainCameraOn(float x, float y) {
        // TODO Change Camera.main.transform.position
        //TODO change Camera.main ortographicSize so that every element will fit on screen.
    }

    //direction should be one of (1, 0), (-1, 0), (0, 1), (0, -1)
    public bool TryMovePlayer(Vector2Int direction) {
        //Player can move if field next to him in given direction
        // - is empty and is not a wall
        // - contains a box and that box can be moved in the same direction

        //if movement in given direction is possible then change playerPosition
        // AND change position of appropriate GameObject
        // AND return true;
        //else
        //  return false
        return false;
    }

    private bool TryMoveBox(Vector2Int position, Vector2Int direction) {
        //Box can move only if field (position + direction) is empty and is not a wall
        //if canMove
            // change box's position whitin boxes array
            // change its GameObject's positon so that box will move on screen
            UpdateCorrectBoxes();
            // return true
        return false;
    }

    private void UpdateCorrectBoxes() {
        int counter = 0;
        // for each target tile
        // if it contains a box then counter++
        correctBoxes = counter;
    }

}
