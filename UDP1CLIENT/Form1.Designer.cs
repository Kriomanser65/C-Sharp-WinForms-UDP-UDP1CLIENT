namespace UDP1CLIENT
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
            this.SearchId = new System.Windows.Forms.Button();
            this.SearchPrice = new System.Windows.Forms.Button();
            this.SearchModel = new System.Windows.Forms.Button();
            this.SetUnaviable = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SearchId
            // 
            this.SearchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchId.Location = new System.Drawing.Point(688, 12);
            this.SearchId.Name = "SearchId";
            this.SearchId.Size = new System.Drawing.Size(100, 34);
            this.SearchId.TabIndex = 0;
            this.SearchId.Text = "Search ID";
            this.SearchId.UseVisualStyleBackColor = true;
            this.SearchId.Click += new System.EventHandler(this.SearchId_Click);
            // 
            // SearchPrice
            // 
            this.SearchPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchPrice.Location = new System.Drawing.Point(688, 52);
            this.SearchPrice.Name = "SearchPrice";
            this.SearchPrice.Size = new System.Drawing.Size(100, 49);
            this.SearchPrice.TabIndex = 1;
            this.SearchPrice.Text = "Search Price";
            this.SearchPrice.UseVisualStyleBackColor = true;
            this.SearchPrice.Click += new System.EventHandler(this.SearchPrice_Click);
            // 
            // SearchModel
            // 
            this.SearchModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchModel.Location = new System.Drawing.Point(688, 107);
            this.SearchModel.Name = "SearchModel";
            this.SearchModel.Size = new System.Drawing.Size(100, 38);
            this.SearchModel.TabIndex = 2;
            this.SearchModel.Text = "Search Mdl";
            this.SearchModel.UseVisualStyleBackColor = true;
            this.SearchModel.Click += new System.EventHandler(this.SearchModel_Click);
            // 
            // SetUnaviable
            // 
            this.SetUnaviable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetUnaviable.Location = new System.Drawing.Point(688, 151);
            this.SetUnaviable.Name = "SetUnaviable";
            this.SetUnaviable.Size = new System.Drawing.Size(100, 34);
            this.SetUnaviable.TabIndex = 3;
            this.SetUnaviable.Text = "Set Un";
            this.SetUnaviable.UseVisualStyleBackColor = true;
            this.SetUnaviable.Click += new System.EventHandler(this.SetUnaviable_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(670, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(670, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(224, 117);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(458, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(224, 159);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(458, 20);
            this.textBox4.TabIndex = 7;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 117);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(206, 20);
            this.textBox5.TabIndex = 8;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(12, 159);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(206, 20);
            this.textBox6.TabIndex = 9;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 196);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SetUnaviable);
            this.Controls.Add(this.SearchModel);
            this.Controls.Add(this.SearchPrice);
            this.Controls.Add(this.SearchId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchId;
        private System.Windows.Forms.Button SearchPrice;
        private System.Windows.Forms.Button SearchModel;
        private System.Windows.Forms.Button SetUnaviable;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}

