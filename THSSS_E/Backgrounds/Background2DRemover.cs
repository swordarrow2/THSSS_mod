﻿ 
// Type: Shooting.Background2DRemover
// Assembly: THSSS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9501F839-8E36-4763-8C1B-4AB9B7BE2AA4
// Assembly location: E:\东方project\非官方游戏\东方夏夜祭 ～ Shining Shooting Star\THSSS.exe

using System;
using System.Drawing;

namespace Shooting
{
  public class Background2DRemover : BaseEffect
  {
    public Background2DRemover(StageDataPackage StageData)
      : base(StageData, (string) null, (PointF) new Point(0, 0), 0.0f, Math.PI / 2.0)
    {
      this.LifeTime = 20;
    }

    public override void Ctrl()
    {
      base.Ctrl();
      this.Background.BackgroundList.ForEach((Action<BaseObject>) (x => x.TransparentValueF -= (float) (this.MaxTransparent / this.LifeTime)));
      if (this.Time < this.LifeTime)
        return;
      this.Background.BackgroundList.Clear();
    }

    public override void Show()
    {
    }
  }
}
