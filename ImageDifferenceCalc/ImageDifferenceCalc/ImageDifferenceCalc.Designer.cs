namespace ImageDifferenceCalc
{
    partial class ImageDifferenceCalc
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            compareButton = new Button();
            addToListBox1 = new Button();
            addToListBox2 = new Button();
            progressBar = new ProgressBar();
            listBox3 = new ListBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(2, 30);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox1.Size = new Size(250, 349);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(547, 30);
            listBox2.Name = "listBox2";
            listBox2.SelectionMode = SelectionMode.MultiSimple;
            listBox2.Size = new Size(250, 349);
            listBox2.TabIndex = 1;
            // 
            // compareButton
            // 
            compareButton.Location = new Point(258, 385);
            compareButton.Name = "compareButton";
            compareButton.Size = new Size(283, 45);
            compareButton.TabIndex = 2;
            compareButton.Text = "비교와 분석";
            compareButton.UseVisualStyleBackColor = true;
            compareButton.Click += compareButton_Click;
            // 
            // addToListBox1
            // 
            addToListBox1.Location = new Point(2, 385);
            addToListBox1.Name = "addToListBox1";
            addToListBox1.Size = new Size(250, 45);
            addToListBox1.TabIndex = 4;
            addToListBox1.Text = "listBox1에 추가";
            addToListBox1.UseVisualStyleBackColor = true;
            addToListBox1.Click += addToListBox1_Click;
            // 
            // addToListBox2
            // 
            addToListBox2.Location = new Point(547, 385);
            addToListBox2.Name = "addToListBox2";
            addToListBox2.Size = new Size(250, 45);
            addToListBox2.TabIndex = 5;
            addToListBox2.Text = "listBox2에 추가";
            addToListBox2.UseVisualStyleBackColor = true;
            addToListBox2.Click += addToListBox2_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(2, 432);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(795, 15);
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 6;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(258, 30);
            listBox3.Name = "listBox3";
            listBox3.SelectionMode = SelectionMode.MultiSimple;
            listBox3.Size = new Size(283, 349);
            listBox3.TabIndex = 7;
            // 
            // ImageDifferenceCalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 450);
            Controls.Add(listBox3);
            Controls.Add(progressBar);
            Controls.Add(addToListBox2);
            Controls.Add(addToListBox1);
            Controls.Add(compareButton);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "ImageDifferenceCalc";
            Text = "이미지 차연산";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Button compareButton;
        private Button addToListBox1;
        private Button addToListBox2;
        private ProgressBar progressBar;
        private ListBox listBox3;
    }
}
