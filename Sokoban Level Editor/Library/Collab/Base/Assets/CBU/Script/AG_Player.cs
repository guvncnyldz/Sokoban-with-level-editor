using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AG_Player : MonoBehaviour
{
    AG_Grid grid;

    float timer = 0;

    int xIncrease = 0;
    int yIncrease = 0;

    int posX, posY = 0;

    private bool right = true;

    public void Start()
    {
        grid = AG_Grid.Instance;
    }

    public void Update()
    {
        xIncrease = 0;
        yIncrease = 0;

        if (Input.anyKey)
            timer += Time.deltaTime;

        PressArrow();

        if (CanIMove(posX + xIncrease, posY + yIncrease))
        {
            posX += xIncrease;
            posY += yIncrease;
        }

        transform.position = grid.grid[posX, posY].transform.position;

        //if (timer >= .35f)
        //StillMove(xIncrease, yIncrease, posx, posy);
    }

//    private void MoveAnimation()
//    {
//        if (xIncrease == 1)
//        {
//            if (right)
//                transform.sca.x *= -1;
//            GetComponent<SpriteRenderer>().sprite.name = "hero_3";
//        }
//    }
    private void PressArrow()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            yIncrease = 1;
            xIncrease = 0;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            yIncrease = 0;
            xIncrease = -1;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            yIncrease = -1;
            xIncrease = 0;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            yIncrease = 0;
            xIncrease = 1;
        }
    }

    private bool CanIMove(int nextPosX, int nextPosY)
    {
        if (grid.StayInGrid(nextPosX, nextPosY))
        {
            Transform nextCellObject = grid.grid[nextPosX, nextPosY].whoAmI();

            if (nextCellObject != null)
            {
                return nextCellObject.GetComponent<AG_Objects>().Interact(xIncrease, yIncrease);
            }
            else
                return true;
        }
        else
            return false;
    }

//    private void StillMove(int x, int y, int posx, int posy)
//    {
//        if (timer > .25f)
//        {
//            player.position = grid.grid[posx + x, posy + y].transform.position;
//            timer = .15f;
//        }
//    }
}