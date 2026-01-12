using UnityEngine;
using DG.Tweening;
using Random = UnityEngine.Random;
using System.Collections.Generic;

public static class MagicUtil
{
    public static SphereCollider AddTrigger(Transform parent, float radius = 1)
    {
        GameObject _trigger = new GameObject("Trigger", typeof(SphereCollider));
        _trigger.transform.SetParent(parent);
        _trigger.transform.localPosition = Vector3.zero;
        _trigger.transform.localScale = Vector3.one;
        _trigger.layer = LayerMask.NameToLayer("Trigger");
        
        SphereCollider _triggerCollider = _trigger.GetComponent<SphereCollider>();
        _triggerCollider.radius = radius;
        _triggerCollider.isTrigger = true;
        
        return _triggerCollider;
    }

    #region SCALES
    public static void Scale(this Transform t, float size = 1.2f)
    {
        t.localScale = Vector3.one * size;
    }
    #endregion

    #region RANDOMIZE
    public static T GetRandom<T>(this List<T> list)
    {
        return list[Random.Range(0, list.Count)];
    }

    public static T GetRandom<T>(this T[] array)
    {
        if (array.Length == 0) return default(T);
        
        return array[Random.Range(0, array.Length)];
    }
    #endregion
}
