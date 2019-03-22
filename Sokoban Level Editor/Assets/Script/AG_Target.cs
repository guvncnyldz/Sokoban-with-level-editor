using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AG_Target : AG_Objects
{
    public bool ımFilled = false;
    public override bool Interact(int xIncrease, int yIncrease)
    {
        return true;
    }

    void Update()
    {            
        if (transform.parent.GetChild(0).GetComponent<AG_Box>() != null)
        {
            ımFilled = true;
        }
        else
        {
            ımFilled = false;
        }
    }
}