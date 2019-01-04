﻿// Decompiled with JetBrains decompiler
// Type: Shooting.SpellCard_SSS05_04
// Assembly: THSSS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9501F839-8E36-4763-8C1B-4AB9B7BE2AA4
// Assembly location: E:\东方project\非官方游戏\东方夏夜祭 ～ Shining Shooting Star\THSSS.exe

using System.Drawing;

namespace Shooting
{
  internal class SpellCard_SSS05_04 : BaseSpellCard
  {
    public SpellCard_SSS05_04(StageDataPackage StageData)
      : base(StageData)
    {
      if (this.Difficulty < DifficultLevel.Hard)
        this.SC_Name = "焰符「原始的烈焰」";
      else
        this.SC_Name = "焰符「八百里的烈焰」";
      this.BaseScore = 30000000L;
      this.Boss.DestPoint = (PointF) new Point(this.BoundRect.Width / 2, 120);
      this.Boss.Velocity = 4f;
      StageData.SoundPlay("se_cat00.wav");
      BackgroundBoss05 backgroundBoss05 = new BackgroundBoss05(StageData);
      BulletTitle bulletTitle = new BulletTitle(StageData, this.SC_Name);
      SpellCardAttack spellCardAttack = new SpellCardAttack(StageData);
      FullPic2 fullPic2 = new FullPic2(StageData, "FaceRakukun_ct");
    }

    public override void Shoot()
    {
      this.Boss.Armon = this.Boss.ArmonArray[6];
      if (this.Time > 100)
        this.Boss.MoveUpDown();
      if (this.Time != 150)
        return;
      string FileName;
      switch (this.Difficulty)
      {
        case DifficultLevel.Easy:
          FileName = ".\\CS\\St05\\关底Boss\\4符E.mbg";
          break;
        case DifficultLevel.Normal:
          FileName = ".\\CS\\St05\\关底Boss\\4符N.mbg";
          break;
        case DifficultLevel.Hard:
          FileName = ".\\CS\\St05\\关底Boss\\4符H.mbg";
          break;
        case DifficultLevel.Lunatic:
          FileName = ".\\CS\\St05\\关底Boss\\4符L.mbg";
          break;
        default:
          FileName = ".\\CS\\St05\\关底Boss\\4符L.mbg";
          break;
      }
      CSEmitterController emitterController = new CSEmitterController(this.StageData, this.StageData.LoadCS(FileName));
    }
  }
}
