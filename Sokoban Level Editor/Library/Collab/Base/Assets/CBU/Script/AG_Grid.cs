using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AG_Grid : MonoBehaviour
{

    public AG_Cell[,] grid = new AG_Cell[20,20];
    public AG_Level selectedLevel;
    public GameObject _player,_box,_boxTarget,_wall,_road;
    
    
    void Awake()
    {



        int sayac = 0;
        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                grid[i, j] = (new GameObject()).AddComponent<SpriteRenderer>().gameObject.AddComponent<AG_Cell>();
                grid[i, j].name = "[CELL]";
                grid[i, j].transform.localScale = new Vector2(1, 1);
                grid[i, j].transform.position = new Vector2(i, j);
                grid[i, j].transform.parent = transform;
                grid[i, j]._setData(i, j);

                createObject(selectedLevel.grid[sayac],  grid[i, j].transform);
                sayac++;
            }
        }
    }
    
    public bool StayInGrid(int posx, int posy)
    {
        if (posx >= 0 && posy >= 0 && posx <= 19 && posy <= 19)
            return true;
        else
            return false;
    }

    public void createObject(int code,Transform parent)
    {
        switch (code)
        {
                case 0:
                    
                    break;
                case 1:
                    Instantiate(_player, parent);
                    break;
                case 2:
                    Instantiate(_box, parent);
                    break;
                case 3:
                    Instantiate(_boxTarget, parent);
                    break;
                case 4:
                    Instantiate(_road, parent);
                    break;
        }
    }
}