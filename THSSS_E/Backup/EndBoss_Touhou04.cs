﻿// Decompiled with JetBrains decompiler
// Type: Shooting.EndBoss_Touhou04
// Assembly: THSSS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9501F839-8E36-4763-8C1B-4AB9B7BE2AA4
// Assembly location: E:\东方project\非官方游戏\东方夏夜祭 ～ Shining Shooting Star\THSSS.exe

using Shooting.Planes.Story;
using System.Drawing;

namespace Shooting
{
  internal class EndBoss_Touhou04 : EndBoss_Touhou
  {
    public EndBoss_Touhou04(
      StageDataPackage StageData,
      PointF OriginalPosition,
      Color Color1,
      Color Color2)
      : base(StageData, OriginalPosition, Color1, Color2)
    {
    }

    public override void Ctrl()
    {
      base.Ctrl();
      if (this.Time != this.LifeTime)
        return;
      Story_SSS04_02 storySsS0402 = new Story_SSS04_02(this.StageData);
    }
  }
}
