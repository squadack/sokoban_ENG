using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile {
    public FloorTile floorTile;
    public Entity entity;

    public Tile(FloorTile floorTile, Entity entity = Entity.None) {
        this.floorTile = floorTile;
        this.entity = entity;
    }
}


public enum FloorTile {
    Floor,
    Target,
    Wall
}

public enum Entity {
    Player,
    Box,
    None
}