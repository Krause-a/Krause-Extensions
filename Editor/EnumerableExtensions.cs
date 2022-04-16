using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class EnumerableExtensions
{
    /// <summary>
    /// SetActive(false) on all gameObjects in list.
    /// </summary>
    public static void DeactivateAll<T>(this IEnumerable<T> list) where T : Component
    {
        list.TurnAllGameObjects(false);
    }
    /// <summary>
    /// SetActive(true) on all gameObjects in list.
    /// </summary>
    public static void ActivateAll<T>(this IEnumerable<T> list) where T : Component
    {
        list.TurnAllGameObjects(true);
    }
    /// <summary>
    /// SetActive(on) on all gameObjects in list.
    /// </summary>
    /// <param name="list"></param>
    /// <param name="on"></param>
    public static void TurnAllGameObjects<T>(this IEnumerable<T> list, bool on) where T : Component
    {
        foreach (var item in list)
        {
            item.gameObject.SetActive(on);
        }
    }
    public static void Shuffle<T>(this IList<T> list, int shuffles = 1)
    {
        for (int i = 0; i < shuffles; i++)
        {
            int n = list.Count;
            while (n > 1)
            {
                int k = UnityEngine.Random.Range(0, list.Count);
                n--;
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
    public static T GetRandom<T>(this IList<T> list)
    {
        return list[UnityEngine.Random.Range(0, list.Count)];
    }
    public static IList<T> Reverse<T>(this IList<T> arr)
    {
        IList<T> temp = new List<T>(arr.Count);
        for (int index = 0, i = arr.Count - 1; i >= 0; i--, index++)
        {
            temp[index] = arr[i];
        }
        return temp;
    }
    public static bool HasAnyFlag<T>(this T e, params T[] flags) where T : Enum
    {
        foreach (var item in flags)
        {
            if (e.HasFlag(item))
            {
                return true;
            }
        }
        return false;
    }
    public static void SetAllAlpha(this IEnumerable<Image> images, float alpha)
    {
        foreach (var image in images)
        {
            image.SetAlpha(alpha);
        }
    }
    public static void RemoveRange<T>(this List<T> a, IEnumerable<T> removal)
    {
        foreach (var item in removal)
        {
            a.Remove(item);
        }
    }
    public static byte AggBitAnd(this IEnumerable<byte> a)
    {
        byte res = 0;
        foreach (var item in a)
        {
            res &= item;
        }
        return res;
    }
    public static byte AggBitOr(this IEnumerable<byte> a)
    {
        byte res = 0;
        foreach (var item in a)
        {
            res |= item;
        }
        return res;
    }
}
