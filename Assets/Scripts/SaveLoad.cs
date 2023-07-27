
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Unity.VisualScripting;
using UnityEngine;

public static class SaveLoad
{
    public static void Save()
    {
       BinaryFormatter bf = new BinaryFormatter();
        FileStream fileStream = File.Create(Application.persistentDataPath + "/save.prikol");
        bf.Serialize();
       fileStream.Close();
    }

    public static void Load()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream fileStream = File.Open(Application.persistentDataPath + "/save.prikol",FileMode.Open);
        bf.Deserialize(fileStream);
        fileStream.Close();
    }
}
