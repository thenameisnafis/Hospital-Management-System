namespace Hospital
{
    partial class MedicalHistoryForm
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
            panel1 = new Panel();
            label6 = new Label();
            PATIENTID = new Label();
            DETAILS = new TextBox();
            label4 = new Label();
            Patient_ID = new Label();
            panel2 = new Panel();
            button1 = new Button();
            DATEID = new Label();
            monthCalendar1 = new MonthCalendar();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(20, 25, 70);
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.ImageAlign = ContentAlignment.BottomLeft;
            label1.Location = new Point(-2, -1);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(914, 76);
            label1.TabIndex = 0;
            label1.Text = "Add a Medical History";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(PATIENTID);
            panel1.Controls.Add(DETAILS);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(Patient_ID);
            panel1.Location = new Point(-2, 66);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 686);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(102, 29);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(223, 48);
            label6.TabIndex = 8;
            label6.Text = "YOUR INFO:";
            // 
            // PATIENTID
            // 
            PATIENTID.AutoSize = true;
            PATIENTID.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            PATIENTID.Location = new Point(161, 101);
            PATIENTID.Margin = new Padding(4, 0, 4, 0);
            PATIENTID.Name = "PATIENTID";
            PATIENTID.Size = new Size(63, 40);
            PATIENTID.TabIndex = 4;
            PATIENTID.Text = "PID";
            // 
            // DETAILS
            // 
            DETAILS.Location = new Point(20, 214);
            DETAILS.Margin = new Padding(4, 5, 4, 5);
            DETAILS.Multiline = true;
            DETAILS.Name = "DETAILS";
            DETAILS.Size = new Size(378, 363);
            DETAILS.TabIndex = 3;
            DETAILS.TextChanged += DETAILS_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label4.Location = new Point(18, 156);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(333, 40);
            label4.TabIndex = 2;
            label4.Text = "Medical Record Details: ";
            // 
            // Patient_ID
            // 
            Patient_ID.AutoSize = true;
            Patient_ID.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            Patient_ID.Location = new Point(20, 101);
            Patient_ID.Margin = new Padding(4, 0, 4, 0);
            Patient_ID.Name = "Patient_ID";
            Patient_ID.Size = new Size(128, 40);
            Patient_ID.TabIndex = 0;
            Patient_ID.Text = "Your ID: ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(DATEID);
            panel2.Controls.Add(monthCalendar1);
            panel2.Location = new Point(424, 66);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(488, 686);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Location = new Point(126, 539);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(214, 39);
            button1.TabIndex = 2;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DATEID
            // 
            DATEID.AutoSize = true;
            DATEID.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            DATEID.Location = new Point(88, 29);
            DATEID.Margin = new Padding(4, 0, 4, 0);
            DATEID.Name = "DATEID";
            DATEID.Size = new Size(281, 48);
            DATEID.TabIndex = 1;
            DATEID.Text = "Choose a Date: ";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(71, 156);
            monthCalendar1.Margin = new Padding(12, 15, 12, 15);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // MedicalHistoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 750);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MedicalHistoryForm";
            Text = "MedicalHistoryForm";
            Load += MedicalHistoryForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label4;
        private Label Patient_ID;
        private Panel panel2;
        private MonthCalendar monthCalendar1;
        private Label PATIENTID;
        private TextBox DETAILS;
        private Button button1;
        private Label DATEID;
        private Label label6;
    }
}