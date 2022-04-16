using UnityEngine;

public static class NumericExtensions
{
    public static float DegreesToRadians(this float value)
    {
        return Mathf.PI * value/ 180;
    }
    public static float RadiansToDegrees(this float value)
    {
        return value * 180 / Mathf.PI;
    }
    /// <summary>
    /// Use for when a lower boundary cannot be crossed.
    /// </summary>
    /// <param name="equalOrAbove"></param>
    /// <returns></returns>
    public static float Above(this float value, float equalOrAbove)
    {
        return Mathf.Max(value, equalOrAbove);
    }
    /// <summary>
    /// Use for when a lower boundary cannot be crossed.
    /// </summary>
    /// <param name="equalOrAbove"></param>
    /// <returns></returns>
    public static int Above(this int value, int equalOrAbove)
    {
        return Mathf.Max(value, equalOrAbove);
    }
    /// <summary>
    /// Use for when a upper boundary cannot be crossed.
    /// </summary>
    /// <param name="equalOrBellow"></param>
    /// <returns></returns>
    public static float Bellow(this float value, float equalOrBellow)
    {
        return Mathf.Min(value, equalOrBellow);
    }
    /// <summary>
    /// Use for when a upper boundary cannot be crossed.
    /// </summary>
    /// <param name="equalOrBellow"></param>
    /// <returns></returns>
    public static int Bellow(this int value, int equalOrBellow)
    {
        return Mathf.Min(value, equalOrBellow);
    }
    /// <summary>
    /// Use for when a bounded value is required.
    /// </summary>
    /// <returns>Number = (inclusiveBottom <= value <= inclusiveTop)</returns>
    public static int Within(this int value, int inclusiveBottom, int inclusiveTop)
    {
        return value.Above(inclusiveBottom).Bellow(inclusiveTop);
    }

    /// <summary>
    /// Use for when a bounded value is required.
    /// </summary>
    /// <returns>Number = (inclusiveBottom <= value <= inclusiveTop)</returns>
    public static float Within(this float value, float inclusiveBottom, float inclusiveTop)
    {
        return value.Above(inclusiveBottom).Bellow(inclusiveTop);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns>True if (inclusiveBottom <= value <= inclusiveTop)</returns>
    public static bool IsWithin(this int value, int inclusiveBottom, int inclusiveTop)
    {
        return value >= inclusiveBottom && value <= inclusiveTop;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <returns>True if (inclusiveBottom <= value <= inclusiveTop)</returns>
    public static bool IsWithin(this float value, float inclusiveBottom, float inclusiveTop)
    {
        return value >= inclusiveBottom && value <= inclusiveTop;
    }
    /// <summary>
    /// Example 3.14159.Truncate(2) returns 3.14.
    /// Example 12345.6789.Truncate(-2) returns 12300
    /// </summary>
    /// <param name="decimalPlaces">Number of decimal places desired. (negative values work)</param>
    /// <returns></returns>
    public static float Truncate(this float value, int decimalPlaces)
    {
        return Mathf.Floor(value * Mathf.Pow(10, decimalPlaces)) / Mathf.Pow(10, decimalPlaces);
    }
}
