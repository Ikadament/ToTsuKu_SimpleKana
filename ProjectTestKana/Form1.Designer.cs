
namespace ProjectTestKana
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnMenu = new System.Windows.Forms.Button();
            this.txtKana = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.grpNote = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNote2 = new System.Windows.Forms.TextBox();
            this.txtNote1 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblOmedeto = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpTestKana = new System.Windows.Forms.GroupBox();
            this.grpNote.SuspendLayout();
            this.grpTestKana.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(6, 19);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "MENU";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // txtKana
            // 
            this.txtKana.AutoSize = true;
            this.txtKana.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKana.Location = new System.Drawing.Point(73, 54);
            this.txtKana.Name = "txtKana";
            this.txtKana.Size = new System.Drawing.Size(143, 111);
            this.txtKana.TabIndex = 1;
            this.txtKana.Text = "あ";
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(78, 170);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(126, 38);
            this.txtResult.TabIndex = 2;
            this.txtResult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResult_KeyPress);
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(210, 170);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEnter.Size = new System.Drawing.Size(67, 38);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "↵";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // grpNote
            // 
            this.grpNote.Controls.Add(this.label1);
            this.grpNote.Controls.Add(this.txtNote2);
            this.grpNote.Controls.Add(this.txtNote1);
            this.grpNote.Location = new System.Drawing.Point(6, 236);
            this.grpNote.Name = "grpNote";
            this.grpNote.Size = new System.Drawing.Size(271, 74);
            this.grpNote.TabIndex = 4;
            this.grpNote.TabStop = false;
            this.grpNote.Text = "Note";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(120, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "/";
            // 
            // txtNote2
            // 
            this.txtNote2.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtNote2.Location = new System.Drawing.Point(157, 19);
            this.txtNote2.Name = "txtNote2";
            this.txtNote2.Size = new System.Drawing.Size(108, 41);
            this.txtNote2.TabIndex = 1;
            // 
            // txtNote1
            // 
            this.txtNote1.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtNote1.Location = new System.Drawing.Point(6, 19);
            this.txtNote1.Name = "txtNote1";
            this.txtNote1.Size = new System.Drawing.Size(108, 41);
            this.txtNote1.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblResult.Location = new System.Drawing.Point(9, 172);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(60, 37);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "lbl";
            // 
            // lblOmedeto
            // 
            this.lblOmedeto.AutoSize = true;
            this.lblOmedeto.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblOmedeto.Location = new System.Drawing.Point(82, 16);
            this.lblOmedeto.Name = "lblOmedeto";
            this.lblOmedeto.Size = new System.Drawing.Size(132, 28);
            this.lblOmedeto.TabIndex = 7;
            this.lblOmedeto.Text = "おめでとう！";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(210, 11);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(67, 39);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Refaire le test";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grpTestKana
            // 
            this.grpTestKana.Controls.Add(this.btnReset);
            this.grpTestKana.Controls.Add(this.lblOmedeto);
            this.grpTestKana.Controls.Add(this.lblResult);
            this.grpTestKana.Controls.Add(this.grpNote);
            this.grpTestKana.Controls.Add(this.btnEnter);
            this.grpTestKana.Controls.Add(this.txtResult);
            this.grpTestKana.Controls.Add(this.txtKana);
            this.grpTestKana.Controls.Add(this.btnMenu);
            this.grpTestKana.Location = new System.Drawing.Point(12, 12);
            this.grpTestKana.Name = "grpTestKana";
            this.grpTestKana.Size = new System.Drawing.Size(283, 316);
            this.grpTestKana.TabIndex = 0;
            this.grpTestKana.TabStop = false;
            this.grpTestKana.Text = "Test Hiragana";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 336);
            this.Controls.Add(this.grpTestKana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ToTsuKu - SimpleKana";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpNote.ResumeLayout(false);
            this.grpNote.PerformLayout();
            this.grpTestKana.ResumeLayout(false);
            this.grpTestKana.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label txtKana;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.GroupBox grpNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNote2;
        private System.Windows.Forms.TextBox txtNote1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblOmedeto;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpTestKana;
    }
}

