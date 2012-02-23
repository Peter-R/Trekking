namespace Trekkingen
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
            this.btToonInfo = new System.Windows.Forms.Button();
            this.tbAantalGewenst = new System.Windows.Forms.TextBox();
            this.tbMaximaleWaarde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btMaakTrekkingObject = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btTrekEnToonAlles = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.btTrekVolgendGetal = new System.Windows.Forms.Button();
            this.btAfsluiten = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btToonInfo
            // 
            this.btToonInfo.Location = new System.Drawing.Point(108, 135);
            this.btToonInfo.Name = "btToonInfo";
            this.btToonInfo.Size = new System.Drawing.Size(140, 23);
            this.btToonInfo.TabIndex = 0;
            this.btToonInfo.Text = "Toon info";
            this.btToonInfo.UseVisualStyleBackColor = true;
            this.btToonInfo.Click += new System.EventHandler(this.btToonInfo_Click);
            // 
            // tbAantalGewenst
            // 
            this.tbAantalGewenst.Location = new System.Drawing.Point(104, 22);
            this.tbAantalGewenst.Name = "tbAantalGewenst";
            this.tbAantalGewenst.Size = new System.Drawing.Size(100, 20);
            this.tbAantalGewenst.TabIndex = 1;
            // 
            // tbMaximaleWaarde
            // 
            this.tbMaximaleWaarde.Location = new System.Drawing.Point(104, 48);
            this.tbMaximaleWaarde.Name = "tbMaximaleWaarde";
            this.tbMaximaleWaarde.Size = new System.Drawing.Size(100, 20);
            this.tbMaximaleWaarde.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aantal gewenst:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Maximale waarde:";
            // 
            // btMaakTrekkingObject
            // 
            this.btMaakTrekkingObject.Location = new System.Drawing.Point(236, 20);
            this.btMaakTrekkingObject.Name = "btMaakTrekkingObject";
            this.btMaakTrekkingObject.Size = new System.Drawing.Size(140, 23);
            this.btMaakTrekkingObject.TabIndex = 5;
            this.btMaakTrekkingObject.Text = "Maak een trekking-object";
            this.btMaakTrekkingObject.UseVisualStyleBackColor = true;
            this.btMaakTrekkingObject.Click += new System.EventHandler(this.btMaakTrekkingObject_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btTrekEnToonAlles);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btTrekVolgendGetal);
            this.groupBox1.Controls.Add(this.btMaakTrekkingObject);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbAantalGewenst);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbMaximaleWaarde);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 293);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trekking";
            // 
            // btTrekEnToonAlles
            // 
            this.btTrekEnToonAlles.Location = new System.Drawing.Point(236, 80);
            this.btTrekEnToonAlles.Name = "btTrekEnToonAlles";
            this.btTrekEnToonAlles.Size = new System.Drawing.Size(140, 23);
            this.btTrekEnToonAlles.TabIndex = 8;
            this.btTrekEnToonAlles.Text = "Trek en toon alle getallen";
            this.btTrekEnToonAlles.UseVisualStyleBackColor = true;
            this.btTrekEnToonAlles.Click += new System.EventHandler(this.btTrekEnToonAlles_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbInfo);
            this.groupBox2.Controls.Add(this.btToonInfo);
            this.groupBox2.Location = new System.Drawing.Point(9, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 164);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(6, 20);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInfo.Size = new System.Drawing.Size(355, 109);
            this.tbInfo.TabIndex = 1;
            // 
            // btTrekVolgendGetal
            // 
            this.btTrekVolgendGetal.Location = new System.Drawing.Point(236, 51);
            this.btTrekVolgendGetal.Name = "btTrekVolgendGetal";
            this.btTrekVolgendGetal.Size = new System.Drawing.Size(140, 23);
            this.btTrekVolgendGetal.TabIndex = 6;
            this.btTrekVolgendGetal.Text = "Trek volgend getal";
            this.btTrekVolgendGetal.UseVisualStyleBackColor = true;
            this.btTrekVolgendGetal.Click += new System.EventHandler(this.btTrekVolgendGetal_Click);
            // 
            // btAfsluiten
            // 
            this.btAfsluiten.Location = new System.Drawing.Point(313, 311);
            this.btAfsluiten.Name = "btAfsluiten";
            this.btAfsluiten.Size = new System.Drawing.Size(75, 23);
            this.btAfsluiten.TabIndex = 8;
            this.btAfsluiten.Text = "Afsluiten";
            this.btAfsluiten.UseVisualStyleBackColor = true;
            this.btAfsluiten.Click += new System.EventHandler(this.btAfsluiten_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 340);
            this.Controls.Add(this.btAfsluiten);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Trekkingen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btToonInfo;
        private System.Windows.Forms.TextBox tbAantalGewenst;
        private System.Windows.Forms.TextBox tbMaximaleWaarde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btMaakTrekkingObject;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btTrekVolgendGetal;
        private System.Windows.Forms.Button btAfsluiten;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Button btTrekEnToonAlles;
    }
}

