using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AG_GameManager : MonoBehaviour
{
    [SerializeField] private List<AG_Target> targets;

    private AG_Grid grid;

    [SerializeField] private int filledCount = 0;

    void Start()
    {
        foreach (GameObject target in GameObject.FindGameObjectsWithTag("Target"))
        {
            targets.Add(target.GetComponent<AG_Target>());
        }
    }

    void Update()
    {
        foreach (AG_Target target in targets)
        {
            if (!target.ımFilled)
            {
                break;
            }

            if (target == targets.ElementAt(targets.Count - 1))
                Debug.Log("Bittttiiiiii");
        }
    }
}