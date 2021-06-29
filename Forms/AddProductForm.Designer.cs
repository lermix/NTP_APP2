namespace NTP_Ivo_Ojvan
{
    partial class AddProductForm
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
            this.tboxId = new System.Windows.Forms.TextBox();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.btnSelectExisting = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblPriceTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // tboxId
            // 
            this.tboxId.Location = new System.Drawing.Point(77, 12);
            this.tboxId.Name = "tboxId";
            this.tboxId.Size = new System.Drawing.Size(153, 22);
            this.tboxId.TabIndex = 2;
            // 
            // tBoxName
            // 
            this.tBoxName.Location = new System.Drawing.Point(77, 44);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(153, 22);
            this.tBoxName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Brand:";
            // 
            // tboxPrice
            // 
            this.tboxPrice.Location = new System.Drawing.Point(77, 113);
            this.tboxPrice.Name = "tboxPrice";
            this.tboxPrice.Size = new System.Drawing.Size(153, 22);
            this.tboxPrice.TabIndex = 8;
            this.tboxPrice.TextChanged += new System.EventHandler(this.tboxPrice_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price:";
            // 
            // cmbBrand
            // 
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(77, 74);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(153, 24);
            this.cmbBrand.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(116, 166);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 16;
            this.listBoxProducts.Location = new System.Drawing.Point(529, 41);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(259, 388);
            this.listBoxProducts.TabIndex = 11;
            this.listBoxProducts.Visible = false;
            this.listBoxProducts.SelectedValueChanged += new System.EventHandler(this.listBoxProducts_SelectedValueChanged);
            // 
            // btnSelectExisting
            // 
            this.btnSelectExisting.Location = new System.Drawing.Point(644, 6);
            this.btnSelectExisting.Name = "btnSelectExisting";
            this.btnSelectExisting.Size = new System.Drawing.Size(144, 23);
            this.btnSelectExisting.TabIndex = 12;
            this.btnSelectExisting.Text = "Odaberi postojeci";
            this.btnSelectExisting.UseVisualStyleBackColor = true;
            this.btnSelectExisting.Click += new System.EventHandler(this.btnSelectExisting_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(116, 237);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Zamjeni";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(116, 309);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Obriši";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblPriceTxt
            // 
            this.lblPriceTxt.AutoSize = true;
            this.lblPriceTxt.Location = new System.Drawing.Point(236, 118);
            this.lblPriceTxt.Name = "lblPriceTxt";
            this.lblPriceTxt.Size = new System.Drawing.Size(0, 17);
            this.lblPriceTxt.TabIndex = 16;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPriceTxt);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSelectExisting);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.tboxPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxId);
            this.Controls.Add(this.label1);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxId;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Button btnSelectExisting;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblPriceTxt;
    }
}