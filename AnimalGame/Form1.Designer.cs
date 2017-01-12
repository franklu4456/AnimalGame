namespace AnimalGame
{
    partial class Form1
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
            this.pnlStore = new System.Windows.Forms.Panel();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStoreItems = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnScrollUp = new System.Windows.Forms.Button();
            this.btnScrollDown = new System.Windows.Forms.Button();
            this.pnlStore.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStore
            // 
            this.pnlStore.Controls.Add(this.btnScrollDown);
            this.pnlStore.Controls.Add(this.btnScrollUp);
            this.pnlStore.Controls.Add(this.txtItemDescription);
            this.pnlStore.Controls.Add(this.lblQuantity);
            this.pnlStore.Controls.Add(this.label6);
            this.pnlStore.Controls.Add(this.btnPurchase);
            this.pnlStore.Controls.Add(this.btnBack);
            this.pnlStore.Controls.Add(this.label5);
            this.pnlStore.Controls.Add(this.label4);
            this.pnlStore.Controls.Add(this.lblMoney);
            this.pnlStore.Controls.Add(this.label2);
            this.pnlStore.Controls.Add(this.txtStoreItems);
            this.pnlStore.Controls.Add(this.label1);
            this.pnlStore.Location = new System.Drawing.Point(24, 12);
            this.pnlStore.Name = "pnlStore";
            this.pnlStore.Size = new System.Drawing.Size(486, 409);
            this.pnlStore.TabIndex = 0;
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Location = new System.Drawing.Point(243, 125);
            this.txtItemDescription.Multiline = true;
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(207, 109);
            this.txtItemDescription.TabIndex = 12;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(336, 237);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(0, 17);
            this.lblQuantity.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(239, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quantity:";
            // 
            // btnPurchase
            // 
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Location = new System.Drawing.Point(243, 368);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(207, 23);
            this.btnPurchase.TabIndex = 8;
            this.btnPurchase.Text = "Purchase Item";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(397, 17);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(239, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Items:";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(98, 67);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(0, 17);
            this.lblMoney.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Money:";
            // 
            // txtStoreItems
            // 
            this.txtStoreItems.Location = new System.Drawing.Point(26, 125);
            this.txtStoreItems.Multiline = true;
            this.txtStoreItems.Name = "txtStoreItems";
            this.txtStoreItems.Size = new System.Drawing.Size(207, 240);
            this.txtStoreItems.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BankGothic Md BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Store";
            // 
            // btnScrollUp
            // 
            this.btnScrollUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScrollUp.Location = new System.Drawing.Point(158, 100);
            this.btnScrollUp.Name = "btnScrollUp";
            this.btnScrollUp.Size = new System.Drawing.Size(75, 23);
            this.btnScrollUp.TabIndex = 13;
            this.btnScrollUp.Text = "Up";
            this.btnScrollUp.UseVisualStyleBackColor = true;
            this.btnScrollUp.Click += new System.EventHandler(this.btnScrollUp_Click);
            // 
            // btnScrollDown
            // 
            this.btnScrollDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScrollDown.Location = new System.Drawing.Point(158, 368);
            this.btnScrollDown.Name = "btnScrollDown";
            this.btnScrollDown.Size = new System.Drawing.Size(75, 23);
            this.btnScrollDown.TabIndex = 14;
            this.btnScrollDown.Text = "Down";
            this.btnScrollDown.UseVisualStyleBackColor = true;
            this.btnScrollDown.Click += new System.EventHandler(this.btnScrollDown_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 615);
            this.Controls.Add(this.pnlStore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlStore.ResumeLayout(false);
            this.pnlStore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStore;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStoreItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnScrollDown;
        private System.Windows.Forms.Button btnScrollUp;
    }
}

