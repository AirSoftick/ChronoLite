namespace ChronoLite
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonStart = new Guna.UI2.WinForms.Guna2Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.labelTopmost = new System.Windows.Forms.Label();
            this.toggletopmost = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.buttonPlay = new Guna.UI2.WinForms.Guna2Button();
            this.PanelTime = new Guna.UI2.WinForms.Guna2Panel();
            this.MainTime = new Guna.UI2.WinForms.Guna2Button();
            this.IntervalTime = new Guna.UI2.WinForms.Guna2Button();
            this.buttonClearTime = new Guna.UI2.WinForms.Guna2Button();
            this.buttonInterval = new Guna.UI2.WinForms.Guna2Button();
            this.buttonStop = new Guna.UI2.WinForms.Guna2Button();
            this.DragPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.buttonMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.buttonClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.SettingsAndBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.MainPanel.SuspendLayout();
            this.PanelTime.SuspendLayout();
            this.DragPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Animated = true;
            this.buttonStart.AutoRoundedCorners = true;
            this.buttonStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart.BorderRadius = 21;
            this.buttonStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(128)))));
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonStart.ForeColor = System.Drawing.Color.White;
            this.buttonStart.Location = new System.Drawing.Point(60, 165);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(106, 45);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Начать";
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MainPanel.Controls.Add(this.labelTopmost);
            this.MainPanel.Controls.Add(this.toggletopmost);
            this.MainPanel.Controls.Add(this.buttonPlay);
            this.MainPanel.Controls.Add(this.PanelTime);
            this.MainPanel.Controls.Add(this.buttonClearTime);
            this.MainPanel.Controls.Add(this.buttonInterval);
            this.MainPanel.Controls.Add(this.buttonStop);
            this.MainPanel.Controls.Add(this.DragPanel);
            this.MainPanel.Controls.Add(this.buttonStart);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(237, 223);
            this.MainPanel.TabIndex = 1;
            // 
            // labelTopmost
            // 
            this.labelTopmost.AutoSize = true;
            this.labelTopmost.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTopmost.ForeColor = System.Drawing.Color.White;
            this.labelTopmost.Location = new System.Drawing.Point(256, 36);
            this.labelTopmost.Name = "labelTopmost";
            this.labelTopmost.Size = new System.Drawing.Size(56, 18);
            this.labelTopmost.TabIndex = 8;
            this.labelTopmost.Text = "TopMost";
            // 
            // toggletopmost
            // 
            this.toggletopmost.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.toggletopmost.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.toggletopmost.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggletopmost.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toggletopmost.Location = new System.Drawing.Point(318, 35);
            this.toggletopmost.Name = "toggletopmost";
            this.toggletopmost.Size = new System.Drawing.Size(35, 20);
            this.toggletopmost.TabIndex = 3;
            this.toggletopmost.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggletopmost.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggletopmost.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggletopmost.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.toggletopmost.CheckedChanged += new System.EventHandler(this.toggletopmost_CheckedChanged);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Animated = true;
            this.buttonPlay.AutoRoundedCorners = true;
            this.buttonPlay.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.BorderRadius = 21;
            this.buttonPlay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonPlay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonPlay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonPlay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonPlay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.buttonPlay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonPlay.ForeColor = System.Drawing.Color.White;
            this.buttonPlay.Location = new System.Drawing.Point(12, 165);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(94, 45);
            this.buttonPlay.TabIndex = 5;
            this.buttonPlay.Text = "Продолж.";
            this.buttonPlay.Visible = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // PanelTime
            // 
            this.PanelTime.Controls.Add(this.MainTime);
            this.PanelTime.Controls.Add(this.IntervalTime);
            this.PanelTime.Location = new System.Drawing.Point(0, 35);
            this.PanelTime.Name = "PanelTime";
            this.PanelTime.Size = new System.Drawing.Size(237, 124);
            this.PanelTime.TabIndex = 0;
            // 
            // MainTime
            // 
            this.MainTime.BorderColor = System.Drawing.Color.White;
            this.MainTime.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MainTime.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MainTime.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MainTime.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MainTime.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MainTime.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MainTime.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MainTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MainTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MainTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MainTime.FocusedColor = System.Drawing.Color.White;
            this.MainTime.Font = new System.Drawing.Font("Trebuchet MS", 27.75F);
            this.MainTime.ForeColor = System.Drawing.Color.White;
            this.MainTime.HoverState.BorderColor = System.Drawing.Color.White;
            this.MainTime.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.MainTime.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MainTime.HoverState.ForeColor = System.Drawing.Color.White;
            this.MainTime.Location = new System.Drawing.Point(0, 3);
            this.MainTime.Name = "MainTime";
            this.MainTime.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MainTime.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MainTime.Size = new System.Drawing.Size(237, 69);
            this.MainTime.TabIndex = 2;
            this.MainTime.Text = "00:00.0";
            // 
            // IntervalTime
            // 
            this.IntervalTime.Animated = true;
            this.IntervalTime.BorderColor = System.Drawing.Color.White;
            this.IntervalTime.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.IntervalTime.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.IntervalTime.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.IntervalTime.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.IntervalTime.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.IntervalTime.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.IntervalTime.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.IntervalTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.IntervalTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.IntervalTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.IntervalTime.FocusedColor = System.Drawing.Color.White;
            this.IntervalTime.Font = new System.Drawing.Font("Trebuchet MS", 14.25F);
            this.IntervalTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.IntervalTime.HoverState.BorderColor = System.Drawing.Color.White;
            this.IntervalTime.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.IntervalTime.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.IntervalTime.HoverState.ForeColor = System.Drawing.Color.White;
            this.IntervalTime.Location = new System.Drawing.Point(0, 65);
            this.IntervalTime.Name = "IntervalTime";
            this.IntervalTime.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.IntervalTime.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.IntervalTime.Size = new System.Drawing.Size(237, 28);
            this.IntervalTime.TabIndex = 7;
            this.IntervalTime.Text = "00:00.0";
            this.IntervalTime.Visible = false;
            // 
            // buttonClearTime
            // 
            this.buttonClearTime.Animated = true;
            this.buttonClearTime.AutoRoundedCorners = true;
            this.buttonClearTime.BackColor = System.Drawing.Color.Transparent;
            this.buttonClearTime.BorderRadius = 21;
            this.buttonClearTime.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonClearTime.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonClearTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonClearTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonClearTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.buttonClearTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonClearTime.ForeColor = System.Drawing.Color.White;
            this.buttonClearTime.Location = new System.Drawing.Point(124, 165);
            this.buttonClearTime.Name = "buttonClearTime";
            this.buttonClearTime.Size = new System.Drawing.Size(101, 45);
            this.buttonClearTime.TabIndex = 6;
            this.buttonClearTime.Text = "Сбросить";
            this.buttonClearTime.Visible = false;
            this.buttonClearTime.Click += new System.EventHandler(this.buttonClearTime_Click);
            // 
            // buttonInterval
            // 
            this.buttonInterval.Animated = true;
            this.buttonInterval.AutoRoundedCorners = true;
            this.buttonInterval.BackColor = System.Drawing.Color.Transparent;
            this.buttonInterval.BorderRadius = 21;
            this.buttonInterval.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonInterval.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonInterval.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonInterval.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonInterval.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.buttonInterval.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonInterval.ForeColor = System.Drawing.Color.White;
            this.buttonInterval.Location = new System.Drawing.Point(124, 165);
            this.buttonInterval.Name = "buttonInterval";
            this.buttonInterval.Size = new System.Drawing.Size(101, 45);
            this.buttonInterval.TabIndex = 4;
            this.buttonInterval.Text = "Интервал";
            this.buttonInterval.Visible = false;
            this.buttonInterval.Click += new System.EventHandler(this.buttonInterval_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Animated = true;
            this.buttonStop.AutoRoundedCorners = true;
            this.buttonStop.BackColor = System.Drawing.Color.Transparent;
            this.buttonStop.BorderRadius = 21;
            this.buttonStop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonStop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonStop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonStop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonStop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(17)))), ((int)(((byte)(25)))));
            this.buttonStop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonStop.ForeColor = System.Drawing.Color.White;
            this.buttonStop.Location = new System.Drawing.Point(12, 165);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(94, 45);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Стоп";
            this.buttonStop.Visible = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // DragPanel
            // 
            this.DragPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.DragPanel.Controls.Add(this.buttonMinimize);
            this.DragPanel.Controls.Add(this.buttonClose);
            this.DragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DragPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.DragPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.DragPanel.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.DragPanel.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.DragPanel.Location = new System.Drawing.Point(0, 0);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.Size = new System.Drawing.Size(237, 29);
            this.DragPanel.TabIndex = 1;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.buttonMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.buttonMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonMinimize.IconColor = System.Drawing.Color.White;
            this.buttonMinimize.Location = new System.Drawing.Point(139, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(45, 29);
            this.buttonMinimize.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.buttonClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonClose.IconColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(189, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(45, 29);
            this.buttonClose.TabIndex = 0;
            // 
            // DragControl
            // 
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.DragStartTransparencyValue = 0.1D;
            this.DragControl.TargetControl = this.DragPanel;
            this.DragControl.TransparentWhileDrag = false;
            // 
            // SettingsAndBack
            // 
            this.SettingsAndBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SettingsAndBack.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.SettingsAndBack.HoverState.ImageSize = new System.Drawing.Size(23, 23);
            this.SettingsAndBack.Image = global::ChronoLite.Properties.Resources.setting1s;
            this.SettingsAndBack.ImageOffset = new System.Drawing.Point(0, 0);
            this.SettingsAndBack.ImageRotate = 0F;
            this.SettingsAndBack.ImageSize = new System.Drawing.Size(23, 23);
            this.SettingsAndBack.Location = new System.Drawing.Point(0, 0);
            this.SettingsAndBack.Name = "SettingsAndBack";
            this.SettingsAndBack.PressedState.ImageSize = new System.Drawing.Size(21, 21);
            this.SettingsAndBack.Size = new System.Drawing.Size(31, 29);
            this.SettingsAndBack.TabIndex = 2;
            this.SettingsAndBack.Click += new System.EventHandler(this.SettingsAndBack_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 223);
            this.Controls.Add(this.SettingsAndBack);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "ChronoLite";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.PanelTime.ResumeLayout(false);
            this.DragPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button buttonStart;
        private System.Windows.Forms.Panel MainPanel;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel DragPanel;
        private Guna.UI2.WinForms.Guna2ControlBox buttonMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox buttonClose;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2Button buttonInterval;
        private Guna.UI2.WinForms.Guna2Button buttonStop;
        private Guna.UI2.WinForms.Guna2Button MainTime;
        private Guna.UI2.WinForms.Guna2Button buttonPlay;
        private Guna.UI2.WinForms.Guna2Button buttonClearTime;
        private Guna.UI2.WinForms.Guna2Button IntervalTime;
        private Guna.UI2.WinForms.Guna2Panel PanelTime;
        private Guna.UI2.WinForms.Guna2ImageButton SettingsAndBack;
        private System.Windows.Forms.Label labelTopmost;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggletopmost;
    }
}

