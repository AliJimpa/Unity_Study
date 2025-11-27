using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EditorScript : EditorWindow
{
    string custSring = "String Here";
    bool groupEnabled;
    bool optionalSetting = true;
    float jumpMod = 1.0f;
    float impactMod = 0.5f;


    [MenuItem("Window / Custom Controls ")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(EditorScript));
    }


    private void OnGUI() {
        GUILayout.Label("Base Setting" , EditorStyles.boldLabel);
        custSring = EditorGUILayout.TextField( "Text Field" , custSring);

        groupEnabled = EditorGUILayout.BeginToggleGroup("Optional Setting" , groupEnabled);
        optionalSetting = EditorGUILayout.Toggle( "Double Enabled" , optionalSetting );
        jumpMod = EditorGUILayout.Slider("Jump Modifier" , jumpMod , -5 ,5);
        impactMod = EditorGUILayout.Slider("Impact Modifier" , impactMod , -5 ,5 );
        EditorGUILayout.EndToggleGroup();

        GUI.backgroundColor = Color.red;

        GUILayout.FlexibleSpace();
        EditorGUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();
        if (GUILayout.Button("Reset" , GUILayout.Width(100) , GUILayout.Height(30) ))
        {
            custSring = "String Here";
            optionalSetting = false;
            jumpMod = 1.0f;
            impactMod = 0.5f;
        }
        EditorGUILayout.EndHorizontal();
    }


}
