namespace GuildPet
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
            this.input = new System.Windows.Forms.TextBox();
            this.calcPet = new System.Windows.Forms.Button();
            this.petDexterity = new System.Windows.Forms.TextBox();
            this.petStrength = new System.Windows.Forms.TextBox();
            this.petIntelligence = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hydraHeads = new System.Windows.Forms.TextBox();
            this.hydraText = new System.Windows.Forms.Label();
            this.playersText = new System.Windows.Forms.Label();
            this.playersInput = new System.Windows.Forms.TextBox();
            this.simulate = new System.Windows.Forms.Button();
            this.strOutput = new System.Windows.Forms.TextBox();
            this.dexOutput = new System.Windows.Forms.TextBox();
            this.intOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(27, 21);
            this.input.MaxLength = 100000;
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(864, 84);
            this.input.TabIndex = 1;
            // 
            // calcPet
            // 
            this.calcPet.Location = new System.Drawing.Point(488, 127);
            this.calcPet.Name = "calcPet";
            this.calcPet.Size = new System.Drawing.Size(98, 23);
            this.calcPet.TabIndex = 5;
            this.calcPet.Text = "Pet ausrechnen";
            this.calcPet.UseVisualStyleBackColor = true;
            this.calcPet.Click += new System.EventHandler(this.calcPet_Click);
            // 
            // petDexterity
            // 
            this.petDexterity.Location = new System.Drawing.Point(423, 199);
            this.petDexterity.Multiline = true;
            this.petDexterity.Name = "petDexterity";
            this.petDexterity.Size = new System.Drawing.Size(214, 88);
            this.petDexterity.TabIndex = 6;
            // 
            // petStrength
            // 
            this.petStrength.Location = new System.Drawing.Point(186, 199);
            this.petStrength.Multiline = true;
            this.petStrength.Name = "petStrength";
            this.petStrength.Size = new System.Drawing.Size(192, 88);
            this.petStrength.TabIndex = 7;
            // 
            // petIntelligence
            // 
            this.petIntelligence.Location = new System.Drawing.Point(688, 199);
            this.petIntelligence.Multiline = true;
            this.petIntelligence.Name = "petIntelligence";
            this.petIntelligence.Size = new System.Drawing.Size(200, 88);
            this.petIntelligence.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Stärke";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Geschick";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(761, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Intelligenz";
            // 
            // hydraHeads
            // 
            this.hydraHeads.Location = new System.Drawing.Point(95, 301);
            this.hydraHeads.Name = "hydraHeads";
            this.hydraHeads.Size = new System.Drawing.Size(39, 23);
            this.hydraHeads.TabIndex = 16;
            // 
            // hydraText
            // 
            this.hydraText.AutoSize = true;
            this.hydraText.Location = new System.Drawing.Point(27, 304);
            this.hydraText.Name = "hydraText";
            this.hydraText.Size = new System.Drawing.Size(39, 15);
            this.hydraText.TabIndex = 17;
            this.hydraText.Text = "Hydra";
            // 
            // playersText
            // 
            this.playersText.AutoSize = true;
            this.playersText.Location = new System.Drawing.Point(22, 344);
            this.playersText.Name = "playersText";
            this.playersText.Size = new System.Drawing.Size(42, 15);
            this.playersText.TabIndex = 18;
            this.playersText.Text = "Spieler";
            // 
            // playersInput
            // 
            this.playersInput.Location = new System.Drawing.Point(95, 341);
            this.playersInput.Name = "playersInput";
            this.playersInput.Size = new System.Drawing.Size(39, 23);
            this.playersInput.TabIndex = 19;
            this.playersInput.Text = "50";
            // 
            // simulate
            // 
            this.simulate.Location = new System.Drawing.Point(7, 388);
            this.simulate.Name = "simulate";
            this.simulate.Size = new System.Drawing.Size(127, 23);
            this.simulate.TabIndex = 20;
            this.simulate.Text = "Simulieren";
            this.simulate.UseVisualStyleBackColor = true;
            this.simulate.Click += new System.EventHandler(this.simulate_Click);
            // 
            // strOutput
            // 
            this.strOutput.Location = new System.Drawing.Point(230, 388);
            this.strOutput.Name = "strOutput";
            this.strOutput.Size = new System.Drawing.Size(100, 23);
            this.strOutput.TabIndex = 21;
            // 
            // dexOutput
            // 
            this.dexOutput.Location = new System.Drawing.Point(486, 388);
            this.dexOutput.Name = "dexOutput";
            this.dexOutput.Size = new System.Drawing.Size(100, 23);
            this.dexOutput.TabIndex = 22;
            // 
            // intOutput
            // 
            this.intOutput.Location = new System.Drawing.Point(737, 388);
            this.intOutput.Name = "intOutput";
            this.intOutput.Size = new System.Drawing.Size(100, 23);
            this.intOutput.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 537);
            this.Controls.Add(this.intOutput);
            this.Controls.Add(this.dexOutput);
            this.Controls.Add(this.strOutput);
            this.Controls.Add(this.simulate);
            this.Controls.Add(this.playersInput);
            this.Controls.Add(this.playersText);
            this.Controls.Add(this.hydraText);
            this.Controls.Add(this.hydraHeads);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.petIntelligence);
            this.Controls.Add(this.petStrength);
            this.Controls.Add(this.petDexterity);
            this.Controls.Add(this.calcPet);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox input;
        private Button calcPet;
        private TextBox petDexterity;
        private TextBox petStrength;
        private TextBox petIntelligence;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox hydraHeads;
        private Label hydraText;
        private Label playersText;
        private TextBox playersInput;
        private Button simulate;
        private TextBox strOutput;
        private TextBox dexOutput;
        private TextBox intOutput;
    }
}