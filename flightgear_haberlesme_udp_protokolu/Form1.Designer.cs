namespace flightgear_haberlesme_udp_protokolu
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
            this.components = new System.ComponentModel.Container();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.throttle_tb = new System.Windows.Forms.TrackBar();
            this.elevator_tb = new System.Windows.Forms.TrackBar();
            this.udp_message_tb = new System.Windows.Forms.RichTextBox();
            this.send_tb = new System.Windows.Forms.RichTextBox();
            this.udpSend_t = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.aileron_tb = new System.Windows.Forms.TrackBar();
            this.rudder_tb = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.throttle_tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevator_tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aileron_tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rudder_tb)).BeginInit();
            this.SuspendLayout();
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(110, 165);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(165, 22);
            this.txt4.TabIndex = 0;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(110, 81);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(165, 22);
            this.txt1.TabIndex = 1;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(110, 137);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(165, 22);
            this.txt3.TabIndex = 2;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(110, 109);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(165, 22);
            this.txt2.TabIndex = 3;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(110, 193);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(165, 22);
            this.txt5.TabIndex = 4;
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(110, 221);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(165, 22);
            this.txt6.TabIndex = 5;
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(110, 249);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(165, 22);
            this.txt7.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Received :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Send :";
            // 
            // throttle_tb
            // 
            this.throttle_tb.Location = new System.Drawing.Point(401, 157);
            this.throttle_tb.Maximum = 100;
            this.throttle_tb.Name = "throttle_tb";
            this.throttle_tb.Size = new System.Drawing.Size(104, 56);
            this.throttle_tb.TabIndex = 10;
            // 
            // elevator_tb
            // 
            this.elevator_tb.Location = new System.Drawing.Point(559, 109);
            this.elevator_tb.Maximum = 100;
            this.elevator_tb.Minimum = -100;
            this.elevator_tb.Name = "elevator_tb";
            this.elevator_tb.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.elevator_tb.Size = new System.Drawing.Size(56, 155);
            this.elevator_tb.TabIndex = 11;
            // 
            // udp_message_tb
            // 
            this.udp_message_tb.Location = new System.Drawing.Point(110, 277);
            this.udp_message_tb.Name = "udp_message_tb";
            this.udp_message_tb.Size = new System.Drawing.Size(177, 76);
            this.udp_message_tb.TabIndex = 12;
            this.udp_message_tb.Text = "";
            // 
            // send_tb
            // 
            this.send_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.send_tb.Location = new System.Drawing.Point(401, 277);
            this.send_tb.Name = "send_tb";
            this.send_tb.Size = new System.Drawing.Size(191, 76);
            this.send_tb.TabIndex = 13;
            this.send_tb.Text = "";
            // 
            // udpSend_t
            // 
            this.udpSend_t.Interval = 30;
            this.udpSend_t.Tick += new System.EventHandler(this.udpSend_t_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Throttle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Elevator";
            // 
            // aileron_tb
            // 
            this.aileron_tb.Location = new System.Drawing.Point(640, 109);
            this.aileron_tb.Maximum = 100;
            this.aileron_tb.Minimum = -100;
            this.aileron_tb.Name = "aileron_tb";
            this.aileron_tb.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.aileron_tb.Size = new System.Drawing.Size(56, 155);
            this.aileron_tb.TabIndex = 16;
            // 
            // rudder_tb
            // 
            this.rudder_tb.Location = new System.Drawing.Point(721, 109);
            this.rudder_tb.Maximum = 100;
            this.rudder_tb.Minimum = -100;
            this.rudder_tb.Name = "rudder_tb";
            this.rudder_tb.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.rudder_tb.Size = new System.Drawing.Size(56, 155);
            this.rudder_tb.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(637, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Aileron";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(718, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Rudder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rudder_tb);
            this.Controls.Add(this.aileron_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.send_tb);
            this.Controls.Add(this.udp_message_tb);
            this.Controls.Add(this.elevator_tb);
            this.Controls.Add(this.throttle_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt7);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.throttle_tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevator_tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aileron_tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rudder_tb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar throttle_tb;
        private System.Windows.Forms.TrackBar elevator_tb;
        private System.Windows.Forms.RichTextBox udp_message_tb;
        private System.Windows.Forms.RichTextBox send_tb;
        private System.Windows.Forms.Timer udpSend_t;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar aileron_tb;
        private System.Windows.Forms.TrackBar rudder_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

