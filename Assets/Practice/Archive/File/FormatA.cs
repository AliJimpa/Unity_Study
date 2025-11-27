using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class FormatA
{
    [Serializable]
    public class CCustomFormat
    {
        public string Message;
    }

    private string Fullpath = "";
    private bool IsStartup = false;
    private string Filetype = "";


    public void Startup(string path, string fileformat, bool inapp)
    {
        if (!IsStartup)
        {
            if (inapp)
                Fullpath = Application.persistentDataPath + "\\";

            Fullpath = Fullpath + path + "\\";
            IsStartup = true;
            Filetype = "." + fileformat;
        }

    }



    public void Save(string filename, CCustomFormat file)
    {
        if (IsStartup)
        {
            var binaryFormatter = new BinaryFormatter();
            using (var fileStream = File.Create(Fullpath + filename + Filetype))
            {
                binaryFormatter.Serialize(fileStream, file);
            }
        }
        else
        {
            Debug.LogWarning("Console: You have to run 'startup' method first");
        }

    }

    public void Savewithpath(string fullpath, CCustomFormat file)
    {

        if (IsStartup)
        {
            var binaryFormatter = new BinaryFormatter();
            using (var fileStream = File.Create(fullpath))
            {
                binaryFormatter.Serialize(fileStream, file);
            }
        }
        else
        {
            Debug.LogWarning("Console: You have to run 'startup' method first");
        }
    }



    public CCustomFormat Load(string filename)
    {
        if (File.Exists(Fullpath + filename + Filetype))
        {
            var binaryFormatter = new BinaryFormatter();
            using (var fileStream = File.Open(Fullpath + filename + Filetype, FileMode.Open))
            {
                return (CCustomFormat)binaryFormatter.Deserialize(fileStream);
            }
        }
        else
        {
            Debug.LogWarning("Your file doesnt exist");
            return new CCustomFormat();
        }
    }
    public CCustomFormat Loadwithpath(string fullpath)
    {
        if (File.Exists(fullpath))
        {
            var binaryFormatter = new BinaryFormatter();
            using (var fileStream = File.Open(fullpath, FileMode.Open))
            {
                return (CCustomFormat)binaryFormatter.Deserialize(fileStream);
            }
        }
        else
        {
            Debug.LogWarning("Your file doesnt exist");
            return new CCustomFormat();
        }
    }





}
