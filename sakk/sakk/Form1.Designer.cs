
namespace sakk
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.jatekos1TBOX = new System.Windows.Forms.TextBox();
            this.jatekos2TBOX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startBTN = new System.Windows.Forms.Button();
            this.babuk = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // jatekos1TBOX
            // 
            this.jatekos1TBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jatekos1TBOX.Location = new System.Drawing.Point(198, 94);
            this.jatekos1TBOX.Name = "jatekos1TBOX";
            this.jatekos1TBOX.Size = new System.Drawing.Size(127, 26);
            this.jatekos1TBOX.TabIndex = 0;
            // 
            // jatekos2TBOX
            // 
            this.jatekos2TBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jatekos2TBOX.Location = new System.Drawing.Point(198, 140);
            this.jatekos2TBOX.Name = "jatekos2TBOX";
            this.jatekos2TBOX.Size = new System.Drawing.Size(127, 26);
            this.jatekos2TBOX.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(94, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(94, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Player2:";
            // 
            // startBTN
            // 
            this.startBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startBTN.Location = new System.Drawing.Point(355, 295);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(143, 76);
            this.startBTN.TabIndex = 5;
            this.startBTN.Text = "Játék indítása";
            this.startBTN.UseVisualStyleBackColor = true;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // babuk
            // 
            this.babuk.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("babuk.ImageStream")));
            this.babuk.TransparentColor = System.Drawing.Color.Transparent;
            this.babuk.Images.SetKeyName(0, "feher_bastya.png");
            this.babuk.Images.SetKeyName(1, "feher_futo.png");
            this.babuk.Images.SetKeyName(2, "feher_kiraly.png");
            this.babuk.Images.SetKeyName(3, "feher_kiralyno.png");
            this.babuk.Images.SetKeyName(4, "feher_lo.png");
            this.babuk.Images.SetKeyName(5, "feher_paraszt.png");
            this.babuk.Images.SetKeyName(6, "fekete_bastya.png");
            this.babuk.Images.SetKeyName(7, "fekete_futo.png");
            this.babuk.Images.SetKeyName(8, "fekete_kiraly.png");
            this.babuk.Images.SetKeyName(9, "fekete_kiralyno.png");
            this.babuk.Images.SetKeyName(10, "fekete_lo.png");
            this.babuk.Images.SetKeyName(11, "fekete_paraszt.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jatekos2TBOX);
            this.Controls.Add(this.jatekos1TBOX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox jatekos1TBOX;
        private System.Windows.Forms.TextBox jatekos2TBOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.ImageList babuk;
    }
}

