namespace dotcer
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
            this.StartedAssemblies = new System.Windows.Forms.ListBox();
            this.AvailableAssemblies = new System.Windows.Forms.ListBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            this.button_CloseWindow = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_RunNotepade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartedAssemblies
            // 
            this.StartedAssemblies.BackColor = System.Drawing.Color.Silver;
            this.StartedAssemblies.Font = new System.Drawing.Font("Alef", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartedAssemblies.FormattingEnabled = true;
            this.StartedAssemblies.ItemHeight = 18;
            this.StartedAssemblies.Location = new System.Drawing.Point(15, 12);
            this.StartedAssemblies.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.StartedAssemblies.Name = "StartedAssemblies";
            this.StartedAssemblies.Size = new System.Drawing.Size(291, 508);
            this.StartedAssemblies.TabIndex = 0;
            this.StartedAssemblies.SelectedIndexChanged += new System.EventHandler(this.StartedAssemblies_SelectedIndexChanged);
            // 
            // AvailableAssemblies
            // 
            this.AvailableAssemblies.BackColor = System.Drawing.Color.Silver;
            this.AvailableAssemblies.Font = new System.Drawing.Font("Alef", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AvailableAssemblies.FormattingEnabled = true;
            this.AvailableAssemblies.ItemHeight = 18;
            this.AvailableAssemblies.Location = new System.Drawing.Point(613, 12);
            this.AvailableAssemblies.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.AvailableAssemblies.Name = "AvailableAssemblies";
            this.AvailableAssemblies.Size = new System.Drawing.Size(291, 508);
            this.AvailableAssemblies.TabIndex = 1;
            this.AvailableAssemblies.SelectedIndexChanged += new System.EventHandler(this.AvailableAssemblies_SelectedIndexChanged);
            // 
            // button_Start
            // 
            this.button_Start.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Start.Enabled = false;
            this.button_Start.Font = new System.Drawing.Font("Alef", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Start.Location = new System.Drawing.Point(313, 12);
            this.button_Start.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(290, 96);
            this.button_Start.TabIndex = 2;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = false;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Stop.Enabled = false;
            this.button_Stop.Font = new System.Drawing.Font("Alef", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Stop.Location = new System.Drawing.Point(313, 115);
            this.button_Stop.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(290, 96);
            this.button_Stop.TabIndex = 3;
            this.button_Stop.Text = "Stop";
            this.button_Stop.UseVisualStyleBackColor = false;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // button_CloseWindow
            // 
            this.button_CloseWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_CloseWindow.Enabled = false;
            this.button_CloseWindow.Font = new System.Drawing.Font("Alef", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_CloseWindow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_CloseWindow.Location = new System.Drawing.Point(313, 218);
            this.button_CloseWindow.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.button_CloseWindow.Name = "button_CloseWindow";
            this.button_CloseWindow.Size = new System.Drawing.Size(290, 96);
            this.button_CloseWindow.TabIndex = 4;
            this.button_CloseWindow.Text = "CloseWindow";
            this.button_CloseWindow.UseVisualStyleBackColor = false;
            this.button_CloseWindow.Click += new System.EventHandler(this.button_CloseWindow_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_Refresh.Enabled = false;
            this.button_Refresh.Font = new System.Drawing.Font("Alef", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Refresh.Location = new System.Drawing.Point(313, 322);
            this.button_Refresh.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(290, 96);
            this.button_Refresh.TabIndex = 5;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = false;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // button_RunNotepade
            // 
            this.button_RunNotepade.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_RunNotepade.Enabled = false;
            this.button_RunNotepade.Font = new System.Drawing.Font("Alef", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_RunNotepade.Location = new System.Drawing.Point(313, 424);
            this.button_RunNotepade.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.button_RunNotepade.Name = "button_RunNotepade";
            this.button_RunNotepade.Size = new System.Drawing.Size(290, 96);
            this.button_RunNotepade.TabIndex = 6;
            this.button_RunNotepade.Text = "Notepade";
            this.button_RunNotepade.UseVisualStyleBackColor = false;
            this.button_RunNotepade.Click += new System.EventHandler(this.button_RunNotepade_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(914, 529);
            this.Controls.Add(this.button_RunNotepade);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.button_CloseWindow);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.AvailableAssemblies);
            this.Controls.Add(this.StartedAssemblies);
            this.Font = new System.Drawing.Font("Alef", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox StartedAssemblies;
        private ListBox AvailableAssemblies;
        private Button button_Start;
        private Button button_Stop;
        private Button button_CloseWindow;
        private Button button_Refresh;
        private Button button_RunNotepade;
    }
}