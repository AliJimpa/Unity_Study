using UnityEngine;
using System.IO;

public class JsonA
{


    public class CJsonformat
    {

    }




    private string Fullpath = "";
    private bool IsStartup = false;



    public void Startup(string path, bool inapp)
    {
        if (!IsStartup)
        {
            if (inapp)
                Fullpath = Application.persistentDataPath + "\\";

            Fullpath = Fullpath + path + "\\";
            IsStartup = true;
        }

    }




    public void WriteJsonfile(string filename, CJsonformat format)
    {
        if (IsStartup)
        {
            string potion = JsonUtility.ToJson(format);
            System.IO.File.WriteAllText(Fullpath + filename + ".json", potion);
            Debug.Log(Fullpath + filename + ".json");
        }
        else
        {
            Debug.LogWarning("Console: You have to run 'startup' method first");
        }
    }
    public void WriteJsonfilepath(string filepath, CJsonformat format)
    {
        string potion = JsonUtility.ToJson(format);
        System.IO.File.WriteAllText(filepath, potion);
    }


    public CJsonformat ReadLogJson(string filename)
    {
        return JsonUtility.FromJson<CJsonformat>(Fullpath + filename + ".json");
    }
    public CJsonformat ReadJsonfilepath(string fullpath)
    {
        return JsonUtility.FromJson<CJsonformat>(fullpath);
    }



    public bool ExistsJsonFile(string filename)
    {
        if (File.Exists(Fullpath + filename + ".json"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool ExistsJsonFilepath(string filepath)
    {
        if (File.Exists(filepath))
        {
            return true;
        }
        else
        {
            return false;
        }
    }




}
