namespace BMS_Final
{
    partial class BMS_Home
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
            this.ButtonCatagory = new System.Windows.Forms.Button();
            this.ButtonProduct = new System.Windows.Forms.Button();
            this.ButtonCustomer = new System.Windows.Forms.Button();
            this.ButtonSupplier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonCatagory
            // 
            this.ButtonCatagory.Location = new System.Drawing.Point(204, 89);
            this.ButtonCatagory.Name = "ButtonCatagory";
            this.ButtonCatagory.Size = new System.Drawing.Size(352, 31);
            this.ButtonCatagory.TabIndex = 0;
            this.ButtonCatagory.Text = "Product Catalog Module (Category)";
            this.ButtonCatagory.UseVisualStyleBackColor = true;
            // 
            // ButtonProduct
            // 
            this.ButtonProduct.Location = new System.Drawing.Point(204, 151);
            this.ButtonProduct.Name = "ButtonProduct";
            this.ButtonProduct.Size = new System.Drawing.Size(352, 31);
            this.ButtonProduct.TabIndex = 0;
            this.ButtonProduct.Text = "Product Catalog Module (Product)";
            this.ButtonProduct.UseVisualStyleBackColor = true;
            // 
            // ButtonCustomer
            // 
            this.ButtonCustomer.Location = new System.Drawing.Point(204, 220);
            this.ButtonCustomer.Name = "ButtonCustomer";
            this.ButtonCustomer.Size = new System.Drawing.Size(352, 31);
            this.ButtonCustomer.TabIndex = 0;
            this.ButtonCustomer.Text = "Party Module (Customer)";
            this.ButtonCustomer.UseVisualStyleBackColor = true;
            // 
            // ButtonSupplier
            // 
            this.ButtonSupplier.Location = new System.Drawing.Point(204, 288);
            this.ButtonSupplier.Name = "ButtonSupplier";
            this.ButtonSupplier.Size = new System.Drawing.Size(352, 31);
            this.ButtonSupplier.TabIndex = 0;
            this.ButtonSupplier.Text = "Party Module (Supplier)";
            this.ButtonSupplier.UseVisualStyleBackColor = true;
            // 
            // BMS_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonSupplier);
            this.Controls.Add(this.ButtonCustomer);
            this.Controls.Add(this.ButtonProduct);
            this.Controls.Add(this.ButtonCatagory);
            this.Name = "BMS_Home";
            this.Text = "BMS_Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonCatagory;
        private System.Windows.Forms.Button ButtonProduct;
        private System.Windows.Forms.Button ButtonCustomer;
        private System.Windows.Forms.Button ButtonSupplier;
    }
}