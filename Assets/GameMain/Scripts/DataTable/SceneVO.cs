using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game{
public class SceneVO {

  static int[] _Keys;
  static SortedList<int, SceneVO> _Data;
  public int Id;
  public string AssetName;
  public int BackgroundMusicId;
  public static void SetVO(string text)
  {
      SceneVO data = new SceneVO();
      string[] tokens = Table.GetTokens(text);
      int.TryParse(tokens[0], out data.Id);
      if (tokens[1] != null)
           data.AssetName = tokens[1];
      int.TryParse(tokens[2], out data.BackgroundMusicId);
      _Data[data.Id] = data;
  }
  public static SceneVO GetConfig(int id)
  {
      if(_Data==null)
          LoadVO();
     SceneVO data = null;
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
      _Data = new SortedList<int, SceneVO>();
      string text = TableComponent.GetTable("Scene");
      string[] rows = text.Split(new char[]{'\r','\n'},StringSplitOptions.RemoveEmptyEntries);
      int count = rows.Length;
      for (int i = 3; i < count; i++)
          SetVO(rows[i]);
  }
}
}
