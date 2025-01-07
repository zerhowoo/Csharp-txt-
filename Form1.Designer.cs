namespace Csharp_读取txt练习
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(102, 81);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(90, 28);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "车机盖";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += CarHood_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(102, 145);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(108, 28);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "车右后门";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += CarRightDoor_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(102, 201);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += SeeHowManyYvalue_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button button1;
    }
}
