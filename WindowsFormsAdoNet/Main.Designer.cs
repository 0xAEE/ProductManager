
namespace WindowsFormsAdoNet
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgw_prodList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_valueId = new System.Windows.Forms.Label();
            this.txtBox_prodStock = new System.Windows.Forms.TextBox();
            this.txtBox_prodPrice = new System.Windows.Forms.TextBox();
            this.txtBox_prodName = new System.Windows.Forms.TextBox();
            this.label_prodStock = new System.Windows.Forms.Label();
            this.label_prodName = new System.Windows.Forms.Label();
            this.label_prodPrice = new System.Windows.Forms.Label();
            this.label_prodId = new System.Windows.Forms.Label();
            this.btn_prodAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_modValueId = new System.Windows.Forms.Label();
            this.txtBox_modStock = new System.Windows.Forms.TextBox();
            this.txtBox_modPrice = new System.Windows.Forms.TextBox();
            this.txtBox_modName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.label_total = new System.Windows.Forms.Label();
            this.label_valueTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_prodList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw_prodList
            // 
            this.dgw_prodList.AllowUserToAddRows = false;
            this.dgw_prodList.AllowUserToDeleteRows = false;
            this.dgw_prodList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgw_prodList.BackgroundColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_prodList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgw_prodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_prodList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgw_prodList.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgw_prodList.Location = new System.Drawing.Point(3, 3);
            this.dgw_prodList.Name = "dgw_prodList";
            this.dgw_prodList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_prodList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgw_prodList.Size = new System.Drawing.Size(446, 222);
            this.dgw_prodList.TabIndex = 0;
            this.dgw_prodList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_prodList_CellClick);
            this.dgw_prodList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgw_prodList_CellMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.label_valueId);
            this.groupBox1.Controls.Add(this.txtBox_prodStock);
            this.groupBox1.Controls.Add(this.txtBox_prodPrice);
            this.groupBox1.Controls.Add(this.txtBox_prodName);
            this.groupBox1.Controls.Add(this.label_prodStock);
            this.groupBox1.Controls.Add(this.label_prodName);
            this.groupBox1.Controls.Add(this.label_prodPrice);
            this.groupBox1.Controls.Add(this.label_prodId);
            this.groupBox1.Controls.Add(this.btn_prodAdd);
            this.groupBox1.Location = new System.Drawing.Point(82, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 204);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Item";
            // 
            // label_valueId
            // 
            this.label_valueId.AutoSize = true;
            this.label_valueId.Location = new System.Drawing.Point(28, 25);
            this.label_valueId.Name = "label_valueId";
            this.label_valueId.Size = new System.Drawing.Size(13, 13);
            this.label_valueId.TabIndex = 8;
            this.label_valueId.Text = "0";
            // 
            // txtBox_prodStock
            // 
            this.txtBox_prodStock.Location = new System.Drawing.Point(9, 151);
            this.txtBox_prodStock.Name = "txtBox_prodStock";
            this.txtBox_prodStock.Size = new System.Drawing.Size(100, 20);
            this.txtBox_prodStock.TabIndex = 7;
            // 
            // txtBox_prodPrice
            // 
            this.txtBox_prodPrice.Location = new System.Drawing.Point(9, 108);
            this.txtBox_prodPrice.Name = "txtBox_prodPrice";
            this.txtBox_prodPrice.Size = new System.Drawing.Size(100, 20);
            this.txtBox_prodPrice.TabIndex = 6;
            // 
            // txtBox_prodName
            // 
            this.txtBox_prodName.Location = new System.Drawing.Point(9, 69);
            this.txtBox_prodName.Name = "txtBox_prodName";
            this.txtBox_prodName.Size = new System.Drawing.Size(100, 20);
            this.txtBox_prodName.TabIndex = 5;
            // 
            // label_prodStock
            // 
            this.label_prodStock.AutoSize = true;
            this.label_prodStock.Location = new System.Drawing.Point(6, 135);
            this.label_prodStock.Name = "label_prodStock";
            this.label_prodStock.Size = new System.Drawing.Size(35, 13);
            this.label_prodStock.TabIndex = 4;
            this.label_prodStock.Text = "Stock";
            // 
            // label_prodName
            // 
            this.label_prodName.AutoSize = true;
            this.label_prodName.Location = new System.Drawing.Point(6, 53);
            this.label_prodName.Name = "label_prodName";
            this.label_prodName.Size = new System.Drawing.Size(35, 13);
            this.label_prodName.TabIndex = 3;
            this.label_prodName.Text = "Name";
            // 
            // label_prodPrice
            // 
            this.label_prodPrice.AutoSize = true;
            this.label_prodPrice.Location = new System.Drawing.Point(6, 92);
            this.label_prodPrice.Name = "label_prodPrice";
            this.label_prodPrice.Size = new System.Drawing.Size(31, 13);
            this.label_prodPrice.TabIndex = 2;
            this.label_prodPrice.Text = "Price";
            // 
            // label_prodId
            // 
            this.label_prodId.AutoSize = true;
            this.label_prodId.Location = new System.Drawing.Point(6, 25);
            this.label_prodId.Name = "label_prodId";
            this.label_prodId.Size = new System.Drawing.Size(24, 13);
            this.label_prodId.TabIndex = 1;
            this.label_prodId.Text = "ID: ";
            // 
            // btn_prodAdd
            // 
            this.btn_prodAdd.Location = new System.Drawing.Point(9, 175);
            this.btn_prodAdd.Name = "btn_prodAdd";
            this.btn_prodAdd.Size = new System.Drawing.Size(100, 23);
            this.btn_prodAdd.TabIndex = 0;
            this.btn_prodAdd.Text = "ADD";
            this.btn_prodAdd.UseVisualStyleBackColor = true;
            this.btn_prodAdd.Click += new System.EventHandler(this.btn_prodAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.label_modValueId);
            this.groupBox2.Controls.Add(this.txtBox_modStock);
            this.groupBox2.Controls.Add(this.txtBox_modPrice);
            this.groupBox2.Controls.Add(this.txtBox_modName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn_Update);
            this.groupBox2.Location = new System.Drawing.Point(224, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 204);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Item";
            // 
            // label_modValueId
            // 
            this.label_modValueId.AutoSize = true;
            this.label_modValueId.Location = new System.Drawing.Point(28, 25);
            this.label_modValueId.Name = "label_modValueId";
            this.label_modValueId.Size = new System.Drawing.Size(13, 13);
            this.label_modValueId.TabIndex = 8;
            this.label_modValueId.Text = "0";
            // 
            // txtBox_modStock
            // 
            this.txtBox_modStock.Location = new System.Drawing.Point(9, 151);
            this.txtBox_modStock.Name = "txtBox_modStock";
            this.txtBox_modStock.Size = new System.Drawing.Size(117, 20);
            this.txtBox_modStock.TabIndex = 7;
            // 
            // txtBox_modPrice
            // 
            this.txtBox_modPrice.Location = new System.Drawing.Point(9, 108);
            this.txtBox_modPrice.Name = "txtBox_modPrice";
            this.txtBox_modPrice.Size = new System.Drawing.Size(117, 20);
            this.txtBox_modPrice.TabIndex = 6;
            // 
            // txtBox_modName
            // 
            this.txtBox_modName.Location = new System.Drawing.Point(9, 69);
            this.txtBox_modName.Name = "txtBox_modName";
            this.txtBox_modName.Size = new System.Drawing.Size(117, 20);
            this.txtBox_modName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "ID: ";
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(9, 175);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(117, 23);
            this.btn_Update.TabIndex = 0;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(0, 436);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(78, 13);
            this.label_total.TabIndex = 10;
            this.label_total.Text = "Product Count:";
            // 
            // label_valueTotal
            // 
            this.label_valueTotal.AutoSize = true;
            this.label_valueTotal.Location = new System.Drawing.Point(79, 436);
            this.label_valueTotal.Name = "label_valueTotal";
            this.label_valueTotal.Size = new System.Drawing.Size(23, 13);
            this.label_valueTotal.TabIndex = 11;
            this.label_valueTotal.Text = "null";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.label_valueTotal);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgw_prodList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(467, 489);
            this.MinimumSize = new System.Drawing.Size(467, 489);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Product Manager   [ dev: github.com/zwiebelmad ]";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_prodList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_prodList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_prodStock;
        private System.Windows.Forms.Label label_prodName;
        private System.Windows.Forms.Label label_prodPrice;
        private System.Windows.Forms.Label label_prodId;
        private System.Windows.Forms.Button btn_prodAdd;
        private System.Windows.Forms.TextBox txtBox_prodStock;
        private System.Windows.Forms.TextBox txtBox_prodPrice;
        private System.Windows.Forms.TextBox txtBox_prodName;
        private System.Windows.Forms.Label label_valueId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_modValueId;
        private System.Windows.Forms.TextBox txtBox_modStock;
        private System.Windows.Forms.TextBox txtBox_modPrice;
        private System.Windows.Forms.TextBox txtBox_modName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label_valueTotal;
    }
}

