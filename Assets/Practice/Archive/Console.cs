using UnityEngine;
using System;
using System.IO;


public class Console
{

    public enum EFiletype
    {
        Text,
        Json
    }
    public enum ELogtype
    {
        LogInfo,
        LogWarning,
        LogError,
        LogSystem
    }
    public class CLine
    {
        public string user;
        public string time;
        public string level;
        public string location;
        public string message;
    }



    // private variable
    private string Fullpath = "";
    private bool IsStartup = false;
    private EFiletype LogType;


    
    public void Startup(string path , bool inapp , EFiletype filetype)
    {
        if (inapp)
        {
            Fullpath = Application.persistentDataPath;
        }else{
            Fullpath = path;
        }
        
        LogType = filetype;
        if (LogType == EFiletype.Text)
        {
            Fullpath = Fullpath + "\\" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + ".txt";
        }else{
            Fullpath = Fullpath + "\\" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + ".json";
        }
        
        IsStartup = true;
    }



    public void Writelog(CLine Logline)
    {
        if (IsStartup)
        {
            if (LogType == EFiletype.Text)
            {
                writelogt(Logline);
            }else{
                writelogj(Logline);
            }
        }
        else
        {
            Debug.LogWarning("Console: You have to run 'startup' method first");
        }
    }
    public void Writelog(ELogtype type, string log)
    {
        if (IsStartup)
        {
            CLine newlog = new CLine();
            newlog.user = Environment.UserName;
            newlog.level = type.ToString();
            newlog.time = DateTime.Now.ToString();
            System.Diagnostics.StackFrame callStack = new System.Diagnostics.StackFrame(1, true);
            newlog.location = "[ Method(" + callStack.GetMethod().Name + ") Line(" + callStack.GetFileLineNumber() + ") ]";
            newlog.message = log;
            if (LogType == EFiletype.Text)
            {
                writelogt(newlog);
            }else{
                writelogj(newlog);
            }
        }else{
            Debug.LogWarning("Console: You have to run 'startup' method first");
        }
    }
    

    public string ReadLog()
    {
        return ReadLog(Fullpath);
    }
    public string ReadLog(string fullpath)
    {
        string message = "";
        StreamReader reader = new StreamReader(fullpath); 
        message = reader.ReadToEnd();
        reader.Close();
        return message;
    }

    public CLine ReadLogJson()
    {
        return JsonUtility.FromJson<CLine>(Fullpath);
    }
    public CLine ReadLogJson(string fullpath)
    {
        return JsonUtility.FromJson<CLine>(fullpath);
    }




    private void writelogj(CLine logline)
    {
        string potion = JsonUtility.ToJson(logline);
        System.IO.File.WriteAllText(Fullpath, potion);
    }
    private void writelogt(CLine Logline)
    {
        string Message = "username:"+Logline.user+",timestamp:"+Logline.time+",level:"+Logline.level+",location:"+Logline.location+",message:["+Logline.message+"]";
        StreamWriter writer = new StreamWriter(Fullpath, true);
        writer.WriteLine(Message);
        writer.Close();
    }
    
  



}
