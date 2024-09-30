using System;
using System.Windows.Forms;

namespace Draw
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsSVGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dragCTRLMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateCTRLRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paintCTRLPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToGroupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewGroupCTRLAltGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteGroupCTRLDeleteGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectGroupSpaceGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primitivesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleCTRLNUM0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineNum2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triangleNum3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipseNum4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSVGFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.speedMenu = new System.Windows.Forms.ToolStrip();
            this.pickUpSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawRotation = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.addToGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFromGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pickerColor = new System.Windows.Forms.ToolStripButton();
            this.pickOpacity = new System.Windows.Forms.ToolStripButton();
            this.pickThickness = new System.Windows.Forms.ToolStripButton();
            this.drawRectangleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.DrawTriangleButton = new System.Windows.Forms.ToolStripButton();
            this.Ellipse = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ColorPicker = new System.Windows.Forms.ColorDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.speedMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(924, 30);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsSVGToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAsSVGToolStripMenuItem
            // 
            this.saveAsSVGToolStripMenuItem.Name = "saveAsSVGToolStripMenuItem";
            this.saveAsSVGToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.saveAsSVGToolStripMenuItem.Text = "Save As JSON";
            this.saveAsSVGToolStripMenuItem.Click += new System.EventHandler(this.saveAsSVGToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dragCTRLMToolStripMenuItem,
            this.rotateCTRLRToolStripMenuItem,
            this.paintCTRLPToolStripMenuItem,
            this.groupToolStripMenuItem,
            this.primitivesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // dragCTRLMToolStripMenuItem
            // 
            this.dragCTRLMToolStripMenuItem.Name = "dragCTRLMToolStripMenuItem";
            this.dragCTRLMToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.dragCTRLMToolStripMenuItem.Text = "Drag (CTRL + M)";
            this.dragCTRLMToolStripMenuItem.Click += new System.EventHandler(this.dragCTRLMToolStripMenuItem_Click);
            // 
            // rotateCTRLRToolStripMenuItem
            // 
            this.rotateCTRLRToolStripMenuItem.Name = "rotateCTRLRToolStripMenuItem";
            this.rotateCTRLRToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.rotateCTRLRToolStripMenuItem.Text = "Rotate (CTRL + R)";
            this.rotateCTRLRToolStripMenuItem.Click += new System.EventHandler(this.rotateCTRLRToolStripMenuItem_Click);
            // 
            // paintCTRLPToolStripMenuItem
            // 
            this.paintCTRLPToolStripMenuItem.Name = "paintCTRLPToolStripMenuItem";
            this.paintCTRLPToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.paintCTRLPToolStripMenuItem.Text = "Paint (CTRL + P)";
            this.paintCTRLPToolStripMenuItem.Click += new System.EventHandler(this.paintCTRLPToolStripMenuItem_Click);
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToGroupToolStripMenuItem1,
            this.removeToGroupToolStripMenuItem,
            this.createNewGroupCTRLAltGToolStripMenuItem,
            this.deleteGroupCTRLDeleteGToolStripMenuItem,
            this.selectGroupSpaceGToolStripMenuItem});
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.groupToolStripMenuItem.Text = "Group";
            // 
            // addToGroupToolStripMenuItem1
            // 
            this.addToGroupToolStripMenuItem1.Name = "addToGroupToolStripMenuItem1";
            this.addToGroupToolStripMenuItem1.Size = new System.Drawing.Size(280, 26);
            this.addToGroupToolStripMenuItem1.Text = "Add to group (CTRL + G)";
            this.addToGroupToolStripMenuItem1.Click += new System.EventHandler(this.addToGroupToolStripMenuItem1_Click);
            // 
            // removeToGroupToolStripMenuItem
            // 
            this.removeToGroupToolStripMenuItem.Name = "removeToGroupToolStripMenuItem";
            this.removeToGroupToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.removeToGroupToolStripMenuItem.Text = "Remove to group (Shift + G)";
            this.removeToGroupToolStripMenuItem.Click += new System.EventHandler(this.removeToGroupToolStripMenuItem_Click);
            // 
            // createNewGroupCTRLAltGToolStripMenuItem
            // 
            this.createNewGroupCTRLAltGToolStripMenuItem.Name = "createNewGroupCTRLAltGToolStripMenuItem";
            this.createNewGroupCTRLAltGToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.createNewGroupCTRLAltGToolStripMenuItem.Text = "Create new group ( Alt + G)";
            this.createNewGroupCTRLAltGToolStripMenuItem.Click += new System.EventHandler(this.createNewGroupCTRLAltGToolStripMenuItem_Click);
            // 
            // deleteGroupCTRLDeleteGToolStripMenuItem
            // 
            this.deleteGroupCTRLDeleteGToolStripMenuItem.Name = "deleteGroupCTRLDeleteGToolStripMenuItem";
            this.deleteGroupCTRLDeleteGToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.deleteGroupCTRLDeleteGToolStripMenuItem.Text = "Delete group (Delete + G)";
            this.deleteGroupCTRLDeleteGToolStripMenuItem.Click += new System.EventHandler(this.deleteGroupCTRLDeleteGToolStripMenuItem_Click);
            // 
            // selectGroupSpaceGToolStripMenuItem
            // 
            this.selectGroupSpaceGToolStripMenuItem.Name = "selectGroupSpaceGToolStripMenuItem";
            this.selectGroupSpaceGToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.selectGroupSpaceGToolStripMenuItem.Text = "Select Group (Space + G)";
            this.selectGroupSpaceGToolStripMenuItem.Click += new System.EventHandler(this.selectGroupSpaceGToolStripMenuItem_Click);
            // 
            // primitivesToolStripMenuItem
            // 
            this.primitivesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectangleCTRLNUM0ToolStripMenuItem,
            this.lineNum2ToolStripMenuItem,
            this.triangleNum3ToolStripMenuItem,
            this.ellipseNum4ToolStripMenuItem});
            this.primitivesToolStripMenuItem.Name = "primitivesToolStripMenuItem";
            this.primitivesToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.primitivesToolStripMenuItem.Text = "Primitives";
            // 
            // rectangleCTRLNUM0ToolStripMenuItem
            // 
            this.rectangleCTRLNUM0ToolStripMenuItem.Name = "rectangleCTRLNUM0ToolStripMenuItem";
            this.rectangleCTRLNUM0ToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.rectangleCTRLNUM0ToolStripMenuItem.Text = "Rectangle (Num1)";
            this.rectangleCTRLNUM0ToolStripMenuItem.Click += new System.EventHandler(this.rectangleCTRLNUM0ToolStripMenuItem_Click);
            // 
            // lineNum2ToolStripMenuItem
            // 
            this.lineNum2ToolStripMenuItem.Name = "lineNum2ToolStripMenuItem";
            this.lineNum2ToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.lineNum2ToolStripMenuItem.Text = "Line (Num2)";
            this.lineNum2ToolStripMenuItem.Click += new System.EventHandler(this.lineNum2ToolStripMenuItem_Click);
            // 
            // triangleNum3ToolStripMenuItem
            // 
            this.triangleNum3ToolStripMenuItem.Name = "triangleNum3ToolStripMenuItem";
            this.triangleNum3ToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.triangleNum3ToolStripMenuItem.Text = "Triangle (Num3)";
            this.triangleNum3ToolStripMenuItem.Click += new System.EventHandler(this.triangleNum3ToolStripMenuItem_Click);
            // 
            // ellipseNum4ToolStripMenuItem
            // 
            this.ellipseNum4ToolStripMenuItem.Name = "ellipseNum4ToolStripMenuItem";
            this.ellipseNum4ToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.ellipseNum4ToolStripMenuItem.Text = "Ellipse (Num4)";
            this.ellipseNum4ToolStripMenuItem.Click += new System.EventHandler(this.ellipseNum4ToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSVGFileToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // openSVGFileToolStripMenuItem
            // 
            this.openSVGFileToolStripMenuItem.Name = "openSVGFileToolStripMenuItem";
            this.openSVGFileToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.openSVGFileToolStripMenuItem.Text = "Open JSON file";
            this.openSVGFileToolStripMenuItem.Click += new System.EventHandler(this.openSVGFileToolStripMenuItem_Click);
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 499);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusBar.Size = new System.Drawing.Size(924, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(0, 16);
            // 
            // speedMenu
            // 
            this.speedMenu.AllowItemReorder = true;
            this.speedMenu.AllowMerge = false;
            this.speedMenu.CanOverflow = false;
            this.speedMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.speedMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.speedMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.speedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickUpSpeedButton,
            this.drawRotation,
            this.toolStripDropDownButton1,
            this.pickerColor,
            this.pickOpacity,
            this.pickThickness,
            this.drawRectangleSpeedButton,
            this.toolStripButton1,
            this.DrawTriangleButton,
            this.Ellipse,
            this.toolStripButton2});
            this.speedMenu.Location = new System.Drawing.Point(0, 30);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.Size = new System.Drawing.Size(40, 469);
            this.speedMenu.TabIndex = 3;
            this.speedMenu.Text = "toolStrip1";
            // 
            // pickUpSpeedButton
            // 
            this.pickUpSpeedButton.Checked = true;
            this.pickUpSpeedButton.CheckOnClick = true;
            this.pickUpSpeedButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pickUpSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickUpSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("pickUpSpeedButton.Image")));
            this.pickUpSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickUpSpeedButton.Name = "pickUpSpeedButton";
            this.pickUpSpeedButton.Size = new System.Drawing.Size(37, 24);
            this.pickUpSpeedButton.Text = "Drag";
            // 
            // drawRotation
            // 
            this.drawRotation.CheckOnClick = true;
            this.drawRotation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawRotation.Image = ((System.Drawing.Image)(resources.GetObject("drawRotation.Image")));
            this.drawRotation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawRotation.Name = "drawRotation";
            this.drawRotation.Size = new System.Drawing.Size(32, 24);
            this.drawRotation.Text = "Rotate";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToGroupToolStripMenuItem,
            this.removeFromGroupToolStripMenuItem,
            this.createNewGroupToolStripMenuItem,
            this.deleteGroupToolStripMenuItem,
            this.selectGroupToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(32, 24);
            this.toolStripDropDownButton1.Text = "Grouping";
            // 
            // addToGroupToolStripMenuItem
            // 
            this.addToGroupToolStripMenuItem.Name = "addToGroupToolStripMenuItem";
            this.addToGroupToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.addToGroupToolStripMenuItem.Text = "Add to group.";
            this.addToGroupToolStripMenuItem.Click += new System.EventHandler(this.addToGroupToolStripMenuItem_Click);
            // 
            // removeFromGroupToolStripMenuItem
            // 
            this.removeFromGroupToolStripMenuItem.Name = "removeFromGroupToolStripMenuItem";
            this.removeFromGroupToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.removeFromGroupToolStripMenuItem.Text = "Remove from group.";
            this.removeFromGroupToolStripMenuItem.Click += new System.EventHandler(this.removeFromGroupToolStripMenuItem_Click);
            // 
            // createNewGroupToolStripMenuItem
            // 
            this.createNewGroupToolStripMenuItem.Name = "createNewGroupToolStripMenuItem";
            this.createNewGroupToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.createNewGroupToolStripMenuItem.Text = "Create new group.";
            this.createNewGroupToolStripMenuItem.Click += new System.EventHandler(this.createNewGroupToolStripMenuItem_Click);
            // 
            // deleteGroupToolStripMenuItem
            // 
            this.deleteGroupToolStripMenuItem.Name = "deleteGroupToolStripMenuItem";
            this.deleteGroupToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.deleteGroupToolStripMenuItem.Text = "Delete group.";
            this.deleteGroupToolStripMenuItem.Click += new System.EventHandler(this.deleteGroupToolStripMenuItem_Click);
            // 
            // selectGroupToolStripMenuItem
            // 
            this.selectGroupToolStripMenuItem.Name = "selectGroupToolStripMenuItem";
            this.selectGroupToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.selectGroupToolStripMenuItem.Text = "Select group.";
            this.selectGroupToolStripMenuItem.Click += new System.EventHandler(this.selectGroupToolStripMenuItem_Click);
            // 
            // pickerColor
            // 
            this.pickerColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickerColor.Image = ((System.Drawing.Image)(resources.GetObject("pickerColor.Image")));
            this.pickerColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickerColor.Name = "pickerColor";
            this.pickerColor.Size = new System.Drawing.Size(32, 24);
            this.pickerColor.Text = "Color Picker";
            this.pickerColor.Click += new System.EventHandler(this.pickerColor_Click);
            // 
            // pickOpacity
            // 
            this.pickOpacity.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickOpacity.Image = ((System.Drawing.Image)(resources.GetObject("pickOpacity.Image")));
            this.pickOpacity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickOpacity.Name = "pickOpacity";
            this.pickOpacity.Size = new System.Drawing.Size(32, 24);
            this.pickOpacity.Text = "Opacity";
            this.pickOpacity.Click += new System.EventHandler(this.pickOpacity_Click);
            // 
            // pickThickness
            // 
            this.pickThickness.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickThickness.Image = ((System.Drawing.Image)(resources.GetObject("pickThickness.Image")));
            this.pickThickness.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickThickness.Name = "pickThickness";
            this.pickThickness.Size = new System.Drawing.Size(32, 24);
            this.pickThickness.Text = "Thickness";
            this.pickThickness.Click += new System.EventHandler(this.pickThickness_Click);
            // 
            // drawRectangleSpeedButton
            // 
            this.drawRectangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawRectangleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawRectangleSpeedButton.Image")));
            this.drawRectangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawRectangleSpeedButton.Name = "drawRectangleSpeedButton";
            this.drawRectangleSpeedButton.Size = new System.Drawing.Size(32, 24);
            this.drawRectangleSpeedButton.Text = "Draw Rectangle";
            this.drawRectangleSpeedButton.Click += new System.EventHandler(this.DrawRectangleSpeedButtonClick);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(32, 24);
            this.toolStripButton1.Text = "Draw Line";
            this.toolStripButton1.Click += new System.EventHandler(this.DrawLineButtonClick);
            // 
            // DrawTriangleButton
            // 
            this.DrawTriangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawTriangleButton.Image = ((System.Drawing.Image)(resources.GetObject("DrawTriangleButton.Image")));
            this.DrawTriangleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DrawTriangleButton.Name = "DrawTriangleButton";
            this.DrawTriangleButton.Size = new System.Drawing.Size(32, 24);
            this.DrawTriangleButton.Text = "Draw Triangle  ";
            this.DrawTriangleButton.Click += new System.EventHandler(this.DrawTriangleButtonClick);
            // 
            // Ellipse
            // 
            this.Ellipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Ellipse.Image = ((System.Drawing.Image)(resources.GetObject("Ellipse.Image")));
            this.Ellipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(32, 24);
            this.Ellipse.Text = "Draw Ellipse  ";
            this.Ellipse.Click += new System.EventHandler(this.DrawEllipseButtonClick);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(32, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.FileName = "Project";
            this.SaveFileDialog.Tag = "";
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // viewPort
            // 
            this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPort.Location = new System.Drawing.Point(40, 30);
            this.viewPort.Margin = new System.Windows.Forms.Padding(5);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(884, 469);
            this.viewPort.TabIndex = 4;
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            this.viewPort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.viewPort_KeyDown);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(924, 521);
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.speedMenu);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Draw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.speedMenu.ResumeLayout(false);
            this.speedMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.ToolStripStatusLabel currentStatusLabel;
		private Draw.DoubleBufferedPanel viewPort;
		private System.Windows.Forms.ToolStripButton pickUpSpeedButton;
		private System.Windows.Forms.ToolStripButton drawRectangleSpeedButton;
		private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStrip speedMenu;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton DrawTriangleButton;
        private System.Windows.Forms.ToolStripButton Ellipse;
        private System.Windows.Forms.ToolStripButton drawRotation;
        private System.Windows.Forms.ToolStripButton pickerColor;
        private System.Windows.Forms.ColorDialog ColorPicker;
        private System.Windows.Forms.ToolStripMenuItem saveAsSVGToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem addToGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFromGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dragCTRLMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateCTRLRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToGroupToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeToGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primitivesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSVGFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleCTRLNUM0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineNum2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triangleNum3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipseNum4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paintCTRLPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewGroupCTRLAltGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteGroupCTRLDeleteGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectGroupSpaceGToolStripMenuItem;
        private ToolStripButton pickOpacity;
        private ToolStripButton pickThickness;
        private OpenFileDialog OpenFileDialog;
        private ToolStripButton toolStripButton2;
    }
}
