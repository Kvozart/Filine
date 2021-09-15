﻿using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Filine
{
    public partial class FormMain : Form
    {
        String FileName = "";
        List<String> Lines    = new List<String> { };
        List<String> FLines   = new List<String> { };
        List<Int32>  FEntries = new List<Int32>  { };
        static NumberFormatInfo NFI = new CultureInfo("en-US", false).NumberFormat;

        public FormMain()
        {
            InitializeComponent();

            // Load options
            try
            {
                if (File.Exists("filine.ini"))
                    using (StreamReader file = File.OpenText("filine.ini"))
                        while (!file.EndOfStream)
                        {
                            String line = file.ReadLine();
                            // Decompress
                            String[] rec = line.Split('\t');
                            // Skip empty
                            if (rec.Length < 2)
                                continue;
                            String option = rec[0],
                                   value = rec[1];
                            // Action
                            switch (option)
                            {
                                case "File": tbFile.Text = value; break;
                                case "Filter":
                                    TreeNode Node = tvFilters.Nodes.Add(value);
                                    Node.StateImageIndex = (rec[2] == "+")? 1 : (rec[2] == "-") ? 2 : 0;
                                    break;
                                //
                                case "MoveStep": nudMoveStep.Value = (Decimal)Double.Parse(value); break;
                                case "MoveOffset": nudMoveOffset.Value = (Decimal)Double.Parse(value); break;
                                //case "MoveX":      nudMoveX.Value      = (Decimal)Double.Parse(value); break;
                                //case "MoveY":      nudMoveY.Value      = (Decimal)Double.Parse(value); break;
                                //case "MoveZ":      nudMoveZ.Value      = (Decimal)Double.Parse(value); break;
                                case "RotateStep": nudRotateStep.Value = (Decimal)Double.Parse(value); break;
                                case "RotateOffset": nudRotateOffset.Value = (Decimal)Double.Parse(value); break;
                                //case "RotateX":      nudRotateX.Value      = (Decimal)Double.Parse(value); break;
                                //case "RotateY":      nudRotateY.Value      = (Decimal)Double.Parse(value); break;
                                //case "RotateZ":      nudRotateZ.Value      = (Decimal)Double.Parse(value); break;
                                default:
                                    break;
                            }
                        }
            }
            catch (Exception exc)
            { MessageBox.Show(exc.Message); }
            nudMoveStep_ValueChanged(null, null);
            nudRotateStep_ValueChanged(null, null);

            // Load file to edit
            if (tbFile.Text != "")
                FileLoad();
        }

        private void FilineMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (StreamWriter file = File.CreateText("filine.ini"))
            {
                file.WriteLine("File\t" + tbFile.Text);
                for (int i = 0; i < tvFilters.Nodes.Count; i++)
                    file.WriteLine("Filter\t" + tvFilters.Nodes[i].Text + "\t" + "*+-"[tvFilters.Nodes[i].StateImageIndex]);
                // Move
                file.WriteLine("MoveStep\t" + nudMoveStep.Value);
                file.WriteLine("MoveOffset\t" + nudMoveOffset.Value);
                //file.WriteLine("MoveX\t"      + nudMoveX.Value);
                //file.WriteLine("MoveY\t"      + nudMoveY.Value);
                //file.WriteLine("MoveZ\t"      + nudMoveZ.Value);
                // Rotation
                file.WriteLine("RotateStep\t" + nudRotateStep.Value);
                file.WriteLine("RotateOffset\t" + nudRotateOffset.Value);
                //file.WriteLine("RotateX\t"      + nudRotateX.Value);
                //file.WriteLine("RotateY\t"      + nudRotateY.Value);
                //file.WriteLine("RotateZ\t"      + nudRotateZ.Value);
            }
        }

        private void btnFileLoad_Click(object sender, EventArgs e)
        {
            dlgOpen.FileName = Path.GetFileName(tbFile.Text);
            if (tbFile.Text != "")
                dlgOpen.InitialDirectory = Path.GetFullPath(tbFile.Text).Replace(Path.GetFileName(tbFile.Text), "");
            if (dlgOpen.ShowDialog() != DialogResult.OK)
                return;
            tbFile.Text = dlgOpen.FileName;
            FileLoad();
        }

        private void FileLoad()
        {
            List<String> lines = new List<String> { };
            try
            {
                using (StreamReader file = File.OpenText(tbFile.Text))
                    while (!file.EndOfStream)
                        lines.Add(file.ReadLine());
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return;
            }
            // Successful
            FileName = tbFile.Text;
            Lines = lines;
            FilterLines();
        }

        private void btnFileSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter file = File.CreateText(FileName))
                    foreach (String s in Lines)
                        file.WriteLine(s);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        #region Filters
        private void FilterLines()
        {
            clbLines.BeginUpdate();
            clbLines.Items.Clear();
            FLines.Clear();
            FEntries.Clear();
            nudMoveX.Value = 0; nudRotateX.Value = 0;
            nudMoveY.Value = 0; nudRotateY.Value = 0;
            nudMoveZ.Value = 0; nudRotateZ.Value = 0;
            // Select
            for (int i = 0; i < Lines.Count; i++)
            {
                bool add = true;
                foreach (TreeNode Filter in tvFilters.Nodes)
                    if (0 < Filter.StateImageIndex)
                        if (Lines[i].Contains(Filter.Text) == (2 == Filter.StateImageIndex))
                        {
                            add = false;
                            break;
                        }
                if (!add)
                    continue;
                FEntries.Add(i);
                FLines.Add(Lines[i]);
                clbLines.Items.Add(Lines[i]);
            }
            clbLines.EndUpdate();
        }

        private void btnFilterAdd_Click(object sender, EventArgs e)
        {
            tvFilters.Nodes.Add(tbFilter.Text).StateImageIndex = 1;
            FilterLines();
        }

        private void btnFilterDelete_Click(object sender, EventArgs e)
        {
         // tvFilters.SelectedNode?.Remove();
            tvFilters.SelectedNode.Remove();
            btnFilterDelete.   Visible =
            btnFilterDeleteAll.Visible = (tvFilters.SelectedNode != null);
            FilterLines();
        }

        private void btnFilterDeleteAll_Click(object sender, EventArgs e)
        {
            tvFilters.Nodes.Clear();
            btnFilterDelete.   Visible =
            btnFilterDeleteAll.Visible = false;
            FilterLines();
        }

        private void tvFilters_AfterSelect(object sender, TreeViewEventArgs e)
        {
            btnFilterDelete.   Visible =
            btnFilterDeleteAll.Visible = (tvFilters.SelectedNode != null);
            tbFilter.Text = tvFilters.SelectedNode.Text;
        }

        private void btnFilterLines_Click(object sender, EventArgs e) => FilterLines();

        private void tvFilters_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            e.Node.TreeView.SelectedNode = e.Node;
            if (e.X < e.Node.Bounds.X)
                NodeSwitchState(e.Node, (e.Button == MouseButtons.Left)? 1 : -1);
        }

        private void tvFilters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                NodeSwitchState((sender as TreeView).SelectedNode);
                e.Handled = true;
            }
            if (e.KeyChar == '\r')
            {
                (sender as TreeView).SelectedNode.BeginEdit();
                e.Handled = true;
            }
        }

        private void tvFilters_AfterLabelEdit(object sender, NodeLabelEditEventArgs e) => FilterLines();

        private void NodeSwitchState(TreeNode Node, int increment = 1)
        {
            int stateBase = Node.TreeView.StateImageList.Images.Count;
            Node.StateImageIndex = (stateBase + Node.StateImageIndex + increment) % stateBase;
            FilterLines();
        }

        private void btnDeselect_Click       (object sender, EventArgs e) { foreach (TreeNode Node in tvFilters.Nodes) Node.StateImageIndex = 0; FilterLines(); }
        private void btnSelect_Click         (object sender, EventArgs e) { foreach (TreeNode Node in tvFilters.Nodes) Node.StateImageIndex = 1; FilterLines(); }
        private void btnInvertSelection_Click(object sender, EventArgs e) { foreach (TreeNode Node in tvFilters.Nodes) Node.StateImageIndex = 2; FilterLines(); }
        #endregion

        #region Filtered Lines
        class TagValues
        {
            public String Before = "", After = "";
            public double x = 0, y = 0, z = 0;

            public TagValues(String Line, String Tag)
            {
                int t = Line.ToUpper().IndexOf(Tag); // position of tag
                int p = Line.IndexOf('"', t) + 1; // first "
                int c = Line.IndexOf('"', p); // second "

                Before = Line.Substring(0, p);
                After = Line.Substring(c);

                string[] v = Line.Substring(p, c - p).Replace("  ", " ").Replace(',', '.').Split(' ');
                x = Double.Parse(v[0], NFI);
                y = Double.Parse(v[1], NFI);
                z = Double.Parse(v[2], NFI);
            }

            public double AlignValue(double value, double step, double offset) => Math.Truncate((value - offset) / step) * step + offset;

            public void AlignValues(double step, double offset)
            {
                x = AlignValue(x, step, offset);
                y = AlignValue(y, step, offset);
                z = AlignValue(z, step, offset);
            }

            public String Concatenate() => Before + x.ToString("f4", NFI) + " " + y.ToString("f4", NFI) + " " + z.ToString("f4", NFI) + " " + After;
        }

        private void ReShowLines()
        {
            //for (int i = 0; i < FLines.Count; i++)
                //tvLines.Nodes[i].Text = FLines[i];
        }

        private void AlignLines(String Tag, Double Step, Double Offset)
        {
            for (int i = 0; i < FLines.Count; i++)
            {
                //if (!tvLines.Nodes[i].Checked)
                //    continue;
                //TagValues tv = new TagValues(Lines[(Int32)tvLines.Nodes[i].Tag], Tag); // Get original line
                //tv.AlignValues(Step, Offset);
                //FLines[i] = tv.Concatenate();
                //tvLines.Nodes[i].Text = FLines[i];
            }
        }

        private void btnPositionAlign_Click(object sender, EventArgs e) => AlignLines("POSITION", (Double)nudMoveStep  .Value, (Double)nudMoveOffset  .Value);
        private void btnRotationAlign_Click(object sender, EventArgs e) => AlignLines("ROTATION", (Double)nudRotateStep.Value, (Double)nudRotateOffset.Value);

        private void nudMoveXYZ_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < FLines.Count; i++)
            {
                //if (!tvLines.Nodes[i].Checked)
                //    continue;
                //TagValues tv = new TagValues(Lines[(Int32)tvLines.Nodes[i].Tag], "POSITION"); // Get original line
                //tv.x += (Double)nudMoveX.Value;
                //tv.y += (Double)nudMoveY.Value;
                //tv.z += (Double)nudMoveZ.Value;
                //FLines[i] = tv.Concatenate();
                //tvLines.Nodes[i].Text = FLines[i];
            }
        }

        private void nudRotateXYZ_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < FLines.Count; i++)
            {
                //if (!tvLines.Nodes[i].Checked)
                //    continue;
                //TagValues tv = new TagValues(Lines[(Int32)tvLines.Nodes[i].Tag], "ROTATION"); // Get original line
                //tv.x += (Double)nudRotateX.Value;
                //tv.y += (Double)nudRotateY.Value;
                //tv.z += (Double)nudRotateZ.Value;
                //FLines[i] = tv.Concatenate();
                //tvLines.Nodes[i].Text = FLines[i];
            }
        }

        private void nudMoveStep_ValueChanged  (object sender, EventArgs e) => nudMoveX.Increment   = nudMoveY.Increment   = nudMoveZ.Increment   = nudMoveStep.Value;
        private void nudRotateStep_ValueChanged(object sender, EventArgs e) => nudRotateX.Increment = nudRotateY.Increment = nudRotateZ.Increment = nudRotateStep.Value;

        private void btnSaveLines_Click(object sender, EventArgs e)
        {
            //foreach (TreeNode node in tvLines.Nodes)
                //Lines[(Int32)node.Tag] = FLines[node.Index] = node.Text;
        }
        #endregion
    }
}