
namespace DbProjectFinal
{
    partial class MeetingEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeetingEdit));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.endTime = new System.Windows.Forms.DateTimePicker();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.datePicker = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.juryButton = new Bunifu.UI.WinForms.BunifuDropdown();
            this.projectButton = new Bunifu.UI.WinForms.BunifuDropdown();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuImageButton2 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.venueInput = new Bunifu.UI.WinForms.BunifuTextBox();
            this.SuspendLayout();
            // 
            // endTime
            // 
            this.endTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endTime.Location = new System.Drawing.Point(90, 283);
            this.endTime.Name = "endTime";
            this.endTime.ShowUpDown = true;
            this.endTime.Size = new System.Drawing.Size(220, 20);
            this.endTime.TabIndex = 53;
            // 
            // startTime
            // 
            this.startTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTime.Location = new System.Drawing.Point(90, 233);
            this.startTime.Name = "startTime";
            this.startTime.ShowUpDown = true;
            this.startTime.Size = new System.Drawing.Size(220, 20);
            this.startTime.TabIndex = 52;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel3.Location = new System.Drawing.Point(15, 283);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(49, 15);
            this.bunifuLabel3.TabIndex = 51;
            this.bunifuLabel3.Text = "End Time";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel2.Location = new System.Drawing.Point(15, 233);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(51, 15);
            this.bunifuLabel2.TabIndex = 50;
            this.bunifuLabel2.Text = "Start time";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // datePicker
            // 
            this.datePicker.BackColor = System.Drawing.Color.Transparent;
            this.datePicker.BorderColor = System.Drawing.Color.Silver;
            this.datePicker.BorderRadius = 1;
            this.datePicker.Color = System.Drawing.Color.Silver;
            this.datePicker.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.datePicker.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.datePicker.DisabledColor = System.Drawing.Color.Gray;
            this.datePicker.DisplayWeekNumbers = false;
            this.datePicker.DPHeight = 0;
            this.datePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.datePicker.FillDatePicker = false;
            this.datePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datePicker.ForeColor = System.Drawing.Color.Black;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Icon = ((System.Drawing.Image)(resources.GetObject("datePicker.Icon")));
            this.datePicker.IconColor = System.Drawing.Color.Gray;
            this.datePicker.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.datePicker.LeftTextMargin = 5;
            this.datePicker.Location = new System.Drawing.Point(90, 167);
            this.datePicker.MinimumSize = new System.Drawing.Size(4, 32);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(220, 32);
            this.datePicker.TabIndex = 49;
            // 
            // juryButton
            // 
            this.juryButton.BackColor = System.Drawing.Color.Transparent;
            this.juryButton.BackgroundColor = System.Drawing.Color.White;
            this.juryButton.BorderColor = System.Drawing.Color.Silver;
            this.juryButton.BorderRadius = 1;
            this.juryButton.Color = System.Drawing.Color.Silver;
            this.juryButton.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.juryButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.juryButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.juryButton.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.juryButton.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.juryButton.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.juryButton.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.juryButton.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.juryButton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.juryButton.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Center;
            this.juryButton.FillDropDown = true;
            this.juryButton.FillIndicator = false;
            this.juryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.juryButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.juryButton.ForeColor = System.Drawing.Color.Black;
            this.juryButton.FormattingEnabled = true;
            this.juryButton.Icon = null;
            this.juryButton.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.juryButton.IndicatorColor = System.Drawing.Color.DarkGray;
            this.juryButton.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.juryButton.IndicatorThickness = 2;
            this.juryButton.IsDropdownOpened = false;
            this.juryButton.ItemBackColor = System.Drawing.Color.White;
            this.juryButton.ItemBorderColor = System.Drawing.Color.White;
            this.juryButton.ItemForeColor = System.Drawing.Color.Black;
            this.juryButton.ItemHeight = 26;
            this.juryButton.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.juryButton.ItemHighLightForeColor = System.Drawing.Color.White;
            this.juryButton.ItemTopMargin = 3;
            this.juryButton.Location = new System.Drawing.Point(12, 463);
            this.juryButton.Name = "juryButton";
            this.juryButton.Size = new System.Drawing.Size(354, 32);
            this.juryButton.TabIndex = 48;
            this.juryButton.Text = "Choose Jury";
            this.juryButton.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Center;
            this.juryButton.TextLeftMargin = 5;
            // 
            // projectButton
            // 
            this.projectButton.BackColor = System.Drawing.Color.Transparent;
            this.projectButton.BackgroundColor = System.Drawing.Color.White;
            this.projectButton.BorderColor = System.Drawing.Color.Silver;
            this.projectButton.BorderRadius = 1;
            this.projectButton.Color = System.Drawing.Color.Silver;
            this.projectButton.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.projectButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.projectButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.projectButton.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.projectButton.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.projectButton.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.projectButton.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.projectButton.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.projectButton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectButton.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Center;
            this.projectButton.FillDropDown = true;
            this.projectButton.FillIndicator = false;
            this.projectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.projectButton.ForeColor = System.Drawing.Color.Black;
            this.projectButton.FormattingEnabled = true;
            this.projectButton.Icon = null;
            this.projectButton.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.projectButton.IndicatorColor = System.Drawing.Color.DarkGray;
            this.projectButton.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.projectButton.IndicatorThickness = 2;
            this.projectButton.IsDropdownOpened = false;
            this.projectButton.ItemBackColor = System.Drawing.Color.White;
            this.projectButton.ItemBorderColor = System.Drawing.Color.White;
            this.projectButton.ItemForeColor = System.Drawing.Color.Black;
            this.projectButton.ItemHeight = 26;
            this.projectButton.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.projectButton.ItemHighLightForeColor = System.Drawing.Color.White;
            this.projectButton.ItemTopMargin = 3;
            this.projectButton.Location = new System.Drawing.Point(12, 409);
            this.projectButton.Name = "projectButton";
            this.projectButton.Size = new System.Drawing.Size(354, 32);
            this.projectButton.TabIndex = 47;
            this.projectButton.Text = "Choose Project";
            this.projectButton.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Center;
            this.projectButton.TextLeftMargin = 5;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 22;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(124)))), ((int)(((byte)(188)))));
            this.guna2Button1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(69, 519);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(212, 37);
            this.guna2Button1.TabIndex = 46;
            this.guna2Button1.Text = "Update";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.ActiveImage = null;
            this.bunifuImageButton2.AllowAnimations = true;
            this.bunifuImageButton2.AllowBuffering = false;
            this.bunifuImageButton2.AllowToggling = false;
            this.bunifuImageButton2.AllowZooming = true;
            this.bunifuImageButton2.AllowZoomingOnFocus = false;
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ErrorImage")));
            this.bunifuImageButton2.FadeWhenInactive = false;
            this.bunifuImageButton2.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.ImageLocation = null;
            this.bunifuImageButton2.ImageMargin = 20;
            this.bunifuImageButton2.ImageSize = new System.Drawing.Size(31, 29);
            this.bunifuImageButton2.ImageZoomSize = new System.Drawing.Size(51, 49);
            this.bunifuImageButton2.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.InitialImage")));
            this.bunifuImageButton2.Location = new System.Drawing.Point(297, 6);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Rotation = 0;
            this.bunifuImageButton2.ShowActiveImage = true;
            this.bunifuImageButton2.ShowCursorChanges = true;
            this.bunifuImageButton2.ShowImageBorders = true;
            this.bunifuImageButton2.ShowSizeMarkers = false;
            this.bunifuImageButton2.Size = new System.Drawing.Size(51, 49);
            this.bunifuImageButton2.TabIndex = 45;
            this.bunifuImageButton2.ToolTipText = "";
            this.bunifuImageButton2.WaitOnLoad = false;
            this.bunifuImageButton2.Zoom = 20;
            this.bunifuImageButton2.ZoomSpeed = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 20;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(95, 83);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(115, 103);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(12, 49);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(115, 103);
            this.bunifuImageButton1.TabIndex = 44;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.ZoomSpeed = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 36);
            this.label1.TabIndex = 43;
            this.label1.Text = "Meeting Details";
            // 
            // venueInput
            // 
            this.venueInput.AcceptsReturn = false;
            this.venueInput.AcceptsTab = false;
            this.venueInput.AnimationSpeed = 200;
            this.venueInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.venueInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.venueInput.AutoSizeHeight = true;
            this.venueInput.BackColor = System.Drawing.Color.Transparent;
            this.venueInput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("venueInput.BackgroundImage")));
            this.venueInput.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(124)))), ((int)(((byte)(188)))));
            this.venueInput.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(124)))), ((int)(((byte)(188)))));
            this.venueInput.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(124)))), ((int)(((byte)(188)))));
            this.venueInput.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(124)))), ((int)(((byte)(188)))));
            this.venueInput.BorderRadius = 15;
            this.venueInput.BorderThickness = 3;
            this.venueInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.venueInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.venueInput.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.venueInput.DefaultText = "";
            this.venueInput.FillColor = System.Drawing.Color.White;
            this.venueInput.HideSelection = true;
            this.venueInput.IconLeft = null;
            this.venueInput.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.venueInput.IconPadding = 10;
            this.venueInput.IconRight = null;
            this.venueInput.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.venueInput.Lines = new string[0];
            this.venueInput.Location = new System.Drawing.Point(112, 353);
            this.venueInput.MaxLength = 32767;
            this.venueInput.MinimumSize = new System.Drawing.Size(1, 1);
            this.venueInput.Modified = false;
            this.venueInput.Multiline = false;
            this.venueInput.Name = "venueInput";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(124)))), ((int)(((byte)(188)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.venueInput.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(124)))), ((int)(((byte)(188)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.venueInput.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(124)))), ((int)(((byte)(188)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.venueInput.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(124)))), ((int)(((byte)(188)))));
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.venueInput.OnIdleState = stateProperties8;
            this.venueInput.Padding = new System.Windows.Forms.Padding(3);
            this.venueInput.PasswordChar = '\0';
            this.venueInput.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.venueInput.PlaceholderText = "Venue";
            this.venueInput.ReadOnly = false;
            this.venueInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.venueInput.SelectedText = "";
            this.venueInput.SelectionLength = 0;
            this.venueInput.SelectionStart = 0;
            this.venueInput.ShortcutsEnabled = true;
            this.venueInput.Size = new System.Drawing.Size(152, 39);
            this.venueInput.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.venueInput.TabIndex = 42;
            this.venueInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.venueInput.TextMarginBottom = 0;
            this.venueInput.TextMarginLeft = 3;
            this.venueInput.TextMarginTop = 1;
            this.venueInput.TextPlaceholder = "Venue";
            this.venueInput.UseSystemPasswordChar = false;
            this.venueInput.WordWrap = true;
            // 
            // MeetingEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 594);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.juryButton);
            this.Controls.Add(this.projectButton);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.venueInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MeetingEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeetingEdit";
            this.Load += new System.EventHandler(this.MeetingEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker endTime;
        private System.Windows.Forms.DateTimePicker startTime;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuDatePicker datePicker;
        private Bunifu.UI.WinForms.BunifuDropdown juryButton;
        private Bunifu.UI.WinForms.BunifuDropdown projectButton;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton2;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextBox venueInput;
    }
}