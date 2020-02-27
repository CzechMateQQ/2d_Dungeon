using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    List<Tile> connections;
    private Tile prev;
    private int gScore = 0;
    TileManager tileMan;
    [HideInInspector] 
    public Tile up, down, left, right;

    private void Connect()
    {
        for (int i = 0; i < tileMan.cells.Length; i++)
        {
            if (tileMan.cells[i].GetComponent<SpriteRenderer>().name == "roguelikeDungeon_transparent_365")
            {

            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
