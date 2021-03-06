﻿ 
// Type: Shooting.SpellCard_SSSEx_01B
// Assembly: THSSS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9501F839-8E36-4763-8C1B-4AB9B7BE2AA4
// Assembly location: E:\东方project\非官方游戏\东方夏夜祭 ～ Shining Shooting Star\THSSS.exe

using System.Drawing;

namespace Shooting
{
  internal class SpellCard_SSSEx_01B : BaseSpellCard
  {
    public SpellCard_SSSEx_01B(StageDataPackage StageData)
      : base(StageData)
    {
      this.SC_Name = "绽放「爱意的玫瑰」";
      this.BaseScore = 40000000L;
      this.Boss.DestPoint = (PointF) new Point(this.BoundRect.Width / 2, 160);
      this.Boss.Velocity = 4f;
      StageData.SoundPlay("se_cat00.wav");
      BulletTitle bulletTitle = new BulletTitle(StageData, this.SC_Name);
      SpellCardAttack spellCardAttack = new SpellCardAttack(StageData);
      FullPic2 fullPic2 = new FullPic2(StageData, "FaceRika_ct1");
      BackgroundBossEx backgroundBossEx = new BackgroundBossEx(StageData);
    }

    public override void Shoot()
    {
      this.Boss.Armon = this.Boss.ArmonArray[1];
      if (this.Time != 100)
        return;
      CSEmitterController emitterController = new CSEmitterController(this.StageData, this.StageData.LoadCS(".\\CS\\StEx\\关底Boss\\1符1.mbg"));
    }
  }
}
