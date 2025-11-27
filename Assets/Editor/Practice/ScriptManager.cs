using UnityEditor;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class ScriptManager : EditorWindow
{
    static int _gameobjectcount = -1, _componentsCount = -1, _missingCount = -1;

    static List<GameObject> _objlist = new List<GameObject>();



    [MenuItem("Window/ScriptManager")]
    public static void MakeWindows()
    {
        GetWindow(typeof(ScriptManager));
    }


    public void OnGUI()
    {
        if (GUILayout.Button("Find Missing Scripts"))
        {
            Findall();
        }

        EditorGUILayout.BeginHorizontal();
        {
            EditorGUILayout.LabelField("Object Scanned:");
            EditorGUILayout.LabelField("" + (_gameobjectcount == -1 ? "---" : _gameobjectcount.ToString()));
        }
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        {
            EditorGUILayout.LabelField("Component Scanned:");
            EditorGUILayout.LabelField("" + (_componentsCount == -1 ? "---" : _componentsCount.ToString()));
        }
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        {
            EditorGUILayout.LabelField("Possible Missing Scripts:");
            EditorGUILayout.LabelField("" + (_missingCount == -1 ? "---" : _missingCount.ToString()));
        }
        EditorGUILayout.EndHorizontal();


        
        if (_objlist.Count > 0)
        {
            EditorGUILayout.LabelField("__________________________________________________");
        }

        foreach (var item in _objlist)
        {
            EditorGUILayout.BeginHorizontal();
            {
                EditorGUILayout.LabelField(item.name);
            }
            EditorGUILayout.EndHorizontal();
        }





    }



    private static void Findall()
    {
        _gameobjectcount = 0;
        _componentsCount = 0;
        _missingCount = 0;
        _objlist.Clear();

        foreach (Transform obj in FindObjectsByType<Transform>(0))
        {
            _gameobjectcount++;
            try
            {
                foreach (var item in obj.GetComponents<Component>())
                {
                    _componentsCount++;
                    if (item == null)
                    {
                        Debug.Log(item.name);
                    }
                }
            }
            catch (System.Exception)
            {
                _objlist.Add(obj.gameObject);
                _missingCount++;
            }

        }
    }


    private static void RemoveMissing()
    {
        foreach (GameObject obj in _objlist)
        {
            foreach (var item in obj.GetComponents<Component>())
            {
                if (item == null)
                {
                    DestroyImmediate(item);
                }
            }
        }
        _objlist.Clear();
    }







}




