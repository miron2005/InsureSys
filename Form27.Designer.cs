namespace Практика_итог
{
    partial class Form27
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
            System.Windows.Forms.Label код_вида_полисаLabel;
            System.Windows.Forms.Label виды_полисов_НаименованиеLabel;
            System.Windows.Forms.Label виды_полисов_ОписаниеLabel;
            System.Windows.Forms.Label условияLabel;
            System.Windows.Forms.Label код_рискаLabel;
            System.Windows.Forms.Label риски_НаименованиеLabel;
            System.Windows.Forms.Label риски_ОписаниеLabel;
            System.Windows.Forms.Label средняя_вероятностьLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form27));
            this.label2 = new System.Windows.Forms.Label();
            this._практика2___копияDataSet = new Практика_итог._практика2___копияDataSet();
            this.риски_полисовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.риски_полисовTableAdapter = new Практика_итог._практика2___копияDataSetTableAdapters.Риски_полисовTableAdapter();
            this.tableAdapterManager = new Практика_итог._практика2___копияDataSetTableAdapters.TableAdapterManager();
            this.риски_полисовBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.риски_полисовBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_вида_полисаTextBox = new System.Windows.Forms.TextBox();
            this.виды_полисов_НаименованиеTextBox = new System.Windows.Forms.TextBox();
            this.виды_полисов_ОписаниеTextBox = new System.Windows.Forms.TextBox();
            this.условияTextBox = new System.Windows.Forms.TextBox();
            this.код_рискаTextBox = new System.Windows.Forms.TextBox();
            this.риски_НаименованиеTextBox = new System.Windows.Forms.TextBox();
            this.риски_ОписаниеTextBox = new System.Windows.Forms.TextBox();
            this.средняя_вероятностьTextBox = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            код_вида_полисаLabel = new System.Windows.Forms.Label();
            виды_полисов_НаименованиеLabel = new System.Windows.Forms.Label();
            виды_полисов_ОписаниеLabel = new System.Windows.Forms.Label();
            условияLabel = new System.Windows.Forms.Label();
            код_рискаLabel = new System.Windows.Forms.Label();
            риски_НаименованиеLabel = new System.Windows.Forms.Label();
            риски_ОписаниеLabel = new System.Windows.Forms.Label();
            средняя_вероятностьLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._практика2___копияDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.риски_полисовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.риски_полисовBindingNavigator)).BeginInit();
            this.риски_полисовBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // код_вида_полисаLabel
            // 
            код_вида_полисаLabel.AutoSize = true;
            код_вида_полисаLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            код_вида_полисаLabel.Location = new System.Drawing.Point(222, 494);
            код_вида_полисаLabel.Name = "код_вида_полисаLabel";
            код_вида_полисаLabel.Size = new System.Drawing.Size(187, 27);
            код_вида_полисаLabel.TabIndex = 213;
            код_вида_полисаLabel.Text = "Код вида полиса:";
            // 
            // виды_полисов_НаименованиеLabel
            // 
            виды_полисов_НаименованиеLabel.AutoSize = true;
            виды_полисов_НаименованиеLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            виды_полисов_НаименованиеLabel.Location = new System.Drawing.Point(126, 151);
            виды_полисов_НаименованиеLabel.Name = "виды_полисов_НаименованиеLabel";
            виды_полисов_НаименованиеLabel.Size = new System.Drawing.Size(322, 27);
            виды_полисов_НаименованиеLabel.TabIndex = 214;
            виды_полисов_НаименованиеLabel.Text = "Виды полисов Наименование:";
            // 
            // виды_полисов_ОписаниеLabel
            // 
            виды_полисов_ОписаниеLabel.AutoSize = true;
            виды_полисов_ОписаниеLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            виды_полисов_ОписаниеLabel.Location = new System.Drawing.Point(164, 196);
            виды_полисов_ОписаниеLabel.Name = "виды_полисов_ОписаниеLabel";
            виды_полисов_ОписаниеLabel.Size = new System.Drawing.Size(273, 27);
            виды_полисов_ОписаниеLabel.TabIndex = 215;
            виды_полисов_ОписаниеLabel.Text = "Виды полисов Описание:";
            // 
            // условияLabel
            // 
            условияLabel.AutoSize = true;
            условияLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            условияLabel.Location = new System.Drawing.Point(282, 241);
            условияLabel.Name = "условияLabel";
            условияLabel.Size = new System.Drawing.Size(102, 27);
            условияLabel.TabIndex = 216;
            условияLabel.Text = "Условия:";
            // 
            // код_рискаLabel
            // 
            код_рискаLabel.AutoSize = true;
            код_рискаLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            код_рискаLabel.Location = new System.Drawing.Point(271, 301);
            код_рискаLabel.Name = "код_рискаLabel";
            код_рискаLabel.Size = new System.Drawing.Size(121, 27);
            код_рискаLabel.TabIndex = 217;
            код_рискаLabel.Text = "Код риска:";
            // 
            // риски_НаименованиеLabel
            // 
            риски_НаименованиеLabel.AutoSize = true;
            риски_НаименованиеLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            риски_НаименованиеLabel.Location = new System.Drawing.Point(186, 352);
            риски_НаименованиеLabel.Name = "риски_НаименованиеLabel";
            риски_НаименованиеLabel.Size = new System.Drawing.Size(238, 27);
            риски_НаименованиеLabel.TabIndex = 218;
            риски_НаименованиеLabel.Text = "Риски Наименование:";
            // 
            // риски_ОписаниеLabel
            // 
            риски_ОписаниеLabel.AutoSize = true;
            риски_ОписаниеLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            риски_ОписаниеLabel.Location = new System.Drawing.Point(224, 399);
            риски_ОписаниеLabel.Name = "риски_ОписаниеLabel";
            риски_ОписаниеLabel.Size = new System.Drawing.Size(189, 27);
            риски_ОписаниеLabel.TabIndex = 219;
            риски_ОписаниеLabel.Text = "Риски Описание:";
            // 
            // средняя_вероятностьLabel
            // 
            средняя_вероятностьLabel.AutoSize = true;
            средняя_вероятностьLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            средняя_вероятностьLabel.Location = new System.Drawing.Point(186, 444);
            средняя_вероятностьLabel.Name = "средняя_вероятностьLabel";
            средняя_вероятностьLabel.Size = new System.Drawing.Size(235, 27);
            средняя_вероятностьLabel.TabIndex = 220;
            средняя_вероятностьLabel.Text = "Средняя вероятность:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(231, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 52);
            this.label2.TabIndex = 212;
            this.label2.Text = "Риски полисов";
            // 
            // _практика2___копияDataSet
            // 
            this._практика2___копияDataSet.DataSetName = "_практика2___копияDataSet";
            this._практика2___копияDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // риски_полисовBindingSource
            // 
            this.риски_полисовBindingSource.DataMember = "Риски полисов";
            this.риски_полисовBindingSource.DataSource = this._практика2___копияDataSet;
            // 
            // риски_полисовTableAdapter
            // 
            this.риски_полисовTableAdapter.ClearBeforeFill = true;
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
            // риски_полисовBindingNavigator
            // 
            this.риски_полисовBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.риски_полисовBindingNavigator.BindingSource = this.риски_полисовBindingSource;
            this.риски_полисовBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.риски_полисовBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.риски_полисовBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.риски_полисовBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.риски_полисовBindingNavigatorSaveItem});
            this.риски_полисовBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.риски_полисовBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.риски_полисовBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.риски_полисовBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.риски_полисовBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.риски_полисовBindingNavigator.Name = "риски_полисовBindingNavigator";
            this.риски_полисовBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.риски_полисовBindingNavigator.Size = new System.Drawing.Size(1214, 31);
            this.риски_полисовBindingNavigator.TabIndex = 213;
            this.риски_полисовBindingNavigator.Text = "bindingNavigator1";
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
            // риски_полисовBindingNavigatorSaveItem
            // 
            this.риски_полисовBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.риски_полисовBindingNavigatorSaveItem.Enabled = false;
            this.риски_полисовBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("риски_полисовBindingNavigatorSaveItem.Image")));
            this.риски_полисовBindingNavigatorSaveItem.Name = "риски_полисовBindingNavigatorSaveItem";
            this.риски_полисовBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 26);
            this.риски_полисовBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // код_вида_полисаTextBox
            // 
            this.код_вида_полисаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.риски_полисовBindingSource, "Код вида полиса", true));
            this.код_вида_полисаTextBox.Location = new System.Drawing.Point(587, 494);
            this.код_вида_полисаTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.код_вида_полисаTextBox.Name = "код_вида_полисаTextBox";
            this.код_вида_полисаTextBox.Size = new System.Drawing.Size(319, 26);
            this.код_вида_полисаTextBox.TabIndex = 214;
            // 
            // виды_полисов_НаименованиеTextBox
            // 
            this.виды_полисов_НаименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.риски_полисовBindingSource, "Виды полисов_Наименование", true));
            this.виды_полисов_НаименованиеTextBox.Location = new System.Drawing.Point(587, 151);
            this.виды_полисов_НаименованиеTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.виды_полисов_НаименованиеTextBox.Name = "виды_полисов_НаименованиеTextBox";
            this.виды_полисов_НаименованиеTextBox.Size = new System.Drawing.Size(319, 26);
            this.виды_полисов_НаименованиеTextBox.TabIndex = 215;
            // 
            // виды_полисов_ОписаниеTextBox
            // 
            this.виды_полисов_ОписаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.риски_полисовBindingSource, "Виды полисов_Описание", true));
            this.виды_полисов_ОписаниеTextBox.Location = new System.Drawing.Point(587, 196);
            this.виды_полисов_ОписаниеTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.виды_полисов_ОписаниеTextBox.Name = "виды_полисов_ОписаниеTextBox";
            this.виды_полисов_ОписаниеTextBox.Size = new System.Drawing.Size(319, 26);
            this.виды_полисов_ОписаниеTextBox.TabIndex = 216;
            // 
            // условияTextBox
            // 
            this.условияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.риски_полисовBindingSource, "Условия", true));
            this.условияTextBox.Location = new System.Drawing.Point(587, 249);
            this.условияTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.условияTextBox.Name = "условияTextBox";
            this.условияTextBox.Size = new System.Drawing.Size(319, 26);
            this.условияTextBox.TabIndex = 217;
            // 
            // код_рискаTextBox
            // 
            this.код_рискаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.риски_полисовBindingSource, "Код риска", true));
            this.код_рискаTextBox.Location = new System.Drawing.Point(587, 301);
            this.код_рискаTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.код_рискаTextBox.Name = "код_рискаTextBox";
            this.код_рискаTextBox.Size = new System.Drawing.Size(319, 26);
            this.код_рискаTextBox.TabIndex = 218;
            // 
            // риски_НаименованиеTextBox
            // 
            this.риски_НаименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.риски_полисовBindingSource, "Риски_Наименование", true));
            this.риски_НаименованиеTextBox.Location = new System.Drawing.Point(587, 352);
            this.риски_НаименованиеTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.риски_НаименованиеTextBox.Name = "риски_НаименованиеTextBox";
            this.риски_НаименованиеTextBox.Size = new System.Drawing.Size(319, 26);
            this.риски_НаименованиеTextBox.TabIndex = 219;
            // 
            // риски_ОписаниеTextBox
            // 
            this.риски_ОписаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.риски_полисовBindingSource, "Риски_Описание", true));
            this.риски_ОписаниеTextBox.Location = new System.Drawing.Point(587, 399);
            this.риски_ОписаниеTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.риски_ОписаниеTextBox.Name = "риски_ОписаниеTextBox";
            this.риски_ОписаниеTextBox.Size = new System.Drawing.Size(319, 26);
            this.риски_ОписаниеTextBox.TabIndex = 220;
            // 
            // средняя_вероятностьTextBox
            // 
            this.средняя_вероятностьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.риски_полисовBindingSource, "Средняя вероятность", true));
            this.средняя_вероятностьTextBox.Location = new System.Drawing.Point(587, 444);
            this.средняя_вероятностьTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.средняя_вероятностьTextBox.Name = "средняя_вероятностьTextBox";
            this.средняя_вероятностьTextBox.Size = new System.Drawing.Size(319, 26);
            this.средняя_вероятностьTextBox.TabIndex = 221;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(350, 730);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(261, 45);
            this.button10.TabIndex = 314;
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
            this.button7.Location = new System.Drawing.Point(350, 661);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(261, 45);
            this.button7.TabIndex = 313;
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
            this.button3.Location = new System.Drawing.Point(633, 606);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 45);
            this.button3.TabIndex = 312;
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
            this.button5.Location = new System.Drawing.Point(350, 606);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(261, 45);
            this.button5.TabIndex = 311;
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
            this.button6.Location = new System.Drawing.Point(102, 606);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(222, 45);
            this.button6.TabIndex = 310;
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
            this.button2.Location = new System.Drawing.Point(633, 552);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 45);
            this.button2.TabIndex = 309;
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
            this.button1.Location = new System.Drawing.Point(350, 552);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 45);
            this.button1.TabIndex = 308;
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
            this.button4.Location = new System.Drawing.Point(102, 552);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(222, 45);
            this.button4.TabIndex = 307;
            this.button4.Text = "первая";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form27
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1214, 812);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(средняя_вероятностьLabel);
            this.Controls.Add(this.средняя_вероятностьTextBox);
            this.Controls.Add(риски_ОписаниеLabel);
            this.Controls.Add(this.риски_ОписаниеTextBox);
            this.Controls.Add(риски_НаименованиеLabel);
            this.Controls.Add(this.риски_НаименованиеTextBox);
            this.Controls.Add(код_рискаLabel);
            this.Controls.Add(this.код_рискаTextBox);
            this.Controls.Add(условияLabel);
            this.Controls.Add(this.условияTextBox);
            this.Controls.Add(виды_полисов_ОписаниеLabel);
            this.Controls.Add(this.виды_полисов_ОписаниеTextBox);
            this.Controls.Add(виды_полисов_НаименованиеLabel);
            this.Controls.Add(this.виды_полисов_НаименованиеTextBox);
            this.Controls.Add(код_вида_полисаLabel);
            this.Controls.Add(this.код_вида_полисаTextBox);
            this.Controls.Add(this.риски_полисовBindingNavigator);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form27";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form27_Load);
            ((System.ComponentModel.ISupportInitialize)(this._практика2___копияDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.риски_полисовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.риски_полисовBindingNavigator)).EndInit();
            this.риски_полисовBindingNavigator.ResumeLayout(false);
            this.риски_полисовBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private _практика2___копияDataSet _практика2___копияDataSet;
        private System.Windows.Forms.BindingSource риски_полисовBindingSource;
        private _практика2___копияDataSetTableAdapters.Риски_полисовTableAdapter риски_полисовTableAdapter;
        private _практика2___копияDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator риски_полисовBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton риски_полисовBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_вида_полисаTextBox;
        private System.Windows.Forms.TextBox виды_полисов_НаименованиеTextBox;
        private System.Windows.Forms.TextBox виды_полисов_ОписаниеTextBox;
        private System.Windows.Forms.TextBox условияTextBox;
        private System.Windows.Forms.TextBox код_рискаTextBox;
        private System.Windows.Forms.TextBox риски_НаименованиеTextBox;
        private System.Windows.Forms.TextBox риски_ОписаниеTextBox;
        private System.Windows.Forms.TextBox средняя_вероятностьTextBox;
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