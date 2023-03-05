namespace TP_MOD3_1302213037
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
            components = new System.ComponentModel.Container();
            TxtInput = new Label();
            Output = new Label();
            buttonBindingSource = new BindingSource(components);
            SubmitButton = new Button();
            textBoxBindingSource = new BindingSource(components);
            InputBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)buttonBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textBoxBindingSource).BeginInit();
            SuspendLayout();
            // 
            // TxtInput
            // 
            TxtInput.AutoSize = true;
            TxtInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtInput.Location = new Point(42, 87);
            TxtInput.Name = "TxtInput";
            TxtInput.Size = new Size(111, 25);
            TxtInput.TabIndex = 1;
            TxtInput.Text = "Input Nama";
            TxtInput.Click += label1_Click_1;
            // 
            // Output
            // 
            Output.AutoSize = true;
            Output.DataBindings.Add(new Binding("Name", buttonBindingSource, "DataBindings", true));
            Output.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Output.Location = new Point(171, 157);
            Output.Name = "Output";
            Output.Size = new Size(0, 30);
            Output.TabIndex = 3;
            Output.Click += Output_Click;
            // 
            // buttonBindingSource
            // 
            buttonBindingSource.DataSource = typeof(Button);
            // 
            // SubmitButton
            // 
            SubmitButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            SubmitButton.Location = new Point(367, 82);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(104, 35);
            SubmitButton.TabIndex = 4;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // textBoxBindingSource
            // 
            textBoxBindingSource.DataSource = typeof(TextBox);
            // 
            // InputBox
            // 
            InputBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            InputBox.ForeColor = SystemColors.InactiveCaption;
            InputBox.Location = new Point(183, 84);
            InputBox.Name = "InputBox";
            InputBox.Size = new Size(154, 32);
            InputBox.TabIndex = 5;
            InputBox.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 256);
            Controls.Add(InputBox);
            Controls.Add(SubmitButton);
            Controls.Add(Output);
            Controls.Add(TxtInput);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)buttonBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)textBoxBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label TxtInput;
        private Label Output;
        private BindingSource buttonBindingSource;
        private Button SubmitButton;
        private BindingSource textBoxBindingSource;
        private TextBox InputBox;
    }
}