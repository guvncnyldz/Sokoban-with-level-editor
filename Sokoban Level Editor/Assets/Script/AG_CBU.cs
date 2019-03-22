using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AG_CBU : MonoBehaviour {

    // Have we loaded the prefs yet
    private static bool prefsLoaded = false;

    // The Preferences
    private static bool boolPreference = false;
    public static Sprite source;


    [PreferenceItem("CBU - OG")]
    private static void CustomPreferencesGUI()
    {
        if (!prefsLoaded)
        {
            boolPreference = EditorPrefs.GetBool("BoolPreferenceKey", false);
            prefsLoaded = true;
        }

        EditorGUILayout.LabelField("Manisa Celal Bayar Universitesi - Oyun Geliştirme Klübü");
      
        

    }
}
