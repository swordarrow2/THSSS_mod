﻿// Decompiled with JetBrains decompiler
// Type: Shooting.BossMark
// Assembly: THSSS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9501F839-8E36-4763-8C1B-4AB9B7BE2AA4
// Assembly location: E:\东方project\非官方游戏\东方夏夜祭 ～ Shining Shooting Star\THSSS.exe

using System;
using System.Drawing;

namespace Shooting
{
  public class BossMark : BaseObject
  {
    public BossMark(StageDataPackage StageData)
    {
      this.StageData = StageData;
      this.TxtureObject = this.TextureObjectDictionary[nameof (BossMark)];
      Rectangle boundRect = this.BoundRect;
      int left = boundRect.Left;
      boundRect = this.BoundRect;
      int num = boundRect.Width / 2;
      this.Position = new PointF((float) (left + num), 472f);
      this.AngleDegree = 90.0;
    }

    public override void Ctrl()
    {
      ++this.Time;
      if (this.Boss == null)
        return;
      this.OriginalPosition = new PointF(this.Boss.OriginalPosition.X + (float) this.BoundRect.X, 472f);
      this.TransparentValueF = (float) (150 + (int) (100.0 * Math.Sin((double) this.Time * Math.PI * 2.0 / 60.0)));
    }

    public override void Show()
    {
      if (this.Boss == null || this.TxtureObject == null)
        return;
      this.SpriteMain.Draw2D(this.TxtureObject, this.ScaleWidth, this.ScaleLength, (float) (this.Direction - Math.PI / 2.0 + this.Angle), this.OriginalPosition, Color.FromArgb(this.TransparentValue, this.ColorValue), this.Mirrored);
    }
  }
}
