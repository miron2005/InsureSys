namespace Практика_итог
{
    partial class Form28
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
            System.Windows.Forms.Label код_клиентаLabel;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label полLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label паспортные_данныеLabel;
            System.Windows.Forms.Label код_группыLabel;
            System.Windows.Forms.Label наименованиеLabel;
            System.Windows.Forms.Label описаниеLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form28));
            this.label2 = new System.Windows.Forms.Label();
            this._практика2___копияDataSet = new Практика_итог._практика2___копияDataSet();
            this.список_клиентовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.список_клиентовTableAdapter = new Практика_итог._практика2___копияDataSetTableAdapters.Список_клиентовTableAdapter();
            this.tableAdapterManager = new Практика_итог._практика2___копияDataSetTableAdapters.TableAdapterManager();
            this.список_клиентовBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.список_клиентовBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_клиентаTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.дата_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.полTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.паспортные_данныеTextBox = new System.Windows.Forms.TextBox();
            this.код_группыTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.описаниеTextBox = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            код_клиентаLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            паспортные_данныеLabel = new System.Windows.Forms.Label();
            код_группыLabel = new System.Windows.Forms.Label();
            наименованиеLabel = new System.Windows.Forms.Label();
            описаниеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._практика2___копияDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_клиентовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_клиентовBindingNavigator)).BeginInit();
            this.список_клиентовBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // код_клиентаLabel
            // 
            код_клиентаLabel.AutoSize = true;
            код_клиентаLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            код_клиентаLabel.Location = new System.Drawing.Point(206, 606);
            код_клиентаLabel.Name = "код_клиентаLabel";
            код_клиентаLabel.Size = new System.Drawing.Size(144, 27);
            код_клиентаLabel.TabIndex = 214;
            код_клиентаLabel.Text = "Код клиента:";
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            фИОLabel.Location = new System.Drawing.Point(262, 146);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(70, 27);
            фИОLabel.TabIndex = 215;
            фИОLabel.Text = "ФИО:";
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            дата_рожденияLabel.Location = new System.Drawing.Point(186, 196);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(171, 27);
            дата_рожденияLabel.TabIndex = 216;
            дата_рожденияLabel.Text = "Дата рождения:";
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            полLabel.Location = new System.Drawing.Point(264, 248);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(59, 27);
            полLabel.TabIndex = 217;
            полLabel.Text = "Пол:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            адресLabel.Location = new System.Drawing.Point(252, 291);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(82, 27);
            адресLabel.TabIndex = 218;
            адресLabel.Text = "Адрес:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            телефонLabel.Location = new System.Drawing.Point(230, 334);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(106, 27);
            телефонLabel.TabIndex = 219;
            телефонLabel.Text = "Телефон:";
            // 
            // паспортные_данныеLabel
            // 
            паспортные_данныеLabel.AutoSize = true;
            паспортные_данныеLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            паспортные_данныеLabel.Location = new System.Drawing.Point(147, 385);
            паспортные_данныеLabel.Name = "паспортные_данныеLabel";
            паспортные_данныеLabel.Size = new System.Drawing.Size(226, 27);
            паспортные_данныеLabel.TabIndex = 220;
            паспортные_данныеLabel.Text = "Паспортные данные:";
            // 
            // код_группыLabel
            // 
            код_группыLabel.AutoSize = true;
            код_группыLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            код_группыLabel.Location = new System.Drawing.Point(214, 439);
            код_группыLabel.Name = "код_группыLabel";
            код_группыLabel.Size = new System.Drawing.Size(138, 27);
            код_группыLabel.TabIndex = 221;
            код_группыLabel.Text = "Код группы:";
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            наименованиеLabel.Location = new System.Drawing.Point(182, 495);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(169, 27);
            наименованиеLabel.TabIndex = 222;
            наименованиеLabel.Text = "Наименование:";
            // 
            // описаниеLabel
            // 
            описаниеLabel.AutoSize = true;
            описаниеLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            описаниеLabel.Location = new System.Drawing.Point(220, 554);
            описаниеLabel.Name = "описаниеLabel";
            описаниеLabel.Size = new System.Drawing.Size(120, 27);
            описаниеLabel.TabIndex = 223;
            описаниеLabel.Text = "Описание:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(225, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 52);
            this.label2.TabIndex = 213;
            this.label2.Text = "Список клиентов";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // _практика2___копияDataSet
            // 
            this._практика2___копияDataSet.DataSetName = "_практика2___копияDataSet";
            this._практика2___копияDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // список_клиентовBindingSource
            // 
            this.список_клиентовBindingSource.DataMember = "Список клиентов";
            this.список_клиентовBindingSource.DataSource = this._практика2___копияDataSet;
            // 
            // список_клиентовTableAdapter
            // 
            this.список_клиентовTableAdapter.ClearBeforeFill = true;
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
            // список_клиентовBindingNavigator
            // 
            this.список_клиентовBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.список_клиентовBindingNavigator.BindingSource = this.список_клиентовBindingSource;
            this.список_клиентовBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.список_клиентовBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.список_клиентовBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.список_клиентовBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.список_клиентовBindingNavigatorSaveItem});
            this.список_клиентовBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.список_клиентовBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.список_клиентовBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.список_клиентовBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.список_клиентовBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.список_клиентовBindingNavigator.Name = "список_клиентовBindingNavigator";
            this.список_клиентовBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.список_клиентовBindingNavigator.Size = new System.Drawing.Size(900, 31);
            this.список_клиентовBindingNavigator.TabIndex = 214;
            this.список_клиентовBindingNavigator.Text = "bindingNavigator1";
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
            // список_клиентовBindingNavigatorSaveItem
            // 
            this.список_клиентовBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.список_клиентовBindingNavigatorSaveItem.Enabled = false;
            this.список_клиентовBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("список_клиентовBindingNavigatorSaveItem.Image")));
            this.список_клиентовBindingNavigatorSaveItem.Name = "список_клиентовBindingNavigatorSaveItem";
            this.список_клиентовBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 26);
            this.список_клиентовBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // код_клиентаTextBox
            // 
            this.код_клиентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.список_клиентовBindingSource, "Код клиента", true));
            this.код_клиентаTextBox.Location = new System.Drawing.Point(502, 606);
            this.код_клиентаTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.код_клиентаTextBox.Name = "код_клиентаTextBox";
            this.код_клиентаTextBox.Size = new System.Drawing.Size(246, 26);
            this.код_клиентаTextBox.TabIndex = 215;
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.список_клиентовBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(505, 146);
            this.фИОTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(246, 26);
            this.фИОTextBox.TabIndex = 216;
            // 
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.список_клиентовBindingSource, "Дата рождения", true));
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(505, 195);
            this.дата_рожденияDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(246, 26);
            this.дата_рожденияDateTimePicker.TabIndex = 217;
            // 
            // полTextBox
            // 
            this.полTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.список_клиентовBindingSource, "Пол", true));
            this.полTextBox.Location = new System.Drawing.Point(505, 244);
            this.полTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.полTextBox.Name = "полTextBox";
            this.полTextBox.Size = new System.Drawing.Size(246, 26);
            this.полTextBox.TabIndex = 218;
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.список_клиентовBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(505, 291);
            this.адресTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(246, 26);
            this.адресTextBox.TabIndex = 219;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.список_клиентовBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(505, 334);
            this.телефонTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(246, 26);
            this.телефонTextBox.TabIndex = 220;
            // 
            // паспортные_данныеTextBox
            // 
            this.паспортные_данныеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.список_клиентовBindingSource, "Паспортные данные", true));
            this.паспортные_данныеTextBox.Location = new System.Drawing.Point(505, 385);
            this.паспортные_данныеTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.паспортные_данныеTextBox.Name = "паспортные_данныеTextBox";
            this.паспортные_данныеTextBox.Size = new System.Drawing.Size(246, 26);
            this.паспортные_данныеTextBox.TabIndex = 221;
            // 
            // код_группыTextBox
            // 
            this.код_группыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.список_клиентовBindingSource, "Код группы", true));
            this.код_группыTextBox.Location = new System.Drawing.Point(505, 439);
            this.код_группыTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.код_группыTextBox.Name = "код_группыTextBox";
            this.код_группыTextBox.Size = new System.Drawing.Size(246, 26);
            this.код_группыTextBox.TabIndex = 222;
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.список_клиентовBindingSource, "Наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(502, 495);
            this.наименованиеTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(246, 26);
            this.наименованиеTextBox.TabIndex = 223;
            // 
            // описаниеTextBox
            // 
            this.описаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.список_клиентовBindingSource, "Описание", true));
            this.описаниеTextBox.Location = new System.Drawing.Point(502, 554);
            this.описаниеTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.описаниеTextBox.Name = "описаниеTextBox";
            this.описаниеTextBox.Size = new System.Drawing.Size(246, 26);
            this.описаниеTextBox.TabIndex = 224;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(318, 848);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(261, 45);
            this.button10.TabIndex = 322;
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
            this.button7.Location = new System.Drawing.Point(318, 779);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(261, 45);
            this.button7.TabIndex = 321;
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
            this.button3.Location = new System.Drawing.Point(602, 724);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 45);
            this.button3.TabIndex = 320;
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
            this.button5.Location = new System.Drawing.Point(318, 724);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(261, 45);
            this.button5.TabIndex = 319;
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
            this.button6.Location = new System.Drawing.Point(71, 724);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(222, 45);
            this.button6.TabIndex = 318;
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
            this.button2.Location = new System.Drawing.Point(602, 670);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 45);
            this.button2.TabIndex = 317;
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
            this.button1.Location = new System.Drawing.Point(318, 670);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 45);
            this.button1.TabIndex = 316;
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
            this.button4.Location = new System.Drawing.Point(71, 670);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(222, 45);
            this.button4.TabIndex = 315;
            this.button4.Text = "первая";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form28
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(900, 901);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(описаниеLabel);
            this.Controls.Add(this.описаниеTextBox);
            this.Controls.Add(наименованиеLabel);
            this.Controls.Add(this.наименованиеTextBox);
            this.Controls.Add(код_группыLabel);
            this.Controls.Add(this.код_группыTextBox);
            this.Controls.Add(паспортные_данныеLabel);
            this.Controls.Add(this.паспортные_данныеTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(полLabel);
            this.Controls.Add(this.полTextBox);
            this.Controls.Add(дата_рожденияLabel);
            this.Controls.Add(this.дата_рожденияDateTimePicker);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(код_клиентаLabel);
            this.Controls.Add(this.код_клиентаTextBox);
            this.Controls.Add(this.список_клиентовBindingNavigator);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form28";
            this.Text = "Form28";
            this.Load += new System.EventHandler(this.Form28_Load);
            ((System.ComponentModel.ISupportInitialize)(this._практика2___копияDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_клиентовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_клиентовBindingNavigator)).EndInit();
            this.список_клиентовBindingNavigator.ResumeLayout(false);
            this.список_клиентовBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private _практика2___копияDataSet _практика2___копияDataSet;
        private System.Windows.Forms.BindingSource список_клиентовBindingSource;
        private _практика2___копияDataSetTableAdapters.Список_клиентовTableAdapter список_клиентовTableAdapter;
        private _практика2___копияDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator список_клиентовBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton список_клиентовBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_клиентаTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.TextBox полTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox паспортные_данныеTextBox;
        private System.Windows.Forms.TextBox код_группыTextBox;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.TextBox описаниеTextBox;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}