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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
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
            this.btnToSale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tboxId
            // 
            resources.ApplyResources(this.tboxId, "tboxId");
            this.tboxId.Name = "tboxId";
            // 
            // tBoxName
            // 
            resources.ApplyResources(this.tBoxName, "tBoxName");
            this.tBoxName.Name = "tBoxName";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tboxPrice
            // 
            resources.ApplyResources(this.tboxPrice, "tboxPrice");
            this.tboxPrice.Name = "tboxPrice";
            this.tboxPrice.TextChanged += new System.EventHandler(this.tboxPrice_TextChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // cmbBrand
            // 
            this.cmbBrand.FormattingEnabled = true;
            resources.ApplyResources(this.cmbBrand, "cmbBrand");
            this.cmbBrand.Name = "cmbBrand";
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxProducts, "listBoxProducts");
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.SelectedValueChanged += new System.EventHandler(this.listBoxProducts_SelectedValueChanged);
            // 
            // btnSelectExisting
            // 
            resources.ApplyResources(this.btnSelectExisting, "btnSelectExisting");
            this.btnSelectExisting.Name = "btnSelectExisting";
            this.btnSelectExisting.UseVisualStyleBackColor = true;
            this.btnSelectExisting.Click += new System.EventHandler(this.btnSelectExisting_Click);
            // 
            // btnUpdate
            // 
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblPriceTxt
            // 
            resources.ApplyResources(this.lblPriceTxt, "lblPriceTxt");
            this.lblPriceTxt.Name = "lblPriceTxt";
            // 
            // btnToSale
            // 
            resources.ApplyResources(this.btnToSale, "btnToSale");
            this.btnToSale.Name = "btnToSale";
            this.btnToSale.UseVisualStyleBackColor = true;
            this.btnToSale.Click += new System.EventHandler(this.btnToSale_Click);
            // 
            // AddProductForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnToSale);
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
        private System.Windows.Forms.Button btnToSale;
    }
}