using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AG_Objects : MonoBehaviour
{
    [SerializeField] public int posX, posY;

    protected AG_Grid grid;
    void Start()
    {
        grid = AG_Grid.Instance;
        transform.parent = grid.grid[posX, posY].transform;
        transform.localPosition = Vector3.zero;
        AG_Cell myCell = transform.parent.GetComponent<AG_Cell>();
        Debug.Log(grid);
        posX = myCell.PosX;
        posY = myCell.PosY;
    }

    protected bool CanIMove(int nextPosX, int nextPosY)
    {
        if (grid.StayInGrid(nextPosX, nextPosY))
        {
            Transform nextCellObject = grid.grid[nextPosX, nextPosY].whoAmI();

            if (nextCellObject != null)
            {
                if (nextCellObject.CompareTag("Object"))
                {
                    return false;
                }
                else if (nextCellObject.CompareTag("Target"))
                {
                    return true;
                }
                else
                {
                    return true;
                }
            }
            else
                return true;
        }
        else
            return false;
    }
    public void setData(int row,int col)
    {
        posX = row;
        posY = col;
    } 
    public abstract bool Interact(int xIncrease, int yIncrease);
}