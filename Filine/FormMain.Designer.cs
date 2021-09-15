namespace Filine
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.nudRotateZ = new System.Windows.Forms.NumericUpDown();
            this.nudRotateY = new System.Windows.Forms.NumericUpDown();
            this.nudRotateX = new System.Windows.Forms.NumericUpDown();
            this.nudMoveX = new System.Windows.Forms.NumericUpDown();
            this.nudMoveY = new System.Windows.Forms.NumericUpDown();
            this.nudMoveZ = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudRotateStep = new System.Windows.Forms.NumericUpDown();
            this.nudRotateOffset = new System.Windows.Forms.NumericUpDown();
            this.nudMoveStep = new System.Windows.Forms.NumericUpDown();
            this.nudMoveOffset = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnInvertSelection = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnDeselect = new System.Windows.Forms.Button();
            this.btnPositionAlign = new System.Windows.Forms.Button();
            this.btnRotationAlign = new System.Windows.Forms.Button();
            this.btnSaveLines = new System.Windows.Forms.Button();
            this.btnFileLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFilterDelete = new System.Windows.Forms.Button();
            this.btnFilterAdd = new System.Windows.Forms.Button();
            this.clbLines = new System.Windows.Forms.CheckedListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvFilters = new System.Windows.Forms.TreeView();
            this.il3State = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFilterDeleteAll = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotateZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotateY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotateX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoveX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoveY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoveZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotateStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotateOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoveStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoveOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFilter
            // 
            this.tbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilter.Location = new System.Drawing.Point(0, 4);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(116, 20);
            this.tbFilter.TabIndex = 1;
            // 
            // tbFile
            // 
            this.tbFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFile.Location = new System.Drawing.Point(32, 8);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(655, 20);
            this.tbFile.TabIndex = 6;
            // 
            // nudRotateZ
            // 
            this.nudRotateZ.DecimalPlaces = 3;
            this.nudRotateZ.Location = new System.Drawing.Point(314, 40);
            this.nudRotateZ.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nudRotateZ.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.nudRotateZ.Name = "nudRotateZ";
            this.nudRotateZ.Size = new System.Drawing.Size(68, 20);
            this.nudRotateZ.TabIndex = 9;
            this.nudRotateZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudRotateZ.ValueChanged += new System.EventHandler(this.nudRotateXYZ_ValueChanged);
            // 
            // nudRotateY
            // 
            this.nudRotateY.DecimalPlaces = 3;
            this.nudRotateY.Location = new System.Drawing.Point(242, 40);
            this.nudRotateY.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nudRotateY.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.nudRotateY.Name = "nudRotateY";
            this.nudRotateY.Size = new System.Drawing.Size(68, 20);
            this.nudRotateY.TabIndex = 9;
            this.nudRotateY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudRotateY.ValueChanged += new System.EventHandler(this.nudRotateXYZ_ValueChanged);
            // 
            // nudRotateX
            // 
            this.nudRotateX.DecimalPlaces = 3;
            this.nudRotateX.Location = new System.Drawing.Point(170, 40);
            this.nudRotateX.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nudRotateX.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.nudRotateX.Name = "nudRotateX";
            this.nudRotateX.Size = new System.Drawing.Size(68, 20);
            this.nudRotateX.TabIndex = 9;
            this.nudRotateX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudRotateX.ValueChanged += new System.EventHandler(this.nudRotateXYZ_ValueChanged);
            // 
            // nudMoveX
            // 
            this.nudMoveX.DecimalPlaces = 3;
            this.nudMoveX.Location = new System.Drawing.Point(170, 16);
            this.nudMoveX.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nudMoveX.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            -2147483648});
            this.nudMoveX.Name = "nudMoveX";
            this.nudMoveX.Size = new System.Drawing.Size(68, 20);
            this.nudMoveX.TabIndex = 10;
            this.nudMoveX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMoveX.ValueChanged += new System.EventHandler(this.nudMoveXYZ_ValueChanged);
            // 
            // nudMoveY
            // 
            this.nudMoveY.DecimalPlaces = 3;
            this.nudMoveY.Location = new System.Drawing.Point(242, 16);
            this.nudMoveY.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nudMoveY.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            -2147483648});
            this.nudMoveY.Name = "nudMoveY";
            this.nudMoveY.Size = new System.Drawing.Size(68, 20);
            this.nudMoveY.TabIndex = 11;
            this.nudMoveY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMoveY.ValueChanged += new System.EventHandler(this.nudMoveXYZ_ValueChanged);
            // 
            // nudMoveZ
            // 
            this.nudMoveZ.DecimalPlaces = 3;
            this.nudMoveZ.Location = new System.Drawing.Point(314, 16);
            this.nudMoveZ.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nudMoveZ.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            -2147483648});
            this.nudMoveZ.Name = "nudMoveZ";
            this.nudMoveZ.Size = new System.Drawing.Size(68, 20);
            this.nudMoveZ.TabIndex = 12;
            this.nudMoveZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMoveZ.ValueChanged += new System.EventHandler(this.nudMoveXYZ_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(198, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(270, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(338, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "z";
            // 
            // nudRotateStep
            // 
            this.nudRotateStep.DecimalPlaces = 3;
            this.nudRotateStep.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudRotateStep.Location = new System.Drawing.Point(28, 40);
            this.nudRotateStep.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nudRotateStep.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.nudRotateStep.Name = "nudRotateStep";
            this.nudRotateStep.Size = new System.Drawing.Size(64, 20);
            this.nudRotateStep.TabIndex = 10;
            this.nudRotateStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudRotateStep.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.nudRotateStep.ValueChanged += new System.EventHandler(this.nudRotateStep_ValueChanged);
            // 
            // nudRotateOffset
            // 
            this.nudRotateOffset.DecimalPlaces = 3;
            this.nudRotateOffset.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudRotateOffset.Location = new System.Drawing.Point(96, 40);
            this.nudRotateOffset.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nudRotateOffset.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.nudRotateOffset.Name = "nudRotateOffset";
            this.nudRotateOffset.Size = new System.Drawing.Size(64, 20);
            this.nudRotateOffset.TabIndex = 10;
            this.nudRotateOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudMoveStep
            // 
            this.nudMoveStep.DecimalPlaces = 3;
            this.nudMoveStep.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudMoveStep.Location = new System.Drawing.Point(28, 16);
            this.nudMoveStep.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nudMoveStep.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.nudMoveStep.Name = "nudMoveStep";
            this.nudMoveStep.Size = new System.Drawing.Size(64, 20);
            this.nudMoveStep.TabIndex = 10;
            this.nudMoveStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMoveStep.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudMoveStep.ValueChanged += new System.EventHandler(this.nudMoveStep_ValueChanged);
            // 
            // nudMoveOffset
            // 
            this.nudMoveOffset.DecimalPlaces = 3;
            this.nudMoveOffset.Increment = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.nudMoveOffset.Location = new System.Drawing.Point(96, 16);
            this.nudMoveOffset.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nudMoveOffset.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.nudMoveOffset.Name = "nudMoveOffset";
            this.nudMoveOffset.Size = new System.Drawing.Size(64, 20);
            this.nudMoveOffset.TabIndex = 10;
            this.nudMoveOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(44, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "step";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(112, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "offset";
            // 
            // btnInvertSelection
            // 
            this.btnInvertSelection.BackgroundImage = global::Filine.Properties.Resources.checkerInvert;
            this.btnInvertSelection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInvertSelection.FlatAppearance.BorderSize = 0;
            this.btnInvertSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvertSelection.Location = new System.Drawing.Point(40, 28);
            this.btnInvertSelection.Name = "btnInvertSelection";
            this.btnInvertSelection.Size = new System.Drawing.Size(20, 20);
            this.btnInvertSelection.TabIndex = 19;
            this.toolTip.SetToolTip(this.btnInvertSelection, "Invert selection");
            this.btnInvertSelection.UseVisualStyleBackColor = true;
            this.btnInvertSelection.Click += new System.EventHandler(this.btnInvertSelection_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackgroundImage = global::Filine.Properties.Resources.checkerFilled;
            this.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Location = new System.Drawing.Point(0, 28);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(20, 20);
            this.btnSelect.TabIndex = 18;
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.toolTip.SetToolTip(this.btnSelect, "Select all");
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnDeselect
            // 
            this.btnDeselect.BackgroundImage = global::Filine.Properties.Resources.checkerEmpty;
            this.btnDeselect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeselect.FlatAppearance.BorderSize = 0;
            this.btnDeselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeselect.Location = new System.Drawing.Point(20, 28);
            this.btnDeselect.Name = "btnDeselect";
            this.btnDeselect.Size = new System.Drawing.Size(20, 20);
            this.btnDeselect.TabIndex = 17;
            this.toolTip.SetToolTip(this.btnDeselect, "Deselect all");
            this.btnDeselect.UseVisualStyleBackColor = true;
            this.btnDeselect.Click += new System.EventHandler(this.btnDeselect_Click);
            // 
            // btnPositionAlign
            // 
            this.btnPositionAlign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPositionAlign.Image = ((System.Drawing.Image)(resources.GetObject("btnPositionAlign.Image")));
            this.btnPositionAlign.Location = new System.Drawing.Point(4, 16);
            this.btnPositionAlign.Name = "btnPositionAlign";
            this.btnPositionAlign.Size = new System.Drawing.Size(21, 21);
            this.btnPositionAlign.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnPositionAlign, "Align position");
            this.btnPositionAlign.UseVisualStyleBackColor = true;
            this.btnPositionAlign.Click += new System.EventHandler(this.btnPositionAlign_Click);
            // 
            // btnRotationAlign
            // 
            this.btnRotationAlign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRotationAlign.Image = global::Filine.Properties.Resources.reload;
            this.btnRotationAlign.Location = new System.Drawing.Point(4, 40);
            this.btnRotationAlign.Name = "btnRotationAlign";
            this.btnRotationAlign.Size = new System.Drawing.Size(21, 21);
            this.btnRotationAlign.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnRotationAlign, "Align rotation");
            this.btnRotationAlign.UseVisualStyleBackColor = true;
            this.btnRotationAlign.Click += new System.EventHandler(this.btnRotationAlign_Click);
            // 
            // btnSaveLines
            // 
            this.btnSaveLines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveLines.AutoEllipsis = true;
            this.btnSaveLines.BackgroundImage = global::Filine.Properties.Resources.save;
            this.btnSaveLines.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveLines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveLines.Location = new System.Drawing.Point(539, 260);
            this.btnSaveLines.Name = "btnSaveLines";
            this.btnSaveLines.Size = new System.Drawing.Size(20, 20);
            this.btnSaveLines.TabIndex = 20;
            this.btnSaveLines.UseVisualStyleBackColor = true;
            this.btnSaveLines.Click += new System.EventHandler(this.btnSaveLines_Click);
            // 
            // btnFileLoad
            // 
            this.btnFileLoad.BackgroundImage = global::Filine.Properties.Resources.load;
            this.btnFileLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFileLoad.FlatAppearance.BorderSize = 0;
            this.btnFileLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileLoad.Location = new System.Drawing.Point(8, 8);
            this.btnFileLoad.Name = "btnFileLoad";
            this.btnFileLoad.Size = new System.Drawing.Size(20, 20);
            this.btnFileLoad.TabIndex = 2;
            this.btnFileLoad.UseVisualStyleBackColor = true;
            this.btnFileLoad.Click += new System.EventHandler(this.btnFileLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackgroundImage = global::Filine.Properties.Resources.save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(691, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(20, 20);
            this.btnSave.TabIndex = 8;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnFileSave_Click);
            // 
            // btnFilterDelete
            // 
            this.btnFilterDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilterDelete.BackgroundImage = global::Filine.Properties.Resources.delete;
            this.btnFilterDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFilterDelete.FlatAppearance.BorderSize = 0;
            this.btnFilterDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterDelete.Location = new System.Drawing.Point(120, 28);
            this.btnFilterDelete.Name = "btnFilterDelete";
            this.btnFilterDelete.Size = new System.Drawing.Size(20, 20);
            this.btnFilterDelete.TabIndex = 2;
            this.btnFilterDelete.UseVisualStyleBackColor = true;
            this.btnFilterDelete.Visible = false;
            this.btnFilterDelete.Click += new System.EventHandler(this.btnFilterDelete_Click);
            // 
            // btnFilterAdd
            // 
            this.btnFilterAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilterAdd.BackgroundImage = global::Filine.Properties.Resources.add;
            this.btnFilterAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFilterAdd.FlatAppearance.BorderSize = 0;
            this.btnFilterAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterAdd.Location = new System.Drawing.Point(120, 4);
            this.btnFilterAdd.Name = "btnFilterAdd";
            this.btnFilterAdd.Size = new System.Drawing.Size(20, 20);
            this.btnFilterAdd.TabIndex = 2;
            this.btnFilterAdd.UseVisualStyleBackColor = true;
            this.btnFilterAdd.Click += new System.EventHandler(this.btnFilterAdd_Click);
            // 
            // clbLines
            // 
            this.clbLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbLines.FormattingEnabled = true;
            this.clbLines.HorizontalScrollbar = true;
            this.clbLines.IntegralHeight = false;
            this.clbLines.Location = new System.Drawing.Point(0, 88);
            this.clbLines.Name = "clbLines";
            this.clbLines.ScrollAlwaysVisible = true;
            this.clbLines.Size = new System.Drawing.Size(561, 194);
            this.clbLines.TabIndex = 21;
            this.clbLines.ThreeDCheckBoxes = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(8, 32);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvFilters);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1MinSize = 140;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnSaveLines);
            this.splitContainer1.Panel2.Controls.Add(this.clbLines);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2MinSize = 300;
            this.splitContainer1.Size = new System.Drawing.Size(707, 282);
            this.splitContainer1.SplitterDistance = 140;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 22;
            // 
            // tvFilters
            // 
            this.tvFilters.CausesValidation = false;
            this.tvFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFilters.FullRowSelect = true;
            this.tvFilters.HideSelection = false;
            this.tvFilters.LabelEdit = true;
            this.tvFilters.Location = new System.Drawing.Point(0, 52);
            this.tvFilters.Name = "tvFilters";
            this.tvFilters.ShowLines = false;
            this.tvFilters.ShowNodeToolTips = true;
            this.tvFilters.ShowPlusMinus = false;
            this.tvFilters.Size = new System.Drawing.Size(140, 230);
            this.tvFilters.StateImageList = this.il3State;
            this.tvFilters.TabIndex = 16;
            this.tvFilters.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.tvFilters_AfterLabelEdit);
            this.tvFilters.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvFilters_AfterSelect);
            this.tvFilters.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvFilters_NodeMouseClick);
            this.tvFilters.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvFilters_NodeMouseClick);
            this.tvFilters.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tvFilters_KeyPress);
            // 
            // il3State
            // 
            this.il3State.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il3State.ImageStream")));
            this.il3State.TransparentColor = System.Drawing.Color.Transparent;
            this.il3State.Images.SetKeyName(0, "checkerEmpty.png");
            this.il3State.Images.SetKeyName(1, "checkerFilled.png");
            this.il3State.Images.SetKeyName(2, "checkerInvert.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFilterDeleteAll);
            this.panel1.Controls.Add(this.tbFilter);
            this.panel1.Controls.Add(this.btnFilterAdd);
            this.panel1.Controls.Add(this.btnFilterDelete);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.btnDeselect);
            this.panel1.Controls.Add(this.btnInvertSelection);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 52);
            this.panel1.TabIndex = 15;
            // 
            // btnFilterDeleteAll
            // 
            this.btnFilterDeleteAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilterDeleteAll.BackgroundImage = global::Filine.Properties.Resources.deleteAll;
            this.btnFilterDeleteAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFilterDeleteAll.FlatAppearance.BorderSize = 0;
            this.btnFilterDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterDeleteAll.Location = new System.Drawing.Point(96, 28);
            this.btnFilterDeleteAll.Name = "btnFilterDeleteAll";
            this.btnFilterDeleteAll.Size = new System.Drawing.Size(20, 20);
            this.btnFilterDeleteAll.TabIndex = 3;
            this.btnFilterDeleteAll.UseVisualStyleBackColor = true;
            this.btnFilterDeleteAll.Visible = false;
            this.btnFilterDeleteAll.Click += new System.EventHandler(this.btnFilterDeleteAll_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.nudMoveStep);
            this.panel2.Controls.Add(this.nudRotateOffset);
            this.panel2.Controls.Add(this.nudRotateZ);
            this.panel2.Controls.Add(this.nudMoveOffset);
            this.panel2.Controls.Add(this.nudRotateStep);
            this.panel2.Controls.Add(this.btnRotationAlign);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.nudMoveX);
            this.panel2.Controls.Add(this.btnPositionAlign);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.nudMoveY);
            this.panel2.Controls.Add(this.nudRotateY);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.nudMoveZ);
            this.panel2.Controls.Add(this.nudRotateX);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 88);
            this.panel2.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(0, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(560, 20);
            this.textBox1.TabIndex = 21;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 318);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnFileLoad);
            this.Controls.Add(this.tbFile);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 240);
            this.Name = "FormMain";
            this.Text = "Filine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FilineMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudRotateZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotateY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotateX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoveX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoveY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoveZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotateStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotateOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoveStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoveOffset)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Button btnFilterAdd;
        private System.Windows.Forms.Button btnFilterDelete;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFileLoad;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.NumericUpDown nudRotateZ;
        private System.Windows.Forms.NumericUpDown nudRotateY;
        private System.Windows.Forms.NumericUpDown nudRotateX;
        private System.Windows.Forms.NumericUpDown nudMoveX;
        private System.Windows.Forms.NumericUpDown nudMoveY;
        private System.Windows.Forms.NumericUpDown nudMoveZ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudRotateStep;
        private System.Windows.Forms.NumericUpDown nudRotateOffset;
        private System.Windows.Forms.NumericUpDown nudMoveStep;
        private System.Windows.Forms.NumericUpDown nudMoveOffset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPositionAlign;
        private System.Windows.Forms.Button btnRotationAlign;
        private System.Windows.Forms.Button btnDeselect;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnInvertSelection;
        private System.Windows.Forms.Button btnSaveLines;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckedListBox clbLines;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFilterDeleteAll;
        public System.Windows.Forms.TreeView tvFilters;
        private System.Windows.Forms.ImageList il3State;
    }
}
