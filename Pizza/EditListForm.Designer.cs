namespace Pizza
{
    partial class EditListForm
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            csv_data_grid = new DataGridView();
            panel1 = new Panel();
            cancel_ = new Button();
            update_ = new Button();
            bindingSource1 = new BindingSource(components);
            pizzajoint_name = new DataGridViewTextBoxColumn();
            orderurl = new DataGridViewTextBoxColumn();
            imageurl = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)csv_data_grid).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(csv_data_grid, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(584, 261);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // csv_data_grid
            // 
            csv_data_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            csv_data_grid.Columns.AddRange(new DataGridViewColumn[] { pizzajoint_name, orderurl, imageurl });
            csv_data_grid.Dock = DockStyle.Fill;
            csv_data_grid.Location = new Point(3, 3);
            csv_data_grid.Name = "csv_data_grid";
            csv_data_grid.RowTemplate.Height = 25;
            csv_data_grid.Size = new Size(578, 210);
            csv_data_grid.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(cancel_);
            panel1.Controls.Add(update_);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 219);
            panel1.Name = "panel1";
            panel1.Size = new Size(578, 39);
            panel1.TabIndex = 1;
            // 
            // cancel_
            // 
            cancel_.Anchor = AnchorStyles.Right;
            cancel_.Location = new Point(494, 7);
            cancel_.Name = "cancel_";
            cancel_.Size = new Size(75, 23);
            cancel_.TabIndex = 2;
            cancel_.Text = "&Cancel";
            cancel_.UseVisualStyleBackColor = true;
            cancel_.Click += cancel__Click;
            // 
            // update_
            // 
            update_.Location = new Point(9, 7);
            update_.Name = "update_";
            update_.Size = new Size(75, 23);
            update_.TabIndex = 1;
            update_.Text = "&Update";
            update_.UseVisualStyleBackColor = true;
            update_.Click += update__Click;
            // 
            // pizzajoint_name
            // 
            pizzajoint_name.HeaderText = "Company name";
            pizzajoint_name.Name = "pizzajoint_name";
            // 
            // orderurl
            // 
            orderurl.FillWeight = 200F;
            orderurl.HeaderText = "Order URL";
            orderurl.Name = "orderurl";
            orderurl.Width = 200;
            // 
            // imageurl
            // 
            imageurl.FillWeight = 200F;
            imageurl.HeaderText = "Company logo (URL)";
            imageurl.Name = "imageurl";
            imageurl.Width = 200;
            // 
            // EditListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 261);
            Controls.Add(tableLayoutPanel1);
            Name = "EditListForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Edit list";
            Load += EditListForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)csv_data_grid).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView csv_data_grid;
        private Panel panel1;
        private Button update_;
        private BindingSource bindingSource1;
        private Button cancel_;
        private DataGridViewTextBoxColumn pizzajoint_name;
        private DataGridViewTextBoxColumn orderurl;
        private DataGridViewTextBoxColumn imageurl;
    }
}