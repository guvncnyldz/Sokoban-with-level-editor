using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

using  UnityEngine.UI;
using Button = UnityEngine.Experimental.UIElements.Button;

public class AG_EditorWindpw : EditorWindow
{
    [MenuItem("CBU/Level Editor")]
    static void Init()
    {
        AG_EditorWindpw window = (AG_EditorWindpw)EditorWindow.GetWindow(typeof(AG_EditorWindpw));
        window.Show();
        
       
    }

    public int editorCommand = 0;
    public AG_Level level;
    void OnGUI()
    {

        level = EditorGUILayout.ObjectField(level, typeof(AG_Level), true) as AG_Level;


     
        if (level != null)
        {
            OnDrawLevelEditor();
        }

        if (GUI.changed)
        {
            EditorUtility.SetDirty(level);
        }
    }


   

   
    public void OnDrawLevelEditor()
    {
        int sayac = 0;
        for (int i = 0; i < 20; i++)
        {
            EditorGUILayout.BeginHorizontal();
            for (int j = 0; j < 20; j++)
            {
                int deneme = sayac;
                OnDrawButton(deneme);
                sayac++;
                
            }  
            EditorGUILayout.EndHorizontal();
        }


        if (GUILayout.Button("Null"))
            editorCommand = 0;
        
        if (GUILayout.Button("Player Spawn Point"))
            editorCommand = 1;
        
        if (GUILayout.Button("Box"))
            editorCommand = 2;
        
        if (GUILayout.Button("Box Target"))
            editorCommand = 3;
        
        if (GUILayout.Button("Road"))
            editorCommand = 4;
        if (GUILayout.Button("Wall"))
            editorCommand = 5;

     



    }

    public void OnDrawButton(int index)
    {
        switch (level.grid[index])
        {
            case 0:
                if (GUILayout.Button("N",  GUILayout.Width(30), GUILayout.Height(30)))
                {
                    Debug.Log(index);
                    level.grid[index] = editorCommand;
                }
                break;
            case 1:
                if (GUILayout.Button("PSP",  GUILayout.Width(30), GUILayout.Height(30)))
                {
                    level.grid[index] = editorCommand;
                }
                break;
            case 2:
                if (GUILayout.Button("B",  GUILayout.Width(30), GUILayout.Height(30)))
                {
                    level.grid[index] = editorCommand;
                }
                break;
            case 3:
                if (GUILayout.Button("BT",  GUILayout.Width(30), GUILayout.Height(30)))
                {
                    level.grid[index] = editorCommand;
                }
                break;
            case 4:
                if (GUILayout.Button("R",  GUILayout.Width(30), GUILayout.Height(30)))
                {
                    level.grid[index] = editorCommand;
                }
                break;
            case 5:
                if (GUILayout.Button("W",  GUILayout.Width(30), GUILayout.Height(30)))
                {
                    level.grid[index] = editorCommand;
                }
                break;
        }
    }



  
  
}