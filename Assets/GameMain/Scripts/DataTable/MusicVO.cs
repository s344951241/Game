﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game{
public class MusicVO {

  static int[] _Keys;
  static SortedList<int, MusicVO> _Data;
  public int Id;
  public string Name;
  public static void SetVO(string text)
  {
      MusicVO data = new MusicVO();
      string[] tokens = Table.GetTokens(text);
      int.TryParse(tokens[0], out data.Id);
      if (tokens[1] != null)
           data.Name = tokens[1];
      _Data[data.Id] = data;
  }
  public static MusicVO GetConfig(int id)
  {
      if(_Data==null)
          LoadVO();
     MusicVO data = null;
      _Data.TryGetValue(id, out data);
      return data;
  }
  public static int[] GetKeys()
  {
      if (_Data == null)
           LoadVO();
      if (_Keys == null)
      {
          IList<int> keys = _Data.Keys;
          _Keys = new int[_Data.Count];
          for (int i = 0; i < _Keys.Length; i++)
          {
              _Keys[i] = keys[i];
          }
          return _Keys;
      }
       return null;
  }
  static void LoadVO()
  {
      _Data = new SortedList<int, MusicVO>();
      string text = TableComponent.GetTable("Music");
      string[] rows = text.Split(new char[]{'\r','\n'},StringSplitOptions.RemoveEmptyEntries);
      int count = rows.Length;
      for (int i = 3; i < count; i++)
          SetVO(rows[i]);
  }
}
}
