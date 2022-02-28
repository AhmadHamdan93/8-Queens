namespace chess
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
            this.button1 = new System.Windows.Forms.Button();
            this.first_btn = new System.Windows.Forms.Button();
            this.pri_btn = new System.Windows.Forms.Button();
            this.last_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_total_sol = new System.Windows.Forms.Label();
            this.label_id_sol = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(52, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Find Solution";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // first_btn
            // 
            this.first_btn.Enabled = false;
            this.first_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_btn.Location = new System.Drawing.Point(278, 27);
            this.first_btn.Name = "first_btn";
            this.first_btn.Size = new System.Drawing.Size(50, 23);
            this.first_btn.TabIndex = 4;
            this.first_btn.Tag = "4";
            this.first_btn.Text = "<<";
            this.first_btn.UseVisualStyleBackColor = true;
            this.first_btn.Click += new System.EventHandler(this.change_solution);
            // 
            // pri_btn
            // 
            this.pri_btn.Enabled = false;
            this.pri_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pri_btn.Location = new System.Drawing.Point(366, 27);
            this.pri_btn.Name = "pri_btn";
            this.pri_btn.Size = new System.Drawing.Size(50, 23);
            this.pri_btn.TabIndex = 4;
            this.pri_btn.Tag = "2";
            this.pri_btn.Text = "<";
            this.pri_btn.UseVisualStyleBackColor = true;
            this.pri_btn.Click += new System.EventHandler(this.change_solution);
            // 
            // last_btn
            // 
            this.last_btn.Enabled = false;
            this.last_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_btn.Location = new System.Drawing.Point(719, 27);
            this.last_btn.Name = "last_btn";
            this.last_btn.Size = new System.Drawing.Size(50, 23);
            this.last_btn.TabIndex = 4;
            this.last_btn.Tag = "3";
            this.last_btn.Text = ">>";
            this.last_btn.UseVisualStyleBackColor = true;
            this.last_btn.Click += new System.EventHandler(this.change_solution);
            // 
            // next_btn
            // 
            this.next_btn.Enabled = false;
            this.next_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_btn.Location = new System.Drawing.Point(631, 27);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(50, 23);
            this.next_btn.TabIndex = 4;
            this.next_btn.Tag = "1";
            this.next_btn.Text = ">";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.change_solution);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(513, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "/";
            // 
            // label_total_sol
            // 
            this.label_total_sol.AutoSize = true;
            this.label_total_sol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total_sol.Location = new System.Drawing.Point(572, 26);
            this.label_total_sol.Name = "label_total_sol";
            this.label_total_sol.Size = new System.Drawing.Size(21, 24);
            this.label_total_sol.TabIndex = 2;
            this.label_total_sol.Text = "0";
            // 
            // label_id_sol
            // 
            this.label_id_sol.AutoSize = true;
            this.label_id_sol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id_sol.Location = new System.Drawing.Point(454, 26);
            this.label_id_sol.Name = "label_id_sol";
            this.label_id_sol.Size = new System.Drawing.Size(21, 24);
            this.label_id_sol.TabIndex = 1;
            this.label_id_sol.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(823, 549);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 634);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_total_sol);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.label_id_sol);
            this.Controls.Add(this.pri_btn);
            this.Controls.Add(this.first_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.last_btn);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Queen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_total_sol;
        private System.Windows.Forms.Label label_id_sol;
        private System.Windows.Forms.Button first_btn;
        private System.Windows.Forms.Button pri_btn;
        private System.Windows.Forms.Button last_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

