﻿using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace QueryMaster
{
    static class Util
    {
       private static readonly Dictionary<string, ushort> GoldSourceGames = new Dictionary<string, ushort>()
       {
            // You can't rely on server description, because it can be modified.
            {"cstrike",10},
            {"tfc",20},
            {"dod",30},
            {"dmc",40},
            {"gearbox",50},
            {"ricochet",60},
            {"valve",70},
            {"czero",80},
            //{"Counter-Strike 1.6 dedicated server",90},
            {"czeror",100},
            {"bshift",130},
       };
        internal static ushort GetGameId(string name)
        {
            if (GoldSourceGames.ContainsKey(name))
                return GoldSourceGames[name];
            return 0;
        }
        internal static string BytesToString(byte[] bytes)
        {
            return Encoding.UTF8.GetString(bytes);
        }

        internal static string BytesToString(byte[] bytes, int index , int count )
        {
            return Encoding.UTF8.GetString(bytes, index, count);
        }

        internal static byte[] StringToBytes(string str)
        {
            return Encoding.UTF8.GetBytes(str);
        }

        internal static byte[] StringToBytes(string str, int index, int count)
        {
            return Encoding.UTF8.GetBytes(str.ToCharArray(), index, count);
        }

        internal static byte[] MergeByteArrays(byte[] array1, byte[] array2)
        {
            byte[] newArray = new byte[array1.Length + array2.Length];
            Buffer.BlockCopy(array1, 0, newArray, 0, array1.Length);
            Buffer.BlockCopy(array2, 0, newArray, array1.Length, array2.Length);
            return newArray;
        }
        internal static byte[] MergeByteArrays(byte[] array1, byte[] array2, byte[] array3)
        {
            byte[] newArray = new byte[array1.Length + array2.Length + array3.Length];
            Buffer.BlockCopy(array1, 0, newArray, 0, array1.Length);
            Buffer.BlockCopy(array2, 0, newArray, array1.Length, array2.Length);
            Buffer.BlockCopy(array3, 0, newArray, array1.Length + array2.Length, array3.Length);
            return newArray;
        }

        internal static T RunWithRetries<T>(Func<T> action, int maxTries, Action<int> onTimeout = null)
        {
          int attempt = 0;
          while (true)
          {
            ++attempt;
            try
            {
              return action();
            }
            catch (SocketException ex)
            {
              if (ex.SocketErrorCode != SocketError.TimedOut)
                throw;

              if (onTimeout != null)
                onTimeout(attempt);

              if (attempt >= maxTries)
                return default(T);
            }
          }
        }

    }
}