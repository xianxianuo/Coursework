namespace CurseWork
{
    partial class fChangeInformation
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChangeInformation));
            toolStrip = new ToolStrip();
            ts_btnSaveInfo = new ToolStripButton();
            ts_btnAdd = new ToolStripButton();
            ts_btnDelete = new ToolStripButton();
            ts_cbSort = new ToolStripComboBox();
            title = new Label();
            dgBookingChange = new DataGridView();
            contextMenuStrip = new ContextMenuStrip(components);
            toolStripMenuItemAdd = new ToolStripMenuItem();
            toolStripMenuItemDelete = new ToolStripMenuItem();
            toolStripMenuItemSave = new ToolStripMenuItem();
            buttonClose = new Button();
            menuStrip = new MenuStrip();
            fILEToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsMenuStripMenuItem = new ToolStripMenuItem();
            copyMenuStripItem = new ToolStripMenuItem();
            newFileMenuStripItem = new ToolStripMenuItem();
            openMenuStripItem = new ToolStripMenuItem();
            clientToolStripMenuItem = new ToolStripMenuItem();
            employeeToolStripMenuItem = new ToolStripMenuItem();
            roomToolStripMenuItem = new ToolStripMenuItem();
            openAsMenuStripItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            newFileToolStripMenuItem = new ToolStripMenuItem();
            eDITToolStripMenuItem = new ToolStripMenuItem();
            sortToolStripMenuItem = new ToolStripMenuItem();
            nameToolStripMenuItem = new ToolStripMenuItem();
            surnameToolStripMenuItem = new ToolStripMenuItem();
            roomNumberToolStripMenuItem = new ToolStripMenuItem();
            dataCheckInToolStripMenuItem = new ToolStripMenuItem();
            nameEmployeeToolStripMenuItem1 = new ToolStripMenuItem();
            idToolStripMenuItem = new ToolStripMenuItem();
            numberToolStripMenuItem = new ToolStripMenuItem();
            priceToolStripMenuItem = new ToolStripMenuItem();
            statusToolStripMenuItem = new ToolStripMenuItem();
            addClientToolStripMenuItem = new ToolStripMenuItem();
            deleteClientToolStripMenuItem = new ToolStripMenuItem();
            deleteCheckOutToolStripMenuItem = new ToolStripMenuItem();
            aDDEMPLOYEEToolStripMenuItem = new ToolStripMenuItem();
            dELETEEMPLOYEEToolStripMenuItem = new ToolStripMenuItem();
            aDDROOMToolStripMenuItem = new ToolStripMenuItem();
            dELETEROOMToolStripMenuItem = new ToolStripMenuItem();
            wINDOWToolStripMenuItem = new ToolStripMenuItem();
            hideToolStripToolStripMenuItem = new ToolStripMenuItem();
            showToolStripToolStripMenuItem = new ToolStripMenuItem();
            tsFile = new ToolStripMenuItem();
            tsFileSave = new ToolStripMenuItem();
            tsFileSaveToFile = new ToolStripMenuItem();
            tsFileExportFromFile = new ToolStripMenuItem();
            tsEdit = new ToolStripMenuItem();
            tsEditAddClient = new ToolStripMenuItem();
            tsEditDeleteClient = new ToolStripMenuItem();
            tsEditExportClient = new ToolStripMenuItem();
            tsEditDeleteCheckOut = new ToolStripMenuItem();
            tsWindow = new ToolStripMenuItem();
            viewHelpToolStripMenuItem = new ToolStripMenuItem();
            aboutCurseWorkToolStripMenuItem = new ToolStripMenuItem();
            tsWindowShowToolStrip = new ToolStripMenuItem();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgBookingChange).BeginInit();
            contextMenuStrip.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip
            // 
            toolStrip.AllowDrop = true;
            toolStrip.Anchor = AnchorStyles.None;
            toolStrip.AutoSize = false;
            toolStrip.BackColor = Color.FromArgb(20, 60, 178);
            toolStrip.Dock = DockStyle.None;
            toolStrip.GripMargin = new Padding(0);
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.ImageScalingSize = new Size(40, 40);
            toolStrip.Items.AddRange(new ToolStripItem[] { ts_btnSaveInfo, ts_btnAdd, ts_btnDelete, ts_cbSort });
            toolStrip.Location = new Point(49, 156);
            toolStrip.Name = "toolStrip";
            toolStrip.Padding = new Padding(40, 0, 40, 0);
            toolStrip.Size = new Size(1094, 62);
            toolStrip.TabIndex = 17;
            toolStrip.Text = "toolStrip";
            // 
            // ts_btnSaveInfo
            // 
            ts_btnSaveInfo.AutoSize = false;
            ts_btnSaveInfo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ts_btnSaveInfo.Image = (Image)resources.GetObject("ts_btnSaveInfo.Image");
            ts_btnSaveInfo.ImageTransparentColor = Color.Magenta;
            ts_btnSaveInfo.Margin = new Padding(0, 1, 20, 2);
            ts_btnSaveInfo.Name = "ts_btnSaveInfo";
            ts_btnSaveInfo.Size = new Size(40, 40);
            ts_btnSaveInfo.Text = "toolStripButton1";
            ts_btnSaveInfo.Click += saveToolStripMenuItem_Click;
            // 
            // ts_btnAdd
            // 
            ts_btnAdd.AutoSize = false;
            ts_btnAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ts_btnAdd.Image = (Image)resources.GetObject("ts_btnAdd.Image");
            ts_btnAdd.ImageTransparentColor = Color.Magenta;
            ts_btnAdd.Margin = new Padding(0);
            ts_btnAdd.MergeIndex = 0;
            ts_btnAdd.Name = "ts_btnAdd";
            ts_btnAdd.Size = new Size(40, 40);
            ts_btnAdd.Click += ts_btnAdd_Click;
            // 
            // ts_btnDelete
            // 
            ts_btnDelete.AutoSize = false;
            ts_btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ts_btnDelete.Image = (Image)resources.GetObject("ts_btnDelete.Image");
            ts_btnDelete.ImageTransparentColor = Color.Magenta;
            ts_btnDelete.Margin = new Padding(0);
            ts_btnDelete.Name = "ts_btnDelete";
            ts_btnDelete.Size = new Size(40, 40);
            ts_btnDelete.Click += toolStripMenuItemDelete_Click;
            // 
            // ts_cbSort
            // 
            ts_cbSort.Font = new Font("Orange Kid", 15F);
            ts_cbSort.Margin = new Padding(20, 0, 0, 0);
            ts_cbSort.Name = "ts_cbSort";
            ts_cbSort.Size = new Size(200, 62);
            ts_cbSort.Click += ts_cbSort_SelectedIndexChanged;
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Font = new Font("Orange Kid", 25F);
            title.ForeColor = Color.White;
            title.Location = new Point(25, 13);
            title.Name = "title";
            title.Size = new Size(430, 50);
            title.TabIndex = 16;
            title.Text = "CHANGE CLIENT INFORMATION";
            // 
            // dgBookingChange
            // 
            dgBookingChange.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgBookingChange.BackgroundColor = Color.FromArgb(255, 192, 192);
            dgBookingChange.BorderStyle = BorderStyle.None;
            dgBookingChange.ColumnHeadersHeight = 29;
            dgBookingChange.ContextMenuStrip = contextMenuStrip;
            dgBookingChange.Cursor = Cursors.Hand;
            dgBookingChange.EnableHeadersVisualStyles = false;
            dgBookingChange.GridColor = Color.FromArgb(3, 37, 140);
            dgBookingChange.Location = new Point(49, 224);
            dgBookingChange.Name = "dgBookingChange";
            dgBookingChange.RightToLeft = RightToLeft.No;
            dgBookingChange.RowHeadersWidth = 51;
            dgBookingChange.ScrollBars = ScrollBars.Vertical;
            dgBookingChange.Size = new Size(1094, 514);
            dgBookingChange.TabIndex = 15;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.ImageScalingSize = new Size(20, 20);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItemAdd, toolStripMenuItemDelete, toolStripMenuItemSave });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.ShowCheckMargin = true;
            contextMenuStrip.ShowImageMargin = false;
            contextMenuStrip.Size = new Size(211, 104);
            // 
            // toolStripMenuItemAdd
            // 
            toolStripMenuItemAdd.Name = "toolStripMenuItemAdd";
            toolStripMenuItemAdd.ShortcutKeys = Keys.Control | Keys.A;
            toolStripMenuItemAdd.Size = new Size(210, 24);
            toolStripMenuItemAdd.Text = "Add";
            toolStripMenuItemAdd.Click += toolStripMenuItemAdd_Click;
            // 
            // toolStripMenuItemDelete
            // 
            toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            toolStripMenuItemDelete.ShortcutKeys = Keys.Control | Keys.X;
            toolStripMenuItemDelete.Size = new Size(210, 24);
            toolStripMenuItemDelete.Text = "Delete";
            toolStripMenuItemDelete.Click += toolStripMenuItemDelete_Click;
            // 
            // toolStripMenuItemSave
            // 
            toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            toolStripMenuItemSave.ShortcutKeys = Keys.Control | Keys.S;
            toolStripMenuItemSave.Size = new Size(210, 24);
            toolStripMenuItemSave.Text = "Save to file";
            toolStripMenuItemSave.Click += toolStripMenuItemSave_Click;
            // 
            // buttonClose
            // 
            buttonClose.BackgroundImage = (Image)resources.GetObject("buttonClose.BackgroundImage");
            buttonClose.BackgroundImageLayout = ImageLayout.Stretch;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Location = new Point(1114, 19);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(40, 40);
            buttonClose.TabIndex = 14;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // menuStrip
            // 
            menuStrip.AutoSize = false;
            menuStrip.BackColor = Color.FromArgb(255, 192, 192);
            menuStrip.Dock = DockStyle.None;
            menuStrip.Font = new Font("Orange Kid", 15F);
            menuStrip.GripMargin = new Padding(0);
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fILEToolStripMenuItem, eDITToolStripMenuItem, wINDOWToolStripMenuItem });
            menuStrip.Location = new Point(23, 85);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1142, 40);
            menuStrip.TabIndex = 19;
            menuStrip.Text = "menuStrip";
            // 
            // fILEToolStripMenuItem
            // 
            fILEToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, saveAsMenuStripMenuItem, openMenuStripItem, openAsMenuStripItem });
            fILEToolStripMenuItem.Font = new Font("Orange Kid", 15F, FontStyle.Bold);
            fILEToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);
            fILEToolStripMenuItem.Margin = new Padding(20, 0, 3, 0);
            fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            fILEToolStripMenuItem.Size = new Size(62, 36);
            fILEToolStripMenuItem.Text = "FILE";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(172, 34);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsMenuStripMenuItem
            // 
            saveAsMenuStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copyMenuStripItem, newFileMenuStripItem });
            saveAsMenuStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);
            saveAsMenuStripMenuItem.Name = "saveAsMenuStripMenuItem";
            saveAsMenuStripMenuItem.Size = new Size(172, 34);
            saveAsMenuStripMenuItem.Text = "Save as";
            // 
            // copyMenuStripItem
            // 
            copyMenuStripItem.ForeColor = Color.FromArgb(3, 37, 140);
            copyMenuStripItem.Name = "copyMenuStripItem";
            copyMenuStripItem.Size = new Size(170, 34);
            copyMenuStripItem.Text = "Copy";
            copyMenuStripItem.Click += copyMenuStripItem_Click;
            // 
            // newFileMenuStripItem
            // 
            newFileMenuStripItem.ForeColor = Color.FromArgb(3, 37, 140);
            newFileMenuStripItem.Name = "newFileMenuStripItem";
            newFileMenuStripItem.Size = new Size(170, 34);
            newFileMenuStripItem.Text = "New file";
            newFileMenuStripItem.Click += saveAsMenuStripItem_Click;
            // 
            // openMenuStripItem
            // 
            openMenuStripItem.DropDownItems.AddRange(new ToolStripItem[] { clientToolStripMenuItem, employeeToolStripMenuItem, roomToolStripMenuItem });
            openMenuStripItem.ForeColor = Color.FromArgb(3, 37, 140);
            openMenuStripItem.Name = "openMenuStripItem";
            openMenuStripItem.Size = new Size(172, 34);
            openMenuStripItem.Text = "Open ";
            // 
            // clientToolStripMenuItem
            // 
            clientToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);
            clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            clientToolStripMenuItem.Size = new Size(181, 34);
            clientToolStripMenuItem.Text = "Client";
            clientToolStripMenuItem.Click += clientToolStripMenuItem_Click;
            // 
            // employeeToolStripMenuItem
            // 
            employeeToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);
            employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            employeeToolStripMenuItem.Size = new Size(181, 34);
            employeeToolStripMenuItem.Text = "Employee";
            employeeToolStripMenuItem.Click += employeeToolStripMenuItem_Click;
            // 
            // roomToolStripMenuItem
            // 
            roomToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);
            roomToolStripMenuItem.Name = "roomToolStripMenuItem";
            roomToolStripMenuItem.Size = new Size(181, 34);
            roomToolStripMenuItem.Text = "Room";
            roomToolStripMenuItem.Click += roomToolStripMenuItem_Click;
            // 
            // openAsMenuStripItem
            // 
            openAsMenuStripItem.DropDownItems.AddRange(new ToolStripItem[] { copyToolStripMenuItem, newFileToolStripMenuItem });
            openAsMenuStripItem.ForeColor = Color.FromArgb(3, 37, 140);
            openAsMenuStripItem.Name = "openAsMenuStripItem";
            openAsMenuStripItem.Size = new Size(172, 34);
            openAsMenuStripItem.Text = "Open as";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(170, 34);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyOpenMenuStripMenuItem_Click;
            // 
            // newFileToolStripMenuItem
            // 
            newFileToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);
            newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            newFileToolStripMenuItem.Size = new Size(170, 34);
            newFileToolStripMenuItem.Text = "New file";
            newFileToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // eDITToolStripMenuItem
            // 
            eDITToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sortToolStripMenuItem, addClientToolStripMenuItem, deleteClientToolStripMenuItem, deleteCheckOutToolStripMenuItem, aDDEMPLOYEEToolStripMenuItem, dELETEEMPLOYEEToolStripMenuItem, aDDROOMToolStripMenuItem, dELETEROOMToolStripMenuItem });
            eDITToolStripMenuItem.Font = new Font("Orange Kid", 15F, FontStyle.Bold);
            eDITToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);
            eDITToolStripMenuItem.Margin = new Padding(3, 0, 3, 0);
            eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            eDITToolStripMenuItem.Size = new Size(65, 36);
            eDITToolStripMenuItem.Text = "EDIT";
            // 
            // sortToolStripMenuItem
            // 
            sortToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nameToolStripMenuItem, surnameToolStripMenuItem, roomNumberToolStripMenuItem, dataCheckInToolStripMenuItem, nameEmployeeToolStripMenuItem1, idToolStripMenuItem, numberToolStripMenuItem, priceToolStripMenuItem, statusToolStripMenuItem });
            sortToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);
            sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            sortToolStripMenuItem.Size = new Size(243, 34);
            sortToolStripMenuItem.Text = "Sort by";
            // 
            // nameToolStripMenuItem
            // 
            nameToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);
            nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            nameToolStripMenuItem.Size = new Size(219, 34);
            nameToolStripMenuItem.Text = "Name";
            nameToolStripMenuItem.Click += nameToolStripMenuItem_Click;
            // 
            // surnameToolStripMenuItem
            // 
            surnameToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);
            surnameToolStripMenuItem.Name = "surnameToolStripMenuItem";
            surnameToolStripMenuItem.Size = new Size(219, 34);
            surnameToolStripMenuItem.Text = "Surname";
            surnameToolStripMenuItem.Click += surnameToolStripMenuItem_Click;
            // 
            // roomNumberToolStripMenuItem
            // 
            roomNumberToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);
            roomNumberToolStripMenuItem.Name = "roomNumberToolStripMenuItem";
            roomNumberToolStripMenuItem.Size = new Size(219, 34);
            roomNumberToolStripMenuItem.Text = "Room number";
            roomNumberToolStripMenuItem.Click += roomNumberToolStripMenuItem_Click;
            // 
            // dataCheckInToolStripMenuItem
            // 
            dataCheckInToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);
            dataCheckInToolStripMenuItem.Name = "dataCheckInToolStripMenuItem";
            dataCheckInToolStripMenuItem.Size = new Size(219, 34);
            dataCheckInToolStripMenuItem.Text = "Data check in";
            dataCheckInToolStripMenuItem.Click += dataCheckInToolStripMenuItem_Click;
            // 
            // nameEmployeeToolStripMenuItem1
            // 
            nameEmployeeToolStripMenuItem1.ForeColor = Color.FromArgb(3, 37, 140);
            nameEmployeeToolStripMenuItem1.Name = "nameEmployeeToolStripMenuItem1";
            nameEmployeeToolStripMenuItem1.Size = new Size(219, 34);
            nameEmployeeToolStripMenuItem1.Text = "Name";
            nameEmployeeToolStripMenuItem1.Click += nameEmployeeToolStripMenuItem1_Click;
            // 
            // idToolStripMenuItem
            // 
            idToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);
            idToolStripMenuItem.Name = "idToolStripMenuItem";
            idToolStripMenuItem.Size = new Size(219, 34);
            idToolStripMenuItem.Text = "Id";
            idToolStripMenuItem.Click += idToolStripMenuItem_Click;
            // 
            // numberToolStripMenuItem
            // 
            numberToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);
            numberToolStripMenuItem.Name = "numberToolStripMenuItem";
            numberToolStripMenuItem.Size = new Size(219, 34);
            numberToolStripMenuItem.Text = "Number";
            numberToolStripMenuItem.Click += numberToolStripMenuItem_Click;
            // 
            // priceToolStripMenuItem
            // 
            priceToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);
            priceToolStripMenuItem.Name = "priceToolStripMenuItem";
            priceToolStripMenuItem.Size = new Size(219, 34);
            priceToolStripMenuItem.Text = "Price";
            priceToolStripMenuItem.Click += priceToolStripMenuItem_Click;
            // 
            // statusToolStripMenuItem
            // 
            statusToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);
            statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            statusToolStripMenuItem.Size = new Size(219, 34);
            statusToolStripMenuItem.Text = "Status";
            statusToolStripMenuItem.Click += statusToolStripMenuItem_Click;
            // 
            // addClientToolStripMenuItem
            // 
            addClientToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);
            addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            addClientToolStripMenuItem.Size = new Size(243, 34);
            addClientToolStripMenuItem.Text = "Add client";
            addClientToolStripMenuItem.Click += addClientToolStripMenuItem_Click;
            // 
            // deleteClientToolStripMenuItem
            // 
            deleteClientToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);
            deleteClientToolStripMenuItem.Name = "deleteClientToolStripMenuItem";
            deleteClientToolStripMenuItem.Size = new Size(243, 34);
            deleteClientToolStripMenuItem.Text = "Delete client";
            deleteClientToolStripMenuItem.Click += deleteClientToolStripMenuItem_Click;
            // 
            // deleteCheckOutToolStripMenuItem
            // 
            deleteCheckOutToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);
            deleteCheckOutToolStripMenuItem.Name = "deleteCheckOutToolStripMenuItem";
            deleteCheckOutToolStripMenuItem.Size = new Size(243, 34);
            deleteCheckOutToolStripMenuItem.Text = "Delete check out";
            // 
            // aDDEMPLOYEEToolStripMenuItem
            // 
            aDDEMPLOYEEToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);
            aDDEMPLOYEEToolStripMenuItem.Name = "aDDEMPLOYEEToolStripMenuItem";
            aDDEMPLOYEEToolStripMenuItem.Size = new Size(243, 34);
            aDDEMPLOYEEToolStripMenuItem.Text = "Add employee";
            aDDEMPLOYEEToolStripMenuItem.Click += aDDEMPLOYEEToolStripMenuItem_Click;
            // 
            // dELETEEMPLOYEEToolStripMenuItem
            // 
            dELETEEMPLOYEEToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);
            dELETEEMPLOYEEToolStripMenuItem.Name = "dELETEEMPLOYEEToolStripMenuItem";
            dELETEEMPLOYEEToolStripMenuItem.Size = new Size(243, 34);
            dELETEEMPLOYEEToolStripMenuItem.Text = "Delete employee";
            // 
            // aDDROOMToolStripMenuItem
            // 
            aDDROOMToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);
            aDDROOMToolStripMenuItem.Name = "aDDROOMToolStripMenuItem";
            aDDROOMToolStripMenuItem.Size = new Size(243, 34);
            aDDROOMToolStripMenuItem.Text = "Add room";
            aDDROOMToolStripMenuItem.Click += aDDROOMToolStripMenuItem_Click;
            // 
            // dELETEROOMToolStripMenuItem
            // 
            dELETEROOMToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);
            dELETEROOMToolStripMenuItem.Name = "dELETEROOMToolStripMenuItem";
            dELETEROOMToolStripMenuItem.Size = new Size(243, 34);
            dELETEROOMToolStripMenuItem.Text = "Delete room";
            // 
            // wINDOWToolStripMenuItem
            // 
            wINDOWToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hideToolStripToolStripMenuItem, showToolStripToolStripMenuItem });
            wINDOWToolStripMenuItem.Font = new Font("Orange Kid", 15F, FontStyle.Bold);
            wINDOWToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);
            wINDOWToolStripMenuItem.Margin = new Padding(3, 0, 3, 0);
            wINDOWToolStripMenuItem.Name = "wINDOWToolStripMenuItem";
            wINDOWToolStripMenuItem.Size = new Size(100, 36);
            wINDOWToolStripMenuItem.Text = "WINDOW";
            // 
            // hideToolStripToolStripMenuItem
            // 
            hideToolStripToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);
            hideToolStripToolStripMenuItem.Name = "hideToolStripToolStripMenuItem";
            hideToolStripToolStripMenuItem.Size = new Size(231, 34);
            hideToolStripToolStripMenuItem.Text = "Hide tool strip";
            hideToolStripToolStripMenuItem.Click += hideToolStripToolStripMenuItem_Click;
            // 
            // showToolStripToolStripMenuItem
            // 
            showToolStripToolStripMenuItem.ForeColor = Color.FromArgb(192, 192, 255);
            showToolStripToolStripMenuItem.Name = "showToolStripToolStripMenuItem";
            showToolStripToolStripMenuItem.Size = new Size(231, 34);
            showToolStripToolStripMenuItem.Text = "Show tool strip";
            showToolStripToolStripMenuItem.Click += showToolStripToolStripMenuItem_Click;
            // 
            // tsFile
            // 
            tsFile.DropDownItems.AddRange(new ToolStripItem[] { tsFileSave, tsFileSaveToFile, tsFileExportFromFile });
            tsFile.Font = new Font("Orange Kid", 15F);
            tsFile.ForeColor = Color.FromArgb(3, 37, 140);
            tsFile.ImageTransparentColor = Color.FromArgb(3, 37, 140);
            tsFile.Name = "tsFile";
            tsFile.Size = new Size(58, 36);
            tsFile.Text = "FILE";
            // 
            // tsFileSave
            // 
            tsFileSave.Name = "tsFileSave";
            tsFileSave.Size = new Size(224, 34);
            tsFileSave.Text = "Save";
            // 
            // tsFileSaveToFile
            // 
            tsFileSaveToFile.Name = "tsFileSaveToFile";
            tsFileSaveToFile.Size = new Size(224, 34);
            tsFileSaveToFile.Text = "Save as";
            // 
            // tsFileExportFromFile
            // 
            tsFileExportFromFile.Name = "tsFileExportFromFile";
            tsFileExportFromFile.Size = new Size(224, 34);
            tsFileExportFromFile.Text = "Export from file";
            // 
            // tsEdit
            // 
            tsEdit.DropDownItems.AddRange(new ToolStripItem[] { tsEditAddClient, tsEditDeleteClient, tsEditExportClient, tsEditDeleteCheckOut });
            tsEdit.Font = new Font("Orange Kid", 15F);
            tsEdit.ForeColor = Color.FromArgb(3, 37, 140);
            tsEdit.Name = "tsEdit";
            tsEdit.Size = new Size(61, 36);
            tsEdit.Text = "EDIT";
            // 
            // tsEditAddClient
            // 
            tsEditAddClient.Name = "tsEditAddClient";
            tsEditAddClient.Size = new Size(234, 34);
            tsEditAddClient.Text = "Add client";
            // 
            // tsEditDeleteClient
            // 
            tsEditDeleteClient.Name = "tsEditDeleteClient";
            tsEditDeleteClient.Size = new Size(234, 34);
            tsEditDeleteClient.Text = "Delete client";
            // 
            // tsEditExportClient
            // 
            tsEditExportClient.Name = "tsEditExportClient";
            tsEditExportClient.Size = new Size(234, 34);
            tsEditExportClient.Text = "Export client";
            // 
            // tsEditDeleteCheckOut
            // 
            tsEditDeleteCheckOut.Name = "tsEditDeleteCheckOut";
            tsEditDeleteCheckOut.Size = new Size(234, 34);
            tsEditDeleteCheckOut.Text = "Delete check out";
            // 
            // tsWindow
            // 
            tsWindow.Font = new Font("Orange Kid", 15F);
            tsWindow.ForeColor = Color.FromArgb(3, 37, 140);
            tsWindow.Name = "tsWindow";
            tsWindow.Size = new Size(94, 36);
            tsWindow.Text = "WINDOW";
            // 
            // viewHelpToolStripMenuItem
            // 
            viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            viewHelpToolStripMenuItem.Size = new Size(242, 34);
            viewHelpToolStripMenuItem.Text = "View help";
            // 
            // aboutCurseWorkToolStripMenuItem
            // 
            aboutCurseWorkToolStripMenuItem.Name = "aboutCurseWorkToolStripMenuItem";
            aboutCurseWorkToolStripMenuItem.Size = new Size(242, 34);
            aboutCurseWorkToolStripMenuItem.Text = "About Curse work";
            // 
            // tsWindowShowToolStrip
            // 
            tsWindowShowToolStrip.Name = "tsWindowShowToolStrip";
            tsWindowShowToolStrip.Size = new Size(219, 34);
            tsWindowShowToolStrip.Text = "Show tool strip";
            tsWindowShowToolStrip.Visible = false;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // fChangeInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1182, 782);
            ControlBox = false;
            Controls.Add(toolStrip);
            Controls.Add(menuStrip);
            Controls.Add(title);
            Controls.Add(dgBookingChange);
            Controls.Add(buttonClose);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip;
            MaximumSize = new Size(1200, 800);
            MinimumSize = new Size(1200, 800);
            Name = "fChangeInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Load += fChangeClient_Load;
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgBookingChange).EndInit();
            contextMenuStrip.ResumeLayout(false);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip;
        private ToolStripButton ts_btnAdd;
        private ToolStripButton ts_btnDelete;
        private ToolStripComboBox ts_cbSort;
        private Label title;
        private DataGridView dgBookingChange;
        private Button buttonClose;
        private MenuStrip menuStrip;
        private ToolStripMenuItem tsFile;
        private ToolStripMenuItem tsFileSave;
        private ToolStripMenuItem tsFileExportFromFile;
        private ToolStripMenuItem tsEdit;
        private ToolStripMenuItem tsEditAddClient;
        private ToolStripMenuItem tsEditDeleteClient;
        private ToolStripMenuItem tsEditExportClient;
        private ToolStripMenuItem tsEditDeleteCheckOut;
        private ToolStripMenuItem tsWindow;
        private ToolStripMenuItem hELPToolStripMenuItem;
        private ToolStripMenuItem newTableToolStripMenuItem;
        private ToolStripMenuItem hideToolStripToolStripMenuItem;
        private ToolStripMenuItem viewHelpToolStripMenuItem;
        private ToolStripMenuItem aboutCurseWorkToolStripMenuItem;
        private ToolStripMenuItem tsFileSaveToFile;
        private ToolStripMenuItem tsWindowShowToolStrip;
        private ToolStripMenuItem fILEToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsMenuStripMenuItem;
        private ToolStripMenuItem eDITToolStripMenuItem;
        private ToolStripMenuItem addClientToolStripMenuItem;
        private ToolStripMenuItem deleteClientToolStripMenuItem;
        private ToolStripMenuItem deleteCheckOutToolStripMenuItem;
        private ToolStripMenuItem wINDOWToolStripMenuItem;
        private ToolStripMenuItem showToolStripToolStripMenuItem;
        private ToolStripMenuItem openMenuStripItem;
        private ToolStripMenuItem clientToolStripMenuItem;
        private ToolStripMenuItem employeeToolStripMenuItem;
        private ToolStripMenuItem roomToolStripMenuItem;
        private ToolStripMenuItem aDDEMPLOYEEToolStripMenuItem;
        private ToolStripMenuItem dELETEEMPLOYEEToolStripMenuItem;
        private ToolStripMenuItem aDDROOMToolStripMenuItem;
        private ToolStripMenuItem dELETEROOMToolStripMenuItem;
        private ToolStripMenuItem sortToolStripMenuItem;
        private ToolStripMenuItem nameToolStripMenuItem;
        private ToolStripMenuItem surnameToolStripMenuItem;
        private ToolStripMenuItem roomNumberToolStripMenuItem;
        private ToolStripMenuItem dataCheckInToolStripMenuItem;
        private ToolStripMenuItem nameEmployeeToolStripMenuItem1;
        private ToolStripMenuItem idToolStripMenuItem;
        private ToolStripMenuItem numberToolStripMenuItem;
        private ToolStripMenuItem priceToolStripMenuItem;
        private ToolStripMenuItem statusToolStripMenuItem;
        private ToolStripButton ts_btnSaveInfo;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private ToolStripMenuItem openAsMenuStripItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem newFileToolStripMenuItem;
        private ToolStripMenuItem copyMenuStripItem;
        private ToolStripMenuItem newFileMenuStripItem;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem toolStripMenuItemAdd;
        private ToolStripMenuItem toolStripMenuItemDelete;
        private ToolStripMenuItem toolStripMenuItemSave;
    }
}