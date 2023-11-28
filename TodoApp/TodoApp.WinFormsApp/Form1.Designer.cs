namespace TodoApp.WinFormsApp
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
            label1 = new Label();
            tBTitle = new TextBox();
            cBIsDone = new CheckBox();
            label2 = new Label();
            btnAdd = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("현대하모니 M", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(65, 37);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 17);
            label1.TabIndex = 0;
            label1.Text = "할 일:";
            // 
            // tBTitle
            // 
            tBTitle.Location = new Point(145, 34);
            tBTitle.Margin = new Padding(4, 3, 4, 3);
            tBTitle.Name = "tBTitle";
            tBTitle.Size = new Size(299, 24);
            tBTitle.TabIndex = 1;
            // 
            // cBIsDone
            // 
            cBIsDone.AutoSize = true;
            cBIsDone.Font = new Font("현대하모니 M", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            cBIsDone.Location = new Point(145, 72);
            cBIsDone.Margin = new Padding(4, 3, 4, 3);
            cBIsDone.Name = "cBIsDone";
            cBIsDone.Size = new Size(65, 21);
            cBIsDone.TabIndex = 2;
            cBIsDone.Text = "완 료";
            cBIsDone.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("현대하모니 M", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label2.Location = new Point(65, 72);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 17);
            label2.TabIndex = 3;
            label2.Text = "완 료:";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("현대하모니 M", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnAdd.Location = new Point(462, 34);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(141, 68);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "등 록";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(65, 125);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(538, 239);
            dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 382);
            Controls.Add(dataGridView1);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(cBIsDone);
            Controls.Add(tBTitle);
            Controls.Add(label1);
            Font = new Font("현대하모니 M", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "할 일 목 록 ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tBTitle;
        private CheckBox cBIsDone;
        private Label label2;
        private Button btnAdd;
        private DataGridView dataGridView1;
    }
}
