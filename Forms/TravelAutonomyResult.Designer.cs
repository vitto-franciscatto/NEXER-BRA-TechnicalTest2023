namespace TesteTecnico2023.Forms
{
    partial class TravelAutonomyResult
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
            this.labelType = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.labelBrand = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.labelCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(91, 43);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(35, 16);
            this.labelType.TabIndex = 0;
            this.labelType.Text = "Tipo";
            // 
            // tbType
            // 
            this.tbType.Enabled = false;
            this.tbType.Location = new System.Drawing.Point(154, 43);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(100, 22);
            this.tbType.TabIndex = 1;
            // 
            // tbBrand
            // 
            this.tbBrand.Enabled = false;
            this.tbBrand.Location = new System.Drawing.Point(154, 80);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(100, 22);
            this.tbBrand.TabIndex = 3;
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(91, 80);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(45, 16);
            this.labelBrand.TabIndex = 2;
            this.labelBrand.Text = "Marca";
            // 
            // tbModel
            // 
            this.tbModel.Enabled = false;
            this.tbModel.Location = new System.Drawing.Point(154, 119);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(100, 22);
            this.tbModel.TabIndex = 5;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(91, 119);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(53, 16);
            this.labelModel.TabIndex = 4;
            this.labelModel.Text = "Modelo";
            // 
            // tbCost
            // 
            this.tbCost.Enabled = false;
            this.tbCost.Location = new System.Drawing.Point(154, 157);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(100, 22);
            this.tbCost.TabIndex = 7;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(91, 157);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(41, 16);
            this.labelCost.TabIndex = 6;
            this.labelCost.Text = "Custo";
            // 
            // TravelCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 234);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.tbBrand);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.labelType);
            this.Name = "TravelCost";
            this.Text = "TravelAutonomyResult";
            this.Load += new System.EventHandler(this.LowerCostVehicle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label labelCost;
    }
}