﻿namespace TesteTecnico2023.Forms
{

    partial class AddVehicle
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWheels = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKMs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFuel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(324, 65);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(53, 16);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "Modelo";
            // 
            // txtModelName
            // 
            this.txtModelName.Location = new System.Drawing.Point(385, 63);
            this.txtModelName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(205, 22);
            this.txtModelName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Marca";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(81, 64);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(132, 22);
            this.txtModel.TabIndex = 1;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(81, 26);
            this.cmbType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(160, 24);
            this.cmbType.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(407, 165);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 28);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rodas";
            // 
            // txtWheels
            // 
            this.txtWheels.Location = new System.Drawing.Point(81, 97);
            this.txtWheels.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWheels.Name = "txtWheels";
            this.txtWheels.Size = new System.Drawing.Size(71, 22);
            this.txtWheels.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "KM por litro";
            // 
            // txtKMs
            // 
            this.txtKMs.Location = new System.Drawing.Point(521, 97);
            this.txtKMs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKMs.Name = "txtKMs";
            this.txtKMs.Size = new System.Drawing.Size(71, 22);
            this.txtKMs.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Peso suportado (KG)";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(328, 97);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(83, 22);
            this.txtWeight.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Combutível";
            // 
            // cmbFuel
            // 
            this.cmbFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuel.FormattingEnabled = true;
            this.cmbFuel.Location = new System.Drawing.Point(385, 26);
            this.cmbFuel.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFuel.Name = "cmbFuel";
            this.cmbFuel.Size = new System.Drawing.Size(160, 24);
            this.cmbFuel.TabIndex = 16;
            // 
            // AddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 249);
            this.Controls.Add(this.cmbFuel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKMs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWheels);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtModelName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddVehicle";
            this.Text = "AddVehicle";
            this.Load += new System.EventHandler(this.AddVehicle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWheels;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKMs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFuel;
    }
}