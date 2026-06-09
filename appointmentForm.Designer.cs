namespace Hospital
{
    partial class appointmentForm
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
            label1 = new Label();
            label2 = new Label();
            patientlabel = new Label();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            doctorlabel = new Label();
            label3 = new Label();
            doctorlabel2 = new Label();
            atlabel = new Label();
            panel2 = new Panel();
            numericUpDown1 = new NumericUpDown();
            label5 = new Label();
            monthCalendar1 = new MonthCalendar();
            label4 = new Label();
            rservebutton = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(138, 60);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(453, 48);
            label1.TabIndex = 0;
            label1.Text = "Appointment Reservation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 130);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 45);
            label2.TabIndex = 1;
            label2.Text = "Patient:";
            // 
            // patientlabel
            // 
            patientlabel.AutoSize = true;
            patientlabel.Font = new Font("Cascadia Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientlabel.Location = new Point(175, 140);
            patientlabel.Margin = new Padding(4, 0, 4, 0);
            patientlabel.Name = "patientlabel";
            patientlabel.Size = new Size(81, 37);
            patientlabel.TabIndex = 2;
            patientlabel.Text = "Null";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(doctorlabel);
            panel1.Location = new Point(0, 191);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(509, 479);
            panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.AliceBlue;
            groupBox1.Location = new Point(4, 71);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(492, 372);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose only one doctor";
            // 
            // doctorlabel
            // 
            doctorlabel.AutoSize = true;
            doctorlabel.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            doctorlabel.ForeColor = Color.AliceBlue;
            doctorlabel.Location = new Point(175, 20);
            doctorlabel.Margin = new Padding(4, 0, 4, 0);
            doctorlabel.Name = "doctorlabel";
            doctorlabel.Size = new Size(124, 45);
            doctorlabel.TabIndex = 4;
            doctorlabel.Text = "Doctor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(98, 235);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(518, 45);
            label3.TabIndex = 5;
            label3.Text = "Appointment Added Successfully";
            // 
            // doctorlabel2
            // 
            doctorlabel2.AutoSize = true;
            doctorlabel2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            doctorlabel2.Location = new Point(98, 338);
            doctorlabel2.Margin = new Padding(4, 0, 4, 0);
            doctorlabel2.Name = "doctorlabel2";
            doctorlabel2.Size = new Size(138, 45);
            doctorlabel2.TabIndex = 6;
            doctorlabel2.Text = "Doctor/";
            // 
            // atlabel
            // 
            atlabel.AutoSize = true;
            atlabel.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            atlabel.Location = new Point(98, 425);
            atlabel.Margin = new Padding(4, 0, 4, 0);
            atlabel.Name = "atlabel";
            atlabel.Size = new Size(70, 45);
            atlabel.TabIndex = 7;
            atlabel.Text = "At: ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Peru;
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(monthCalendar1);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(504, 191);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(509, 479);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(196, 400);
            numericUpDown1.Margin = new Padding(4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(188, 31);
            numericUpDown1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label5.ForeColor = Color.AliceBlue;
            label5.Location = new Point(99, 398);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 30);
            label5.TabIndex = 8;
            label5.Text = "Hour:";
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = Color.DarkCyan;
            monthCalendar1.Location = new Point(88, 102);
            monthCalendar1.Margin = new Padding(11);
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 7;
            monthCalendar1.TitleBackColor = Color.DarkCyan;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.AliceBlue;
            label4.Location = new Point(196, 20);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 45);
            label4.TabIndex = 6;
            label4.Text = "Date";
            // 
            // rservebutton
            // 
            rservebutton.BackColor = Color.CadetBlue;
            rservebutton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rservebutton.ForeColor = Color.AliceBlue;
            rservebutton.Location = new Point(802, 66);
            rservebutton.Margin = new Padding(4);
            rservebutton.Name = "rservebutton";
            rservebutton.Size = new Size(145, 48);
            rservebutton.TabIndex = 9;
            rservebutton.Text = "reserve";
            rservebutton.UseVisualStyleBackColor = false;
            rservebutton.Click += rservebutton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.calendar;
            pictureBox1.Location = new Point(41, 46);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(718, 144);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 31);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label6.Location = new Point(490, 146);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(204, 30);
            label6.TabIndex = 12;
            label6.Text = "Appointment Type:";
            label6.Click += label6_Click;
            // 
            // appointmentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1000, 668);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(rservebutton);
            Controls.Add(panel2);
            Controls.Add(patientlabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(doctorlabel2);
            Controls.Add(atlabel);
            Margin = new Padding(4);
            Name = "appointmentForm";
            Text = "appointmentForm";
            Load += appointmentForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label patientlabel;
        private Panel panel1;
        private Label doctorlabel;
        private GroupBox groupBox1;
        private Label label3;
        private Label doctorlabel2;
        private Label atlabel;
        private Panel panel2;
        private Label label4;
        private MonthCalendar monthCalendar1;
        private Button rservebutton;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label6;
    }
}