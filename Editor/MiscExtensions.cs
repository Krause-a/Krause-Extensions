using System;
using UnityEngine;
using UnityEngine.UI;

public static class MiscExtensions
{
    public static bool OrFalse(this bool b, float percentage)
    {
        float attempt = UnityEngine.Random.Range(0, 1f);
        return attempt < percentage ? false : b;
    }
    public static bool OrTrue(this bool b, float percentage)
    {
        float attempt = UnityEngine.Random.Range(0, 1f);
        return attempt < percentage ? true : b;
    }
    public static string EnumName<TEnum>(this TEnum arg) where TEnum : Enum
    {
        return Enum.GetName(arg.GetType(), arg);
    }
    public static void SetAlpha(this Image image, float alpha)
    {
        Color c = image.color;
        c.a = alpha;
        image.color = c;
    }
    public static void SetAlpha(this SpriteRenderer sr, float alpha)
    {
        Color c = sr.color;
        c.a = alpha;
        sr.color = c;
    }
}
