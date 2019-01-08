﻿// Decompiled with JetBrains decompiler
// Type: Shooting.SpellCard_SSSEx_01D
// Assembly: THSSS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9501F839-8E36-4763-8C1B-4AB9B7BE2AA4
// Assembly location: E:\东方project\非官方游戏\东方夏夜祭 ～ Shining Shooting Star\THSSS.exe

using System.Drawing;

namespace Shooting
{
  internal class SpellCard_SSSEx_01D : BaseSpellCard
  {
    public SpellCard_SSSEx_01D(StageDataPackage StageData)
      : base(StageData)
    {
      this.SC_Name = "迴梦「月色琉璃光」";
      this.BaseScore = 40000000L;
      this.Boss.DestPoint = (PointF) new Point(this.BoundRect.Width / 2, 120);
      this.Boss.Velocity = 4f;
      StageData.SoundPlay("se_cat00.wav");
      BulletTitle bulletTitle = new BulletTitle(StageData, this.SC_Name);
      SpellCardAttack spellCardAttack = new SpellCardAttack(StageData);
      FullPic2 fullPic2 = new FullPic2(StageData, "FaceRika_ct3");
      BackgroundBossEx backgroundBossEx = new BackgroundBossEx(StageData);
    }

    public override void Shoot() {
            if(SpellList.Count>0 ) {
                Boss.Armon=1f;
                Boss.HealthPoint+=1;
            } else { 
            this.Boss.Armon = this.Boss.ArmonArray[1];
            }
      if (this.Time != 100)
        return;
      CSEmitterController emitterController = new CSEmitterController(this.StageData, this.StageData.LoadCS(".\\CS\\StEx\\关底Boss\\1符3.mbg"));
    }
  }
}
