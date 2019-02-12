using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game{
public class SoundVO {

  static int[] _Keys;
  static SortedList<int, SoundVO> _Data;
  public int Id;
  public string Name;
  public float Priority;
  public bool Loop;
  public float Volume;
  public float SpatialBlend;
  public float MaxDistance;
  public static void SetVO(string text)
  {
      SoundVO data = new SoundVO();
      string[] tokens = Table.GetTokens(text);
      int.TryParse(tokens[0], out data.Id);
      if (tokens[1] != null)
           data.Name = tokens[1];
      float.TryParse(tokens[2], out data.Priority);
      bool.TryParse(tokens[3], out data.Loop);
      float.TryParse(tokens[4], out data.Volume);
      float.TryParse(tokens[5], out data.SpatialBlend);
      float.TryParse(tokens[6], out data.MaxDistance);
      _Data[data.Id] = data;
  }
  public static SoundVO GetConfig(int id)
  {
      if(_Data==null)
          LoadVO();
     SoundVO data = null;
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
      _Data = new SortedList<int, SoundVO>();
      string text = TableComponent.GetTable("Sound");
      string[] rows = text.Split(new char[]{'\r','\n'},StringSplitOptions.RemoveEmptyEntries);
      int count = rows.Length;
      for (int i = 3; i < count; i++)
          SetVO(rows[i]);
  }
}
}
