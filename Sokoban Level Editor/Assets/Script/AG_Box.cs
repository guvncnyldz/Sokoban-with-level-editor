using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AG_Box : AG_Objects
{
    public override bool Interact(int xIncrease, int yIncrease)
    {
        if (base.CanIMove(posX + xIncrease, posY + yIncrease))
        {
            posX += xIncrease;
            posY += yIncrease;
            transform.parent = grid.grid[posX, posY].transform;
            transform.SetSiblingIndex(0);
            transform.localPosition = Vector3.zero;
            return true;
        }
        else
            return false;
    }
}