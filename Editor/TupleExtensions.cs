using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TupleExtensions
{
    #region Add
    #region Piecewise
    public static void Add(this ref (int, int, int, int, int, int, int) value, (int, int, int, int, int, int, int) add)
    {
        value = (value.Item1 + add.Item1, value.Item2 + add.Item2, value.Item3 + add.Item3, value.Item4 + add.Item4, value.Item5 + add.Item5, value.Item6 + add.Item6, value.Item7 + add.Item7);
    }
    public static void Add(this ref (int, int, int, int, int, int) value, (int, int, int, int, int, int) add)
    {
        value = (value.Item1 + add.Item1, value.Item2 + add.Item2, value.Item3 + add.Item3, value.Item4 + add.Item4, value.Item5 + add.Item5, value.Item6 + add.Item6);
    }
    public static void Add(this ref (int, int, int, int, int) value, (int, int, int, int, int) add)
    {
        value = (value.Item1 + add.Item1, value.Item2 + add.Item2, value.Item3 + add.Item3, value.Item4 + add.Item4, value.Item5 + add.Item5);
    }
    public static void Add(this ref (int, int, int, int) value, (int, int, int, int) add)
    {
        value = (value.Item1 + add.Item1, value.Item2 + add.Item2, value.Item3 + add.Item3, value.Item4 + add.Item4);
    }
    public static void Add(this ref (int, int, int) value, (int, int, int) add)
    {
        value = (value.Item1 + add.Item1, value.Item2 + add.Item2, value.Item3 + add.Item3);
    }
    public static void Add(this ref (int, int) value, (int, int) add)
    {
        value = (value.Item1 + add.Item1, value.Item2 + add.Item2);
    }
    public static void Add(this ref (float, float, float, float, float, float, float) value, (float, float, float, float, float, float, float) add)
    {
        value = (value.Item1 + add.Item1, value.Item2 + add.Item2, value.Item3 + add.Item3, value.Item4 + add.Item4, value.Item5 + add.Item5, value.Item6 + add.Item6, value.Item7 + add.Item7);
    }
    public static void Add(this ref (float, float, float, float, float, float) value, (float, float, float, float, float, float) add)
    {
        value = (value.Item1 + add.Item1, value.Item2 + add.Item2, value.Item3 + add.Item3, value.Item4 + add.Item4, value.Item5 + add.Item5, value.Item6 + add.Item6);
    }
    public static void Add(this ref (float, float, float, float, float) value, (float, float, float, float, float) add)
    {
        value = (value.Item1 + add.Item1, value.Item2 + add.Item2, value.Item3 + add.Item3, value.Item4 + add.Item4, value.Item5 + add.Item5);
    }
    public static void Add(this ref (float, float, float, float) value, (float, float, float, float) add)
    {
        value = (value.Item1 + add.Item1, value.Item2 + add.Item2, value.Item3 + add.Item3, value.Item4 + add.Item4);
    }
    public static void Add(this ref (float, float, float) value, (float, float, float) add)
    {
        value = (value.Item1 + add.Item1, value.Item2 + add.Item2, value.Item3 + add.Item3);
    }
    public static void Add(this ref (float, float) value, (float, float) add)
    {
        value = (value.Item1 + add.Item1, value.Item2 + add.Item2);
    }
    #endregion
    #region Scalar
    public static void Add(this ref (float, float, float, float, float, float, float) value, float add)
    {
        value = (value.Item1 + add, value.Item2 + add, value.Item3 + add, value.Item4 + add, value.Item5 + add, value.Item6 + add, value.Item7 + add);
    }
    public static void Add(this ref (float, float, float, float, float, float) value, float add)
    {
        value = (value.Item1 + add, value.Item2 + add, value.Item3 + add, value.Item4 + add, value.Item5 + add, value.Item6 + add);
    }
    public static void Add(this ref (float, float, float, float, float) value, float add)
    {
        value = (value.Item1 + add, value.Item2 + add, value.Item3 + add, value.Item4 + add, value.Item5 + add);
    }
    public static void Add(this ref (float, float, float, float) value, float add)
    {
        value = (value.Item1 + add, value.Item2 + add, value.Item3 + add, value.Item4 + add);
    }
    public static void Add(this ref (float, float, float) value, float add)
    {
        value = (value.Item1 + add, value.Item2 + add, value.Item3 + add);
    }
    public static void Add(this ref (float, float) value, float add)
    {
        value = (value.Item1 + add, value.Item2 + add);
    }
    public static void Add(this ref (float, float, float, float, float, float, float) value, int add)
    {
        value = (value.Item1 + add, value.Item2 + add, value.Item3 + add, value.Item4 + add, value.Item5 + add, value.Item6 + add, value.Item7 + add);
    }
    public static void Add(this ref (float, float, float, float, float, float) value, int add)
    {
        value = (value.Item1 + add, value.Item2 + add, value.Item3 + add, value.Item4 + add, value.Item5 + add, value.Item6 + add);
    }
    public static void Add(this ref (float, float, float, float, float) value, int add)
    {
        value = (value.Item1 + add, value.Item2 + add, value.Item3 + add, value.Item4 + add, value.Item5 + add);
    }
    public static void Add(this ref (float, float, float, float) value, int add)
    {
        value = (value.Item1 + add, value.Item2 + add, value.Item3 + add, value.Item4 + add);
    }
    public static void Add(this ref (float, float, float) value, int add)
    {
        value = (value.Item1 + add, value.Item2 + add, value.Item3 + add);
    }
    public static void Add(this ref (float, float) value, int add)
    {
        value = (value.Item1 + add, value.Item2 + add);
    }
    public static void Add(this ref (int, int, int, int, int, int, int) value, int add)
    {
        value = (value.Item1 + add, value.Item2 + add, value.Item3 + add, value.Item4 + add, value.Item5 + add, value.Item6 + add, value.Item7 + add);
    }
    public static void Add(this ref (int, int, int, int, int, int) value, int add)
    {
        value = (value.Item1 + add, value.Item2 + add, value.Item3 + add, value.Item4 + add, value.Item5 + add, value.Item6 + add);
    }
    public static void Add(this ref (int, int, int, int, int) value, int add)
    {
        value = (value.Item1 + add, value.Item2 + add, value.Item3 + add, value.Item4 + add, value.Item5 + add);
    }
    public static void Add(this ref (int, int, int, int) value, int add)
    {
        value = (value.Item1 + add, value.Item2 + add, value.Item3 + add, value.Item4 + add);
    }
    public static void Add(this ref (int, int, int) value, int add)
    {
        value = (value.Item1 + add, value.Item2 + add, value.Item3 + add);
    }
    public static void Add(this ref (int, int) value, int add)
    {
        value = (value.Item1 + add, value.Item2 + add);
    }
    #endregion
    #endregion

    #region Subtract
    public static void Subtract(this ref (int, int, int, int, int, int, int) value, (int, int, int, int, int, int, int) sub)
    {
        value = (value.Item1 - sub.Item1, value.Item2 - sub.Item2, value.Item3 - sub.Item3, value.Item4 - sub.Item4, value.Item5 - sub.Item5, value.Item6 - sub.Item6, value.Item7 - sub.Item7);
    }
    public static void Subtract(this ref (int, int, int, int, int, int) value, (int, int, int, int, int, int) sub)
    {
        value = (value.Item1 - sub.Item1, value.Item2 - sub.Item2, value.Item3 - sub.Item3, value.Item4 - sub.Item4, value.Item5 - sub.Item5, value.Item6 - sub.Item6);
    }
    public static void Subtract(this ref (int, int, int, int, int) value, (int, int, int, int, int) sub)
    {
        value = (value.Item1 - sub.Item1, value.Item2 - sub.Item2, value.Item3 - sub.Item3, value.Item4 - sub.Item4, value.Item5 - sub.Item5);
    }
    public static void Subtract(this ref (int, int, int, int) value, (int, int, int, int) sub)
    {
        value = (value.Item1 - sub.Item1, value.Item2 - sub.Item2, value.Item3 - sub.Item3, value.Item4 - sub.Item4);
    }
    public static void Subtract(this ref (int, int, int) value, (int, int, int) sub)
    {
        value = (value.Item1 - sub.Item1, value.Item2 - sub.Item2, value.Item3 - sub.Item3);
    }
    public static void Subtract(this ref (int, int) value, (int, int) sub)
    {
        value = (value.Item1 - sub.Item1, value.Item2 - sub.Item2);
    }
    public static void Subtract(this ref (float, float, float, float, float, float, float) value, (float, float, float, float, float, float, float) sub)
    {
        value = (value.Item1 - sub.Item1, value.Item2 - sub.Item2, value.Item3 - sub.Item3, value.Item4 - sub.Item4, value.Item5 - sub.Item5, value.Item6 - sub.Item6, value.Item7 - sub.Item7);
    }
    public static void Subtract(this ref (float, float, float, float, float, float) value, (float, float, float, float, float, float) sub)
    {
        value = (value.Item1 - sub.Item1, value.Item2 - sub.Item2, value.Item3 - sub.Item3, value.Item4 - sub.Item4, value.Item5 - sub.Item5, value.Item6 - sub.Item6);
    }
    public static void Subtract(this ref (float, float, float, float, float) value, (float, float, float, float, float) sub)
    {
        value = (value.Item1 - sub.Item1, value.Item2 - sub.Item2, value.Item3 - sub.Item3, value.Item4 - sub.Item4, value.Item5 - sub.Item5);
    }
    public static void Subtract(this ref (float, float, float, float) value, (float, float, float, float) sub)
    {
        value = (value.Item1 - sub.Item1, value.Item2 - sub.Item2, value.Item3 - sub.Item3, value.Item4 - sub.Item4);
    }
    public static void Subtract(this ref (float, float, float) value, (float, float, float) sub)
    {
        value = (value.Item1 - sub.Item1, value.Item2 - sub.Item2, value.Item3 - sub.Item3);
    }
    public static void Subtract(this ref (float, float) value, (float, float) sub)
    {
        value = (value.Item1 - sub.Item1, value.Item2 - sub.Item2);
    }
    #endregion

    #region Multiply
    #region Piecewise
    public static void Multiply(this ref (int, int, int, int, int, int, int) value, (int, int, int, int, int, int, int) mult)
    {
        value = (value.Item1 * mult.Item1, value.Item2 * mult.Item2, value.Item3 * mult.Item3, value.Item4 * mult.Item4, value.Item5 * mult.Item5, value.Item6 * mult.Item6, value.Item7 * mult.Item7);
    }
    public static void Multiply(this ref (int, int, int, int, int, int) value, (int, int, int, int, int, int) mult)
    {
        value = (value.Item1 * mult.Item1, value.Item2 * mult.Item2, value.Item3 * mult.Item3, value.Item4 * mult.Item4, value.Item5 * mult.Item5, value.Item6 * mult.Item6);
    }
    public static void Multiply(this ref (int, int, int, int, int) value, (int, int, int, int, int) mult)
    {
        value = (value.Item1 * mult.Item1, value.Item2 * mult.Item2, value.Item3 * mult.Item3, value.Item4 * mult.Item4, value.Item5 * mult.Item5);
    }
    public static void Multiply(this ref (int, int, int, int) value, (int, int, int, int) mult)
    {
        value = (value.Item1 * mult.Item1, value.Item2 * mult.Item2, value.Item3 * mult.Item3, value.Item4 * mult.Item4);
    }
    public static void Multiply(this ref (int, int, int) value, (int, int, int) mult)
    {
        value = (value.Item1 * mult.Item1, value.Item2 * mult.Item2, value.Item3 * mult.Item3);
    }
    public static void Multiply(this ref (int, int) value, (int, int) mult)
    {
        value = (value.Item1 * mult.Item1, value.Item2 * mult.Item2);
    }
    public static void Multiply(this ref (float, float, float, float, float, float, float) value, (float, float, float, float, float, float, float) mult)
    {
        value = (value.Item1 * mult.Item1, value.Item2 * mult.Item2, value.Item3 * mult.Item3, value.Item4 * mult.Item4, value.Item5 * mult.Item5, value.Item6 * mult.Item6, value.Item7 * mult.Item7);
    }
    public static void Multiply(this ref (float, float, float, float, float, float) value, (float, float, float, float, float, float) mult)
    {
        value = (value.Item1 * mult.Item1, value.Item2 * mult.Item2, value.Item3 * mult.Item3, value.Item4 * mult.Item4, value.Item5 * mult.Item5, value.Item6 * mult.Item6);
    }
    public static void Multiply(this ref (float, float, float, float, float) value, (float, float, float, float, float) mult)
    {
        value = (value.Item1 * mult.Item1, value.Item2 * mult.Item2, value.Item3 * mult.Item3, value.Item4 * mult.Item4, value.Item5 * mult.Item5);
    }
    public static void Multiply(this ref (float, float, float, float) value, (float, float, float, float) mult)
    {
        value = (value.Item1 * mult.Item1, value.Item2 * mult.Item2, value.Item3 * mult.Item3, value.Item4 * mult.Item4);
    }
    public static void Multiply(this ref (float, float, float) value, (float, float, float) mult)
    {
        value = (value.Item1 * mult.Item1, value.Item2 * mult.Item2, value.Item3 * mult.Item3);
    }
    public static void Multiply(this ref (float, float) value, (float, float) mult)
    {
        value = (value.Item1 * mult.Item1, value.Item2 * mult.Item2);
    }
    #endregion
    #region Scalar

    public static void Multiply(this ref (float, float, float, float, float, float, float) value, float mult)
    {
        value = (value.Item1 * mult, value.Item2 * mult, value.Item3 * mult, value.Item4 * mult, value.Item5 * mult, value.Item6 * mult, value.Item7 * mult);
    }
    public static void Multiply(this ref (float, float, float, float, float, float) value, float mult)
    {
        value = (value.Item1 * mult, value.Item2 * mult, value.Item3 * mult, value.Item4 * mult, value.Item5 * mult, value.Item6 * mult);
    }
    public static void Multiply(this ref (float, float, float, float, float) value, float mult)
    {
        value = (value.Item1 * mult, value.Item2 * mult, value.Item3 * mult, value.Item4 * mult, value.Item5 * mult);
    }
    public static void Multiply(this ref (float, float, float, float) value, float mult)
    {
        value = (value.Item1 * mult, value.Item2 * mult, value.Item3 * mult, value.Item4 * mult);
    }
    public static void Multiply(this ref (float, float, float) value, float mult)
    {
        value = (value.Item1 * mult, value.Item2 * mult, value.Item3 * mult);
    }
    public static void Multiply(this ref (float, float) value, float mult)
    {
        value = (value.Item1 * mult, value.Item2 * mult);
    }
    public static void Multiply(this ref (float, float, float, float, float, float, float) value, int mult)
    {
        value = (value.Item1 * mult, value.Item2 * mult, value.Item3 * mult, value.Item4 * mult, value.Item5 * mult, value.Item6 * mult, value.Item7 * mult);
    }
    public static void Multiply(this ref (float, float, float, float, float, float) value, int mult)
    {
        value = (value.Item1 * mult, value.Item2 * mult, value.Item3 * mult, value.Item4 * mult, value.Item5 * mult, value.Item6 * mult);
    }
    public static void Multiply(this ref (float, float, float, float, float) value, int mult)
    {
        value = (value.Item1 * mult, value.Item2 * mult, value.Item3 * mult, value.Item4 * mult, value.Item5 * mult);
    }
    public static void Multiply(this ref (float, float, float, float) value, int mult)
    {
        value = (value.Item1 * mult, value.Item2 * mult, value.Item3 * mult, value.Item4 * mult);
    }
    public static void Multiply(this ref (float, float, float) value, int mult)
    {
        value = (value.Item1 * mult, value.Item2 * mult, value.Item3 * mult);
    }
    public static void Multiply(this ref (float, float) value, int mult)
    {
        value = (value.Item1 * mult, value.Item2 * mult);
    }
    public static void Multiply(this ref (int, int, int, int, int, int, int) value, int mult)
    {
        value = (value.Item1 * mult, value.Item2 * mult, value.Item3 * mult, value.Item4 * mult, value.Item5 * mult, value.Item6 * mult, value.Item7 * mult);
    }
    public static void Multiply(this ref (int, int, int, int, int, int) value, int mult)
    {
        value = (value.Item1 * mult, value.Item2 * mult, value.Item3 * mult, value.Item4 * mult, value.Item5 * mult, value.Item6 * mult);
    }
    public static void Multiply(this ref (int, int, int, int, int) value, int mult)
    {
        value = (value.Item1 * mult, value.Item2 * mult, value.Item3 * mult, value.Item4 * mult, value.Item5 * mult);
    }
    public static void Multiply(this ref (int, int, int, int) value, int mult)
    {
        value = (value.Item1 * mult, value.Item2 * mult, value.Item3 * mult, value.Item4 * mult);
    }
    public static void Multiply(this ref (int, int, int) value, int mult)
    {
        value = (value.Item1 * mult, value.Item2 * mult, value.Item3 * mult);
    }
    public static void Multiply(this ref (int, int) value, int mult)
    {
        value = (value.Item1 * mult, value.Item2 * mult);
    }
    #endregion
    #endregion

    #region Divide
    public static void Divide(this ref (int, int, int, int, int, int, int) value, (int, int, int, int, int, int, int) div)
    {
        value = (value.Item1 / div.Item1, value.Item2 / div.Item2, value.Item3 / div.Item3, value.Item4 / div.Item4, value.Item5 / div.Item5, value.Item6 / div.Item6, value.Item7 / div.Item7);
    }
    public static void Divide(this ref (int, int, int, int, int, int) value, (int, int, int, int, int, int) div)
    {
        value = (value.Item1 / div.Item1, value.Item2 / div.Item2, value.Item3 / div.Item3, value.Item4 / div.Item4, value.Item5 / div.Item5, value.Item6 / div.Item6);
    }
    public static void Divide(this ref (int, int, int, int, int) value, (int, int, int, int, int) div)
    {
        value = (value.Item1 / div.Item1, value.Item2 / div.Item2, value.Item3 / div.Item3, value.Item4 / div.Item4, value.Item5 / div.Item5);
    }
    public static void Divide(this ref (int, int, int, int) value, (int, int, int, int) div)
    {
        value = (value.Item1 / div.Item1, value.Item2 / div.Item2, value.Item3 / div.Item3, value.Item4 / div.Item4);
    }
    public static void Divide(this ref (int, int, int) value, (int, int, int) div)
    {
        value = (value.Item1 / div.Item1, value.Item2 / div.Item2, value.Item3 / div.Item3);
    }
    public static void Divide(this ref (int, int) value, (int, int) div)
    {
        value = (value.Item1 / div.Item1, value.Item2 / div.Item2);
    }
    public static void Divide(this ref (float, float, float, float, float, float, float) value, (float, float, float, float, float, float, float) div)
    {
        value = (value.Item1 / div.Item1, value.Item2 / div.Item2, value.Item3 / div.Item3, value.Item4 / div.Item4, value.Item5 / div.Item5, value.Item6 / div.Item6, value.Item7 / div.Item7);
    }
    public static void Divide(this ref (float, float, float, float, float, float) value, (float, float, float, float, float, float) div)
    {
        value = (value.Item1 / div.Item1, value.Item2 / div.Item2, value.Item3 / div.Item3, value.Item4 / div.Item4, value.Item5 / div.Item5, value.Item6 / div.Item6);
    }
    public static void Divide(this ref (float, float, float, float, float) value, (float, float, float, float, float) div)
    {
        value = (value.Item1 / div.Item1, value.Item2 / div.Item2, value.Item3 / div.Item3, value.Item4 / div.Item4, value.Item5 / div.Item5);
    }
    public static void Divide(this ref (float, float, float, float) value, (float, float, float, float) div)
    {
        value = (value.Item1 / div.Item1, value.Item2 / div.Item2, value.Item3 / div.Item3, value.Item4 / div.Item4);
    }
    public static void Divide(this ref (float, float, float) value, (float, float, float) div)
    {
        value = (value.Item1 / div.Item1, value.Item2 / div.Item2, value.Item3 / div.Item3);
    }
    public static void Divide(this ref (float, float) value, (float, float) div)
    {
        value = (value.Item1 / div.Item1, value.Item2 / div.Item2);
    }
    #endregion

    #region ToCollections
    #region List
    public static List<T> ToList<T>(this (T, T, T, T, T, T, T) value)
    {
        return new List<T>() { value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7 };
    }
    public static List<T> ToList<T>(this (T, T, T, T, T, T) value)
    {
        return new List<T>() { value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6 };
    }
    public static List<T> ToList<T>(this (T, T, T, T, T) value)
    {
        return new List<T>() { value.Item1, value.Item2, value.Item3, value.Item4, value.Item5 };
    }
    public static List<T> ToList<T>(this (T, T, T, T) value)
    {
        return new List<T>() { value.Item1, value.Item2, value.Item3, value.Item4 };
    }
    public static List<T> ToList<T>(this (T, T, T) value)
    {
        return new List<T>() { value.Item1, value.Item2, value.Item3 };
    }
    public static List<T> ToList<T>(this (T, T) value)
    {
        return new List<T>() { value.Item1, value.Item2 };
    }
    public static List<object> ToObjectList<T1, T2, T3, T4, T5, T6, T7>(this (T1, T2, T3, T4, T5, T6, T7) value)
    {
        return new List<object>() { value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7 };
    }
    public static List<object> ToObjectList<T1, T2, T3, T4, T5, T6, T7>(this (T1, T2, T3, T4, T5, T6) value)
    {
        return new List<object>() { value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, };
    }
    public static List<object> ToObjectList<T1, T2, T3, T4, T5, T6, T7>(this (T1, T2, T3, T4, T5) value)
    {
        return new List<object>() { value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, };
    }
    public static List<object> ToObjectList<T1, T2, T3, T4, T5, T6, T7>(this (T1, T2, T3, T4) value)
    {
        return new List<object>() { value.Item1, value.Item2, value.Item3, value.Item4 };
    }
    public static List<object> ToObjectList<T1, T2, T3, T4, T5, T6, T7>(this (T1, T2, T3) value)
    {
        return new List<object>() { value.Item1, value.Item2, value.Item3 };
    }
    public static List<object> ToObjectList<T1, T2, T3, T4, T5, T6, T7>(this (T1, T2) value)
    {
        return new List<object>() { value.Item1, value.Item2 };
    }
    #endregion
    #region Array
    public static T[] ToArray<T>(this (T, T, T, T, T, T, T) value)
    {
        return new T[] { value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7 };
    }
    public static T[] ToArray<T>(this (T, T, T, T, T, T) value)
    {
        return new T[] { value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6 };
    }
    public static T[] ToArray<T>(this (T, T, T, T, T) value)
    {
        return new T[] { value.Item1, value.Item2, value.Item3, value.Item4, value.Item5 };
    }
    public static T[] ToArray<T>(this (T, T, T, T) value)
    {
        return new T[] { value.Item1, value.Item2, value.Item3, value.Item4 };
    }
    public static T[] ToArray<T>(this (T, T, T) value)
    {
        return new T[] { value.Item1, value.Item2, value.Item3 };
    }
    public static T[] ToArray<T>(this (T, T) value)
    {
        return new T[] { value.Item1, value.Item2 };
    }
    public static object[] ToObjectArray<T1, T2, T3, T4, T5, T6, T7>(this (T1, T2, T3, T4, T5, T6, T7) value)
    {
        return new object[] { value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7 };
    }
    public static object[] ToObjectArray<T1, T2, T3, T4, T5, T6>(this (T1, T2, T3, T4, T5, T6) value)
    {
        return new object[] { value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6 };
    }
    public static object[] ToObjectArray<T1, T2, T3, T4, T5>(this (T1, T2, T3, T4, T5) value)
    {
        return new object[] { value.Item1, value.Item2, value.Item3, value.Item4, value.Item5 };
    }
    public static object[] ToObjectArray<T1, T2, T3, T4>(this (T1, T2, T3, T4) value)
    {
        return new object[] { value.Item1, value.Item2, value.Item3, value.Item4 };
    }
    public static object[] ToObjectArray<T1, T2, T3>(this (T1, T2, T3) value)
    {
        return new object[] { value.Item1, value.Item2, value.Item3 };
    }
    public static object[] ToObjectArray<T1, T2>(this (T1, T2) value)
    {
        return new object[] { value.Item1, value.Item2 };
    }
    #endregion
    #endregion

    #region ToValue
    #region Count
    public static int Count<T1, T2, T3, T4, T5, T6, T7>(this (T1, T2, T3, T4, T5, T6, T7) value)
    {
        return 7;
    }
    public static int Count<T1, T2, T3, T4, T5, T6>(this (T1, T2, T3, T4, T5, T6) value)
    {
        return 6;
    }
    public static int Count<T1, T2, T3, T4, T5>(this (T1, T2, T3, T4, T5) value)
    {
        return 5;
    }
    public static int Count<T1, T2, T3, T4>(this (T1, T2, T3, T4) value)
    {
        return 4;
    }
    public static int Count<T1, T2, T3>(this (T1, T2, T3) value)
    {
        return 3;
    }
    public static int Count<T1, T2>(this (T1, T2) value)
    {
        return 2;
    }
    #endregion
    #region Sum
    public static int Sum(this (int, int, int, int, int, int, int) value)
    {
        return value.Item1 + value.Item2 + value.Item3 + value.Item4 + value.Item5 + value.Item6 + value.Item7;
    }
    public static int Sum(this (int, int, int, int, int, int) value)
    {
        return value.Item1 + value.Item2 + value.Item3 + value.Item4 + value.Item5 + value.Item6;
    }
    public static int Sum(this (int, int, int, int, int) value)
    {
        return value.Item1 + value.Item2 + value.Item3 + value.Item4 + value.Item5;
    }
    public static int Sum(this (int, int, int, int) value)
    {
        return value.Item1 + value.Item2 + value.Item3 + value.Item4;
    }
    public static int Sum(this (int, int, int) value)
    {
        return value.Item1 + value.Item2 + value.Item3;
    }
    public static int Sum(this (int, int) value)
    {
        return value.Item1 + value.Item2;
    }
    #endregion
    #endregion

    #region Loop
    public static void ForEach<T1, T2, T3, T4, T5, T6, T7, G>(this ref (T1, T2, T3, T4, T5, T6, T7) value, System.Action<G> action)
        where T1 : G
        where T2 : G
        where T3 : G
        where T4 : G
        where T5 : G
        where T6 : G
        where T7 : G
    {
        action(value.Item1);
        action(value.Item2);
        action(value.Item3);
        action(value.Item4);
        action(value.Item5);
        action(value.Item6);
        action(value.Item7);
    }
    public static void ForEach<T1, T2, T3, T4, T5, T6, G>(this ref (T1, T2, T3, T4, T5, T6) value, System.Action<G> action)
        where T1 : G
        where T2 : G
        where T3 : G
        where T4 : G
        where T5 : G
        where T6 : G
    {
        action(value.Item1);
        action(value.Item2);
        action(value.Item3);
        action(value.Item4);
        action(value.Item5);
        action(value.Item6);
    }
    public static void ForEach<T1, T2, T3, T4, T5, G>(this ref (T1, T2, T3, T4, T5) value, System.Action<G> action)
        where T1 : G
        where T2 : G
        where T3 : G
        where T4 : G
        where T5 : G
    {
        action(value.Item1);
        action(value.Item2);
        action(value.Item3);
        action(value.Item4);
        action(value.Item5);
    }
    public static void ForEach<T1, T2, T3, T4, G>(this ref (T1, T2, T3, T4) value, System.Action<G> action)
        where T1 : G
        where T2 : G
        where T3 : G
        where T4 : G
    {
        action(value.Item1);
        action(value.Item2);
        action(value.Item3);
        action(value.Item4);
    }
    public static void ForEach<T1, T2, T3, G>(this ref (T1, T2, T3) value, System.Action<G> action)
        where T1 : G
        where T2 : G
        where T3 : G
    {
        action(value.Item1);
        action(value.Item2);
        action(value.Item3);
    }
    public static void ForEach<T1, T2, G>(this ref (T1, T2) value, System.Action<G> action)
        where T1 : G
        where T2 : G
    {
        action(value.Item1);
        action(value.Item2);
    }
    #endregion

    #region Clear
    public static void Clear<T1, T2, T3, T4, T5, T6, T7>(this ref (T1, T2, T3, T4, T5, T6, T7) value)
        where T1 : new()
        where T2 : new()
        where T3 : new()
        where T4 : new()
        where T5 : new()
        where T6 : new()
        where T7 : new()
    {
        value = (new T1(), new T2(), new T3(), new T4(), new T5(), new T6(), new T7());
    }
    public static void Clear<T1, T2, T3, T4, T5, T6>(this ref (T1, T2, T3, T4, T5, T6) value)
        where T1 : new()
        where T2 : new()
        where T3 : new()
        where T4 : new()
        where T5 : new()
        where T6 : new()
    {
        value = (new T1(), new T2(), new T3(), new T4(), new T5(), new T6());
    }
    public static void Clear<T1, T2, T3, T4, T5>(this ref (T1, T2, T3, T4, T5) value)
        where T1 : new()
        where T2 : new()
        where T3 : new()
        where T4 : new()
        where T5 : new()
    {
        value = (new T1(), new T2(), new T3(), new T4(), new T5());
    }
    public static void Clear<T1, T2, T3, T4>(this ref (T1, T2, T3, T4) value)
        where T1 : new()
        where T2 : new()
        where T3 : new()
        where T4 : new()
    {
        value = (new T1(), new T2(), new T3(), new T4());
    }
    public static void Clear<T1, T2, T3>(this ref (T1, T2, T3) value)
        where T1 : new()
        where T2 : new()
        where T3 : new()
    {
        value = (new T1(), new T2(), new T3());
    }
    public static void Clear<T1, T2>(this ref (T1, T2) value)
        where T1 : new()
        where T2 : new()
    {
        value = (new T1(), new T2());
    }
    #endregion
}
