using Draw.src.Custom_Dialogs;
using Draw.src.Model;
using Draw.src.SaveModes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Draw
{
    /// <summary>
    /// Върху главната форма е поставен потребителски контрол,
    /// в който се осъществява визуализацията
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Агрегирания диалогов процесор във формата улеснява манипулацията на модела.
        /// </summary>
        private DialogProcessor dialogProcessor = new DialogProcessor();
        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        /// <summary>
        /// Изход от програмата. Затваря главната форма, а с това и програмата.
        /// </summary>
        void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Събитието, което се прихваща, за да се превизуализира при изменение на модела.
        /// </summary>
        void ViewPortPaint(object sender, PaintEventArgs e)
        {
            dialogProcessor.ReDraw(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomTestShape();

            statusBar.Items[0].Text = "Последно действие: Рисуване на TestObj.";

            viewPort.Invalidate();
        }

        /// <summary>
        /// Бутон, който поставя на произволно място правоъгълник със зададените размери.
        /// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
        /// </summary>
        void DrawRectangleSpeedButtonClick(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomRectangle();

            statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник.";

            viewPort.Invalidate();
        }

        /// <summary>
        /// Бутон, който поставя на произволно място линия със зададените размери.
        /// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
        /// </summary>
        private void DrawLineButtonClick(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomLine();

            statusBar.Items[0].Text = "Последно действие: Рисуване на Черта.";

            viewPort.Invalidate();
        }
        /// <summary>
        /// Бутон, който поставя на произволно място триъгълник със зададените размери.
        /// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
        /// </summary>
        private void DrawTriangleButtonClick(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomTriangle();

            statusBar.Items[0].Text = "Последно действие: Рисуване на Триъгълник.";

            viewPort.Invalidate();
        }
        /// <summary>
        /// Бутон, който поставя на произволно място елипса със зададените размери.
        /// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
        /// </summary>
        private void DrawEllipseButtonClick(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomEllipse();

            statusBar.Items[0].Text = "Последно действие: Рисуване на Елипса.";

            viewPort.Invalidate();
        }
        /// <summary>
        /// Прихващане на координатите при натискането на бутон на мишката и проверка (в обратен ред) дали не е
        /// щракнато върху елемент. Ако е така то той се отбелязва като селектиран и започва процес на "влачене".
        /// Промяна на статуса и инвалидиране на контрола, в който визуализираме.
        /// Реализацията се диалогът с потребителя, при който се избира "най-горния" елемент от екрана.
        /// </summary>
        void ViewPortMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {

            if (drawRotation.Checked)
            {
                dialogProcessor.Selection = dialogProcessor.ContainsPoint(e.Location);
                if (dialogProcessor.Selection != null)
                {
                    statusBar.Items[0].Text = "Последно действие: Селекция на примитив.";
                    dialogProcessor.IsRotating = true;
                    dialogProcessor.IsDragging = false;
                    dialogProcessor.LastLocation = e.Location;
                    viewPort.Invalidate();
                }
            }

            if (pickUpSpeedButton.Checked)
            {
                dialogProcessor.Selection = dialogProcessor.ContainsPoint(e.Location);
                if (dialogProcessor.Selection != null)
                {
                    statusBar.Items[0].Text = "Последно действие: Селекция на примитив.";
                    dialogProcessor.IsDragging = true;
                    dialogProcessor.IsRotating = false;
                    dialogProcessor.LastLocation = e.Location;
                    viewPort.Invalidate();
                }
            }
        }

        /// <summary>
        /// Прихващане на преместването на мишката.
        /// Ако сме в режм на "влачене", то избрания елемент се транслира.
        /// </summary>
        void ViewPortMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (dialogProcessor.IsRotating)
            {
                if (dialogProcessor.Selection != null) statusBar.Items[0].Text = "Последно действие: Въртене.";
                dialogProcessor.RotateTo(e.Location);

                viewPort.Invalidate();
            }

            if (dialogProcessor.IsDragging) {
                if (dialogProcessor.Selection != null)
                {
                    if (dialogProcessor.Selection.IsGrouped)
                    {
                        foreach (var GL in dialogProcessor.ListOfGroups)
                        {
                            if (GL.GroupList.Contains(dialogProcessor.Selection))
                            {
                                statusBar.Items[0].Text = $"Последно действие: Влачене на групата \"{dialogProcessor.GroupSelection.GroupName}\".";
                                dialogProcessor.GroupTranslateTo(e.Location, GL.GroupList);
                            }
                        }
                        
                    }
                    else
                    {
                        statusBar.Items[0].Text = "Последно действие: Влачене.";
                        dialogProcessor.TranslateTo(e.Location);
                    }
                   
                }


                viewPort.Invalidate();
            }
        }


        /// <summary>
        /// Прихващане на отпускането на бутона на мишката.
        /// Излизаме от режим "влачене".
        /// </summary>
        void ViewPortMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            dialogProcessor.IsRotating = false;

            dialogProcessor.IsDragging = false;
        }


        private void viewPort_KeyDown(object sender, KeyEventArgs e)
        {
            //Keybind за местене на примитив
            if (e.Control && e.KeyCode == Keys.R)
            {
                drawRotation.Checked = true;
                pickUpSpeedButton.Checked = false;
            }
            //Keybind за ротация на примитив
            if (e.Control && e.KeyCode == Keys.M)
            {
                drawRotation.Checked = false;
                pickUpSpeedButton.Checked = true;
            }
            //Keybind за Оцветяване на примитив
            if (e.Control && e.KeyCode == Keys.P)
            {
                drawRotation.Checked = false;
                FillColor();
            }
            //Keybind за премахване от група
            if (e.Shift && e.KeyCode == Keys.G)
            {
                drawRotation.Checked = false;
                pickUpSpeedButton.Checked = true;

                removeFromGroupToolStripMenuItem_Click(sender, e);
            }
            //Keybind за вместване на група
            if (e.Control && e.KeyCode == Keys.G)
            {
                drawRotation.Checked = false;
                pickUpSpeedButton.Checked = true;

                addToGroupToolStripMenuItem_Click(sender, e);
            }
            //Keybind Създаване на нова група.
            if(e.Alt && e.KeyCode == Keys.G)
            {
                createNewGroupToolStripMenuItem_Click(sender, e);
            }
            //Keybind за премахване от група
            if (e.KeyCode == Keys.Delete && e.KeyCode == Keys.G)
            {
                deleteGroupToolStripMenuItem_Click(sender, e);
            }
            //Keybind за избиране от група
            if (e.KeyCode == Keys.Space && e.KeyCode == Keys.G)
            {
                selectGroupToolStripMenuItem_Click(sender, e);
            }
            //Keybind за Създаване на примитив
            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                    DrawRectangleSpeedButtonClick(sender, e); break;
                case Keys.NumPad2:
                    DrawLineButtonClick(sender, e); break;
                case Keys.NumPad3:
                    DrawTriangleButtonClick(sender, e); break;
                case Keys.NumPad4:
                    DrawEllipseButtonClick(sender, e); break;
            }
        }
        /// <summary>
        /// Бутон за оцветяване на примитив.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pickerColor_Click(object sender, EventArgs e)
        {
            FillColor();
        }
        //Оцветяване на примитив чрез селектиране.
        void FillColor()
        {

            if (dialogProcessor.Selection != null)
            {
                statusBar.Items[0].Text = "Последно действие: Оцветяване.";


                if (ColorPicker.ShowDialog() == DialogResult.OK)
                {
                    if (dialogProcessor.Selection.IsGrouped)
                    {
                        foreach (var GL in dialogProcessor.ListOfGroups)
                        {
                            if (GL.GroupList.Contains(dialogProcessor.Selection))
                            {
                                dialogProcessor.GroupColorIt(ColorPicker.Color, GL.GroupList);
                            }
                        }
                    } else
                        dialogProcessor.ColorIt(ColorPicker.Color);
                }

            }
            else
            {
                pickUpSpeedButton.Checked = true;
                MessageBox.Show("Select object from the canvas.", "Warning!");
            }
            viewPort.Invalidate();

        }
        private System.Windows.Forms.TrackBar Track = new System.Windows.Forms.TrackBar();
        private Label optionLabel = new Label();
        /// <summary>
        /// Бутон за управление на прозрачност.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pickOpacity_Click(object sender, EventArgs e)
        {
            viewPort.Controls.Add(optionLabel);
            optionLabel.Text = "Opacity";

            optionLabel.Dock = DockStyle.Bottom;
            optionLabel.TextAlign = ContentAlignment.MiddleCenter;
            optionLabel.Font = new Font(new FontFamily("Arial"), 16, FontStyle.Regular, GraphicsUnit.Pixel);

            optionLabel.Visible = true;

            viewPort.Controls.Add(Track);
            Track.Dock = DockStyle.Bottom;
            Track.Maximum = 255;
            Track.Value = 255;
            Track.Minimum = 1;

            Track.TabStop = false;

            Track.Scroll -= UpdateThickness;
            Track.Scroll += UpdateOpacity;

            Track.Show();
        }

        private void UpdateOpacity(object sender, EventArgs e)
        {

            if (dialogProcessor.Selection != null)
            {
                statusBar.Items[0].Text = "Последно действие: Промяна на прозрачноста.";

                    if (dialogProcessor.Selection.IsGrouped)
                    {
                        foreach (var GL in dialogProcessor.ListOfGroups)
                        {
                            if (GL.GroupList.Contains(dialogProcessor.Selection))
                            {
                                dialogProcessor.GroupChangeOpacity(Track.Value, GL.GroupList);
                            }
                        }
                    }
                    else
                        dialogProcessor.ChangeOpacity(Track.Value);
                

            }
            else
            {
                pickUpSpeedButton.Checked = true;
                MessageBox.Show("Select object from the canvas.", "Warning!");
            }

            viewPort.Invalidate();
        }

        /// <summary>
        /// Бутон за управление на дебелината на контурите.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pickThickness_Click(object sender, EventArgs e)
        {
            viewPort.Controls.Add(optionLabel);
            optionLabel.Text = "Thickness";

            optionLabel.Dock = DockStyle.Bottom;
            optionLabel.TextAlign = ContentAlignment.MiddleCenter;
            optionLabel.Font = new Font(new FontFamily("Arial"), 16, FontStyle.Regular, GraphicsUnit.Pixel);

            optionLabel.Visible = true;



            viewPort.Controls.Add(Track);
            Track.Dock = DockStyle.Bottom;
            Track.Maximum = 10;
            Track.Value = 1;
            Track.Minimum = 1;

            Track.Scroll -= UpdateOpacity;
            Track.Scroll += UpdateThickness;

            Track.TabStop = false;

            Track.Show();
        }

        private void UpdateThickness(object sender, EventArgs e)
        {
            if (dialogProcessor.Selection != null)
            {
                statusBar.Items[0].Text = "Последно действие: Удебеляване.";

                    if (dialogProcessor.Selection.IsGrouped)
                    {
                        foreach (var GL in dialogProcessor.ListOfGroups)
                        {
                            if (GL.GroupList.Contains(dialogProcessor.Selection))
                            {
                                dialogProcessor.GroupChangeThickness(Track.Value, GL.GroupList);
                            }
                        }
                    }
                    else
                        dialogProcessor.ChangeThickness(Track.Value);
                

            }
            else
            {
                pickUpSpeedButton.Checked = true;
                MessageBox.Show("Select object from the canvas.", "Warning!");
            }
            viewPort.Invalidate();
        }

        /// <summary>
        /// Запаметяване на Json Файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsSVGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog.Title = saveAsSVGToolStripMenuItem.Text;
            SaveFileDialog.Filter = "Json (*.json)|*.json|All files (*.*)|*.*";


            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText($"{SaveFileDialog.FileName}", JsonModel.SaveAs(dialogProcessor.ShapeList));
            }


        }
        /// <summary>
        /// Четене на Json Файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openSVGFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog.Title = saveAsSVGToolStripMenuItem.Text;
            OpenFileDialog.Filter = "Json (*.json)|*.json|All files (*.*)|*.*";

            dialogProcessor.RemoveAllShapes();

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader r = new StreamReader($"{OpenFileDialog.FileName}"))
                {
                    string json = r.ReadToEnd();

                    dialogProcessor.AddAllShapes(JsonModel.ReadJson(json));

                    viewPort.Invalidate();
                }
            }
        }

        /// <summary>
        /// Добавяне на елемент в групата.
        /// </summary>
        private void addToGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isAdded = false;
            if (dialogProcessor.Selection == null)
            {
                pickUpSpeedButton.Checked = true;
                MessageBox.Show("Select object from the canvas!", "Warning!");
            } else
            /*
                Проверка за съществуващ лист
             */
            if (dialogProcessor.GroupSelection == null)
            {
                dialogProcessor.GroupSelection = new GroupModel();
                dialogProcessor.GroupSelection.GroupList = new List<Shape>() { dialogProcessor.Selection };
                dialogProcessor.ListOfGroups.Add(dialogProcessor.GroupSelection);

                dialogProcessor.GroupSelection.GroupName = "Not named";
                statusBar.Items[0].Text = $"Последно действие: Групиране и създаване на групата {dialogProcessor.GroupSelection.GroupName}.";
                dialogProcessor.Selection.IsGrouped = true;
            }
            else
            {
                /*
                    Проверка дали елемента е част от листа.
                 */
                if (dialogProcessor.Selection != null)
                {
                    for (int i = 0; i < dialogProcessor.GroupSelection.GroupList.Count; i++)
                    {

                        if (dialogProcessor.GroupSelection.GroupList[i].Equals(dialogProcessor.Selection))
                        {
                            isAdded = true;
                            break;

                        } else isAdded = false;
                    }

                    if (isAdded != true)
                    {
                        statusBar.Items[0].Text = $"Последно действие: Групиране в {dialogProcessor.GroupSelection.GroupName}.";

                        dialogProcessor.GroupSelection.GroupList.Add(dialogProcessor.Selection);
                        dialogProcessor.Selection.IsGrouped = true;
                    }
                    else
                    {
                        pickUpSpeedButton.Checked = true;
                        MessageBox.Show("This obj is already in a group!!", "Warning!");
                    }
                }
                else
                {
                    pickUpSpeedButton.Checked = true;
                    MessageBox.Show("Select object from the canvas!", "Warning!");
                }
                viewPort.Invalidate();
            }



        }
        /// <summary>
        /// Премахване на елемент от групата.
        /// </summary>
        private void removeFromGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dialogProcessor.GroupSelection == null)
            {
                pickUpSpeedButton.Checked = true;
                MessageBox.Show("There is no existing groups!", "Warning!");
            }
            else
            {
                int shapeListLength = dialogProcessor.GroupSelection.GroupList.Count;


                for (int i = 0; i < dialogProcessor.GroupSelection.GroupList.Count; i++)
                {
                    if (dialogProcessor.Selection == dialogProcessor.GroupSelection.GroupList[i])
                    {
                        statusBar.Items[0].Text = $"Последно действие: Разгрупиране от {dialogProcessor.GroupSelection.GroupName}.";
                        dialogProcessor.GroupSelection.GroupList.Remove(dialogProcessor.Selection);
                        dialogProcessor.Selection.IsGrouped = false;
                    }
                }

                if (shapeListLength == dialogProcessor.GroupSelection.GroupList.Count)
                {
                    pickUpSpeedButton.Checked = true;
                    MessageBox.Show("Select object from a group!", "Warning!");
                }
            }
            viewPort.Invalidate();
        }

        /// <summary>
        /// Създаване на лист от елементи.
        /// </summary>
        private void createNewGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateDialog createDialog = new CreateDialog();
            createDialog.ShowDialog();

            if(createDialog.ListOfElements != null)
            {
                
                dialogProcessor.GroupSelection = createDialog.ListOfElements;
                dialogProcessor.ListOfGroups.Add(dialogProcessor.GroupSelection);

                statusBar.Items[0].Text = $"Последно действие: Създаване на групата \"{dialogProcessor.GroupSelection.GroupName}\".";
            }
        }

        /// <summary>
        /// Премахване на лист от елементи.
        /// </summary>
        private void deleteGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            DeleteDialog deleteDialog = new DeleteDialog(dialogProcessor.ListOfGroups);
            deleteDialog.ShowDialog();

            if (deleteDialog.SelectedList != null)
            {
                foreach (var shape in deleteDialog.SelectedList.GroupList)
                {
                    shape.IsGrouped = false;
                }
                dialogProcessor.ListOfGroups.Remove(deleteDialog.SelectedList);

                statusBar.Items[0].Text = $"Последно действие: Премахване на групата \"{dialogProcessor.GroupSelection.GroupName}\".";
            }
        }
        /// <summary>
        /// Избиране на лист от елементи.
        /// </summary>
        private void selectGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectGroupDIalog groupDialog = new SelectGroupDIalog(dialogProcessor.ListOfGroups);
            groupDialog.ShowDialog();

            if (groupDialog.SelectedList != null)
            {
                dialogProcessor.GroupSelection = groupDialog.SelectedList;

                statusBar.Items[0].Text = $"Последно действие: Създаване на групата \"{dialogProcessor.GroupSelection.GroupName}\".";
            }
        }

        // Добавяне на tool snips.
        private void dragCTRLMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawRotation.Checked = false;
            pickUpSpeedButton.Checked = true;
        }

        private void rotateCTRLRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawRotation.Checked = true;
            pickUpSpeedButton.Checked = false;
        }

        private void paintCTRLPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawRotation.Checked = false;
            FillColor();
        }

        private void addToGroupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            drawRotation.Checked = false;
            pickUpSpeedButton.Checked = true;

            addToGroupToolStripMenuItem_Click(sender, e);
        }

        private void removeToGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawRotation.Checked = false;
            pickUpSpeedButton.Checked = true;

            removeFromGroupToolStripMenuItem_Click(sender, e);
        }


        private void createNewGroupCTRLAltGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createNewGroupToolStripMenuItem_Click(sender, e);
        }

        private void deleteGroupCTRLDeleteGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteGroupToolStripMenuItem_Click(sender, e);
        }

        private void selectGroupSpaceGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectGroupToolStripMenuItem_Click(sender, e);
        }
        private void rectangleCTRLNUM0ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawRectangleSpeedButtonClick(sender, e);
        }

        private void lineNum2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawLineButtonClick(sender, e);
        }

        private void triangleNum3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
                DrawTriangleButtonClick(sender, e);     
        }

        private void ellipseNum4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
                DrawEllipseButtonClick(sender, e);
        }


        // Край на добавянето.
    }
}