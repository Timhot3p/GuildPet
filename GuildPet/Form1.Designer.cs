﻿namespace GuildPet
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
            this.showPets = new System.Windows.Forms.Button();
            this.petInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hydraHeads = new System.Windows.Forms.TextBox();
            this.hydraText = new System.Windows.Forms.Label();
            this.playersText = new System.Windows.Forms.Label();
            this.playersInput = new System.Windows.Forms.TextBox();
            this.simulate = new System.Windows.Forms.Button();
            this.strOutput1 = new System.Windows.Forms.TextBox();
            this.dexOutput1 = new System.Windows.Forms.TextBox();
            this.intOutput1 = new System.Windows.Forms.TextBox();
            this.intOutput2 = new System.Windows.Forms.TextBox();
            this.dexOutput2 = new System.Windows.Forms.TextBox();
            this.strOutput2 = new System.Windows.Forms.TextBox();
            this.intOutput3 = new System.Windows.Forms.TextBox();
            this.dexOutput3 = new System.Windows.Forms.TextBox();
            this.strOutput3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.iterationsInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(187, 21);
            this.input.MaxLength = 100000;
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(704, 67);
            this.input.TabIndex = 1;
            // 
            // showPets
            // 
            this.showPets.Location = new System.Drawing.Point(197, 148);
            this.showPets.Name = "showPets";
            this.showPets.Size = new System.Drawing.Size(98, 23);
            this.showPets.TabIndex = 5;
            this.showPets.Text = "Show Pets";
            this.showPets.UseVisualStyleBackColor = true;
            this.showPets.Click += new System.EventHandler(this.calcPet_Click);
            // 
            // petInput
            // 
            this.petInput.Location = new System.Drawing.Point(321, 131);
            this.petInput.Multiline = true;
            this.petInput.Name = "petInput";
            this.petInput.Size = new System.Drawing.Size(570, 50);
            this.petInput.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(240, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Strength";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(493, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Dexterity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(746, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Intelligence";
            // 
            // hydraHeads
            // 
            this.hydraHeads.Location = new System.Drawing.Point(102, 253);
            this.hydraHeads.Name = "hydraHeads";
            this.hydraHeads.Size = new System.Drawing.Size(39, 23);
            this.hydraHeads.TabIndex = 16;
            this.hydraHeads.Text = "18";
            // 
            // hydraText
            // 
            this.hydraText.AutoSize = true;
            this.hydraText.Location = new System.Drawing.Point(25, 256);
            this.hydraText.Name = "hydraText";
            this.hydraText.Size = new System.Drawing.Size(58, 15);
            this.hydraText.TabIndex = 17;
            this.hydraText.Text = "Hydra Nr.";
            // 
            // playersText
            // 
            this.playersText.AutoSize = true;
            this.playersText.Location = new System.Drawing.Point(29, 299);
            this.playersText.Name = "playersText";
            this.playersText.Size = new System.Drawing.Size(44, 15);
            this.playersText.TabIndex = 18;
            this.playersText.Text = "Players";
            // 
            // playersInput
            // 
            this.playersInput.Location = new System.Drawing.Point(102, 296);
            this.playersInput.Name = "playersInput";
            this.playersInput.Size = new System.Drawing.Size(39, 23);
            this.playersInput.TabIndex = 19;
            this.playersInput.Text = "50";
            // 
            // simulate
            // 
            this.simulate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.simulate.Location = new System.Drawing.Point(421, 256);
            this.simulate.Name = "simulate";
            this.simulate.Size = new System.Drawing.Size(214, 44);
            this.simulate.TabIndex = 20;
            this.simulate.Text = "Simulate";
            this.simulate.UseVisualStyleBackColor = true;
            this.simulate.Click += new System.EventHandler(this.simulate_Click);
            // 
            // strOutput1
            // 
            this.strOutput1.Location = new System.Drawing.Point(228, 398);
            this.strOutput1.Name = "strOutput1";
            this.strOutput1.Size = new System.Drawing.Size(100, 23);
            this.strOutput1.TabIndex = 21;
            // 
            // dexOutput1
            // 
            this.dexOutput1.Location = new System.Drawing.Point(484, 398);
            this.dexOutput1.Name = "dexOutput1";
            this.dexOutput1.Size = new System.Drawing.Size(100, 23);
            this.dexOutput1.TabIndex = 22;
            // 
            // intOutput1
            // 
            this.intOutput1.Location = new System.Drawing.Point(735, 398);
            this.intOutput1.Name = "intOutput1";
            this.intOutput1.Size = new System.Drawing.Size(100, 23);
            this.intOutput1.TabIndex = 23;
            // 
            // intOutput2
            // 
            this.intOutput2.Location = new System.Drawing.Point(735, 447);
            this.intOutput2.Name = "intOutput2";
            this.intOutput2.Size = new System.Drawing.Size(100, 23);
            this.intOutput2.TabIndex = 26;
            // 
            // dexOutput2
            // 
            this.dexOutput2.Location = new System.Drawing.Point(484, 447);
            this.dexOutput2.Name = "dexOutput2";
            this.dexOutput2.Size = new System.Drawing.Size(100, 23);
            this.dexOutput2.TabIndex = 25;
            // 
            // strOutput2
            // 
            this.strOutput2.Location = new System.Drawing.Point(228, 447);
            this.strOutput2.Name = "strOutput2";
            this.strOutput2.Size = new System.Drawing.Size(100, 23);
            this.strOutput2.TabIndex = 24;
            // 
            // intOutput3
            // 
            this.intOutput3.Location = new System.Drawing.Point(735, 502);
            this.intOutput3.Name = "intOutput3";
            this.intOutput3.Size = new System.Drawing.Size(100, 23);
            this.intOutput3.TabIndex = 29;
            // 
            // dexOutput3
            // 
            this.dexOutput3.Location = new System.Drawing.Point(484, 502);
            this.dexOutput3.Name = "dexOutput3";
            this.dexOutput3.Size = new System.Drawing.Size(100, 23);
            this.dexOutput3.TabIndex = 28;
            // 
            // strOutput3
            // 
            this.strOutput3.Location = new System.Drawing.Point(228, 502);
            this.strOutput3.Name = "strOutput3";
            this.strOutput3.Size = new System.Drawing.Size(100, 23);
            this.strOutput3.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Winrate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Average Rest Hp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 510);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Players Needed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "Iterations";
            // 
            // iterationsInput
            // 
            this.iterationsInput.Location = new System.Drawing.Point(102, 342);
            this.iterationsInput.Name = "iterationsInput";
            this.iterationsInput.Size = new System.Drawing.Size(39, 23);
            this.iterationsInput.TabIndex = 34;
            this.iterationsInput.Text = "100";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(95, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 21);
            this.label8.TabIndex = 35;
            this.label8.Text = "Input";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 537);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.iterationsInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.intOutput3);
            this.Controls.Add(this.dexOutput3);
            this.Controls.Add(this.strOutput3);
            this.Controls.Add(this.intOutput2);
            this.Controls.Add(this.dexOutput2);
            this.Controls.Add(this.strOutput2);
            this.Controls.Add(this.intOutput1);
            this.Controls.Add(this.dexOutput1);
            this.Controls.Add(this.strOutput1);
            this.Controls.Add(this.simulate);
            this.Controls.Add(this.playersInput);
            this.Controls.Add(this.playersText);
            this.Controls.Add(this.hydraText);
            this.Controls.Add(this.hydraHeads);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.petInput);
            this.Controls.Add(this.showPets);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "Hydra Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox input;
        private Button showPets;
        private TextBox petInput;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox hydraHeads;
        private Label hydraText;
        private Label playersText;
        private TextBox playersInput;
        private Button simulate;
        private TextBox strOutput1;
        private TextBox dexOutput1;
        private TextBox intOutput1;
        private TextBox intOutput2;
        private TextBox dexOutput2;
        private TextBox strOutput2;
        private TextBox intOutput3;
        private TextBox dexOutput3;
        private TextBox strOutput3;
        private Label label1;
        private Label label2;
        private Label label6;
        private Label label7;
        private TextBox iterationsInput;
        private Label label8;
    }
}