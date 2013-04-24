﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices.WindowsRuntime;

namespace MySql.Data.MySqlClient
{
  public static class ExtensionMethods
  {
    public static byte[] GetBuffer(this Stream stream)
    {
      return ((MemoryStream)stream).GetWindowsRuntimeBuffer().ToArray();
    }

    public static void Close(this Stream stream)
    {
      stream.Dispose();
    }

    public static void Close(this StreamReader stream)
    {
      stream.Dispose();
    }

    public static string ToLower(this String newString, System.Globalization.CultureInfo culture)
    {
      if (culture == System.Globalization.CultureInfo.InvariantCulture)
        return newString.ToLowerInvariant();
      else
        return newString.ToLower();
    }

    public static string ToLongTimeString(this DateTime dateTime)
    {
      return dateTime.ToString(System.Globalization.DateTimeFormatInfo.CurrentInfo.LongTimePattern);
    }

    public static bool WaitOne(this WaitHandle waitHandle, int millisecondsTimeout, bool exitContext)
    {
      return waitHandle.WaitOne(millisecondsTimeout);
    }

    public static PropertyInfo[] GetProperties(this Type type)
    {
      return type.GetRuntimeProperties().ToArray();
    }
  }
}
