using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AG_Cell : MonoBehaviour
{
    public int PosX { get; set; }
    public int PosY { get; set; }

    public void _setData(int posX, int posY)
    {
        this.PosX = posX;
        this.PosY = posY;
    }

    public Transform whoAmI()
    {
        if (transform.childCount > 0)
            return transform.GetChild(0).transform;
        else
            return null;
    }
}