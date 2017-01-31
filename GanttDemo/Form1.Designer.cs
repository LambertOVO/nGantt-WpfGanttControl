using System.Windows.Forms;

namespace GanttDemo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePrasy = new System.Windows.Forms.TabPage();
            this.RowChosen = new System.Windows.Forms.TextBox();
            this.AddRowButton = new System.Windows.Forms.Button();
            this.AddBlock_Button = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.ganttControl1 = new nGantt.GanttControl();
            this.tabPageSpawarki = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.RichTextBox();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.ganttControl2 = new nGantt.GanttControl();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPagePrasy.SuspendLayout();
            this.tabPageSpawarki.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Controls.Add(this.buttonPrevious);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1195, 57);
            this.panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(554, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 34);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(399, 12);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(100, 28);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(16, 12);
            this.buttonPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(100, 28);
            this.buttonPrevious.TabIndex = 1;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "HH:mm:ss d.MM.yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(124, 15);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePrasy);
            this.tabControl1.Controls.Add(this.tabPageSpawarki);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1209, 720);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPagePrasy
            // 
            this.tabPagePrasy.Controls.Add(this.RowChosen);
            this.tabPagePrasy.Controls.Add(this.AddRowButton);
            this.tabPagePrasy.Controls.Add(this.AddBlock_Button);
            this.tabPagePrasy.Controls.Add(this.dateTimePicker2);
            this.tabPagePrasy.Controls.Add(this.dateTimePicker1);
            this.tabPagePrasy.Controls.Add(this.elementHost1);
            this.tabPagePrasy.Controls.Add(this.panel1);
            this.tabPagePrasy.Location = new System.Drawing.Point(4, 25);
            this.tabPagePrasy.Name = "tabPagePrasy";
            this.tabPagePrasy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrasy.Size = new System.Drawing.Size(1201, 691);
            this.tabPagePrasy.TabIndex = 0;
            this.tabPagePrasy.Text = "Prasy";
            this.tabPagePrasy.UseVisualStyleBackColor = true;
            // 
            // RowChosen
            // 
            this.RowChosen.Location = new System.Drawing.Point(20, 610);
            this.RowChosen.Name = "RowChosen";
            this.RowChosen.Size = new System.Drawing.Size(27, 22);
            this.RowChosen.TabIndex = 11;
            this.RowChosen.Text = "2";
            // 
            // AddRowButton
            // 
            this.AddRowButton.Location = new System.Drawing.Point(592, 610);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(84, 22);
            this.AddRowButton.TabIndex = 10;
            this.AddRowButton.Text = "Add Row";
            this.AddRowButton.UseVisualStyleBackColor = true;
            this.AddRowButton.Click += new System.EventHandler(this.AddRow_Click);
            // 
            // AddBlock_Button
            // 
            this.AddBlock_Button.Location = new System.Drawing.Point(154, 610);
            this.AddBlock_Button.Name = "AddBlock_Button";
            this.AddBlock_Button.Size = new System.Drawing.Size(84, 22);
            this.AddBlock_Button.TabIndex = 7;
            this.AddBlock_Button.Text = "Add Block";
            this.AddBlock_Button.UseVisualStyleBackColor = true;
            this.AddBlock_Button.Click += new System.EventHandler(this.AddBlock_Clik);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "HH:mm:ss d.MM.yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(303, 581);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm:ss d.MM.yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 581);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(3, 60);
            this.elementHost1.Margin = new System.Windows.Forms.Padding(4);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(1195, 628);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.ganttControl1;
            // 
            // tabPageSpawarki
            // 
            this.tabPageSpawarki.Controls.Add(this.richTextBox1);
            this.tabPageSpawarki.Controls.Add(this.button1);
            this.tabPageSpawarki.Controls.Add(this.button2);
            this.tabPageSpawarki.Controls.Add(this.dateTimePicker3);
            this.tabPageSpawarki.Controls.Add(this.elementHost2);
            this.tabPageSpawarki.Controls.Add(this.textBox2);
            this.tabPageSpawarki.Location = new System.Drawing.Point(4, 25);
            this.tabPageSpawarki.Name = "tabPageSpawarki";
            this.tabPageSpawarki.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSpawarki.Size = new System.Drawing.Size(1201, 691);
            this.tabPageSpawarki.TabIndex = 1;
            this.tabPageSpawarki.Text = "Spawarki";
            this.tabPageSpawarki.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(434, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(336, 52);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "";
            // 
            // elementHost2
            // 
            this.elementHost2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost2.Location = new System.Drawing.Point(3, 3);
            this.elementHost2.Margin = new System.Windows.Forms.Padding(4);
            this.elementHost2.Name = "elementHost2";
            this.elementHost2.Size = new System.Drawing.Size(1195, 685);
            this.elementHost2.TabIndex = 3;
            this.elementHost2.Text = "elementHost2";
            this.elementHost2.Child = this.ganttControl2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(546, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(304, 34);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 14;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "HH:mm:ss d.MM.yyyy";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(116, 15);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker3.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 744);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "GanttDemo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPagePrasy.ResumeLayout(false);
            this.tabPagePrasy.PerformLayout();
            this.tabPageSpawarki.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private nGantt.GanttControl ganttControl1;
        private TabControl tabControl1;
        private TabPage tabPagePrasy;
        private TabPage tabPageSpawarki;
        private TextBox RowChosen;
        private Button AddRowButton;
        private Button AddBlock_Button;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private RichTextBox textBox1;
        private RichTextBox textBox2;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Integration.ElementHost elementHost2;
        private nGantt.GanttControl ganttControl2;
    }
}

