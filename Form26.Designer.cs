namespace Практика_итог
{
    partial class Form26
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
            System.Windows.Forms.Label код_сотрудникаLabel;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label возрастLabel;
            System.Windows.Forms.Label полLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label паспортные_данныеLabel;
            System.Windows.Forms.Label наименование_должностиLabel;
            System.Windows.Forms.Label окладLabel;
            System.Windows.Forms.Label обязанностиLabel;
            System.Windows.Forms.Label требованияLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form26));
            this.label3 = new System.Windows.Forms.Label();
            this._практика2___копияDataSet = new Практика_итог._практика2___копияDataSet();
            this.отдел_кадровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.отдел_кадровTableAdapter = new Практика_итог._практика2___копияDataSetTableAdapters.Отдел_кадровTableAdapter();
            this.tableAdapterManager = new Практика_итог._практика2___копияDataSetTableAdapters.TableAdapterManager();
            this.отдел_кадровBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.отдел_кадровBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_сотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.возрастTextBox = new System.Windows.Forms.TextBox();
            this.полTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.паспортные_данныеTextBox = new System.Windows.Forms.TextBox();
            this.наименование_должностиTextBox = new System.Windows.Forms.TextBox();
            this.окладTextBox = new System.Windows.Forms.TextBox();
            this.обязанностиTextBox = new System.Windows.Forms.TextBox();
            this.требованияTextBox = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            код_сотрудникаLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            возрастLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            паспортные_данныеLabel = new System.Windows.Forms.Label();
            наименование_должностиLabel = new System.Windows.Forms.Label();
            окладLabel = new System.Windows.Forms.Label();
            обязанностиLabel = new System.Windows.Forms.Label();
            требованияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._практика2___копияDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_кадровBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_кадровBindingNavigator)).BeginInit();
            this.отдел_кадровBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // код_сотрудникаLabel
            // 
            код_сотрудникаLabel.AutoSize = true;
            код_сотрудникаLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            код_сотрудникаLabel.Location = new System.Drawing.Point(178, 98);
            код_сотрудникаLabel.Name = "код_сотрудникаLabel";
            код_сотрудникаLabel.Size = new System.Drawing.Size(178, 27);
            код_сотрудникаLabel.TabIndex = 214;
            код_сотрудникаLabel.Text = "Код сотрудника:";
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            фИОLabel.Location = new System.Drawing.Point(260, 132);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(70, 27);
            фИОLabel.TabIndex = 215;
            фИОLabel.Text = "ФИО:";
            // 
            // возрастLabel
            // 
            возрастLabel.AutoSize = true;
            возрастLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            возрастLabel.Location = new System.Drawing.Point(233, 179);
            возрастLabel.Name = "возрастLabel";
            возрастLabel.Size = new System.Drawing.Size(99, 27);
            возрастLabel.TabIndex = 216;
            возрастLabel.Text = "Возраст:";
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            полLabel.Location = new System.Drawing.Point(266, 225);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(59, 27);
            полLabel.TabIndex = 217;
            полLabel.Text = "Пол:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            адресLabel.Location = new System.Drawing.Point(250, 271);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(82, 27);
            адресLabel.TabIndex = 218;
            адресLabel.Text = "Адрес:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            телефонLabel.Location = new System.Drawing.Point(227, 318);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(106, 27);
            телефонLabel.TabIndex = 219;
            телефонLabel.Text = "Телефон:";
            // 
            // паспортные_данныеLabel
            // 
            паспортные_данныеLabel.AutoSize = true;
            паспортные_данныеLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            паспортные_данныеLabel.Location = new System.Drawing.Point(145, 364);
            паспортные_данныеLabel.Name = "паспортные_данныеLabel";
            паспортные_данныеLabel.Size = new System.Drawing.Size(226, 27);
            паспортные_данныеLabel.TabIndex = 220;
            паспортные_данныеLabel.Text = "Паспортные данные:";
            // 
            // наименование_должностиLabel
            // 
            наименование_должностиLabel.AutoSize = true;
            наименование_должностиLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            наименование_должностиLabel.Location = new System.Drawing.Point(100, 411);
            наименование_должностиLabel.Name = "наименование_должностиLabel";
            наименование_должностиLabel.Size = new System.Drawing.Size(288, 27);
            наименование_должностиLabel.TabIndex = 221;
            наименование_должностиLabel.Text = "Наименование должности:";
            // 
            // окладLabel
            // 
            окладLabel.AutoSize = true;
            окладLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            окладLabel.Location = new System.Drawing.Point(249, 458);
            окладLabel.Name = "окладLabel";
            окладLabel.Size = new System.Drawing.Size(82, 27);
            окладLabel.TabIndex = 222;
            окладLabel.Text = "Оклад:";
            // 
            // обязанностиLabel
            // 
            обязанностиLabel.AutoSize = true;
            обязанностиLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            обязанностиLabel.Location = new System.Drawing.Point(197, 504);
            обязанностиLabel.Name = "обязанностиLabel";
            обязанностиLabel.Size = new System.Drawing.Size(150, 27);
            обязанностиLabel.TabIndex = 223;
            обязанностиLabel.Text = "Обязанности:";
            // 
            // требованияLabel
            // 
            требованияLabel.AutoSize = true;
            требованияLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            требованияLabel.Location = new System.Drawing.Point(205, 556);
            требованияLabel.Name = "требованияLabel";
            требованияLabel.Size = new System.Drawing.Size(137, 27);
            требованияLabel.TabIndex = 224;
            требованияLabel.Text = "Требования:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(269, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 46);
            this.label3.TabIndex = 213;
            this.label3.Text = "Отдел кадров";
            // 
            // _практика2___копияDataSet
            // 
            this._практика2___копияDataSet.DataSetName = "_практика2___копияDataSet";
            this._практика2___копияDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // отдел_кадровBindingSource
            // 
            this.отдел_кадровBindingSource.DataMember = "Отдел кадров";
            this.отдел_кадровBindingSource.DataSource = this._практика2___копияDataSet;
            // 
            // отдел_кадровTableAdapter
            // 
            this.отдел_кадровTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Практика_итог._практика2___копияDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Виды_полисовTableAdapter = null;
            this.tableAdapterManager.Группы_клиентовTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.ПолисыTableAdapter = null;
            this.tableAdapterManager.РискиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Таблица1TableAdapter = null;
            // 
            // отдел_кадровBindingNavigator
            // 
            this.отдел_кадровBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.отдел_кадровBindingNavigator.BindingSource = this.отдел_кадровBindingSource;
            this.отдел_кадровBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.отдел_кадровBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.отдел_кадровBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.отдел_кадровBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.отдел_кадровBindingNavigatorSaveItem});
            this.отдел_кадровBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.отдел_кадровBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.отдел_кадровBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.отдел_кадровBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.отдел_кадровBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.отдел_кадровBindingNavigator.Name = "отдел_кадровBindingNavigator";
            this.отдел_кадровBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.отдел_кадровBindingNavigator.Size = new System.Drawing.Size(900, 31);
            this.отдел_кадровBindingNavigator.TabIndex = 214;
            this.отдел_кадровBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 26);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 26);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 26);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 26);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 26);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(56, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 26);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 26);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // отдел_кадровBindingNavigatorSaveItem
            // 
            this.отдел_кадровBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.отдел_кадровBindingNavigatorSaveItem.Enabled = false;
            this.отдел_кадровBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("отдел_кадровBindingNavigatorSaveItem.Image")));
            this.отдел_кадровBindingNavigatorSaveItem.Name = "отдел_кадровBindingNavigatorSaveItem";
            this.отдел_кадровBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 26);
            this.отдел_кадровBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // код_сотрудникаTextBox
            // 
            this.код_сотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отдел_кадровBindingSource, "Код сотрудника", true));
            this.код_сотрудникаTextBox.Location = new System.Drawing.Point(406, 98);
            this.код_сотрудникаTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.код_сотрудникаTextBox.Name = "код_сотрудникаTextBox";
            this.код_сотрудникаTextBox.Size = new System.Drawing.Size(429, 26);
            this.код_сотрудникаTextBox.TabIndex = 215;
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отдел_кадровBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(406, 132);
            this.фИОTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(429, 26);
            this.фИОTextBox.TabIndex = 216;
            // 
            // возрастTextBox
            // 
            this.возрастTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отдел_кадровBindingSource, "Возраст", true));
            this.возрастTextBox.Location = new System.Drawing.Point(406, 179);
            this.возрастTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.возрастTextBox.Name = "возрастTextBox";
            this.возрастTextBox.Size = new System.Drawing.Size(429, 26);
            this.возрастTextBox.TabIndex = 217;
            // 
            // полTextBox
            // 
            this.полTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отдел_кадровBindingSource, "Пол", true));
            this.полTextBox.Location = new System.Drawing.Point(406, 225);
            this.полTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.полTextBox.Name = "полTextBox";
            this.полTextBox.Size = new System.Drawing.Size(429, 26);
            this.полTextBox.TabIndex = 218;
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отдел_кадровBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(406, 271);
            this.адресTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(429, 26);
            this.адресTextBox.TabIndex = 219;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отдел_кадровBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(406, 318);
            this.телефонTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(429, 26);
            this.телефонTextBox.TabIndex = 220;
            // 
            // паспортные_данныеTextBox
            // 
            this.паспортные_данныеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отдел_кадровBindingSource, "Паспортные данные", true));
            this.паспортные_данныеTextBox.Location = new System.Drawing.Point(406, 364);
            this.паспортные_данныеTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.паспортные_данныеTextBox.Name = "паспортные_данныеTextBox";
            this.паспортные_данныеTextBox.Size = new System.Drawing.Size(429, 26);
            this.паспортные_данныеTextBox.TabIndex = 221;
            // 
            // наименование_должностиTextBox
            // 
            this.наименование_должностиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отдел_кадровBindingSource, "Наименование должности", true));
            this.наименование_должностиTextBox.Location = new System.Drawing.Point(406, 411);
            this.наименование_должностиTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.наименование_должностиTextBox.Name = "наименование_должностиTextBox";
            this.наименование_должностиTextBox.Size = new System.Drawing.Size(429, 26);
            this.наименование_должностиTextBox.TabIndex = 222;
            // 
            // окладTextBox
            // 
            this.окладTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отдел_кадровBindingSource, "Оклад", true));
            this.окладTextBox.Location = new System.Drawing.Point(406, 458);
            this.окладTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.окладTextBox.Name = "окладTextBox";
            this.окладTextBox.Size = new System.Drawing.Size(429, 26);
            this.окладTextBox.TabIndex = 223;
            // 
            // обязанностиTextBox
            // 
            this.обязанностиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отдел_кадровBindingSource, "Обязанности", true));
            this.обязанностиTextBox.Location = new System.Drawing.Point(406, 504);
            this.обязанностиTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.обязанностиTextBox.Name = "обязанностиTextBox";
            this.обязанностиTextBox.Size = new System.Drawing.Size(429, 26);
            this.обязанностиTextBox.TabIndex = 224;
            // 
            // требованияTextBox
            // 
            this.требованияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отдел_кадровBindingSource, "Требования", true));
            this.требованияTextBox.Location = new System.Drawing.Point(406, 556);
            this.требованияTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.требованияTextBox.Name = "требованияTextBox";
            this.требованияTextBox.Size = new System.Drawing.Size(429, 26);
            this.требованияTextBox.TabIndex = 225;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(308, 796);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(261, 45);
            this.button10.TabIndex = 306;
            this.button10.Text = "закрыть";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(308, 728);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(261, 45);
            this.button7.TabIndex = 305;
            this.button7.Text = "сохранить";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(592, 672);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 45);
            this.button3.TabIndex = 304;
            this.button3.Text = "удалить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(308, 672);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(261, 45);
            this.button5.TabIndex = 303;
            this.button5.Text = "следующая";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(61, 672);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(222, 45);
            this.button6.TabIndex = 302;
            this.button6.Text = "последняя";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(592, 619);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 45);
            this.button2.TabIndex = 301;
            this.button2.Text = "добавить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(308, 619);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 45);
            this.button1.TabIndex = 300;
            this.button1.Text = "предыдущая";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(61, 619);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(222, 45);
            this.button4.TabIndex = 299;
            this.button4.Text = "первая";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(592, 728);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(222, 45);
            this.button8.TabIndex = 307;
            this.button8.Text = "Фильтр";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form26
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(900, 849);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(требованияLabel);
            this.Controls.Add(this.требованияTextBox);
            this.Controls.Add(обязанностиLabel);
            this.Controls.Add(this.обязанностиTextBox);
            this.Controls.Add(окладLabel);
            this.Controls.Add(this.окладTextBox);
            this.Controls.Add(наименование_должностиLabel);
            this.Controls.Add(this.наименование_должностиTextBox);
            this.Controls.Add(паспортные_данныеLabel);
            this.Controls.Add(this.паспортные_данныеTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(полLabel);
            this.Controls.Add(this.полTextBox);
            this.Controls.Add(возрастLabel);
            this.Controls.Add(this.возрастTextBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(код_сотрудникаLabel);
            this.Controls.Add(this.код_сотрудникаTextBox);
            this.Controls.Add(this.отдел_кадровBindingNavigator);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form26";
            this.Text = "Form26";
            this.Load += new System.EventHandler(this.Form26_Load);
            ((System.ComponentModel.ISupportInitialize)(this._практика2___копияDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_кадровBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_кадровBindingNavigator)).EndInit();
            this.отдел_кадровBindingNavigator.ResumeLayout(false);
            this.отдел_кадровBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private _практика2___копияDataSet _практика2___копияDataSet;
        private System.Windows.Forms.BindingSource отдел_кадровBindingSource;
        private _практика2___копияDataSetTableAdapters.Отдел_кадровTableAdapter отдел_кадровTableAdapter;
        private _практика2___копияDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator отдел_кадровBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton отдел_кадровBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_сотрудникаTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox возрастTextBox;
        private System.Windows.Forms.TextBox полTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox паспортные_данныеTextBox;
        private System.Windows.Forms.TextBox наименование_должностиTextBox;
        private System.Windows.Forms.TextBox окладTextBox;
        private System.Windows.Forms.TextBox обязанностиTextBox;
        private System.Windows.Forms.TextBox требованияTextBox;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
    }
}