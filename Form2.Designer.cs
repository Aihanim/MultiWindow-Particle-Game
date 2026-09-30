namespace WindowsFormsApp12
{
    partial class Form2
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
            this.groupBoxCount = new System.Windows.Forms.GroupBox();
            this.radioCount30 = new System.Windows.Forms.RadioButton();
            this.radioCount60 = new System.Windows.Forms.RadioButton();
            this.radioCount90 = new System.Windows.Forms.RadioButton();
            this.groupBoxSize = new System.Windows.Forms.GroupBox();
            this.radioSize10 = new System.Windows.Forms.RadioButton();
            this.radioSize15 = new System.Windows.Forms.RadioButton();
            this.radioSize20 = new System.Windows.Forms.RadioButton();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.panelWinColor = new System.Windows.Forms.Panel();
            this.panelLoseColor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonWinColor = new System.Windows.Forms.Button();
            this.buttonLoseColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxCount.SuspendLayout();
            this.groupBoxSize.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCount
            // 
            this.groupBoxCount.Controls.Add(this.radioCount90);
            this.groupBoxCount.Controls.Add(this.radioCount60);
            this.groupBoxCount.Controls.Add(this.radioCount30);
            this.groupBoxCount.Location = new System.Drawing.Point(369, 28);
            this.groupBoxCount.Name = "groupBoxCount";
            this.groupBoxCount.Size = new System.Drawing.Size(160, 249);
            this.groupBoxCount.TabIndex = 0;
            this.groupBoxCount.TabStop = false;
            this.groupBoxCount.Text = "Количество частиц";
            // 
            // radioCount30
            // 
            this.radioCount30.AutoSize = true;
            this.radioCount30.Location = new System.Drawing.Point(23, 36);
            this.radioCount30.Name = "radioCount30";
            this.radioCount30.Size = new System.Drawing.Size(37, 17);
            this.radioCount30.TabIndex = 0;
            this.radioCount30.TabStop = true;
            this.radioCount30.Text = "30";
            this.radioCount30.UseVisualStyleBackColor = true;
            // 
            // radioCount60
            // 
            this.radioCount60.AutoSize = true;
            this.radioCount60.Location = new System.Drawing.Point(23, 103);
            this.radioCount60.Name = "radioCount60";
            this.radioCount60.Size = new System.Drawing.Size(37, 17);
            this.radioCount60.TabIndex = 1;
            this.radioCount60.TabStop = true;
            this.radioCount60.Text = "60";
            this.radioCount60.UseVisualStyleBackColor = true;
            // 
            // radioCount90
            // 
            this.radioCount90.AutoSize = true;
            this.radioCount90.Location = new System.Drawing.Point(23, 173);
            this.radioCount90.Name = "radioCount90";
            this.radioCount90.Size = new System.Drawing.Size(37, 17);
            this.radioCount90.TabIndex = 2;
            this.radioCount90.TabStop = true;
            this.radioCount90.Text = "90";
            this.radioCount90.UseVisualStyleBackColor = true;
            // 
            // groupBoxSize
            // 
            this.groupBoxSize.Controls.Add(this.radioSize20);
            this.groupBoxSize.Controls.Add(this.radioSize15);
            this.groupBoxSize.Controls.Add(this.radioSize10);
            this.groupBoxSize.Location = new System.Drawing.Point(548, 28);
            this.groupBoxSize.Name = "groupBoxSize";
            this.groupBoxSize.Size = new System.Drawing.Size(159, 249);
            this.groupBoxSize.TabIndex = 1;
            this.groupBoxSize.TabStop = false;
            this.groupBoxSize.Text = "Размер частиц";
            // 
            // radioSize10
            // 
            this.radioSize10.AutoSize = true;
            this.radioSize10.Location = new System.Drawing.Point(7, 36);
            this.radioSize10.Name = "radioSize10";
            this.radioSize10.Size = new System.Drawing.Size(64, 17);
            this.radioSize10.TabIndex = 0;
            this.radioSize10.TabStop = true;
            this.radioSize10.Text = "10 пикс";
            this.radioSize10.UseVisualStyleBackColor = true;
            // 
            // radioSize15
            // 
            this.radioSize15.AutoSize = true;
            this.radioSize15.Location = new System.Drawing.Point(7, 103);
            this.radioSize15.Name = "radioSize15";
            this.radioSize15.Size = new System.Drawing.Size(64, 17);
            this.radioSize15.TabIndex = 1;
            this.radioSize15.TabStop = true;
            this.radioSize15.Text = "15 пикс";
            this.radioSize15.UseVisualStyleBackColor = true;
            // 
            // radioSize20
            // 
            this.radioSize20.AutoSize = true;
            this.radioSize20.Location = new System.Drawing.Point(7, 173);
            this.radioSize20.Name = "radioSize20";
            this.radioSize20.Size = new System.Drawing.Size(64, 17);
            this.radioSize20.TabIndex = 2;
            this.radioSize20.TabStop = true;
            this.radioSize20.Text = "20 пикс";
            this.radioSize20.UseVisualStyleBackColor = true;
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.buttonLoseColor);
            this.groupBoxColor.Controls.Add(this.buttonWinColor);
            this.groupBoxColor.Controls.Add(this.label2);
            this.groupBoxColor.Controls.Add(this.label1);
            this.groupBoxColor.Controls.Add(this.panelLoseColor);
            this.groupBoxColor.Controls.Add(this.panelWinColor);
            this.groupBoxColor.Location = new System.Drawing.Point(38, 28);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(281, 287);
            this.groupBoxColor.TabIndex = 2;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Цвета";
            // 
            // panelWinColor
            // 
            this.panelWinColor.Location = new System.Drawing.Point(32, 56);
            this.panelWinColor.Name = "panelWinColor";
            this.panelWinColor.Size = new System.Drawing.Size(97, 77);
            this.panelWinColor.TabIndex = 0;
            // 
            // panelLoseColor
            // 
            this.panelLoseColor.Location = new System.Drawing.Point(32, 190);
            this.panelLoseColor.Name = "panelLoseColor";
            this.panelLoseColor.Size = new System.Drawing.Size(97, 80);
            this.panelLoseColor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "выигрышный цвет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "проигрышный цвет";
            // 
            // buttonWinColor
            // 
            this.buttonWinColor.Location = new System.Drawing.Point(156, 89);
            this.buttonWinColor.Name = "buttonWinColor";
            this.buttonWinColor.Size = new System.Drawing.Size(75, 23);
            this.buttonWinColor.TabIndex = 4;
            this.buttonWinColor.Text = "Изменить";
            this.buttonWinColor.UseVisualStyleBackColor = true;
            // 
            // buttonLoseColor
            // 
            this.buttonLoseColor.Location = new System.Drawing.Point(156, 217);
            this.buttonLoseColor.Name = "buttonLoseColor";
            this.buttonLoseColor.Size = new System.Drawing.Size(75, 23);
            this.buttonLoseColor.TabIndex = 5;
            this.buttonLoseColor.Text = "Изменить";
            this.buttonLoseColor.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(54, 351);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(144, 351);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.groupBoxSize);
            this.Controls.Add(this.groupBoxCount);
            this.Name = "Form2";
            this.Text = "Настройки игры";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBoxCount.ResumeLayout(false);
            this.groupBoxCount.PerformLayout();
            this.groupBoxSize.ResumeLayout(false);
            this.groupBoxSize.PerformLayout();
            this.groupBoxColor.ResumeLayout(false);
            this.groupBoxColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCount;
        private System.Windows.Forms.RadioButton radioCount90;
        private System.Windows.Forms.RadioButton radioCount60;
        private System.Windows.Forms.RadioButton radioCount30;
        private System.Windows.Forms.GroupBox groupBoxSize;
        private System.Windows.Forms.RadioButton radioSize20;
        private System.Windows.Forms.RadioButton radioSize15;
        private System.Windows.Forms.RadioButton radioSize10;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Button buttonLoseColor;
        private System.Windows.Forms.Button buttonWinColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLoseColor;
        private System.Windows.Forms.Panel panelWinColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}