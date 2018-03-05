namespace NieRAutomata_ChapterSelect_DebugMode_Unlocker
{
    partial class Form1
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonOpenSlot = new System.Windows.Forms.Button();
            this.cbDebugMode = new System.Windows.Forms.CheckBox();
            this.cbChapterSelectDebugRoom = new System.Windows.Forms.CheckBox();
            this.cbUnknown1 = new System.Windows.Forms.CheckBox();
            this.cbUnknown2 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(270, 148);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(8, 48);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(336, 32);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "4 bits stores the flags to enable Chapter Select/Debug Room and the Debug Mode, a" +
    "nd two other unknown states.";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(89, 12);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.ReadOnly = true;
            this.textBoxFilePath.Size = new System.Drawing.Size(255, 20);
            this.textBoxFilePath.TabIndex = 2;
            this.textBoxFilePath.Text = "No slot file loaded...";
            // 
            // buttonOpenSlot
            // 
            this.buttonOpenSlot.Location = new System.Drawing.Point(8, 10);
            this.buttonOpenSlot.Name = "buttonOpenSlot";
            this.buttonOpenSlot.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenSlot.TabIndex = 1;
            this.buttonOpenSlot.Text = "Open slot...";
            this.buttonOpenSlot.UseVisualStyleBackColor = true;
            this.buttonOpenSlot.Click += new System.EventHandler(this.buttonOpenSlot_Click);
            // 
            // cbDebugMode
            // 
            this.cbDebugMode.AutoSize = true;
            this.cbDebugMode.Enabled = false;
            this.cbDebugMode.Location = new System.Drawing.Point(8, 86);
            this.cbDebugMode.Name = "cbDebugMode";
            this.cbDebugMode.Size = new System.Drawing.Size(143, 17);
            this.cbDebugMode.TabIndex = 4;
            this.cbDebugMode.Text = "Debug Menu (RT+Back)";
            this.cbDebugMode.UseVisualStyleBackColor = true;
            // 
            // cbChapterSelectDebugRoom
            // 
            this.cbChapterSelectDebugRoom.AutoSize = true;
            this.cbChapterSelectDebugRoom.Enabled = false;
            this.cbChapterSelectDebugRoom.Location = new System.Drawing.Point(157, 86);
            this.cbChapterSelectDebugRoom.Name = "cbChapterSelectDebugRoom";
            this.cbChapterSelectDebugRoom.Size = new System.Drawing.Size(170, 17);
            this.cbChapterSelectDebugRoom.TabIndex = 5;
            this.cbChapterSelectDebugRoom.Text = "Chapter Select / Debug Room";
            this.cbChapterSelectDebugRoom.UseVisualStyleBackColor = true;
            // 
            // cbUnknown1
            // 
            this.cbUnknown1.AutoSize = true;
            this.cbUnknown1.Enabled = false;
            this.cbUnknown1.Location = new System.Drawing.Point(157, 109);
            this.cbUnknown1.Name = "cbUnknown1";
            this.cbUnknown1.Size = new System.Drawing.Size(88, 17);
            this.cbUnknown1.TabIndex = 7;
            this.cbUnknown1.Text = "Unknown #1";
            this.cbUnknown1.UseVisualStyleBackColor = true;
            // 
            // cbUnknown2
            // 
            this.cbUnknown2.AutoSize = true;
            this.cbUnknown2.Enabled = false;
            this.cbUnknown2.Location = new System.Drawing.Point(8, 109);
            this.cbUnknown2.Name = "cbUnknown2";
            this.cbUnknown2.Size = new System.Drawing.Size(88, 17);
            this.cbUnknown2.TabIndex = 6;
            this.cbUnknown2.Text = "Unknown #2";
            this.cbUnknown2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(8, 139);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(213, 32);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Enable all four states to be on the safe side, as this is what ending C/D does.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 181);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbUnknown2);
            this.Controls.Add(this.cbUnknown1);
            this.Controls.Add(this.cbChapterSelectDebugRoom);
            this.Controls.Add(this.cbDebugMode);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.buttonOpenSlot);
            this.Name = "Form1";
            this.Text = "NieR: Automata - Chapter Select + Debug Room/Menu Unlocker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonOpenSlot;
        private System.Windows.Forms.CheckBox cbDebugMode;
        private System.Windows.Forms.CheckBox cbChapterSelectDebugRoom;
        private System.Windows.Forms.CheckBox cbUnknown1;
        private System.Windows.Forms.CheckBox cbUnknown2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

