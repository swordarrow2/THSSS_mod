﻿// Decompiled with JetBrains decompiler
// Type: Shooting.ParticleBiger
// Assembly: THSSS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9501F839-8E36-4763-8C1B-4AB9B7BE2AA4
// Assembly location: E:\东方project\非官方游戏\东方夏夜祭 ～ Shining Shooting Star\THSSS.exe

using System.Drawing;

namespace Shooting
{
  internal class ParticleBiger : BaseEffect
  {
    public ParticleBiger(
      StageDataPackage StageData,
      string textureName,
      PointF Position,
      float Velocity,
      double Direction)
      : base(StageData, textureName, Position, Velocity, Direction)
    {
      this.LifeTime = 30;
      this.Scale = 0.5f;
    }

    public override void Ctrl()
    {
      base.Ctrl();
      if (this.Time <= 0)
        return;
      this.TransparentValueF -= (float) (this.MaxTransparent / this.LifeTime);
      this.Scale += 0.05f;
    }
  }
}
