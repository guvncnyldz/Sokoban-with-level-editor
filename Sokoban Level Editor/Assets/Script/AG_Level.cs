using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Level", menuName = "CBU/Level", order = 1)]
public class AG_Level : ScriptableObject
{
    [HideInInspector]
    [SerializeField]
    public int[] grid = new int[400];
}
