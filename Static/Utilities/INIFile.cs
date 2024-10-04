using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

public class INIFile
{
    public string Path { get; private set; }

    [DllImport("kernel32", CharSet = CharSet.Unicode)]
    private static extern long WritePrivateProfileString(string section, string key, string value, string filePath);

    [DllImport("kernel32", CharSet = CharSet.Unicode)]
    private static extern int GetPrivateProfileString(string section, string key, string defaultValue, StringBuilder retVal, int size, string filePath);

    public INIFile(string path)
    {
        Path = path;
    }

    public void Write(string section, string key, string value)
    {
        WritePrivateProfileString(section, key, value, Path);
    }

    public string Read(string section, string key, string defaultValue = "")
    {
        var retVal = new StringBuilder(255);
        GetPrivateProfileString(section, key, defaultValue, retVal, 255, Path);
        return retVal.ToString();
    }

    public void DeleteKey(string section, string key)
    {
        Write(section, key, null);
    }

    public void DeleteSection(string section)
    {
        Write(section, null, null);
    }

    public bool KeyExists(string section, string key)
    {
        return Read(section, key).Length > 0;
    }
}