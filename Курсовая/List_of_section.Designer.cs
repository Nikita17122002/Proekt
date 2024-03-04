namespace Курсовая
{
    partial class List_of_section
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List_of_section));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sportDataSet = new Курсовая.SportDataSet();
            this.list_of_sectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.list_of_sectionsTableAdapter = new Курсовая.SportDataSetTableAdapters.List_of_sectionsTableAdapter();
            this.tableAdapterManager = new Курсовая.SportDataSetTableAdapters.TableAdapterManager();
            this.list_of_sectionsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.list_of_sectionsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.list_of_sectionsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_of_sectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_of_sectionsBindingNavigator)).BeginInit();
            this.list_of_sectionsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_of_sectionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(352, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 22);
            this.textBox1.TabIndex = 42;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(708, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 38);
            this.button2.TabIndex = 41;
            this.button2.Text = "Найти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(27, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 41);
            this.label3.TabIndex = 40;
            this.label3.Text = "Информация о секциях";
            // 
            // sportDataSet
            // 
            this.sportDataSet.DataSetName = "SportDataSet";
            this.sportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // list_of_sectionsBindingSource
            // 
            this.list_of_sectionsBindingSource.DataMember = "List_of_sections";
            this.list_of_sectionsBindingSource.DataSource = this.sportDataSet;
            // 
            // list_of_sectionsTableAdapter
            // 
            this.list_of_sectionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AthletesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Class_scheduleTableAdapter = null;
            this.tableAdapterManager.Coachs1TableAdapter = null;
            this.tableAdapterManager.List_of_sectionsTableAdapter = this.list_of_sectionsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Курсовая.SportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // list_of_sectionsBindingNavigator
            // 
            this.list_of_sectionsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.list_of_sectionsBindingNavigator.BindingSource = this.list_of_sectionsBindingSource;
            this.list_of_sectionsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.list_of_sectionsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.list_of_sectionsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.list_of_sectionsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.list_of_sectionsBindingNavigatorSaveItem});
            this.list_of_sectionsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.list_of_sectionsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.list_of_sectionsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.list_of_sectionsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.list_of_sectionsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.list_of_sectionsBindingNavigator.Name = "list_of_sectionsBindingNavigator";
            this.list_of_sectionsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.list_of_sectionsBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.list_of_sectionsBindingNavigator.TabIndex = 43;
            this.list_of_sectionsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 20);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // list_of_sectionsBindingNavigatorSaveItem
            // 
            this.list_of_sectionsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.list_of_sectionsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("list_of_sectionsBindingNavigatorSaveItem.Image")));
            this.list_of_sectionsBindingNavigatorSaveItem.Name = "list_of_sectionsBindingNavigatorSaveItem";
            this.list_of_sectionsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.list_of_sectionsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.list_of_sectionsBindingNavigatorSaveItem.Click += new System.EventHandler(this.list_of_sectionsBindingNavigatorSaveItem_Click);
            // 
            // list_of_sectionsDataGridView
            // 
            this.list_of_sectionsDataGridView.AutoGenerateColumns = false;
            this.list_of_sectionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_of_sectionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.list_of_sectionsDataGridView.DataSource = this.list_of_sectionsBindingSource;
            this.list_of_sectionsDataGridView.Location = new System.Drawing.Point(34, 109);
            this.list_of_sectionsDataGridView.Name = "list_of_sectionsDataGridView";
            this.list_of_sectionsDataGridView.RowHeadersWidth = 51;
            this.list_of_sectionsDataGridView.RowTemplate.Height = 24;
            this.list_of_sectionsDataGridView.Size = new System.Drawing.Size(300, 220);
            this.list_of_sectionsDataGridView.TabIndex = 43;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name_of_the_section";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название секции";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // List_of_section
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.list_of_sectionsDataGridView);
            this.Controls.Add(this.list_of_sectionsBindingNavigator);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Name = "List_of_section";
            this.Text = "Секции";
            this.Load += new System.EventHandler(this.List_of_section_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_of_sectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_of_sectionsBindingNavigator)).EndInit();
            this.list_of_sectionsBindingNavigator.ResumeLayout(false);
            this.list_of_sectionsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_of_sectionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private SportDataSet sportDataSet;
        private System.Windows.Forms.BindingSource list_of_sectionsBindingSource;
        private SportDataSetTableAdapters.List_of_sectionsTableAdapter list_of_sectionsTableAdapter;
        private SportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator list_of_sectionsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton list_of_sectionsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView list_of_sectionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}