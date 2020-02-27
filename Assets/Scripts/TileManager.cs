using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public Tile[] cells;

    [HideInInspector]
    public int xSize = 30;
    [HideInInspector]
    public int ySize = 15;

    [SerializeField]
    Transform temp;

    void CreateArray()
    {
        Sort(0, cells.Length, 0);

        for (int x = 0; x < cells.Length; x += ySize)
        {
            int startIdx = x;           
            int endIdx = x + ySize;

            //Debug.LogFormat("{0}:{1}", startIdx, endIdx);

            Sort(startIdx, endIdx, 1);
        }

        //for(int i = 0; i < cells.Length; ++i)
        //{
        //    cells[i].parent = temp;
        //    cells[i].transform.SetSiblingIndex(i);
        //    cells[i].name = i.ToString();
        //}
    }

    private void Sort(int startIdx, int endIdx, int dimension)
    {
        Tile tmp;

        for (int i = startIdx; i < endIdx; ++i)
        {
            for (int j = startIdx; j < endIdx - 1; j++)
            {
                if (cells[j].transform.position[dimension] > cells[j + 1].transform.position[dimension])
                {
                    tmp = cells[j];
                    cells[j] = cells[j + 1];
                    cells[j + 1] = tmp;
                }
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        CreateArray();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
