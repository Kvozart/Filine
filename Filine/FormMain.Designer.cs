﻿namespace Filine
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
            this.lvFilters = new System.Windows.Forms.ListView();
            this.tvLines = new System.Windows.Forms.TreeView();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnDeselect = new System.Windows.Forms.Button();
            this.btnFileLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFilterSub = new System.Windows.Forms.Button();
            this.btnPositionAlign = new System.Windows.Forms.Button();
            this.btnRotationAlign = new System.Windows.Forms.Button();
            this.btnFilterAdd = new System.Windows.Forms.Button();
            this.btnInvertSelection = new System.Windows.Forms.Button();
            this.btnSaveLines = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(32, 36);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(108, 20);
            this.tbFilter.TabIndex = 1;
            // 
            // tbFile
            // 
            this.tbFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFile.Location = new System.Drawing.Point(32, 8);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(560, 20);
            this.tbFile.TabIndex = 6;
            // 
            // nudRotateZ
            // 
            this.nudRotateZ.DecimalPlaces = 3;
            this.nudRotateZ.Location = new System.Drawing.Point(548, 72);
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
            this.nudRotateY.Location = new System.Drawing.Point(476, 72);
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
            this.nudRotateX.Location = new System.Drawing.Point(404, 72);
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
            this.nudMoveX.Location = new System.Drawing.Point(404, 44);
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
            this.nudMoveY.Location = new System.Drawing.Point(476, 44);
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
            this.nudMoveZ.Location = new System.Drawing.Point(548, 44);
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
            this.label2.Location = new System.Drawing.Point(432, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(504, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(572, 28);
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
            this.nudRotateStep.Location = new System.Drawing.Point(262, 72);
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
            this.nudRotateOffset.Location = new System.Drawing.Point(330, 72);
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
            this.nudMoveStep.Location = new System.Drawing.Point(262, 44);
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
            this.nudMoveOffset.Location = new System.Drawing.Point(330, 44);
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
            this.label5.Location = new System.Drawing.Point(278, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "step";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(346, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "offset";
            // 
            // lvFilters
            // 
            this.lvFilters.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvFilters.AutoArrange = false;
            this.lvFilters.CausesValidation = false;
            this.lvFilters.CheckBoxes = true;
            this.lvFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvFilters.FullRowSelect = true;
            this.lvFilters.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvFilters.HideSelection = false;
            this.lvFilters.LabelEdit = true;
            this.lvFilters.LabelWrap = false;
            this.lvFilters.Location = new System.Drawing.Point(8, 64);
            this.lvFilters.Name = "lvFilters";
            this.lvFilters.Size = new System.Drawing.Size(180, 132);
            this.lvFilters.TabIndex = 14;
            this.lvFilters.UseCompatibleStateImageBehavior = false;
            this.lvFilters.View = System.Windows.Forms.View.List;
            this.lvFilters.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lvFilters_AfterLabelEdit);
            this.lvFilters.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvFilters_ItemChecked);
            this.lvFilters.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvFilters_ItemSelectionChanged);
            this.lvFilters.SelectedIndexChanged += new System.EventHandler(this.lvFilters_SelectedIndexChanged);
            // 
            // tvLines
            // 
            this.tvLines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvLines.CheckBoxes = true;
            this.tvLines.FullRowSelect = true;
            this.tvLines.LabelEdit = true;
            this.tvLines.Location = new System.Drawing.Point(204, 96);
            this.tvLines.Name = "tvLines";
            this.tvLines.ShowLines = false;
            this.tvLines.ShowPlusMinus = false;
            this.tvLines.ShowRootLines = false;
            this.tvLines.Size = new System.Drawing.Size(412, 100);
            this.tvLines.TabIndex = 16;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnSelect
            // 
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Image = global::Filine.Properties.Resources.checkerFilled;
            this.btnSelect.Location = new System.Drawing.Point(204, 44);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(17, 17);
            this.btnSelect.TabIndex = 18;
            this.toolTip.SetToolTip(this.btnSelect, "Select all");
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnDeselect
            // 
            this.btnDeselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeselect.Image = global::Filine.Properties.Resources.checkerEmpty;
            this.btnDeselect.Location = new System.Drawing.Point(204, 76);
            this.btnDeselect.Name = "btnDeselect";
            this.btnDeselect.Size = new System.Drawing.Size(17, 17);
            this.btnDeselect.TabIndex = 17;
            this.toolTip.SetToolTip(this.btnDeselect, "Deselect all");
            this.btnDeselect.UseVisualStyleBackColor = true;
            this.btnDeselect.Click += new System.EventHandler(this.btnDeselect_Click);
            // 
            // btnFileLoad
            // 
            this.btnFileLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileLoad.Image = global::Filine.Properties.Resources.load;
            this.btnFileLoad.Location = new System.Drawing.Point(8, 7);
            this.btnFileLoad.Name = "btnFileLoad";
            this.btnFileLoad.Size = new System.Drawing.Size(21, 21);
            this.btnFileLoad.TabIndex = 2;
            this.btnFileLoad.UseVisualStyleBackColor = true;
            this.btnFileLoad.Click += new System.EventHandler(this.btnFileLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::Filine.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(596, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(21, 21);
            this.btnSave.TabIndex = 8;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnFileSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Filine.Properties.Resources.filter;
            this.pictureBox1.Location = new System.Drawing.Point(8, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnFilterSub
            // 
            this.btnFilterSub.Enabled = false;
            this.btnFilterSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterSub.Image = global::Filine.Properties.Resources.delete;
            this.btnFilterSub.Location = new System.Drawing.Point(144, 36);
            this.btnFilterSub.Name = "btnFilterSub";
            this.btnFilterSub.Size = new System.Drawing.Size(21, 21);
            this.btnFilterSub.TabIndex = 2;
            this.btnFilterSub.UseVisualStyleBackColor = true;
            this.btnFilterSub.Click += new System.EventHandler(this.btnFilterSub_Click);
            // 
            // btnPositionAlign
            // 
            this.btnPositionAlign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPositionAlign.Image = global::Filine.Properties.Resources.toolLevelSmooth;
            this.btnPositionAlign.Location = new System.Drawing.Point(238, 44);
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
            this.btnRotationAlign.Location = new System.Drawing.Point(238, 72);
            this.btnRotationAlign.Name = "btnRotationAlign";
            this.btnRotationAlign.Size = new System.Drawing.Size(21, 21);
            this.btnRotationAlign.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnRotationAlign, "Align rotation");
            this.btnRotationAlign.UseVisualStyleBackColor = true;
            this.btnRotationAlign.Click += new System.EventHandler(this.btnRotationAlign_Click);
            // 
            // btnFilterAdd
            // 
            this.btnFilterAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterAdd.Image = global::Filine.Properties.Resources.add;
            this.btnFilterAdd.Location = new System.Drawing.Point(168, 36);
            this.btnFilterAdd.Name = "btnFilterAdd";
            this.btnFilterAdd.Size = new System.Drawing.Size(21, 21);
            this.btnFilterAdd.TabIndex = 2;
            this.btnFilterAdd.UseVisualStyleBackColor = true;
            this.btnFilterAdd.Click += new System.EventHandler(this.btnFilterAdd_Click);
            // 
            // btnInvertSelection
            // 
            this.btnInvertSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvertSelection.Image = global::Filine.Properties.Resources.checkerInvert;
            this.btnInvertSelection.Location = new System.Drawing.Point(204, 60);
            this.btnInvertSelection.Name = "btnInvertSelection";
            this.btnInvertSelection.Size = new System.Drawing.Size(17, 17);
            this.btnInvertSelection.TabIndex = 19;
            this.toolTip.SetToolTip(this.btnInvertSelection, "Invert selection");
            this.btnInvertSelection.UseVisualStyleBackColor = true;
            this.btnInvertSelection.Click += new System.EventHandler(this.btnInvertSelection_Click);
            // 
            // btnSaveLines
            // 
            this.btnSaveLines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveLines.AutoEllipsis = true;
            this.btnSaveLines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveLines.Image = global::Filine.Properties.Resources.save;
            this.btnSaveLines.Location = new System.Drawing.Point(592, 172);
            this.btnSaveLines.Name = "btnSaveLines";
            this.btnSaveLines.Size = new System.Drawing.Size(20, 20);
            this.btnSaveLines.TabIndex = 20;
            this.btnSaveLines.UseVisualStyleBackColor = true;
            this.btnSaveLines.Click += new System.EventHandler(this.btnSaveLines_Click);
            // 
            // FilineMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 202);
            this.Controls.Add(this.btnSaveLines);
            this.Controls.Add(this.btnInvertSelection);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnDeselect);
            this.Controls.Add(this.tvLines);
            this.Controls.Add(this.lvFilters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudMoveOffset);
            this.Controls.Add(this.nudRotateOffset);
            this.Controls.Add(this.nudMoveStep);
            this.Controls.Add(this.nudRotateStep);
            this.Controls.Add(this.nudMoveX);
            this.Controls.Add(this.nudMoveY);
            this.Controls.Add(this.nudMoveZ);
            this.Controls.Add(this.nudRotateX);
            this.Controls.Add(this.nudRotateY);
            this.Controls.Add(this.nudRotateZ);
            this.Controls.Add(this.btnFileLoad);
            this.Controls.Add(this.tbFile);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.btnFilterSub);
            this.Controls.Add(this.btnPositionAlign);
            this.Controls.Add(this.btnRotationAlign);
            this.Controls.Add(this.btnFilterAdd);
            this.MinimumSize = new System.Drawing.Size(640, 240);
            this.Name = "FilineMain";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Button btnFilterAdd;
        private System.Windows.Forms.Button btnFilterSub;
        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.ListView lvFilters;
        private System.Windows.Forms.TreeView tvLines;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnDeselect;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnInvertSelection;
        private System.Windows.Forms.Button btnSaveLines;
        private System.Windows.Forms.ToolTip toolTip;
    }
}