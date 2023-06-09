namespace iPhone_calculater
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
            ACbutton = new Button();
            PMbutton = new Button();
            PObutton = new Button();
            DIVbutton = new Button();
            SEbutton = new Button();
            Hbutton = new Button();
            Nbutton = new Button();
            MULbutton = new Button();
            Fbutton = new Button();
            FAbutton = new Button();
            SIbutton = new Button();
            MINbutton = new Button();
            Obutton = new Button();
            Tbutton = new Button();
            THbutton = new Button();
            ADDbutton = new Button();
            Zbutton = new Button();
            Pbutton = new Button();
            EQbutton = new Button();
            result = new Label();
            SuspendLayout();
            // 
            // ACbutton
            // 
            ACbutton.BackColor = SystemColors.ActiveBorder;
            ACbutton.FlatAppearance.BorderSize = 0;
            ACbutton.FlatStyle = FlatStyle.Flat;
            ACbutton.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ACbutton.Location = new Point(12, 218);
            ACbutton.Name = "ACbutton";
            ACbutton.Size = new Size(56, 49);
            ACbutton.TabIndex = 0;
            ACbutton.Text = "AC";
            ACbutton.UseVisualStyleBackColor = false;
            ACbutton.Click += btnClear_Click;
            // 
            // PMbutton
            // 
            PMbutton.BackColor = SystemColors.ActiveBorder;
            PMbutton.FlatAppearance.BorderSize = 0;
            PMbutton.FlatStyle = FlatStyle.Flat;
            PMbutton.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PMbutton.Location = new Point(74, 218);
            PMbutton.Name = "PMbutton";
            PMbutton.Size = new Size(56, 49);
            PMbutton.TabIndex = 1;
            PMbutton.Text = "+/-";
            PMbutton.UseVisualStyleBackColor = false;
            // 
            // PObutton
            // 
            PObutton.BackColor = SystemColors.ActiveBorder;
            PObutton.FlatAppearance.BorderSize = 0;
            PObutton.FlatStyle = FlatStyle.Flat;
            PObutton.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PObutton.Location = new Point(136, 218);
            PObutton.Name = "PObutton";
            PObutton.Size = new Size(56, 49);
            PObutton.TabIndex = 2;
            PObutton.Text = "%";
            PObutton.UseVisualStyleBackColor = false;
            // 
            // DIVbutton
            // 
            DIVbutton.BackColor = Color.Orange;
            DIVbutton.FlatAppearance.BorderSize = 0;
            DIVbutton.FlatStyle = FlatStyle.Flat;
            DIVbutton.Font = new Font("Arial", 22F, FontStyle.Regular, GraphicsUnit.Point);
            DIVbutton.ForeColor = SystemColors.ControlLightLight;
            DIVbutton.Location = new Point(199, 218);
            DIVbutton.Name = "DIVbutton";
            DIVbutton.Size = new Size(55, 49);
            DIVbutton.TabIndex = 3;
            DIVbutton.Text = "÷";
            DIVbutton.UseVisualStyleBackColor = false;
            DIVbutton.Click += btnDiv_Click;
            // 
            // SEbutton
            // 
            SEbutton.BackColor = SystemColors.ControlDarkDark;
            SEbutton.FlatAppearance.BorderSize = 0;
            SEbutton.FlatStyle = FlatStyle.Flat;
            SEbutton.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SEbutton.ForeColor = SystemColors.ButtonHighlight;
            SEbutton.Location = new Point(12, 273);
            SEbutton.Name = "SEbutton";
            SEbutton.Size = new Size(56, 49);
            SEbutton.TabIndex = 4;
            SEbutton.Text = "7";
            SEbutton.UseVisualStyleBackColor = false;
            SEbutton.Click += btn7_Click;
            // 
            // Hbutton
            // 
            Hbutton.BackColor = SystemColors.ControlDarkDark;
            Hbutton.FlatAppearance.BorderSize = 0;
            Hbutton.FlatStyle = FlatStyle.Flat;
            Hbutton.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Hbutton.ForeColor = SystemColors.ButtonHighlight;
            Hbutton.Location = new Point(74, 273);
            Hbutton.Name = "Hbutton";
            Hbutton.Size = new Size(56, 49);
            Hbutton.TabIndex = 5;
            Hbutton.Text = "8";
            Hbutton.UseVisualStyleBackColor = false;
            Hbutton.Click += btn8_Click;
            // 
            // Nbutton
            // 
            Nbutton.BackColor = SystemColors.ControlDarkDark;
            Nbutton.FlatAppearance.BorderSize = 0;
            Nbutton.FlatStyle = FlatStyle.Flat;
            Nbutton.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Nbutton.ForeColor = SystemColors.ButtonHighlight;
            Nbutton.Location = new Point(136, 273);
            Nbutton.Name = "Nbutton";
            Nbutton.Size = new Size(56, 49);
            Nbutton.TabIndex = 6;
            Nbutton.Text = "9";
            Nbutton.UseVisualStyleBackColor = false;
            Nbutton.Click += btn9_Click;
            // 
            // MULbutton
            // 
            MULbutton.BackColor = Color.Orange;
            MULbutton.FlatAppearance.BorderSize = 0;
            MULbutton.FlatStyle = FlatStyle.Flat;
            MULbutton.Font = new Font("Arial", 15.5F, FontStyle.Bold, GraphicsUnit.Point);
            MULbutton.ForeColor = SystemColors.ControlLightLight;
            MULbutton.Location = new Point(198, 273);
            MULbutton.Name = "MULbutton";
            MULbutton.Size = new Size(55, 49);
            MULbutton.TabIndex = 7;
            MULbutton.Text = "x";
            MULbutton.UseVisualStyleBackColor = false;
            MULbutton.Click += btnMul_Click;
            // 
            // Fbutton
            // 
            Fbutton.BackColor = SystemColors.ControlDarkDark;
            Fbutton.FlatAppearance.BorderSize = 0;
            Fbutton.FlatStyle = FlatStyle.Flat;
            Fbutton.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Fbutton.ForeColor = SystemColors.ButtonHighlight;
            Fbutton.Location = new Point(12, 328);
            Fbutton.Name = "Fbutton";
            Fbutton.Size = new Size(56, 49);
            Fbutton.TabIndex = 8;
            Fbutton.Text = "4";
            Fbutton.UseVisualStyleBackColor = false;
            Fbutton.Click += btn4_Click;
            // 
            // FAbutton
            // 
            FAbutton.BackColor = SystemColors.ControlDarkDark;
            FAbutton.FlatAppearance.BorderSize = 0;
            FAbutton.FlatStyle = FlatStyle.Flat;
            FAbutton.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            FAbutton.ForeColor = SystemColors.ButtonHighlight;
            FAbutton.Location = new Point(74, 328);
            FAbutton.Name = "FAbutton";
            FAbutton.Size = new Size(56, 49);
            FAbutton.TabIndex = 9;
            FAbutton.Text = "5";
            FAbutton.UseVisualStyleBackColor = false;
            FAbutton.Click += btn5_Click;
            // 
            // SIbutton
            // 
            SIbutton.BackColor = SystemColors.ControlDarkDark;
            SIbutton.FlatAppearance.BorderSize = 0;
            SIbutton.FlatStyle = FlatStyle.Flat;
            SIbutton.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SIbutton.ForeColor = SystemColors.ButtonHighlight;
            SIbutton.Location = new Point(136, 328);
            SIbutton.Name = "SIbutton";
            SIbutton.Size = new Size(56, 49);
            SIbutton.TabIndex = 10;
            SIbutton.Text = "6";
            SIbutton.UseVisualStyleBackColor = false;
            SIbutton.Click += btn6_Click;
            // 
            // MINbutton
            // 
            MINbutton.BackColor = Color.Orange;
            MINbutton.FlatAppearance.BorderSize = 0;
            MINbutton.FlatStyle = FlatStyle.Flat;
            MINbutton.Font = new Font("Arial", 30F, FontStyle.Regular, GraphicsUnit.Point);
            MINbutton.ForeColor = SystemColors.ControlLightLight;
            MINbutton.Location = new Point(198, 328);
            MINbutton.Name = "MINbutton";
            MINbutton.Size = new Size(55, 49);
            MINbutton.TabIndex = 11;
            MINbutton.Text = "-";
            MINbutton.TextAlign = ContentAlignment.BottomCenter;
            MINbutton.UseVisualStyleBackColor = false;
            MINbutton.Click += btnMin_Click;
            // 
            // Obutton
            // 
            Obutton.BackColor = SystemColors.ControlDarkDark;
            Obutton.FlatAppearance.BorderSize = 0;
            Obutton.FlatStyle = FlatStyle.Flat;
            Obutton.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Obutton.ForeColor = SystemColors.ButtonHighlight;
            Obutton.Location = new Point(12, 383);
            Obutton.Name = "Obutton";
            Obutton.Size = new Size(56, 49);
            Obutton.TabIndex = 12;
            Obutton.Text = "1";
            Obutton.UseVisualStyleBackColor = false;
            Obutton.Click += btn1_Click;
            // 
            // Tbutton
            // 
            Tbutton.BackColor = SystemColors.ControlDarkDark;
            Tbutton.FlatAppearance.BorderSize = 0;
            Tbutton.FlatStyle = FlatStyle.Flat;
            Tbutton.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Tbutton.ForeColor = SystemColors.ButtonHighlight;
            Tbutton.Location = new Point(74, 383);
            Tbutton.Name = "Tbutton";
            Tbutton.Size = new Size(56, 49);
            Tbutton.TabIndex = 13;
            Tbutton.Text = "2";
            Tbutton.UseVisualStyleBackColor = false;
            Tbutton.Click += btn2_Click;
            // 
            // THbutton
            // 
            THbutton.BackColor = SystemColors.ControlDarkDark;
            THbutton.FlatAppearance.BorderSize = 0;
            THbutton.FlatStyle = FlatStyle.Flat;
            THbutton.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            THbutton.ForeColor = SystemColors.ButtonHighlight;
            THbutton.Location = new Point(138, 383);
            THbutton.Name = "THbutton";
            THbutton.Size = new Size(54, 49);
            THbutton.TabIndex = 14;
            THbutton.Text = "3";
            THbutton.UseVisualStyleBackColor = false;
            THbutton.Click += btn3_Click;
            // 
            // ADDbutton
            // 
            ADDbutton.BackColor = Color.Orange;
            ADDbutton.FlatAppearance.BorderSize = 0;
            ADDbutton.FlatStyle = FlatStyle.Flat;
            ADDbutton.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            ADDbutton.ForeColor = SystemColors.ControlLightLight;
            ADDbutton.Location = new Point(199, 383);
            ADDbutton.Name = "ADDbutton";
            ADDbutton.Size = new Size(55, 49);
            ADDbutton.TabIndex = 15;
            ADDbutton.Text = "+";
            ADDbutton.UseVisualStyleBackColor = false;
            ADDbutton.Click += btnPlus_Click;
            // 
            // Zbutton
            // 
            Zbutton.BackColor = SystemColors.ControlDarkDark;
            Zbutton.FlatAppearance.BorderSize = 0;
            Zbutton.FlatStyle = FlatStyle.Flat;
            Zbutton.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Zbutton.ForeColor = SystemColors.ButtonHighlight;
            Zbutton.Location = new Point(12, 438);
            Zbutton.Name = "Zbutton";
            Zbutton.Size = new Size(120, 48);
            Zbutton.TabIndex = 16;
            Zbutton.Text = "0";
            Zbutton.UseVisualStyleBackColor = false;
            Zbutton.Click += btn0_Click;
            // 
            // Pbutton
            // 
            Pbutton.BackColor = SystemColors.ControlDarkDark;
            Pbutton.FlatAppearance.BorderSize = 0;
            Pbutton.FlatStyle = FlatStyle.Flat;
            Pbutton.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Pbutton.ForeColor = SystemColors.ButtonHighlight;
            Pbutton.Location = new Point(138, 438);
            Pbutton.Name = "Pbutton";
            Pbutton.Size = new Size(54, 48);
            Pbutton.TabIndex = 17;
            Pbutton.Text = ",\r\n";
            Pbutton.UseVisualStyleBackColor = false;
            // 
            // EQbutton
            // 
            EQbutton.BackColor = Color.Orange;
            EQbutton.FlatAppearance.BorderSize = 0;
            EQbutton.FlatStyle = FlatStyle.Flat;
            EQbutton.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            EQbutton.ForeColor = SystemColors.ControlLightLight;
            EQbutton.Location = new Point(199, 439);
            EQbutton.Name = "EQbutton";
            EQbutton.Size = new Size(55, 48);
            EQbutton.TabIndex = 18;
            EQbutton.Text = "=";
            EQbutton.UseVisualStyleBackColor = false;
            EQbutton.Click += EQQbutton_Click;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("Arial", 39.75F, FontStyle.Bold, GraphicsUnit.Point);
            result.ForeColor = Color.White;
            result.Location = new Point(12, 125);
            result.Name = "result";
            result.Size = new Size(0, 62);
            result.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(266, 500);
            Controls.Add(result);
            Controls.Add(EQbutton);
            Controls.Add(Pbutton);
            Controls.Add(Zbutton);
            Controls.Add(ADDbutton);
            Controls.Add(THbutton);
            Controls.Add(Tbutton);
            Controls.Add(Obutton);
            Controls.Add(MINbutton);
            Controls.Add(SIbutton);
            Controls.Add(FAbutton);
            Controls.Add(Fbutton);
            Controls.Add(MULbutton);
            Controls.Add(Nbutton);
            Controls.Add(Hbutton);
            Controls.Add(SEbutton);
            Controls.Add(DIVbutton);
            Controls.Add(PObutton);
            Controls.Add(PMbutton);
            Controls.Add(ACbutton);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "appel calculater";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ACbutton;
        private Button PMbutton;
        private Button PObutton;
        private Button DIVbutton;
        private Button SEbutton;
        private Button Hbutton;
        private Button Nbutton;
        private Button MULbutton;
        private Button Fbutton;
        private Button FAbutton;
        private Button SIbutton;
        private Button MINbutton;
        private Button Obutton;
        private Button Tbutton;
        private Button THbutton;
        private Button ADDbutton;
        private Button Zbutton;
        private Button Pbutton;
        private Button EQbutton;
        private Label result;
    }
}