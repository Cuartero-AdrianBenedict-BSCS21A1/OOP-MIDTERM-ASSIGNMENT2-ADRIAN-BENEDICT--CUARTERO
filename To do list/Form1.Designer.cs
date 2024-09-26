namespace To_do_list
{
    partial class Form1TodoList
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
            this.label1Title = new System.Windows.Forms.Label();
            this.label2Desc = new System.Windows.Forms.Label();
            this.Descriptionn = new System.Windows.Forms.TextBox();
            this.Titlee = new System.Windows.Forms.TextBox();
            this.dataGridView1TodoList = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1Edit = new System.Windows.Forms.Button();
            this.button2Delete = new System.Windows.Forms.Button();
            this.button3New = new System.Windows.Forms.Button();
            this.button4Save = new System.Windows.Forms.Button();
            this.button1Exit = new System.Windows.Forms.Button();
            this.label1Date = new System.Windows.Forms.Label();
            this.Datee = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1TodoList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1Title
            // 
            this.label1Title.AutoSize = true;
            this.label1Title.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Title.Location = new System.Drawing.Point(22, 19);
            this.label1Title.Name = "label1Title";
            this.label1Title.Size = new System.Drawing.Size(45, 19);
            this.label1Title.TabIndex = 0;
            this.label1Title.Text = "Title:";
            // 
            // label2Desc
            // 
            this.label2Desc.AutoSize = true;
            this.label2Desc.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Desc.Location = new System.Drawing.Point(405, 19);
            this.label2Desc.Name = "label2Desc";
            this.label2Desc.Size = new System.Drawing.Size(99, 19);
            this.label2Desc.TabIndex = 1;
            this.label2Desc.Text = "Description:";
            this.label2Desc.Click += new System.EventHandler(this.label2_Click);
            // 
            // Descriptionn
            // 
            this.Descriptionn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Descriptionn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Descriptionn.Location = new System.Drawing.Point(409, 41);
            this.Descriptionn.Multiline = true;
            this.Descriptionn.Name = "Descriptionn";
            this.Descriptionn.Size = new System.Drawing.Size(361, 109);
            this.Descriptionn.TabIndex = 2;
            this.Descriptionn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Titlee
            // 
            this.Titlee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Titlee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Titlee.Location = new System.Drawing.Point(26, 41);
            this.Titlee.Multiline = true;
            this.Titlee.Name = "Titlee";
            this.Titlee.Size = new System.Drawing.Size(361, 109);
            this.Titlee.TabIndex = 3;
            this.Titlee.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dataGridView1TodoList
            // 
            this.dataGridView1TodoList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1TodoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1TodoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Description,
            this.Date,
            this.Checkbox});
            this.dataGridView1TodoList.Location = new System.Drawing.Point(26, 175);
            this.dataGridView1TodoList.Name = "dataGridView1TodoList";
            this.dataGridView1TodoList.Size = new System.Drawing.Size(779, 450);
            this.dataGridView1TodoList.TabIndex = 4;
            this.dataGridView1TodoList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1TodoList_CellContentClick);
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.Width = 170;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 225;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Width = 170;
            // 
            // Checkbox
            // 
            this.Checkbox.HeaderText = "Check box";
            this.Checkbox.Name = "Checkbox";
            this.Checkbox.Width = 170;
            // 
            // button1Edit
            // 
            this.button1Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1Edit.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Edit.Location = new System.Drawing.Point(827, 267);
            this.button1Edit.Name = "button1Edit";
            this.button1Edit.Size = new System.Drawing.Size(174, 58);
            this.button1Edit.TabIndex = 5;
            this.button1Edit.Text = "Edit";
            this.button1Edit.UseVisualStyleBackColor = false;
            this.button1Edit.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2Delete
            // 
            this.button2Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2Delete.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2Delete.Location = new System.Drawing.Point(827, 361);
            this.button2Delete.Name = "button2Delete";
            this.button2Delete.Size = new System.Drawing.Size(174, 58);
            this.button2Delete.TabIndex = 6;
            this.button2Delete.Text = "Delete";
            this.button2Delete.UseVisualStyleBackColor = false;
            this.button2Delete.Click += new System.EventHandler(this.button2Delete_Click);
            // 
            // button3New
            // 
            this.button3New.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3New.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3New.Location = new System.Drawing.Point(827, 175);
            this.button3New.Name = "button3New";
            this.button3New.Size = new System.Drawing.Size(174, 58);
            this.button3New.TabIndex = 7;
            this.button3New.Text = "New";
            this.button3New.UseVisualStyleBackColor = false;
            this.button3New.Click += new System.EventHandler(this.button3New_Click);
            // 
            // button4Save
            // 
            this.button4Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4Save.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4Save.Location = new System.Drawing.Point(827, 453);
            this.button4Save.Name = "button4Save";
            this.button4Save.Size = new System.Drawing.Size(174, 60);
            this.button4Save.TabIndex = 8;
            this.button4Save.Text = "Save";
            this.button4Save.UseVisualStyleBackColor = false;
            this.button4Save.Click += new System.EventHandler(this.button4Save_Click);
            // 
            // button1Exit
            // 
            this.button1Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1Exit.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Exit.ForeColor = System.Drawing.Color.Black;
            this.button1Exit.Location = new System.Drawing.Point(827, 549);
            this.button1Exit.Name = "button1Exit";
            this.button1Exit.Size = new System.Drawing.Size(174, 59);
            this.button1Exit.TabIndex = 9;
            this.button1Exit.Text = "Exit";
            this.button1Exit.UseVisualStyleBackColor = false;
            // 
            // label1Date
            // 
            this.label1Date.AutoSize = true;
            this.label1Date.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Date.Location = new System.Drawing.Point(785, 19);
            this.label1Date.Name = "label1Date";
            this.label1Date.Size = new System.Drawing.Size(49, 19);
            this.label1Date.TabIndex = 10;
            this.label1Date.Text = "Date:";
            // 
            // Datee
            // 
            this.Datee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Datee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Datee.Location = new System.Drawing.Point(789, 40);
            this.Datee.Multiline = true;
            this.Datee.Name = "Datee";
            this.Datee.Size = new System.Drawing.Size(306, 109);
            this.Datee.TabIndex = 11;
            this.Datee.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Form1TodoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 637);
            this.Controls.Add(this.Datee);
            this.Controls.Add(this.label1Date);
            this.Controls.Add(this.button1Exit);
            this.Controls.Add(this.button4Save);
            this.Controls.Add(this.button3New);
            this.Controls.Add(this.button2Delete);
            this.Controls.Add(this.button1Edit);
            this.Controls.Add(this.dataGridView1TodoList);
            this.Controls.Add(this.Titlee);
            this.Controls.Add(this.Descriptionn);
            this.Controls.Add(this.label2Desc);
            this.Controls.Add(this.label1Title);
            this.Name = "Form1TodoList";
            this.Text = "To do list menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1TodoList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1Title;
        private System.Windows.Forms.Label label2Desc;
        private System.Windows.Forms.TextBox Descriptionn;
        private System.Windows.Forms.TextBox Titlee;
        private System.Windows.Forms.DataGridView dataGridView1TodoList;
        private System.Windows.Forms.Button button1Edit;
        private System.Windows.Forms.Button button2Delete;
        private System.Windows.Forms.Button button3New;
        private System.Windows.Forms.Button button4Save;
        private System.Windows.Forms.Button button1Exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Checkbox;
        private System.Windows.Forms.Label label1Date;
        private System.Windows.Forms.TextBox Datee;
    }
}

