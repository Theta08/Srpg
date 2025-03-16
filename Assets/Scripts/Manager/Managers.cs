using UnityEngine;

public class Managers : MonoBehaviour
{
    public static Managers s_instance;
    public static Managers Instance { get { Init();  return s_instance; } }
    
    private DataManager _data = new DataManager();
    private ResourceManager _resource = new ResourceManager();
    
    public static DataManager Data { get { Init(); return Instance._data; } }
    public static ResourceManager Resource { get { Init(); return Instance._resource; } }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Init();
    }

    private static void Init()
    {
        if (s_instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if (go == null)
                go = new GameObject { name = "@Managers" };

            DontDestroyOnLoad(go);
            s_instance = Utils.GetOrAddComponent<Managers>(go);
            
            // 다른 매니저 Init
            s_instance._data.Init();
            s_instance._resource.Init();
        
        }
    }
}
