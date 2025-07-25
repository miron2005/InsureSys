namespace Практика_итог
{
    partial class Form9
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
            System.Windows.Forms.Label дата_началаLabel;
            System.Windows.Forms.Label дата_окончанияLabel;
            System.Windows.Forms.Label стоимостьLabel;
            System.Windows.Forms.Label сумма_выплатыLabel;
            System.Windows.Forms.Label код_вида_полисаLabel;
            System.Windows.Forms.Label отметка_о_выплатеLabel;
            System.Windows.Forms.Label номер_полисаLabel;
            System.Windows.Forms.Label отметка_об_окончанииLabel;
            System.Windows.Forms.Label код_клиентаLabel;
            System.Windows.Forms.Label код_сотрудникаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.label2 = new System.Windows.Forms.Label();
            this._практика2___копияDataSet = new Практика_итог._практика2___копияDataSet();
            this.полисыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.полисыTableAdapter = new Практика_итог._практика2___копияDataSetTableAdapters.ПолисыTableAdapter();
            this.tableAdapterManager = new Практика_итог._практика2___копияDataSetTableAdapters.TableAdapterManager();
            this.полисыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.полисыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.дата_началаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_окончанияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.сумма_выплатыTextBox = new System.Windows.Forms.TextBox();
            this.код_вида_полисаTextBox = new System.Windows.Forms.TextBox();
            this.отметка_о_выплатеCheckBox = new System.Windows.Forms.CheckBox();
            this.номер_полисаTextBox = new System.Windows.Forms.TextBox();
            this.отметка_об_окончанииCheckBox = new System.Windows.Forms.CheckBox();
            this.код_клиентаTextBox = new System.Windows.Forms.TextBox();
            this.код_сотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            дата_началаLabel = new System.Windows.Forms.Label();
            дата_окончанияLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            сумма_выплатыLabel = new System.Windows.Forms.Label();
            код_вида_полисаLabel = new System.Windows.Forms.Label();
            отметка_о_выплатеLabel = new System.Windows.Forms.Label();
            номер_полисаLabel = new System.Windows.Forms.Label();
            отметка_об_окончанииLabel = new System.Windows.Forms.Label();
            код_клиентаLabel = new System.Windows.Forms.Label();
            код_сотрудникаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._практика2___копияDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.полисыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.полисыBindingNavigator)).BeginInit();
            this.полисыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // дата_началаLabel
            // 
            дата_началаLabel.AutoSize = true;
            дата_началаLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            дата_началаLabel.Location = new System.Drawing.Point(150, 152);
            дата_началаLabel.Name = "дата_началаLabel";
            дата_началаLabel.Size = new System.Drawing.Size(140, 27);
            дата_началаLabel.TabIndex = 215;
            дата_началаLabel.Text = "Дата начала:";
            // 
            // дата_окончанияLabel
            // 
            дата_окончанияLabel.AutoSize = true;
            дата_окончанияLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            дата_окончанияLabel.Location = new System.Drawing.Point(125, 206);
            дата_окончанияLabel.Name = "дата_окончанияLabel";
            дата_окончанияLabel.Size = new System.Drawing.Size(179, 27);
            дата_окончанияLabel.TabIndex = 216;
            дата_окончанияLabel.Text = "Дата окончания:";
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            стоимостьLabel.Location = new System.Drawing.Point(164, 254);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(129, 27);
            стоимостьLabel.TabIndex = 217;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // сумма_выплатыLabel
            // 
            сумма_выплатыLabel.AutoSize = true;
            сумма_выплатыLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            сумма_выплатыLabel.Location = new System.Drawing.Point(127, 285);
            сумма_выплатыLabel.Name = "сумма_выплатыLabel";
            сумма_выплатыLabel.Size = new System.Drawing.Size(180, 27);
            сумма_выплатыLabel.TabIndex = 218;
            сумма_выплатыLabel.Text = "Сумма выплаты:";
            // 
            // код_вида_полисаLabel
            // 
            код_вида_полисаLabel.AutoSize = true;
            код_вида_полисаLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            код_вида_полисаLabel.Location = new System.Drawing.Point(120, 325);
            код_вида_полисаLabel.Name = "код_вида_полисаLabel";
            код_вида_полисаLabel.Size = new System.Drawing.Size(187, 27);
            код_вида_полисаLabel.TabIndex = 219;
            код_вида_полисаLabel.Text = "Код вида полиса:";
            // 
            // отметка_о_выплатеLabel
            // 
            отметка_о_выплатеLabel.AutoSize = true;
            отметка_о_выплатеLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            отметка_о_выплатеLabel.Location = new System.Drawing.Point(101, 366);
            отметка_о_выплатеLabel.Name = "отметка_о_выплатеLabel";
            отметка_о_выплатеLabel.Size = new System.Drawing.Size(211, 27);
            отметка_о_выплатеLabel.TabIndex = 220;
            отметка_о_выплатеLabel.Text = "Отметка о выплате:";
            // 
            // номер_полисаLabel
            // 
            номер_полисаLabel.AutoSize = true;
            номер_полисаLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            номер_полисаLabel.Location = new System.Drawing.Point(138, 109);
            номер_полисаLabel.Name = "номер_полисаLabel";
            номер_полисаLabel.Size = new System.Drawing.Size(163, 27);
            номер_полисаLabel.TabIndex = 221;
            номер_полисаLabel.Text = "Номер полиса:";
            // 
            // отметка_об_окончанииLabel
            // 
            отметка_об_окончанииLabel.AutoSize = true;
            отметка_об_окончанииLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            отметка_об_окончанииLabel.Location = new System.Drawing.Point(75, 409);
            отметка_об_окончанииLabel.Name = "отметка_об_окончанииLabel";
            отметка_об_окончанииLabel.Size = new System.Drawing.Size(250, 27);
            отметка_об_окончанииLabel.TabIndex = 222;
            отметка_об_окончанииLabel.Text = "Отметка об окончании:";
            // 
            // код_клиентаLabel
            // 
            код_клиентаLabel.AutoSize = true;
            код_клиентаLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            код_клиентаLabel.Location = new System.Drawing.Point(152, 460);
            код_клиентаLabel.Name = "код_клиентаLabel";
            код_клиентаLabel.Size = new System.Drawing.Size(144, 27);
            код_клиентаLabel.TabIndex = 223;
            код_клиентаLabel.Text = "Код клиента:";
            // 
            // код_сотрудникаLabel
            // 
            код_сотрудникаLabel.AutoSize = true;
            код_сотрудникаLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            код_сотрудникаLabel.Location = new System.Drawing.Point(127, 496);
            код_сотрудникаLabel.Name = "код_сотрудникаLabel";
            код_сотрудникаLabel.Size = new System.Drawing.Size(178, 27);
            код_сотрудникаLabel.TabIndex = 224;
            код_сотрудникаLabel.Text = "Код сотрудника:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(309, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 52);
            this.label2.TabIndex = 214;
            this.label2.Text = "Полисы";
            // 
            // _практика2___копияDataSet
            // 
            this._практика2___копияDataSet.DataSetName = "_практика2___копияDataSet";
            this._практика2___копияDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // полисыBindingSource
            // 
            this.полисыBindingSource.DataMember = "Полисы";
            this.полисыBindingSource.DataSource = this._практика2___копияDataSet;
            // 
            // полисыTableAdapter
            // 
            this.полисыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Практика_итог._практика2___копияDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Виды_полисовTableAdapter = null;
            this.tableAdapterManager.Группы_клиентовTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.ПолисыTableAdapter = this.полисыTableAdapter;
            this.tableAdapterManager.РискиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Таблица1TableAdapter = null;
            // 
            // полисыBindingNavigator
            // 
            this.полисыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.полисыBindingNavigator.BindingSource = this.полисыBindingSource;
            this.полисыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.полисыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.полисыBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.полисыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.полисыBindingNavigatorSaveItem});
            this.полисыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.полисыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.полисыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.полисыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.полисыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.полисыBindingNavigator.Name = "полисыBindingNavigator";
            this.полисыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.полисыBindingNavigator.Size = new System.Drawing.Size(932, 31);
            this.полисыBindingNavigator.TabIndex = 215;
            this.полисыBindingNavigator.Text = "bindingNavigator1";
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
            // полисыBindingNavigatorSaveItem
            // 
            this.полисыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.полисыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("полисыBindingNavigatorSaveItem.Image")));
            this.полисыBindingNavigatorSaveItem.Name = "полисыBindingNavigatorSaveItem";
            this.полисыBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 26);
            this.полисыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.полисыBindingNavigatorSaveItem.Click += new System.EventHandler(this.полисыBindingNavigatorSaveItem_Click);
            // 
            // дата_началаDateTimePicker
            // 
            this.дата_началаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.полисыBindingSource, "Дата начала", true));
            this.дата_началаDateTimePicker.Location = new System.Drawing.Point(392, 144);
            this.дата_началаDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.дата_началаDateTimePicker.Name = "дата_началаDateTimePicker";
            this.дата_началаDateTimePicker.Size = new System.Drawing.Size(224, 26);
            this.дата_началаDateTimePicker.TabIndex = 216;
            // 
            // дата_окончанияDateTimePicker
            // 
            this.дата_окончанияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.полисыBindingSource, "Дата окончания", true));
            this.дата_окончанияDateTimePicker.Location = new System.Drawing.Point(392, 206);
            this.дата_окончанияDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.дата_окончанияDateTimePicker.Name = "дата_окончанияDateTimePicker";
            this.дата_окончанияDateTimePicker.Size = new System.Drawing.Size(224, 26);
            this.дата_окончанияDateTimePicker.TabIndex = 217;
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.полисыBindingSource, "Стоимость", true));
            this.стоимостьTextBox.Location = new System.Drawing.Point(392, 254);
            this.стоимостьTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(224, 26);
            this.стоимостьTextBox.TabIndex = 218;
            // 
            // сумма_выплатыTextBox
            // 
            this.сумма_выплатыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.полисыBindingSource, "Сумма выплаты", true));
            this.сумма_выплатыTextBox.Location = new System.Drawing.Point(392, 292);
            this.сумма_выплатыTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.сумма_выплатыTextBox.Name = "сумма_выплатыTextBox";
            this.сумма_выплатыTextBox.Size = new System.Drawing.Size(224, 26);
            this.сумма_выплатыTextBox.TabIndex = 219;
            // 
            // код_вида_полисаTextBox
            // 
            this.код_вида_полисаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.полисыBindingSource, "Код вида полиса", true));
            this.код_вида_полисаTextBox.Location = new System.Drawing.Point(392, 332);
            this.код_вида_полисаTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.код_вида_полисаTextBox.Name = "код_вида_полисаTextBox";
            this.код_вида_полисаTextBox.Size = new System.Drawing.Size(224, 26);
            this.код_вида_полисаTextBox.TabIndex = 220;
            // 
            // отметка_о_выплатеCheckBox
            // 
            this.отметка_о_выплатеCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.полисыBindingSource, "Отметка о выплате", true));
            this.отметка_о_выплатеCheckBox.Location = new System.Drawing.Point(438, 368);
            this.отметка_о_выплатеCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.отметка_о_выплатеCheckBox.Name = "отметка_о_выплатеCheckBox";
            this.отметка_о_выплатеCheckBox.Size = new System.Drawing.Size(117, 30);
            this.отметка_о_выплатеCheckBox.TabIndex = 221;
            this.отметка_о_выплатеCheckBox.UseVisualStyleBackColor = true;
            // 
            // номер_полисаTextBox
            // 
            this.номер_полисаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.полисыBindingSource, "Номер полиса", true));
            this.номер_полисаTextBox.Location = new System.Drawing.Point(392, 109);
            this.номер_полисаTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.номер_полисаTextBox.Name = "номер_полисаTextBox";
            this.номер_полисаTextBox.Size = new System.Drawing.Size(224, 26);
            this.номер_полисаTextBox.TabIndex = 222;
            // 
            // отметка_об_окончанииCheckBox
            // 
            this.отметка_об_окончанииCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.полисыBindingSource, "Отметка об окончании", true));
            this.отметка_об_окончанииCheckBox.Location = new System.Drawing.Point(438, 406);
            this.отметка_об_окончанииCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.отметка_об_окончанииCheckBox.Name = "отметка_об_окончанииCheckBox";
            this.отметка_об_окончанииCheckBox.Size = new System.Drawing.Size(117, 30);
            this.отметка_об_окончанииCheckBox.TabIndex = 223;
            this.отметка_об_окончанииCheckBox.UseVisualStyleBackColor = true;
            // 
            // код_клиентаTextBox
            // 
            this.код_клиентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.полисыBindingSource, "Код клиента", true));
            this.код_клиентаTextBox.Location = new System.Drawing.Point(392, 460);
            this.код_клиентаTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.код_клиентаTextBox.Name = "код_клиентаTextBox";
            this.код_клиентаTextBox.Size = new System.Drawing.Size(224, 26);
            this.код_клиентаTextBox.TabIndex = 224;
            // 
            // код_сотрудникаTextBox
            // 
            this.код_сотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.полисыBindingSource, "Код сотрудника", true));
            this.код_сотрудникаTextBox.Location = new System.Drawing.Point(392, 504);
            this.код_сотрудникаTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.код_сотрудникаTextBox.Name = "код_сотрудникаTextBox";
            this.код_сотрудникаTextBox.Size = new System.Drawing.Size(224, 26);
            this.код_сотрудникаTextBox.TabIndex = 225;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(318, 672);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(261, 45);
            this.button7.TabIndex = 311;
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
            this.button3.Location = new System.Drawing.Point(602, 618);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 45);
            this.button3.TabIndex = 310;
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
            this.button5.Location = new System.Drawing.Point(318, 618);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(261, 45);
            this.button5.TabIndex = 309;
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
            this.button6.Location = new System.Drawing.Point(71, 618);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(222, 45);
            this.button6.TabIndex = 308;
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
            this.button2.Location = new System.Drawing.Point(602, 564);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 45);
            this.button2.TabIndex = 307;
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
            this.button1.Location = new System.Drawing.Point(318, 564);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 45);
            this.button1.TabIndex = 306;
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
            this.button4.Location = new System.Drawing.Point(71, 564);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(222, 45);
            this.button4.TabIndex = 305;
            this.button4.Text = "первая";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(318, 741);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(261, 45);
            this.button10.TabIndex = 312;
            this.button10.Text = "закрыть";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(932, 818);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(код_сотрудникаLabel);
            this.Controls.Add(this.код_сотрудникаTextBox);
            this.Controls.Add(код_клиентаLabel);
            this.Controls.Add(this.код_клиентаTextBox);
            this.Controls.Add(отметка_об_окончанииLabel);
            this.Controls.Add(this.отметка_об_окончанииCheckBox);
            this.Controls.Add(номер_полисаLabel);
            this.Controls.Add(this.номер_полисаTextBox);
            this.Controls.Add(отметка_о_выплатеLabel);
            this.Controls.Add(this.отметка_о_выплатеCheckBox);
            this.Controls.Add(код_вида_полисаLabel);
            this.Controls.Add(this.код_вида_полисаTextBox);
            this.Controls.Add(сумма_выплатыLabel);
            this.Controls.Add(this.сумма_выплатыTextBox);
            this.Controls.Add(стоимостьLabel);
            this.Controls.Add(this.стоимостьTextBox);
            this.Controls.Add(дата_окончанияLabel);
            this.Controls.Add(this.дата_окончанияDateTimePicker);
            this.Controls.Add(дата_началаLabel);
            this.Controls.Add(this.дата_началаDateTimePicker);
            this.Controls.Add(this.полисыBindingNavigator);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this._практика2___копияDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.полисыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.полисыBindingNavigator)).EndInit();
            this.полисыBindingNavigator.ResumeLayout(false);
            this.полисыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private _практика2___копияDataSet _практика2___копияDataSet;
        private System.Windows.Forms.BindingSource полисыBindingSource;
        private _практика2___копияDataSetTableAdapters.ПолисыTableAdapter полисыTableAdapter;
        private _практика2___копияDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator полисыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton полисыBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker дата_началаDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_окончанияDateTimePicker;
        private System.Windows.Forms.TextBox стоимостьTextBox;
        private System.Windows.Forms.TextBox сумма_выплатыTextBox;
        private System.Windows.Forms.TextBox код_вида_полисаTextBox;
        private System.Windows.Forms.CheckBox отметка_о_выплатеCheckBox;
        private System.Windows.Forms.TextBox номер_полисаTextBox;
        private System.Windows.Forms.CheckBox отметка_об_окончанииCheckBox;
        private System.Windows.Forms.TextBox код_клиентаTextBox;
        private System.Windows.Forms.TextBox код_сотрудникаTextBox;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button10;
    }
}