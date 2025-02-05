﻿namespace Server.Database
{
    partial class RecipeInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RecipeList = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            RecipeGroupBox = new GroupBox();
            ItemComboBox = new ComboBox();
            GoldTextBox = new TextBox();
            ChanceTextBox = new TextBox();
            CraftAmountTextBox = new TextBox();
            label6 = new Label();
            ToolsGroupBox = new GroupBox();
            Tool3ComboBox = new ComboBox();
            Tool2ComboBox = new ComboBox();
            Tool1ComboBox = new ComboBox();
            IngredientsGroupBox = new GroupBox();
            IngredientDura6TextBox = new TextBox();
            IngredientDura5TextBox = new TextBox();
            label8 = new Label();
            IngredientDura4TextBox = new TextBox();
            IngredientDura3TextBox = new TextBox();
            IngredientDura2TextBox = new TextBox();
            IngredientDura1TextBox = new TextBox();
            IngredientAmount6TextBox = new TextBox();
            IngredientAmount5TextBox = new TextBox();
            IngredientName6ComboBox = new ComboBox();
            IngredientName5ComboBox = new ComboBox();
            IngredientName4ComboBox = new ComboBox();
            IngredientName3ComboBox = new ComboBox();
            IngredientName2ComboBox = new ComboBox();
            IngredientName1ComboBox = new ComboBox();
            label7 = new Label();
            label5 = new Label();
            IngredientAmount4TextBox = new TextBox();
            IngredientAmount3TextBox = new TextBox();
            IngredientAmount2TextBox = new TextBox();
            IngredientAmount1TextBox = new TextBox();
            NewRecipeButton = new Button();
            OpenRecipeButton = new Button();
            SaveButton = new Button();
            groupBox1 = new GroupBox();
            RecipeCountLabel = new Label();
            DeleteButton = new Button();
            RecipeGroupBox.SuspendLayout();
            ToolsGroupBox.SuspendLayout();
            IngredientsGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // RecipeList
            // 
            RecipeList.FormattingEnabled = true;
            RecipeList.ItemHeight = 17;
            RecipeList.Location = new Point(12, 14);
            RecipeList.Name = "RecipeList";
            RecipeList.Size = new Size(135, 361);
            RecipeList.TabIndex = 0;
            RecipeList.SelectedIndexChanged += RecipeList_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 51);
            label1.Name = "label1";
            label1.Size = new Size(63, 17);
            label1.TabIndex = 1;
            label1.Text = "合成数量: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 80);
            label2.Name = "label2";
            label2.Size = new Size(62, 17);
            label2.TabIndex = 2;
            label2.Text = "成功率 %:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 115);
            label3.Name = "label3";
            label3.Size = new Size(63, 17);
            label3.TabIndex = 3;
            label3.Text = "金币消耗: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 17);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 4;
            label4.Text = "辅助工具";
            // 
            // RecipeGroupBox
            // 
            RecipeGroupBox.Controls.Add(ItemComboBox);
            RecipeGroupBox.Controls.Add(GoldTextBox);
            RecipeGroupBox.Controls.Add(ChanceTextBox);
            RecipeGroupBox.Controls.Add(CraftAmountTextBox);
            RecipeGroupBox.Controls.Add(label6);
            RecipeGroupBox.Controls.Add(label1);
            RecipeGroupBox.Controls.Add(label2);
            RecipeGroupBox.Controls.Add(label3);
            RecipeGroupBox.Location = new Point(153, 14);
            RecipeGroupBox.Name = "RecipeGroupBox";
            RecipeGroupBox.Size = new Size(271, 148);
            RecipeGroupBox.TabIndex = 6;
            RecipeGroupBox.TabStop = false;
            RecipeGroupBox.Text = "合成配方(必填)";
            // 
            // ItemComboBox
            // 
            ItemComboBox.FormattingEnabled = true;
            ItemComboBox.Location = new Point(69, 17);
            ItemComboBox.Name = "ItemComboBox";
            ItemComboBox.Size = new Size(190, 25);
            ItemComboBox.TabIndex = 10;
            ItemComboBox.SelectedIndexChanged += ItemComboBox_SelectedIndexChanged;
            // 
            // GoldTextBox
            // 
            GoldTextBox.Location = new Point(69, 112);
            GoldTextBox.Name = "GoldTextBox";
            GoldTextBox.Size = new Size(128, 23);
            GoldTextBox.TabIndex = 8;
            // 
            // ChanceTextBox
            // 
            ChanceTextBox.Location = new Point(69, 77);
            ChanceTextBox.Name = "ChanceTextBox";
            ChanceTextBox.Size = new Size(40, 23);
            ChanceTextBox.TabIndex = 7;
            // 
            // CraftAmountTextBox
            // 
            CraftAmountTextBox.Location = new Point(69, 48);
            CraftAmountTextBox.Name = "CraftAmountTextBox";
            CraftAmountTextBox.Size = new Size(40, 23);
            CraftAmountTextBox.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 22);
            label6.Name = "label6";
            label6.Size = new Size(63, 17);
            label6.TabIndex = 4;
            label6.Text = "合成物品: ";
            // 
            // ToolsGroupBox
            // 
            ToolsGroupBox.Controls.Add(Tool3ComboBox);
            ToolsGroupBox.Controls.Add(Tool2ComboBox);
            ToolsGroupBox.Controls.Add(Tool1ComboBox);
            ToolsGroupBox.Controls.Add(label4);
            ToolsGroupBox.Location = new Point(153, 169);
            ToolsGroupBox.Name = "ToolsGroupBox";
            ToolsGroupBox.Size = new Size(271, 144);
            ToolsGroupBox.TabIndex = 7;
            ToolsGroupBox.TabStop = false;
            ToolsGroupBox.Text = "辅助工具(可选)";
            // 
            // Tool3ComboBox
            // 
            Tool3ComboBox.FormattingEnabled = true;
            Tool3ComboBox.Location = new Point(6, 105);
            Tool3ComboBox.Name = "Tool3ComboBox";
            Tool3ComboBox.Size = new Size(190, 25);
            Tool3ComboBox.TabIndex = 13;
            // 
            // Tool2ComboBox
            // 
            Tool2ComboBox.FormattingEnabled = true;
            Tool2ComboBox.Location = new Point(6, 73);
            Tool2ComboBox.Name = "Tool2ComboBox";
            Tool2ComboBox.Size = new Size(190, 25);
            Tool2ComboBox.TabIndex = 12;
            // 
            // Tool1ComboBox
            // 
            Tool1ComboBox.FormattingEnabled = true;
            Tool1ComboBox.Location = new Point(6, 40);
            Tool1ComboBox.Name = "Tool1ComboBox";
            Tool1ComboBox.Size = new Size(190, 25);
            Tool1ComboBox.TabIndex = 11;
            // 
            // IngredientsGroupBox
            // 
            IngredientsGroupBox.Controls.Add(IngredientDura6TextBox);
            IngredientsGroupBox.Controls.Add(IngredientDura5TextBox);
            IngredientsGroupBox.Controls.Add(label8);
            IngredientsGroupBox.Controls.Add(IngredientDura4TextBox);
            IngredientsGroupBox.Controls.Add(IngredientDura3TextBox);
            IngredientsGroupBox.Controls.Add(IngredientDura2TextBox);
            IngredientsGroupBox.Controls.Add(IngredientDura1TextBox);
            IngredientsGroupBox.Controls.Add(IngredientAmount6TextBox);
            IngredientsGroupBox.Controls.Add(IngredientAmount5TextBox);
            IngredientsGroupBox.Controls.Add(IngredientName6ComboBox);
            IngredientsGroupBox.Controls.Add(IngredientName5ComboBox);
            IngredientsGroupBox.Controls.Add(IngredientName4ComboBox);
            IngredientsGroupBox.Controls.Add(IngredientName3ComboBox);
            IngredientsGroupBox.Controls.Add(IngredientName2ComboBox);
            IngredientsGroupBox.Controls.Add(IngredientName1ComboBox);
            IngredientsGroupBox.Controls.Add(label7);
            IngredientsGroupBox.Controls.Add(label5);
            IngredientsGroupBox.Controls.Add(IngredientAmount4TextBox);
            IngredientsGroupBox.Controls.Add(IngredientAmount3TextBox);
            IngredientsGroupBox.Controls.Add(IngredientAmount2TextBox);
            IngredientsGroupBox.Controls.Add(IngredientAmount1TextBox);
            IngredientsGroupBox.Location = new Point(153, 320);
            IngredientsGroupBox.Name = "IngredientsGroupBox";
            IngredientsGroupBox.Size = new Size(271, 255);
            IngredientsGroupBox.TabIndex = 8;
            IngredientsGroupBox.TabStop = false;
            IngredientsGroupBox.Text = "配方 (必填)";
            // 
            // IngredientDura6TextBox
            // 
            IngredientDura6TextBox.Location = new Point(200, 215);
            IngredientDura6TextBox.Name = "IngredientDura6TextBox";
            IngredientDura6TextBox.Size = new Size(59, 23);
            IngredientDura6TextBox.TabIndex = 29;
            // 
            // IngredientDura5TextBox
            // 
            IngredientDura5TextBox.Location = new Point(200, 182);
            IngredientDura5TextBox.Name = "IngredientDura5TextBox";
            IngredientDura5TextBox.Size = new Size(59, 23);
            IngredientDura5TextBox.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(198, 22);
            label8.Name = "label8";
            label8.Size = new Size(61, 17);
            label8.TabIndex = 27;
            label8.Text = "品质/持久";
            // 
            // IngredientDura4TextBox
            // 
            IngredientDura4TextBox.Location = new Point(200, 150);
            IngredientDura4TextBox.Name = "IngredientDura4TextBox";
            IngredientDura4TextBox.Size = new Size(59, 23);
            IngredientDura4TextBox.TabIndex = 26;
            // 
            // IngredientDura3TextBox
            // 
            IngredientDura3TextBox.Location = new Point(200, 117);
            IngredientDura3TextBox.Name = "IngredientDura3TextBox";
            IngredientDura3TextBox.Size = new Size(59, 23);
            IngredientDura3TextBox.TabIndex = 25;
            // 
            // IngredientDura2TextBox
            // 
            IngredientDura2TextBox.Location = new Point(200, 84);
            IngredientDura2TextBox.Name = "IngredientDura2TextBox";
            IngredientDura2TextBox.Size = new Size(59, 23);
            IngredientDura2TextBox.TabIndex = 24;
            // 
            // IngredientDura1TextBox
            // 
            IngredientDura1TextBox.Location = new Point(200, 51);
            IngredientDura1TextBox.Name = "IngredientDura1TextBox";
            IngredientDura1TextBox.Size = new Size(59, 23);
            IngredientDura1TextBox.TabIndex = 23;
            // 
            // IngredientAmount6TextBox
            // 
            IngredientAmount6TextBox.Location = new Point(135, 215);
            IngredientAmount6TextBox.Name = "IngredientAmount6TextBox";
            IngredientAmount6TextBox.Size = new Size(59, 23);
            IngredientAmount6TextBox.TabIndex = 22;
            // 
            // IngredientAmount5TextBox
            // 
            IngredientAmount5TextBox.Location = new Point(135, 182);
            IngredientAmount5TextBox.Name = "IngredientAmount5TextBox";
            IngredientAmount5TextBox.Size = new Size(59, 23);
            IngredientAmount5TextBox.TabIndex = 21;
            // 
            // IngredientName6ComboBox
            // 
            IngredientName6ComboBox.FormattingEnabled = true;
            IngredientName6ComboBox.Location = new Point(6, 215);
            IngredientName6ComboBox.Name = "IngredientName6ComboBox";
            IngredientName6ComboBox.Size = new Size(121, 25);
            IngredientName6ComboBox.TabIndex = 20;
            // 
            // IngredientName5ComboBox
            // 
            IngredientName5ComboBox.FormattingEnabled = true;
            IngredientName5ComboBox.Location = new Point(6, 182);
            IngredientName5ComboBox.Name = "IngredientName5ComboBox";
            IngredientName5ComboBox.Size = new Size(121, 25);
            IngredientName5ComboBox.TabIndex = 19;
            // 
            // IngredientName4ComboBox
            // 
            IngredientName4ComboBox.FormattingEnabled = true;
            IngredientName4ComboBox.Location = new Point(6, 150);
            IngredientName4ComboBox.Name = "IngredientName4ComboBox";
            IngredientName4ComboBox.Size = new Size(121, 25);
            IngredientName4ComboBox.TabIndex = 18;
            // 
            // IngredientName3ComboBox
            // 
            IngredientName3ComboBox.FormattingEnabled = true;
            IngredientName3ComboBox.Location = new Point(6, 117);
            IngredientName3ComboBox.Name = "IngredientName3ComboBox";
            IngredientName3ComboBox.Size = new Size(121, 25);
            IngredientName3ComboBox.TabIndex = 17;
            // 
            // IngredientName2ComboBox
            // 
            IngredientName2ComboBox.FormattingEnabled = true;
            IngredientName2ComboBox.Location = new Point(6, 84);
            IngredientName2ComboBox.Name = "IngredientName2ComboBox";
            IngredientName2ComboBox.Size = new Size(121, 25);
            IngredientName2ComboBox.TabIndex = 16;
            // 
            // IngredientName1ComboBox
            // 
            IngredientName1ComboBox.FormattingEnabled = true;
            IngredientName1ComboBox.Location = new Point(6, 51);
            IngredientName1ComboBox.Name = "IngredientName1ComboBox";
            IngredientName1ComboBox.Size = new Size(121, 25);
            IngredientName1ComboBox.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 22);
            label7.Name = "label7";
            label7.Size = new Size(56, 17);
            label7.TabIndex = 15;
            label7.Text = "物品名称";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(148, 22);
            label5.Name = "label5";
            label5.Size = new Size(32, 17);
            label5.TabIndex = 14;
            label5.Text = "数量";
            // 
            // IngredientAmount4TextBox
            // 
            IngredientAmount4TextBox.Location = new Point(135, 150);
            IngredientAmount4TextBox.Name = "IngredientAmount4TextBox";
            IngredientAmount4TextBox.Size = new Size(59, 23);
            IngredientAmount4TextBox.TabIndex = 13;
            // 
            // IngredientAmount3TextBox
            // 
            IngredientAmount3TextBox.Location = new Point(135, 117);
            IngredientAmount3TextBox.Name = "IngredientAmount3TextBox";
            IngredientAmount3TextBox.Size = new Size(59, 23);
            IngredientAmount3TextBox.TabIndex = 12;
            // 
            // IngredientAmount2TextBox
            // 
            IngredientAmount2TextBox.Location = new Point(135, 84);
            IngredientAmount2TextBox.Name = "IngredientAmount2TextBox";
            IngredientAmount2TextBox.Size = new Size(59, 23);
            IngredientAmount2TextBox.TabIndex = 11;
            // 
            // IngredientAmount1TextBox
            // 
            IngredientAmount1TextBox.Location = new Point(135, 51);
            IngredientAmount1TextBox.Name = "IngredientAmount1TextBox";
            IngredientAmount1TextBox.Size = new Size(59, 23);
            IngredientAmount1TextBox.TabIndex = 10;
            // 
            // NewRecipeButton
            // 
            NewRecipeButton.Location = new Point(9, 31);
            NewRecipeButton.Name = "NewRecipeButton";
            NewRecipeButton.Size = new Size(75, 26);
            NewRecipeButton.TabIndex = 9;
            NewRecipeButton.Text = "新增";
            NewRecipeButton.UseVisualStyleBackColor = true;
            NewRecipeButton.Click += NewRecipeButton_Click;
            // 
            // OpenRecipeButton
            // 
            OpenRecipeButton.Location = new Point(9, 63);
            OpenRecipeButton.Name = "OpenRecipeButton";
            OpenRecipeButton.Size = new Size(75, 26);
            OpenRecipeButton.TabIndex = 10;
            OpenRecipeButton.Text = "打开";
            OpenRecipeButton.UseVisualStyleBackColor = true;
            OpenRecipeButton.Click += OpenRecipeButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(9, 94);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 26);
            SaveButton.TabIndex = 11;
            SaveButton.Text = "保存";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RecipeCountLabel);
            groupBox1.Controls.Add(DeleteButton);
            groupBox1.Controls.Add(NewRecipeButton);
            groupBox1.Controls.Add(SaveButton);
            groupBox1.Controls.Add(OpenRecipeButton);
            groupBox1.Location = new Point(12, 382);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(135, 190);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "操作";
            // 
            // RecipeCountLabel
            // 
            RecipeCountLabel.AutoSize = true;
            RecipeCountLabel.Location = new Point(9, 156);
            RecipeCountLabel.Name = "RecipeCountLabel";
            RecipeCountLabel.Size = new Size(63, 17);
            RecipeCountLabel.TabIndex = 13;
            RecipeCountLabel.Text = "配方总计: ";
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(9, 125);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 26);
            DeleteButton.TabIndex = 12;
            DeleteButton.Text = "删除";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // RecipeInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 586);
            Controls.Add(groupBox1);
            Controls.Add(IngredientsGroupBox);
            Controls.Add(ToolsGroupBox);
            Controls.Add(RecipeGroupBox);
            Controls.Add(RecipeList);
            Name = "RecipeInfoForm";
            Text = "合成配方";
            FormClosing += RecipeInfoForm_FormClosing;
            Load += RecipeInfoForm_Load;
            RecipeGroupBox.ResumeLayout(false);
            RecipeGroupBox.PerformLayout();
            ToolsGroupBox.ResumeLayout(false);
            ToolsGroupBox.PerformLayout();
            IngredientsGroupBox.ResumeLayout(false);
            IngredientsGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox RecipeList;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox RecipeGroupBox;
        private GroupBox ToolsGroupBox;
        private GroupBox IngredientsGroupBox;
        private Label label5;
        private TextBox IngredientAmount4TextBox;
        private TextBox IngredientAmount3TextBox;
        private TextBox IngredientAmount2TextBox;
        private TextBox IngredientAmount1TextBox;
        private Label label6;
        private TextBox GoldTextBox;
        private TextBox ChanceTextBox;
        private TextBox CraftAmountTextBox;
        private Label label7;
        private Button NewRecipeButton;
        private ComboBox ItemComboBox;
        private ComboBox Tool1ComboBox;
        private TextBox IngredientAmount6TextBox;
        private TextBox IngredientAmount5TextBox;
        private ComboBox IngredientName6ComboBox;
        private ComboBox IngredientName5ComboBox;
        private ComboBox IngredientName4ComboBox;
        private ComboBox IngredientName3ComboBox;
        private ComboBox IngredientName2ComboBox;
        private ComboBox IngredientName1ComboBox;
        private Button OpenRecipeButton;
        private TextBox IngredientDura6TextBox;
        private TextBox IngredientDura5TextBox;
        private Label label8;
        private TextBox IngredientDura4TextBox;
        private TextBox IngredientDura3TextBox;
        private TextBox IngredientDura2TextBox;
        private TextBox IngredientDura1TextBox;
        private Button SaveButton;
        private ComboBox Tool3ComboBox;
        private ComboBox Tool2ComboBox;
        private GroupBox groupBox1;
        private Button DeleteButton;
        private Label RecipeCountLabel;
    }
}