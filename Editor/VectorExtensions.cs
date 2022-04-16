using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class VectorExtensions
{
    /// <summary>
    /// If mapping values to the same spot, the latter values will take priority. Any map value outside of 0,1 will discard that value.
    /// </summary>
    /// <param name="mapX">(0,1)=>(x,y)</param>
    /// <param name="mapY">(0,1)=>(x,y)</param>
    /// <param name="mapZ">(0,1)=>(x,y)</param>
    /// <returns>Returns a Vector3 with x value mapped to mapX and y value mapped to mapY</returns>
    public static Vector2 ToVector2(this Vector3 v, byte mapX = 0, byte mapY = 1, byte mapZ = 2)
    {
        Vector2 res = new Vector2();
        switch (mapX)
        {
            case 0:
                res.x = v.x;
                break;
            case 1:
                res.y = v.x;
                break;
        }
        switch (mapY)
        {
            case 0:
                res.x = v.y;
                break;
            case 1:
                res.y = v.y;
                break;
        }
        switch (mapZ)
        {
            case 0:
                res.x = v.z;
                break;
            case 1:
                res.y = v.z;
                break;
        }
        return res;
    }
    /// <summary>
    /// If mapping values to the same spot, the latter values will take priority. Any map value outside of 0,1,2 will discard that value.
    /// </summary>
    /// <param name="mapX">(0,1,2)=>(x,y,z)</param>
    /// <param name="mapY">(0,1,2)=>(x,y,z)</param>
    /// <returns>Returns a Vector3 with x value mapped to mapX and y value mapped to mapY</returns>
    public static Vector3 ToVector3(this Vector2 v, byte mapX = 0, byte mapY = 1)
    {
        Vector3 res = new Vector3();
        switch (mapX)
        {
            case 0:
                res.x = v.x;
                break;
            case 1:
                res.y = v.x;
                break;
            case 2:
                res.z = v.x;
                break;
        }
        switch (mapY)
        {
            case 0:
                res.x = v.y;
                break;
            case 1:
                res.y = v.y;
                break;
            case 2:
                res.z = v.y;
                break;
        }
        return res;
    }

    public static Vector3 SetValues(this Vector3 v, float? x = null, float? y = null, float? z = null)
    {
        return new Vector3(x ?? v.x, y ?? v.y, z ?? v.z);
    }
    public static Vector2 SetValues(this Vector2 v, float? x = null, float? y = null)
    {
        return new Vector2(x ?? v.x, y ?? v.y);
    }
    /// <summary>
    /// Rotation for 2D to keep sprites flat.
    /// </summary>
    /// <param name="angle">In degrees</param>
    /// <returns>Vector2 rotated angle degrees.</returns>
    public static Vector2 Rotate(this Vector2 v, float angle)
    {
        return Quaternion.AngleAxis(angle, Vector3.forward) * v;
    }
}
