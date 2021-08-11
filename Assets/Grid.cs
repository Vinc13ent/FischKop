using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using UnityEditor.IMGUI.Controls;
using UnityEngine;
using CodeMonkey.Utils;
using UnityEditor.Experimental.GraphView;

public class Grid
{
    private int width;
    private int hight;
    private float cellSize;
    private int[,] gridArray;

    public Grid(int width, int hight, float cellSize)
    {
        this.width = width;
        this.hight = hight;
        this.cellSize = cellSize;

        gridArray = new int[width, hight];

        for (int x = 0; x < gridArray.GetLength(0); x++)
        {
            for (int y = 0; y < gridArray.GetLength(1); y++)
            {
                UtilsClass.CreateWorldText(gridArray[x, y].ToString(), null, GetWorldPosition(x,y), 30, Color.black, TextAnchor.MiddleCenter);
            }
        }
    }

    private Vector3 GetWorldPosition(int x, int y)
    {
        return new Vector3(x, y) * cellSize;
    }
}
