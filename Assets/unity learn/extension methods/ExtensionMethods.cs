
using UnityEngine;

// this is a static class
public static class ExtensionMethods
{
    // this is an extension method
    public static void ResetTransform(this Transform transform)
    {
        transform.position = Vector3.zero;
        transform.rotation = Quaternion.identity;
        transform.localScale = Vector3.one;
        
        Debug.Log("Reset Transformation sucessfully!");
    }
}