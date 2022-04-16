using System.Text;
using UnityEngine;

public static class StringExtension
{
    public static char GetRandomChar(this string list)
    {
        return list[Random.Range(0, list.Length)];
    }
    public static string GetRandomLetter(this string list)
    {
        return list[Random.Range(0, list.Length)].ToString();
    }
    public static string Reverse(this string s)
    {
        StringBuilder sb = new StringBuilder(s.Length);
        for (int i = s.Length - 1; i >= 0; i--)
        {
            sb.Append(s[i]);
        }
        return sb.ToString();
    }
}