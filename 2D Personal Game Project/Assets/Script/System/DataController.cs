using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataController : MonoBehaviour
{
    static GameObject container;
    static GameObject Container
    {
        get
        {
            return container;
        }
    }
    static DataController _instance;
    public static DataController instance
    {
        get
        {
            if (!_instance)
            {
                container = new GameObject();
                container.name = "DataController";
                _instance = container.AddComponent(typeof(DataController)) as DataController;
                DontDestroyOnLoad(container);
            }
            return _instance;
        }
    }
    public string GameDataFileName = "ClearData.json";

    public GameData _gameData;
    public GameData gameData
    {
        get
        {
            if(_gameData == null)
            {
                LoadGameData();
                SaveGameData();
            }
            return _gameData;
        }
    }
    public void LoadGameData()
    {
        string filePath = Application.persistentDataPath + GameDataFileName;

        if(File.Exists(filePath))
        {
            Debug.Log("Load Success");
            string FromJsonData = File.ReadAllText(filePath);
            _gameData = JsonUtility.FromJson<GameData>(FromJsonData);
        }
        else
        {
            //새 파일 생성
            _gameData = new GameData();
            Debug.Log("파일생성완료");
        }
    }
    public void SaveGameData()
    {
        string ToJsonData = JsonUtility.ToJson(gameData);
        string filePath = Application.persistentDataPath + GameDataFileName;
        File.WriteAllText(filePath, ToJsonData);
        Debug.Log("Save Success");
    }
    private void Awake()
    {
        LoadGameData();
    }
    private void OnApplicationQuit()
    {
        SaveGameData();
    }

}
