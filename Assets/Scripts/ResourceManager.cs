using UnityEngine;

public class ResourceManager 
{
   public void Init(){}

   public T Load<T>(string path) where T : Object
   {
      if (typeof(T) == typeof(GameObject))
      {
         string name = path;
         int index = name.LastIndexOf('/');
         
         if(index >= 0)
            name = name.Substring(index + 1);
      }
      
      return Resources.Load<T>(path);
   }
}
