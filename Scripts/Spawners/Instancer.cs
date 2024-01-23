using Unity.Mathematics;
using UnityEngine;

[CreateAssetMenu]
public class Instancer : ScriptableObject
{
    public GameObject prefab;
    private int num;
    public void CreateInstance()
    {
        Instantiate(prefab);
    }

    public void CreateInstanceFromList(Vector3Data obj)
    {
        Instantiate(prefab, obj.value, Quaternion.identity);
    }

    public void CreateInstance(Vector3DataList obj)
    {
        foreach (var i in obj.vector3DList)
        {
            Instantiate(prefab, i.value, Quaternion.identity);
        }
    }

     public void CreateInstanceFromListCounting(Vector3DataList obj)
    {
       Instantiate(prefab, obj.vector3DList[num].value, Quaternion.identity);
       num++;
       if (num == obj.vector3DList.Count)
       {
            num = 0;
       }  
    }

     public void CreateInstanceListRandomly(Vector3DataList obj)
    {
        num = UnityEngine.Random.Range(0, obj.vector3DList.Count - 1);
        Instantiate(prefab, obj.vector3DList[num].value, Quaternion.identity);
    }
}
