using UnityEngine;

public class HideFlagsTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject[] allObjects = FindObjectsOfType<GameObject>(true);
        
        foreach (GameObject obj in allObjects)
        {
            if (obj.hideFlags != HideFlags.None)
            {
                Debug.Log($"Object: {obj.name}, HideFlags: {obj.hideFlags}");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
