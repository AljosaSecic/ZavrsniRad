
namespace ZavrsniRad
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.Od0do10 = new System.Windows.Forms.Button();
            this.od10do20 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Savet = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RESET = new System.Windows.Forms.Button();
            this.Savet.SuspendLayout();
            this.SuspendLayout();
            // 
            // Od0do10
            // 
            this.Od0do10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Od0do10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Od0do10.Location = new System.Drawing.Point(147, 173);
            this.Od0do10.Name = "Od0do10";
            this.Od0do10.Size = new System.Drawing.Size(75, 23);
            this.Od0do10.TabIndex = 0;
            this.Od0do10.Text = "Pre 2010";
            this.Od0do10.UseVisualStyleBackColor = false;
            this.Od0do10.Click += new System.EventHandler(this.button1_Click);
            // 
            // od10do20
            // 
            this.od10do20.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.od10do20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.od10do20.Location = new System.Drawing.Point(266, 173);
            this.od10do20.Name = "od10do20";
            this.od10do20.Size = new System.Drawing.Size(75, 23);
            this.od10do20.TabIndex = 1;
            this.od10do20.Text = "Posle 2010";
            this.od10do20.UseVisualStyleBackColor = false;
            this.od10do20.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Iz kojeg perioda želite da je igrica?";
            // 
            // Savet
            // 
            this.Savet.BackColor = System.Drawing.Color.Transparent;
            this.Savet.Controls.Add(this.label4);
            this.Savet.Controls.Add(this.label3);
            this.Savet.Controls.Add(this.label2);
            this.Savet.ForeColor = System.Drawing.Color.White;
            this.Savet.Location = new System.Drawing.Point(99, 270);
            this.Savet.Name = "Savet";
            this.Savet.Size = new System.Drawing.Size(295, 118);
            this.Savet.TabIndex = 6;
            this.Savet.TabStop = false;
            this.Savet.Text = "Savet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "biće igrice pre 2010 godine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "A onaj koji voli takozvane \"old school\" igrice bolja varijanta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Neko ko voli modernije igrice neka izabere \"Posle 2010\"";
            // 
            // RESET
            // 
            this.RESET.BackColor = System.Drawing.Color.Red;
            this.RESET.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RESET.Location = new System.Drawing.Point(400, 327);
            this.RESET.Name = "RESET";
            this.RESET.Size = new System.Drawing.Size(75, 23);
            this.RESET.TabIndex = 21;
            this.RESET.Text = "RESET";
            this.RESET.UseVisualStyleBackColor = false;
            this.RESET.Click += new System.EventHandler(this.RESET_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.RESET);
            this.Controls.Add(this.Savet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.od10do20);
            this.Controls.Add(this.Od0do10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mysting Gaming";
            this.Savet.ResumeLayout(false);
            this.Savet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Od0do10;
        private System.Windows.Forms.Button od10do20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Savet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RESET;
    }
}