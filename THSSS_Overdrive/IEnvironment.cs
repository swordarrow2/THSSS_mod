﻿// Decompiled with JetBrains decompiler
// Type: Shooting.IEnvironment
// Assembly: THSSS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9501F839-8E36-4763-8C1B-4AB9B7BE2AA4
// Assembly location: E:\东方project\非官方游戏\东方夏夜祭 ～ Shining Shooting Star\THSSS.exe

using SlimDX;

namespace Shooting
{
  public interface IEnvironment
  {
    float CameraAngle { get; }

    Vector3 CameraPos { get; }

    void Ctrl();

    void SetRenderPara();
  }
}
