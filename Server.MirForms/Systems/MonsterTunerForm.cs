﻿using Server.MirDatabase;
using Server.MirEnvir;
using Server.MirObjects;

namespace Server.MirForms.Systems
{
    public partial class MonsterTunerForm : Form
    {
        public Envir Envir => SMain.Envir;

        public MonsterTunerForm()
        {
            InitializeComponent();
            
            for (int i = 0; i < Envir.MonsterInfoList.Count; i++)
            {
                SelectMonsterComboBox.Items.Add(Envir.MonsterInfoList[i]);
            }
        }

        private void SelectMonsterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            MonsterInfo monster = (MonsterInfo)comboBox.SelectedItem;

            if (monster == null) return;

            MonsterNameTextBox.Text = monster.Name;
            HPTextBox.Text = monster.Stats[Stat.HP].ToString();
            EffectTextBox.Text = monster.Effect.ToString();
            LevelTextBox.Text = monster.Level.ToString();
            ViewRangeTextBox.Text = monster.ViewRange.ToString();
            CoolEyeTextBox.Text = monster.CoolEye.ToString();
            MinACTextBox.Text = monster.Stats[Stat.最小防御].ToString();
            MaxACTextBox.Text = monster.Stats[Stat.最大防御].ToString();
            MinMACTextBox.Text = monster.Stats[Stat.最小魔御].ToString();
            MaxMACTextBox.Text = monster.Stats[Stat.最大魔御].ToString();
            MinDCTextBox.Text = monster.Stats[Stat.最小攻击].ToString();
            MaxDCTextBox.Text = monster.Stats[Stat.最大攻击].ToString();
            MinMCTextBox.Text = monster.Stats[Stat.最小魔法].ToString();
            MaxMCTextBox.Text = monster.Stats[Stat.最大魔法].ToString();
            MinSCTextBox.Text = monster.Stats[Stat.最小道术].ToString();
            MaxSCTextBox.Text = monster.Stats[Stat.最大道术].ToString();
            AccuracyTextBox.Text = monster.Stats[Stat.准确].ToString();
            AgilityTextBox.Text = monster.Stats[Stat.敏捷].ToString();
            ASpeedTextBox.Text = monster.AttackSpeed.ToString();
            MSpeedTextBox.Text = monster.MoveSpeed.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            MonsterInfo monster = (MonsterInfo)SelectMonsterComboBox.SelectedItem;

            if (monster == null) return;

            try
            {
                monster.Stats[Stat.HP] = int.Parse(HPTextBox.Text);
                monster.Effect = byte.Parse(EffectTextBox.Text);
                monster.Level = ushort.Parse(LevelTextBox.Text);
                monster.ViewRange = byte.Parse(ViewRangeTextBox.Text);
                monster.CoolEye = byte.Parse(CoolEyeTextBox.Text);
                monster.Stats[Stat.最小防御] = ushort.Parse(MinACTextBox.Text);
                monster.Stats[Stat.最大防御] = ushort.Parse(MaxACTextBox.Text);
                monster.Stats[Stat.最小魔御] = ushort.Parse(MinMACTextBox.Text);
                monster.Stats[Stat.最大魔御] = ushort.Parse(MaxMACTextBox.Text);
                monster.Stats[Stat.最小攻击] = ushort.Parse(MinDCTextBox.Text);
                monster.Stats[Stat.最大攻击] = ushort.Parse(MaxDCTextBox.Text);
                monster.Stats[Stat.最小魔法] = ushort.Parse(MinMCTextBox.Text);
                monster.Stats[Stat.最大魔法] = ushort.Parse(MaxMCTextBox.Text);
                monster.Stats[Stat.最小道术] = ushort.Parse(MinSCTextBox.Text);
                monster.Stats[Stat.最大道术] = ushort.Parse(MaxSCTextBox.Text);
                monster.Stats[Stat.准确] = byte.Parse(AccuracyTextBox.Text);
                monster.Stats[Stat.敏捷] = byte.Parse(AgilityTextBox.Text);
                monster.AttackSpeed = ushort.Parse(ASpeedTextBox.Text);
                monster.MoveSpeed = ushort.Parse(MSpeedTextBox.Text);
            }
            catch
            {
                MessageBox.Show("验证失败！请在更新前验证", "Notice",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            foreach (var item in Envir.Objects)
            {
                if (item.Race != ObjectType.Monster) continue;

                MonsterObject mob = (MonsterObject)item;

                mob.RefreshAll();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SelectMonsterComboBox.Items.Count; i++)
            {
                MonsterInfo mob = (MonsterInfo)SelectMonsterComboBox.Items[i];

                if (mob == null) continue;

                if (Envir.MonsterInfoList[i].Index != mob.Index) break;

                Envir.MonsterInfoList[i] = mob;
            }

            Envir.SaveDB();
        }
    }
}
