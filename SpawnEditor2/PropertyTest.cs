// Decompiled with JetBrains decompiler
// Type: SpawnEditor2.PropertyTest
// Assembly: SpawnEditor2, Version=1.18.2133.41352, Culture=neutral, PublicKeyToken=null
// MVID: 02C34E83-756B-4927-A841-6F97602C50A7
// Assembly location: Y:\Spawn Editor2 v1.8\SpawnEditor2.exe

using System;
using System.Collections;
using System.Reflection;

namespace SpawnEditor2
{
  public class PropertyTest
  {
    public static ArrayList PropertyInfoList = new ArrayList();
    private static Type typeofTimeSpan = typeof (TimeSpan);
    private static Type[] m_ParseTypes = new Type[1]
    {
      typeof (string)
    };
    private static object[] m_ParseParams = new object[1];
    private static Type[] m_NumericTypes = new Type[8]
    {
      typeof (byte),
      typeof (sbyte),
      typeof (short),
      typeof (ushort),
      typeof (int),
      typeof (uint),
      typeof (long),
      typeof (ulong)
    };
    private static Type typeofType = typeof (Type);
    private static Type typeofChar = typeof (char);
    private static Type typeofString = typeof (string);

    private static bool IsParsable(Type t)
    {
      return t == PropertyTest.typeofTimeSpan;
    }

    private static object Parse(object o, Type t, string value)
    {
      MethodInfo method = t.GetMethod("Parse", PropertyTest.m_ParseTypes);
      PropertyTest.m_ParseParams[0] = (object) value;
      return method.Invoke(o, PropertyTest.m_ParseParams);
    }

    public static bool IsNumeric(Type t)
    {
      return Array.IndexOf((Array) PropertyTest.m_NumericTypes, (object) t) >= 0;
    }

    private static bool IsType(Type t)
    {
      return t == PropertyTest.typeofType;
    }

    private static bool IsChar(Type t)
    {
      return t == PropertyTest.typeofChar;
    }

    private static bool IsString(Type t)
    {
      return t == PropertyTest.typeofString;
    }

    private static bool IsEnum(Type t)
    {
      return t.IsEnum;
    }

    private static string InternalGetValue(object o, PropertyInfo p, int index)
    {
      Type propertyType = p.PropertyType;
      object obj1 = (object) null;
      if (propertyType.IsArray)
      {
        try
        {
          object obj2 = p.GetValue(o, (object[]) null);
          int lowerBound = ((Array) obj2).GetLowerBound(0);
          int upperBound = ((Array) obj2).GetUpperBound(0);
          if (index <= lowerBound)
          {
            if (index <= upperBound)
              obj1 = ((Array) obj2).GetValue(index);
          }
        }
        catch
        {
        }
      }
      else
        obj1 = p.GetValue(o, (object[]) null);
      string str = obj1 != null ? (!PropertyTest.IsNumeric(propertyType) ? (!PropertyTest.IsChar(propertyType) ? (!PropertyTest.IsString(propertyType) ? obj1.ToString() : string.Format("\"{0}\"", obj1)) : string.Format("'{0}' ({1} [0x{1:X}])", obj1, (object) (int) obj1)) : string.Format("{0} (0x{0:X})", obj1)) : "(-null-)";
      return string.Format("{0} = {1}", (object) p.Name, (object) str);
    }

    public static string GetPropertyValue(object o, string name, out Type ptype)
    {
      ptype = (Type) null;
      if (o == null || name == null)
        return (string) null;
      Type type = o.GetType();
      object o1 = (object) null;
      PropertyInfo[] properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
      string[] strArray1 = PropertyTest.ParseString(name, 2, ".");
      string str = strArray1[0];
      PropertyTest.ParseString(str, 4, ",");
      string[] strArray2 = strArray1[0].Split('[');
      int index = 0;
      if (strArray2.Length > 1)
      {
        str = strArray2[0];
        string[] strArray3 = strArray2[1].Split(']');
        if (strArray3.Length > 0)
        {
          try
          {
            index = int.Parse(strArray3[0]);
          }
          catch
          {
          }
        }
      }
      if (strArray1.Length == 2)
      {
        PropertyInfo propertyInfo1 = PropertyTest.LookupPropertyInfo(type, str);
        if (propertyInfo1 != null)
        {
          if (!propertyInfo1.CanWrite)
            return "Property is read only.";
          ptype = propertyInfo1.PropertyType;
          if (ptype.IsArray)
          {
            try
            {
              object obj = propertyInfo1.GetValue(o, (object[]) null);
              int lowerBound = ((Array) obj).GetLowerBound(0);
              int upperBound = ((Array) obj).GetUpperBound(0);
              if (index <= lowerBound)
              {
                if (index <= upperBound)
                  o1 = ((Array) obj).GetValue(index);
              }
            }
            catch
            {
            }
          }
          else
            o1 = propertyInfo1.GetValue(o, (object[]) null);
          return PropertyTest.GetPropertyValue(o1, strArray1[1], out ptype);
        }
        foreach (PropertyInfo propertyInfo2 in properties)
        {
          if (PropertyTest.Insensitive.Equals(propertyInfo2.Name, str))
          {
            if (!propertyInfo2.CanWrite)
              return "Property is read only.";
            ptype = propertyInfo2.PropertyType;
            if (ptype.IsArray)
            {
              try
              {
                object obj = propertyInfo2.GetValue(o, (object[]) null);
                int lowerBound = ((Array) obj).GetLowerBound(0);
                int upperBound = ((Array) obj).GetUpperBound(0);
                if (index <= lowerBound)
                {
                  if (index <= upperBound)
                    o1 = ((Array) obj).GetValue(index);
                }
              }
              catch
              {
              }
            }
            else
              o1 = propertyInfo2.GetValue(o, (object[]) null);
            return PropertyTest.GetPropertyValue(o1, strArray1[1], out ptype);
          }
        }
      }
      else
      {
        PropertyInfo p1 = PropertyTest.LookupPropertyInfo(type, str);
        if (p1 != null)
        {
          if (!p1.CanRead)
            return "Property is write only.";
          ptype = p1.PropertyType;
          return PropertyTest.InternalGetValue(o, p1, index);
        }
        foreach (PropertyInfo p2 in properties)
        {
          if (PropertyTest.Insensitive.Equals(p2.Name, str))
          {
            if (!p2.CanRead)
              return "Property is write only.";
            ptype = p2.PropertyType;
            return PropertyTest.InternalGetValue(o, p2, index);
          }
        }
      }
      return "Property not found.";
    }

    public static PropertyInfo LookupPropertyInfo(Type type, string propname)
    {
      if (type == null || propname == null)
        return (PropertyInfo) null;
      PropertyInfo propertyInfo1 = (PropertyInfo) null;
      PropertyTest.TypeInfo typeInfo1 = (PropertyTest.TypeInfo) null;
      foreach (PropertyTest.TypeInfo typeInfo2 in PropertyTest.PropertyInfoList)
      {
        if (typeInfo2.t == type)
        {
          typeInfo1 = typeInfo2;
          foreach (PropertyInfo propertyInfo2 in typeInfo2.plist)
          {
            if (PropertyTest.Insensitive.Equals(propertyInfo2.Name, propname))
              propertyInfo1 = propertyInfo2;
          }
        }
      }
      if (propertyInfo1 != null)
        return propertyInfo1;
      foreach (PropertyInfo propertyInfo2 in type.GetProperties(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public))
      {
        if (PropertyTest.Insensitive.Equals(propertyInfo2.Name, propname))
        {
          if (typeInfo1 == null)
          {
            typeInfo1 = new PropertyTest.TypeInfo();
            typeInfo1.t = type;
            PropertyTest.PropertyInfoList.Add((object) typeInfo1);
          }
          typeInfo1.plist.Add((object) propertyInfo2);
          return propertyInfo2;
        }
      }
      return (PropertyInfo) null;
    }

    public static string[] ParseString(string str, int nitems, string delimstr)
    {
      if (str == null || delimstr == null)
        return (string[]) null;
      char[] separator = delimstr.ToCharArray();
      str = str.Trim();
      return str.Split(separator, nitems);
    }

    public static string[] ParseToMatchingParen(string str, char opendelim, char closedelim)
    {
      int num1 = 1;
      int num2 = 0;
      int length = str.Length;
      for (int index = 0; index < str.Length; ++index)
      {
        if ((int) str[index] == (int) opendelim)
          ++num1;
        if ((int) str[index] == (int) closedelim)
          ++num2;
        if (num1 == num2)
        {
          length = index;
          break;
        }
      }
      string[] strArray = new string[2]
      {
        str.Substring(0, length),
        ""
      };
      if (length + 1 < str.Length)
        strArray[1] = str.Substring(length + 1, str.Length - length - 1);
      return strArray;
    }

    public static string ParseForKeywords(object o, string valstr, bool literal, out Type ptype)
    {
      ptype = (Type) null;
      if (valstr == null || valstr.Length <= 0)
        return (string) null;
      string str1 = valstr.Trim();
      string[] strArray1 = PropertyTest.ParseString(str1, 2, "[");
      string str2 = (string) null;
      if (strArray1.Length > 1)
        str2 = PropertyTest.ParseToMatchingParen(strArray1[1], '[', ']')[0];
      string[] strArray2 = strArray1[0].Trim().Split(',');
      if (str2 != null && str2.Length > 0 && (strArray2 != null && strArray2.Length > 0))
        strArray2[strArray2.Length - 1] = str2;
      string name = strArray2[0].Trim();
      char ch = str1[0];
      if ((int) ch == 46 || (int) ch == 45 || (int) ch == 43 || (int) ch >= 48 && (int) ch <= 57)
      {
        ptype = str1.IndexOf(".") < 0 ? typeof (int) : typeof (double);
        return str1;
      }
      if ((int) ch == 34 || (int) ch == 40)
      {
        ptype = typeof (string);
        return str1;
      }
      if ((int) ch == 35)
      {
        ptype = typeof (string);
        return str1.Substring(1);
      }
      if (str1.ToLower() == "true" || str1.ToLower() == "false")
      {
        ptype = typeof (bool);
        return str1;
      }
      if (!literal)
        return PropertyTest.ParseGetValue(PropertyTest.GetPropertyValue(o, name, out ptype), ptype);
      ptype = typeof (string);
      return str1;
    }

    public static string ParseGetValue(string str, Type ptype)
    {
      if (str == null)
        return (string) null;
      string[] strArray = str.Split("=".ToCharArray(), 2);
      if (strArray.Length <= 1)
        return (string) null;
      if (PropertyTest.IsNumeric(ptype))
        return strArray[1].Trim().Split(" ".ToCharArray(), 2)[0];
      return strArray[1].Trim();
    }

    public static bool CheckPropertyString(object o, string testString, out string status_str)
    {
      status_str = (string) null;
      if (o == null)
        return false;
      if (testString == null || testString.Length < 1)
      {
        status_str = "Null property test string";
        return false;
      }
      string[] strArray = PropertyTest.ParseString(testString, 2, "&|");
      if (strArray.Length < 2)
        return PropertyTest.CheckSingleProperty(o, testString, out status_str);
      bool flag1 = PropertyTest.CheckSingleProperty(o, strArray[0], out status_str);
      bool flag2 = PropertyTest.CheckPropertyString(o, strArray[1], out status_str);
      int num1 = testString.IndexOf("&");
      int num2 = testString.IndexOf("|");
      if (num1 > 0 && num2 <= 0 || num1 > 0 && num1 < num2)
      {
        if (flag1)
          return flag2;
        return false;
      }
      if ((num2 <= 0 || num1 > 0) && (num2 <= 0 || num2 >= num1))
        return false;
      if (!flag1)
        return flag2;
      return true;
    }

    public static bool CheckSingleProperty(object o, string testString, out string status_str)
    {
      status_str = (string) null;
      if (o == null)
        return false;
      string[] strArray = PropertyTest.ParseString(testString, 2, "=><!");
      if (strArray.Length < 2)
      {
        status_str = "invalid property string : " + testString;
        return false;
      }
      bool flag1 = false;
      bool flag2 = false;
      bool flag3 = false;
      bool flag4 = false;
      if (testString.IndexOf("=") > 0)
        flag1 = true;
      else if (testString.IndexOf("!") > 0)
        flag2 = true;
      else if (testString.IndexOf(">") > 0)
        flag3 = true;
      else if (testString.IndexOf("<") > 0)
        flag4 = true;
      if (!flag1 && !flag3 && (!flag4 && !flag2))
        return false;
      Type ptype1;
      string s1 = PropertyTest.ParseForKeywords(o, strArray[0].Trim(), false, out ptype1);
      if (ptype1 == null)
      {
        status_str = strArray[0] + " : " + s1;
        return false;
      }
      Type ptype2;
      string s2 = PropertyTest.ParseForKeywords(o, strArray[1].Trim(), false, out ptype2);
      if (ptype2 == null)
      {
        status_str = strArray[1] + " : " + s2;
        return false;
      }
      int fromBase1 = 10;
      int fromBase2 = 10;
      if (PropertyTest.IsNumeric(ptype1) && s1.StartsWith("0x"))
        fromBase1 = 16;
      if (PropertyTest.IsNumeric(ptype2) && s2.StartsWith("0x"))
        fromBase2 = 16;
      if (ptype2 == typeof (TimeSpan) || ptype1 == typeof (TimeSpan))
      {
        if (flag1)
        {
          try
          {
            if (TimeSpan.Parse(s1) == TimeSpan.Parse(s2))
              return true;
          }
          catch
          {
            status_str = "invalid timespan comparison : {0}" + testString;
          }
        }
        else if (flag2)
        {
          try
          {
            if (TimeSpan.Parse(s1) != TimeSpan.Parse(s2))
              return true;
          }
          catch
          {
            status_str = "invalid timespan comparison : {0}" + testString;
          }
        }
        else if (flag3)
        {
          try
          {
            if (TimeSpan.Parse(s1) > TimeSpan.Parse(s2))
              return true;
          }
          catch
          {
            status_str = "invalid timespan comparison : {0}" + testString;
          }
        }
        else if (flag4)
        {
          try
          {
            if (TimeSpan.Parse(s1) < TimeSpan.Parse(s2))
              return true;
          }
          catch
          {
            status_str = "invalid timespan comparison : {0}" + testString;
          }
        }
      }
      else if (ptype2 == typeof (DateTime) || ptype1 == typeof (DateTime))
      {
        if (flag1)
        {
          try
          {
            if (DateTime.Parse(s1) == DateTime.Parse(s2))
              return true;
          }
          catch
          {
            status_str = "invalid DateTime comparison : {0}" + testString;
          }
        }
        else if (flag2)
        {
          try
          {
            if (DateTime.Parse(s1) != DateTime.Parse(s2))
              return true;
          }
          catch
          {
            status_str = "invalid DateTime comparison : {0}" + testString;
          }
        }
        else if (flag3)
        {
          try
          {
            if (DateTime.Parse(s1) > DateTime.Parse(s2))
              return true;
          }
          catch
          {
            status_str = "invalid DateTime comparison : {0}" + testString;
          }
        }
        else if (flag4)
        {
          try
          {
            if (DateTime.Parse(s1) < DateTime.Parse(s2))
              return true;
          }
          catch
          {
            status_str = "invalid DateTime comparison : {0}" + testString;
          }
        }
      }
      else if (PropertyTest.IsNumeric(ptype2) && PropertyTest.IsNumeric(ptype1))
      {
        if (flag1)
        {
          try
          {
            if (Convert.ToInt64(s1, fromBase1) == Convert.ToInt64(s2, fromBase2))
              return true;
          }
          catch
          {
            status_str = "invalid int comparison : {0}" + testString;
          }
        }
        else if (flag2)
        {
          try
          {
            if (Convert.ToInt64(s1, fromBase1) != Convert.ToInt64(s2, fromBase2))
              return true;
          }
          catch
          {
            status_str = "invalid int comparison : {0}" + testString;
          }
        }
        else if (flag3)
        {
          try
          {
            if (Convert.ToInt64(s1, fromBase1) > Convert.ToInt64(s2, fromBase2))
              return true;
          }
          catch
          {
            status_str = "invalid int comparison : {0}" + testString;
          }
        }
        else if (flag4)
        {
          try
          {
            if (Convert.ToInt64(s1, fromBase1) < Convert.ToInt64(s2, fromBase2))
              return true;
          }
          catch
          {
            status_str = "invalid int comparison : {0}" + testString;
          }
        }
      }
      else if (ptype2 == typeof (double) && PropertyTest.IsNumeric(ptype1))
      {
        if (flag1)
        {
          try
          {
            if ((double) Convert.ToInt64(s1, fromBase1) == double.Parse(s2))
              return true;
          }
          catch
          {
            status_str = "invalid int comparison : {0}" + testString;
          }
        }
        else if (flag2)
        {
          try
          {
            if ((double) Convert.ToInt64(s1, fromBase1) != double.Parse(s2))
              return true;
          }
          catch
          {
            status_str = "invalid int comparison : {0}" + testString;
          }
        }
        else if (flag3)
        {
          try
          {
            if ((double) Convert.ToInt64(s1, fromBase1) > double.Parse(s2))
              return true;
          }
          catch
          {
            status_str = "invalid int comparison : {0}" + testString;
          }
        }
        else if (flag4)
        {
          try
          {
            if ((double) Convert.ToInt64(s1, fromBase1) < double.Parse(s2))
              return true;
          }
          catch
          {
            status_str = "invalid int comparison : {0}" + testString;
          }
        }
      }
      else if (ptype1 == typeof (double) && PropertyTest.IsNumeric(ptype2))
      {
        if (flag1)
        {
          try
          {
            if (double.Parse(s1) == (double) Convert.ToInt64(s2, fromBase2))
              return true;
          }
          catch
          {
            status_str = "invalid int comparison : {0}" + testString;
          }
        }
        else if (flag2)
        {
          try
          {
            if (double.Parse(s1) != (double) Convert.ToInt64(s2, fromBase2))
              return true;
          }
          catch
          {
            status_str = "invalid int comparison : {0}" + testString;
          }
        }
        else if (flag3)
        {
          try
          {
            if (double.Parse(s1) > (double) Convert.ToInt64(s2, fromBase2))
              return true;
          }
          catch
          {
            status_str = "invalid int comparison : {0}" + testString;
          }
        }
        else if (flag4)
        {
          try
          {
            if (double.Parse(s1) < (double) Convert.ToInt64(s2, fromBase2))
              return true;
          }
          catch
          {
            status_str = "invalid int comparison : {0}" + testString;
          }
        }
      }
      else if (ptype1 == typeof (double) && ptype2 == typeof (double))
      {
        if (flag1)
        {
          try
          {
            if (double.Parse(s1) == double.Parse(s2))
              return true;
          }
          catch
          {
            status_str = "invalid int comparison : {0}" + testString;
          }
        }
        else if (flag2)
        {
          try
          {
            if (double.Parse(s1) != double.Parse(s2))
              return true;
          }
          catch
          {
            status_str = "invalid int comparison : {0}" + testString;
          }
        }
        else if (flag3)
        {
          try
          {
            if (double.Parse(s1) > double.Parse(s2))
              return true;
          }
          catch
          {
            status_str = "invalid int comparison : {0}" + testString;
          }
        }
        else if (flag4)
        {
          try
          {
            if (double.Parse(s1) < double.Parse(s2))
              return true;
          }
          catch
          {
            status_str = "invalid int comparison : {0}" + testString;
          }
        }
      }
      else
      {
        if (ptype2 == typeof (bool))
        {
          if (ptype1 == typeof (bool))
          {
            try
            {
              if (Convert.ToBoolean(s1) == Convert.ToBoolean(s2))
                return true;
              goto label_151;
            }
            catch
            {
              status_str = "invalid bool comparison : {0}" + testString;
              goto label_151;
            }
          }
        }
        if (ptype2 == typeof (double) || ptype2 == typeof (double))
        {
          if (flag1)
          {
            try
            {
              if (Convert.ToDouble(s1) == Convert.ToDouble(s2))
                return true;
            }
            catch
            {
              status_str = "invalid double comparison : {0}" + testString;
            }
          }
          else if (flag2)
          {
            try
            {
              if (Convert.ToDouble(s1) != Convert.ToDouble(s2))
                return true;
            }
            catch
            {
              status_str = "invalid double comparison : {0}" + testString;
            }
          }
          else if (flag3)
          {
            try
            {
              if (Convert.ToDouble(s1) > Convert.ToDouble(s2))
                return true;
            }
            catch
            {
              status_str = "invalid double comparison : {0}" + testString;
            }
          }
          else if (flag4)
          {
            try
            {
              if (Convert.ToDouble(s1) < Convert.ToDouble(s2))
                return true;
            }
            catch
            {
              status_str = "invalid double comparison : {0}" + testString;
            }
          }
        }
        else if (flag1)
        {
          if (s1 == s2)
            return true;
        }
        else if (flag2 && s1 != s2)
          return true;
      }
label_151:
      return false;
    }

    public class TypeInfo
    {
      public ArrayList plist = new ArrayList();
      public Type t;
    }

    public class Insensitive
    {
      private static IComparer m_Comparer = (IComparer) CaseInsensitiveComparer.Default;

      public static IComparer Comparer
      {
        get
        {
          return PropertyTest.Insensitive.m_Comparer;
        }
      }

      private Insensitive()
      {
      }

      public static int Compare(string a, string b)
      {
        return PropertyTest.Insensitive.m_Comparer.Compare((object) a, (object) b);
      }

      public static bool Equals(string a, string b)
      {
        if (a == null && b == null)
          return true;
        if (a == null || b == null || a.Length != b.Length)
          return false;
        return PropertyTest.Insensitive.m_Comparer.Compare((object) a, (object) b) == 0;
      }

      public static bool StartsWith(string a, string b)
      {
        if (a == null || b == null || a.Length < b.Length)
          return false;
        return PropertyTest.Insensitive.m_Comparer.Compare((object) a.Substring(0, b.Length), (object) b) == 0;
      }

      public static bool EndsWith(string a, string b)
      {
        if (a == null || b == null || a.Length < b.Length)
          return false;
        return PropertyTest.Insensitive.m_Comparer.Compare((object) a.Substring(a.Length - b.Length), (object) b) == 0;
      }

      public static bool Contains(string a, string b)
      {
        if (a == null || b == null || a.Length < b.Length)
          return false;
        a = a.ToLower();
        b = b.ToLower();
        return a.IndexOf(b) >= 0;
      }
    }
  }
}
