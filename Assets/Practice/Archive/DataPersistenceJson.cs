using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataPersistenceJson : MonoBehaviour {

    [System.Serializable]
    class SaveData
    {
        public Color TeamColor;
    }

    public void SaveColor(Color color)
    {
        SaveData data = new SaveData();
        data.TeamColor = color;

        string json = JsonUtility.ToJson(data);
  
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public Color LoadColor()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            return data.TeamColor;
        }
            return Color.black;
    }

    
}