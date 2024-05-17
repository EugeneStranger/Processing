namespace ProcessManipulation
{
    partial class MainForm
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
            this.listBoxAvailableAssemblies = new System.Windows.Forms.ListBox();
            this.listBoxStartedAssemblies = new System.Windows.Forms.ListBox();
            this.buttonStrat = new System.Windows.Forms.Button();
            this.labelAvailableAssemblies = new System.Windows.Forms.Label();
            this.labelStartedAssemblies = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonCloseWindow = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAvailableAssemblies
            // 
            this.listBoxAvailableAssemblies.FormattingEnabled = true;
            this.listBoxAvailableAssemblies.Location = new System.Drawing.Point(12, 38);
            this.listBoxAvailableAssemblies.Name = "listBoxAvailableAssemblies";
            this.listBoxAvailableAssemblies.Size = new System.Drawing.Size(335, 277);
            this.listBoxAvailableAssemblies.TabIndex = 0;
            // 
            // listBoxStartedAssemblies
            // 
            this.listBoxStartedAssemblies.FormattingEnabled = true;
            this.listBoxStartedAssemblies.Location = new System.Drawing.Point(449, 38);
            this.listBoxStartedAssemblies.Name = "listBoxStartedAssemblies";
            this.listBoxStartedAssemblies.Size = new System.Drawing.Size(339, 277);
            this.listBoxStartedAssemblies.TabIndex = 1;
            // 
            // buttonStrat
            // 
            this.buttonStrat.Location = new System.Drawing.Point(353, 38);
            this.buttonStrat.Name = "buttonStrat";
            this.buttonStrat.Size = new System.Drawing.Size(90, 23);
            this.buttonStrat.TabIndex = 2;
            this.buttonStrat.Text = "Start";
            this.buttonStrat.UseVisualStyleBackColor = true;
            this.buttonStrat.Click += new System.EventHandler(this.buttonStrat_Click);
            // 
            // labelAvailableAssemblies
            // 
            this.labelAvailableAssemblies.AutoSize = true;
            this.labelAvailableAssemblies.Location = new System.Drawing.Point(12, 13);
            this.labelAvailableAssemblies.Name = "labelAvailableAssemblies";
            this.labelAvailableAssemblies.Size = new System.Drawing.Size(103, 13);
            this.labelAvailableAssemblies.TabIndex = 3;
            this.labelAvailableAssemblies.Text = "Доступные сборки";
            // 
            // labelStartedAssemblies
            // 
            this.labelStartedAssemblies.AutoSize = true;
            this.labelStartedAssemblies.Location = new System.Drawing.Point(455, 13);
            this.labelStartedAssemblies.Name = "labelStartedAssemblies";
            this.labelStartedAssemblies.Size = new System.Drawing.Size(111, 13);
            this.labelStartedAssemblies.TabIndex = 4;
            this.labelStartedAssemblies.Text = "Запущенные сборки";
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(354, 68);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(89, 23);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonCloseWindow
            // 
            this.buttonCloseWindow.Location = new System.Drawing.Point(354, 97);
            this.buttonCloseWindow.Name = "buttonCloseWindow";
            this.buttonCloseWindow.Size = new System.Drawing.Size(89, 23);
            this.buttonCloseWindow.TabIndex = 6;
            this.buttonCloseWindow.Text = "Close Window";
            this.buttonCloseWindow.UseVisualStyleBackColor = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(354, 127);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(89, 23);
            this.buttonRefresh.TabIndex = 7;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonCloseWindow);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.labelStartedAssemblies);
            this.Controls.Add(this.labelAvailableAssemblies);
            this.Controls.Add(this.buttonStrat);
            this.Controls.Add(this.listBoxStartedAssemblies);
            this.Controls.Add(this.listBoxAvailableAssemblies);
            this.Name = "MainForm";
            this.Text = "Manipulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAvailableAssemblies;
        private System.Windows.Forms.ListBox listBoxStartedAssemblies;
        private System.Windows.Forms.Button buttonStrat;
        private System.Windows.Forms.Label labelAvailableAssemblies;
        private System.Windows.Forms.Label labelStartedAssemblies;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonCloseWindow;
        private System.Windows.Forms.Button buttonRefresh;
    }
}

