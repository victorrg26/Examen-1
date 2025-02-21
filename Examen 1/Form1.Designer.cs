namespace Examen_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtv1 = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnCargar = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dtv1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtv1
            // 
            dtv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtv1.Dock = DockStyle.Fill;
            dtv1.Location = new Point(3, 3);
            dtv1.Name = "dtv1";
            dtv1.RowHeadersWidth = 51;
            dtv1.Size = new Size(794, 350);
            dtv1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dtv1, 0, 0);
            tableLayoutPanel1.Controls.Add(btnCargar, 0, 1);
            tableLayoutPanel1.Location = new Point(1, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.Size = new Size(800, 414);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnCargar
            // 
            btnCargar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnCargar.Location = new Point(3, 370);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(794, 29);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtv1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtv1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnCargar;
        private OpenFileDialog openFileDialog1;
    }
}
