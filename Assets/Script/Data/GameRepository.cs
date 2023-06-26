using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class GameRepository : MonoBehaviour
{
    public void SaveData(GameData data)
    {
        string destination = Application.persistentDataPath + "/save.dat";
        FileStream file;

        if (File.Exists(destination))
            file = File.OpenWrite(destination);
        else
            file = File.Create(destination);

        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(file, data);
        file.Close();
    }

    public GameData GetSavedData()
    {
        Debug.Log("Loading file save.dat");

        string destination = Application.persistentDataPath + "/save.dat";

        if (File.Exists(destination))
        {
            FileStream file = File.OpenRead(destination);
            BinaryFormatter bf = new BinaryFormatter();
            GameData data = (GameData)bf.Deserialize(file);
            file.Close();

            // Verificar si el personaje está muerto
            // Si está muerto, devolver un nuevo objeto GameData con valores predeterminados
            if (data.vidas == 0)
            {
                return new GameData();
            }

            // Si el personaje está vivo, devolver la data guardada
            return data;
        }

        return new GameData();
    }
}
