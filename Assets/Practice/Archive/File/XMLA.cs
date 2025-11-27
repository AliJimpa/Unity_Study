using UnityEngine;
using System.IO;
using System.Xml.Serialization;

public class XMLA
{
    public class CXMLFormat {
        // Help : [XmlArray("Alijimpa")] use for make array of Class
        public string message;
    }


    private string path;


    public void StartUpXML(string Basefolder , bool InApp)
    {
        if (InApp)
        {
            path = Application.dataPath + "/" + Basefolder;
        }else{
            path = Basefolder + "\\";
        }
    }



    public void WriteXMLFile(string filename, FileMode XMLMode, CXMLFormat format)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(CXMLFormat));
        FileStream streem = new FileStream(path + "/" + filename + ".xml", XMLMode);
        serializer.Serialize(streem, format);
        streem.Close();
    }
    public void WriteXMLFilepath(string filepath, FileMode XMLMode, CXMLFormat format)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(CXMLFormat));
        FileStream streem = new FileStream(filepath, XMLMode);
        serializer.Serialize(streem, format);
        streem.Close();
    }



    
    public CXMLFormat ReadXMlFile(string filename, FileMode XMLMode)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(CXMLFormat));
        FileStream streem = new FileStream(path + "/" + filename + ".xml", XMLMode);
        CXMLFormat newfile = serializer.Deserialize(streem) as CXMLFormat;
        streem.Close();
        return newfile;
    }
    public CXMLFormat ReadXMlFilepath(string filepath, FileMode XMLMode)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(CXMLFormat));
        FileStream streem = new FileStream(filepath, XMLMode);
        CXMLFormat newfile = serializer.Deserialize(streem) as CXMLFormat;
        streem.Close();
        return newfile;
    }




    public bool ExistsXMLFile(string filename)
    {
        if (File.Exists(path + filename + ".xml"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool ExistsXMLFilepath(string filepath)
    {
        if (File.Exists(filepath + ".xml"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }




    


















}
