
namespace WindowsForms
{
    partial class ECForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.SaveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.EquipmentTpyeBox = new System.Windows.Forms.ComboBox();
            this.EquipmentTypeText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RarityBox = new System.Windows.Forms.ComboBox();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.宗门ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.绿ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.蓝ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.天地灵宝ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.先天ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.后天ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WuXingText = new System.Windows.Forms.Label();
            this.WuXingBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EqJichuBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EqGuYouBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EqYangchengBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EqYangchengBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EqYangchengBox3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EqYangchengBox4 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.JC_Number = new System.Windows.Forms.TextBox();
            this.GY_Number = new System.Windows.Forms.TextBox();
            this.YC_Number1 = new System.Windows.Forms.TextBox();
            this.YC_Number2 = new System.Windows.Forms.TextBox();
            this.YC_Number3 = new System.Windows.Forms.TextBox();
            this.YC_Number4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ValueNumber = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(236, 468);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(151, 21);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(79, 468);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(151, 21);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(399, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(39, 21);
            this.toolStripMenuItem1.Text = "File";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.readToolStripMenuItem.Text = "Read";
            this.readToolStripMenuItem.Click += new System.EventHandler(this.readToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // EquipmentTpyeBox
            // 
            this.EquipmentTpyeBox.FormattingEnabled = true;
            this.EquipmentTpyeBox.Items.AddRange(new object[] {
            "武器",
            "防具",
            "饰品"});
            this.EquipmentTpyeBox.Location = new System.Drawing.Point(109, 60);
            this.EquipmentTpyeBox.Name = "EquipmentTpyeBox";
            this.EquipmentTpyeBox.Size = new System.Drawing.Size(121, 20);
            this.EquipmentTpyeBox.TabIndex = 3;
            this.EquipmentTpyeBox.Text = "武器";
            this.EquipmentTpyeBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // EquipmentTypeText
            // 
            this.EquipmentTypeText.AutoSize = true;
            this.EquipmentTypeText.Location = new System.Drawing.Point(12, 63);
            this.EquipmentTypeText.Name = "EquipmentTypeText";
            this.EquipmentTypeText.Size = new System.Drawing.Size(83, 12);
            this.EquipmentTypeText.TabIndex = 4;
            this.EquipmentTypeText.Text = "EquipmentType";
            this.EquipmentTypeText.Click += new System.EventHandler(this.EquipmentTypeText_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rarity";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RarityBox
            // 
            this.RarityBox.FormattingEnabled = true;
            this.RarityBox.Items.AddRange(new object[] {
            "灰",
            "白",
            "绿",
            "蓝",
            "紫",
            "橙",
            "红",
            "真红"});
            this.RarityBox.Location = new System.Drawing.Point(109, 86);
            this.RarityBox.Name = "RarityBox";
            this.RarityBox.Size = new System.Drawing.Size(121, 20);
            this.RarityBox.TabIndex = 5;
            this.RarityBox.Text = "灰";
            this.RarityBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.宗门ToolStripMenuItem,
            this.天地灵宝ToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // 宗门ToolStripMenuItem
            // 
            this.宗门ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.绿ToolStripMenuItem,
            this.蓝ToolStripMenuItem});
            this.宗门ToolStripMenuItem.Name = "宗门ToolStripMenuItem";
            this.宗门ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.宗门ToolStripMenuItem.Text = "宗门制式装备";
            this.宗门ToolStripMenuItem.Click += new System.EventHandler(this.宗门ToolStripMenuItem_Click);
            // 
            // 绿ToolStripMenuItem
            // 
            this.绿ToolStripMenuItem.Name = "绿ToolStripMenuItem";
            this.绿ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.绿ToolStripMenuItem.Text = "绿";
            // 
            // 蓝ToolStripMenuItem
            // 
            this.蓝ToolStripMenuItem.Name = "蓝ToolStripMenuItem";
            this.蓝ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.蓝ToolStripMenuItem.Text = "蓝";
            // 
            // 天地灵宝ToolStripMenuItem
            // 
            this.天地灵宝ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.先天ToolStripMenuItem,
            this.后天ToolStripMenuItem});
            this.天地灵宝ToolStripMenuItem.Name = "天地灵宝ToolStripMenuItem";
            this.天地灵宝ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.天地灵宝ToolStripMenuItem.Text = "天地灵宝";
            // 
            // 先天ToolStripMenuItem
            // 
            this.先天ToolStripMenuItem.Name = "先天ToolStripMenuItem";
            this.先天ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.先天ToolStripMenuItem.Text = "先天";
            // 
            // 后天ToolStripMenuItem
            // 
            this.后天ToolStripMenuItem.Name = "后天ToolStripMenuItem";
            this.后天ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.后天ToolStripMenuItem.Text = "后天";
            // 
            // WuXingText
            // 
            this.WuXingText.AutoSize = true;
            this.WuXingText.Location = new System.Drawing.Point(12, 115);
            this.WuXingText.Name = "WuXingText";
            this.WuXingText.Size = new System.Drawing.Size(41, 12);
            this.WuXingText.TabIndex = 8;
            this.WuXingText.Text = "WuXing";
            // 
            // WuXingBox
            // 
            this.WuXingBox.FormattingEnabled = true;
            this.WuXingBox.Items.AddRange(new object[] {
            "金",
            "水",
            "木",
            "火",
            "土"});
            this.WuXingBox.Location = new System.Drawing.Point(109, 112);
            this.WuXingBox.Name = "WuXingBox";
            this.WuXingBox.Size = new System.Drawing.Size(121, 20);
            this.WuXingBox.TabIndex = 7;
            this.WuXingBox.Text = "金";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "基础";
            // 
            // EqJichuBox
            // 
            this.EqJichuBox.FormattingEnabled = true;
            this.EqJichuBox.Items.AddRange(new object[] {
            "金",
            "水",
            "木",
            "火",
            "土"});
            this.EqJichuBox.Location = new System.Drawing.Point(109, 138);
            this.EqJichuBox.Name = "EqJichuBox";
            this.EqJichuBox.Size = new System.Drawing.Size(121, 20);
            this.EqJichuBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "固有";
            // 
            // EqGuYouBox
            // 
            this.EqGuYouBox.FormattingEnabled = true;
            this.EqGuYouBox.Items.AddRange(new object[] {
            "金",
            "水",
            "木",
            "火",
            "土"});
            this.EqGuYouBox.Location = new System.Drawing.Point(109, 164);
            this.EqGuYouBox.Name = "EqGuYouBox";
            this.EqGuYouBox.Size = new System.Drawing.Size(121, 20);
            this.EqGuYouBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "养成1";
            // 
            // EqYangchengBox1
            // 
            this.EqYangchengBox1.FormattingEnabled = true;
            this.EqYangchengBox1.Items.AddRange(new object[] {
            "金",
            "水",
            "木",
            "火",
            "土"});
            this.EqYangchengBox1.Location = new System.Drawing.Point(109, 190);
            this.EqYangchengBox1.Name = "EqYangchengBox1";
            this.EqYangchengBox1.Size = new System.Drawing.Size(121, 20);
            this.EqYangchengBox1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "养成2";
            // 
            // EqYangchengBox2
            // 
            this.EqYangchengBox2.FormattingEnabled = true;
            this.EqYangchengBox2.Items.AddRange(new object[] {
            "金",
            "水",
            "木",
            "火",
            "土"});
            this.EqYangchengBox2.Location = new System.Drawing.Point(109, 216);
            this.EqYangchengBox2.Name = "EqYangchengBox2";
            this.EqYangchengBox2.Size = new System.Drawing.Size(121, 20);
            this.EqYangchengBox2.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "养成3";
            // 
            // EqYangchengBox3
            // 
            this.EqYangchengBox3.FormattingEnabled = true;
            this.EqYangchengBox3.Items.AddRange(new object[] {
            "金",
            "水",
            "木",
            "火",
            "土"});
            this.EqYangchengBox3.Location = new System.Drawing.Point(109, 242);
            this.EqYangchengBox3.Name = "EqYangchengBox3";
            this.EqYangchengBox3.Size = new System.Drawing.Size(121, 20);
            this.EqYangchengBox3.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "养成4";
            // 
            // EqYangchengBox4
            // 
            this.EqYangchengBox4.FormattingEnabled = true;
            this.EqYangchengBox4.Items.AddRange(new object[] {
            "金",
            "水",
            "木",
            "火",
            "土"});
            this.EqYangchengBox4.Location = new System.Drawing.Point(109, 268);
            this.EqYangchengBox4.Name = "EqYangchengBox4";
            this.EqYangchengBox4.Size = new System.Drawing.Size(121, 20);
            this.EqYangchengBox4.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 12);
            this.label9.TabIndex = 22;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "Description";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(109, 300);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(258, 113);
            this.richTextBox1.TabIndex = 24;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 21);
            this.textBox1.TabIndex = 25;
            // 
            // JC_Number
            // 
            this.JC_Number.Location = new System.Drawing.Point(236, 137);
            this.JC_Number.Name = "JC_Number";
            this.JC_Number.Size = new System.Drawing.Size(121, 21);
            this.JC_Number.TabIndex = 26;
            this.JC_Number.Text = "99";
            // 
            // GY_Number
            // 
            this.GY_Number.Location = new System.Drawing.Point(236, 163);
            this.GY_Number.Name = "GY_Number";
            this.GY_Number.Size = new System.Drawing.Size(121, 21);
            this.GY_Number.TabIndex = 27;
            this.GY_Number.Text = "99";
            // 
            // YC_Number1
            // 
            this.YC_Number1.Location = new System.Drawing.Point(236, 190);
            this.YC_Number1.Name = "YC_Number1";
            this.YC_Number1.Size = new System.Drawing.Size(121, 21);
            this.YC_Number1.TabIndex = 28;
            this.YC_Number1.Text = "99";
            // 
            // YC_Number2
            // 
            this.YC_Number2.Location = new System.Drawing.Point(236, 217);
            this.YC_Number2.Name = "YC_Number2";
            this.YC_Number2.Size = new System.Drawing.Size(121, 21);
            this.YC_Number2.TabIndex = 29;
            this.YC_Number2.Text = "99";
            // 
            // YC_Number3
            // 
            this.YC_Number3.Location = new System.Drawing.Point(236, 242);
            this.YC_Number3.Name = "YC_Number3";
            this.YC_Number3.Size = new System.Drawing.Size(121, 21);
            this.YC_Number3.TabIndex = 30;
            this.YC_Number3.Text = "99";
            // 
            // YC_Number4
            // 
            this.YC_Number4.Location = new System.Drawing.Point(236, 267);
            this.YC_Number4.Name = "YC_Number4";
            this.YC_Number4.Size = new System.Drawing.Size(121, 21);
            this.YC_Number4.TabIndex = 31;
            this.YC_Number4.Text = "99";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 439);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 12);
            this.label11.TabIndex = 32;
            this.label11.Text = "value";
            // 
            // ValueNumber
            // 
            this.ValueNumber.Location = new System.Drawing.Point(109, 436);
            this.ValueNumber.Name = "ValueNumber";
            this.ValueNumber.Size = new System.Drawing.Size(121, 21);
            this.ValueNumber.TabIndex = 33;
            this.ValueNumber.Text = "99";
            // 
            // ECForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 501);
            this.Controls.Add(this.ValueNumber);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.YC_Number4);
            this.Controls.Add(this.YC_Number3);
            this.Controls.Add(this.YC_Number2);
            this.Controls.Add(this.YC_Number1);
            this.Controls.Add(this.GY_Number);
            this.Controls.Add(this.JC_Number);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EqYangchengBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EqYangchengBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EqYangchengBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EqYangchengBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EqGuYouBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EqJichuBox);
            this.Controls.Add(this.WuXingText);
            this.Controls.Add(this.WuXingBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RarityBox);
            this.Controls.Add(this.EquipmentTypeText);
            this.Controls.Add(this.EquipmentTpyeBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ECForm";
            this.Text = "EquipmentCreater";
            this.Load += new System.EventHandler(this.EquipmentCreater_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox EquipmentTpyeBox;
        private System.Windows.Forms.Label EquipmentTypeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RarityBox;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 宗门ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 绿ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 蓝ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 天地灵宝ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 先天ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 后天ToolStripMenuItem;
        private System.Windows.Forms.Label WuXingText;
        private System.Windows.Forms.ComboBox WuXingBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox EqJichuBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox EqGuYouBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox EqYangchengBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox EqYangchengBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox EqYangchengBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox EqYangchengBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox JC_Number;
        private System.Windows.Forms.TextBox GY_Number;
        private System.Windows.Forms.TextBox YC_Number1;
        private System.Windows.Forms.TextBox YC_Number2;
        private System.Windows.Forms.TextBox YC_Number3;
        private System.Windows.Forms.TextBox YC_Number4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ValueNumber;
    }
}

