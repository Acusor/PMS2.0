namespace PMS2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanelMedicamente = new System.Windows.Forms.FlowLayoutPanel();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtProducator = new System.Windows.Forms.TextBox();
            this.nudPret = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCantitate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPret)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMedicamente
            // 
            this.flowLayoutPanelMedicamente.BackColor = System.Drawing.Color.Lime;
            this.flowLayoutPanelMedicamente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanelMedicamente.BackgroundImage")));
            this.flowLayoutPanelMedicamente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanelMedicamente.Location = new System.Drawing.Point(209, 50);
            this.flowLayoutPanelMedicamente.Name = "flowLayoutPanelMedicamente";
            this.flowLayoutPanelMedicamente.Size = new System.Drawing.Size(579, 269);
            this.flowLayoutPanelMedicamente.TabIndex = 0;
            this.flowLayoutPanelMedicamente.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelMedicamente_Paint);
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(44, 50);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(100, 22);
            this.txtNume.TabIndex = 2;
            this.txtNume.TextChanged += new System.EventHandler(this.txtNume_TextChanged);
            // 
            // txtProducator
            // 
            this.txtProducator.Location = new System.Drawing.Point(44, 101);
            this.txtProducator.Name = "txtProducator";
            this.txtProducator.Size = new System.Drawing.Size(100, 22);
            this.txtProducator.TabIndex = 3;
            this.txtProducator.TextChanged += new System.EventHandler(this.txtProducator_TextChanged);
            // 
            // nudPret
            // 
            this.nudPret.Location = new System.Drawing.Point(39, 222);
            this.nudPret.Name = "nudPret";
            this.nudPret.Size = new System.Drawing.Size(120, 22);
            this.nudPret.TabIndex = 4;
            this.nudPret.ValueChanged += new System.EventHandler(this.nudPret_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(52, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Adauga";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtCantitate
            // 
            this.txtCantitate.Location = new System.Drawing.Point(44, 168);
            this.txtCantitate.Name = "txtCantitate";
            this.txtCantitate.Size = new System.Drawing.Size(100, 22);
            this.txtCantitate.TabIndex = 6;
            this.txtCantitate.TextChanged += new System.EventHandler(this.txtCantitate_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "ADAUGARE MEDICAMENTE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "TIP:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "PRODUCATOR:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "CANTITATE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "PRET:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantitate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nudPret);
            this.Controls.Add(this.txtProducator);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.flowLayoutPanelMedicamente);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudPret)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMedicamente;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtProducator;
        private System.Windows.Forms.NumericUpDown nudPret;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCantitate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

