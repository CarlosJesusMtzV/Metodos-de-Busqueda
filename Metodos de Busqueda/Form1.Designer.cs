namespace Metodos_de_Busqueda
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
            btnGenerate = new Button();
            btnSequentialSearch = new Button();
            btnHashSearch = new Button();
            btnBinarySearch = new Button();
            txtNumbers = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtSearch = new TextBox();
            lblResult = new Label();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = SystemColors.ActiveCaption;
            btnGenerate.Location = new Point(246, 33);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(136, 53);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = " Generar números.";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnSequentialSearch
            // 
            btnSequentialSearch.BackColor = SystemColors.ActiveCaption;
            btnSequentialSearch.Location = new Point(246, 112);
            btnSequentialSearch.Name = "btnSequentialSearch";
            btnSequentialSearch.Size = new Size(136, 53);
            btnSequentialSearch.TabIndex = 1;
            btnSequentialSearch.Text = "Buscar (Secuencial).";
            btnSequentialSearch.UseVisualStyleBackColor = false;
            btnSequentialSearch.Click += btnSequentialSearch_Click;
            // 
            // btnHashSearch
            // 
            btnHashSearch.BackColor = SystemColors.ActiveCaption;
            btnHashSearch.Location = new Point(428, 112);
            btnHashSearch.Name = "btnHashSearch";
            btnHashSearch.Size = new Size(136, 53);
            btnHashSearch.TabIndex = 3;
            btnHashSearch.Text = " Buscar (Hash).";
            btnHashSearch.UseVisualStyleBackColor = false;
            btnHashSearch.Click += btnHashSearch_Click;
            // 
            // btnBinarySearch
            // 
            btnBinarySearch.BackColor = SystemColors.ActiveCaption;
            btnBinarySearch.Location = new Point(428, 33);
            btnBinarySearch.Name = "btnBinarySearch";
            btnBinarySearch.Size = new Size(136, 53);
            btnBinarySearch.TabIndex = 2;
            btnBinarySearch.Text = "Buscar (Binaria)";
            btnBinarySearch.UseVisualStyleBackColor = false;
            btnBinarySearch.Click += btnBinarySearch_Click;
            // 
            // txtNumbers
            // 
            txtNumbers.Location = new Point(12, 37);
            txtNumbers.Multiline = true;
            txtNumbers.Name = "txtNumbers";
            txtNumbers.Size = new Size(152, 49);
            txtNumbers.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(198, 20);
            label1.TabIndex = 5;
            label1.Text = "Mostrar números generados.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-1, 112);
            label2.Name = "label2";
            label2.Size = new Size(176, 20);
            label2.TabIndex = 7;
            label2.Text = "Ingresar número a buscar";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 143);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(152, 49);
            txtSearch.TabIndex = 6;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(77, 283);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(50, 20);
            lblResult.TabIndex = 8;
            lblResult.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(label2);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(txtNumbers);
            Controls.Add(btnHashSearch);
            Controls.Add(btnBinarySearch);
            Controls.Add(btnSequentialSearch);
            Controls.Add(btnGenerate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerate;
        private Button btnSequentialSearch;
        private Button btnHashSearch;
        private Button btnBinarySearch;
        private TextBox txtNumbers;
        private Label label1;
        private Label label2;
        private TextBox txtSearch;
        private Label lblResult;
    }
}
