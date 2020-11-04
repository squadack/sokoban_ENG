using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level
{
    public List<List<Tile>> levelLayout;


    public List<Vector2Int> targets; // list of all target tiles
    public int height;
    public int width;

    public Level() {
        // string demoLevel = "#######\n#@..$_#\n#######";
        string demoLevel =
@"#######
#@..$_#
#######";

// ###
// #_###
// #..$@#
// #..##
//  ##
        CreateFromString(demoLevel);
    }

    public Level(string s) {
        CreateFromString(s);
    }


    private void CreateFromString(string s) {
    // # - wall
    // @ - player (floor underneath)
    // . - floor
    // $ - box
    // _ - target
        Debug.Log("Level created (almost).");
    }
}
