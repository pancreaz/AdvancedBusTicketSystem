namespace AdvancedBusTicketSystem.UI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlTopHeader = new System.Windows.Forms.Panel();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabBooking = new System.Windows.Forms.TabPage();
            this.pnlRightBooking = new System.Windows.Forms.Panel();
            this.btnProceedCheckout = new System.Windows.Forms.Button();
            this.lblTotalFare = new System.Windows.Forms.Label();
            this.lblSelectedSeatNum = new System.Windows.Forms.Label();
            this.lblBookingSummaryHeader = new System.Windows.Forms.Label();
            this.grpLegend = new System.Windows.Forms.GroupBox();
            this.lblLegendBlocked = new System.Windows.Forms.Label();
            this.lblLegendSelected = new System.Windows.Forms.Label();
            this.lblLegendFemale = new System.Windows.Forms.Label();
            this.lblLegendMale = new System.Windows.Forms.Label();
            this.lblLegendAvail = new System.Windows.Forms.Label();
            this.pnlCenterSeatMap = new System.Windows.Forms.Panel();
            this.seatMapControl = new AdvancedBusTicketSystem.UI.Controls.BusSeatMapControl();
            this.pnlLeftSearch = new System.Windows.Forms.Panel();
            this.lblSelectedTripInfo = new System.Windows.Forms.Label();
            this.lstTrips = new System.Windows.Forms.ListBox();
            this.lblTripsListHeader = new System.Windows.Forms.Label();
            this.btnSearchTrips = new System.Windows.Forms.Button();
            this.dtpTripDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbDestination = new System.Windows.Forms.ComboBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.cmbOrigin = new System.Windows.Forms.ComboBox();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.tabTicketManager = new System.Windows.Forms.TabPage();
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.pnlTicketActions = new System.Windows.Forms.Panel();
            this.btnCancelTicket = new System.Windows.Forms.Button();
            this.btnViewVoucher = new System.Windows.Forms.Button();
            this.btnRefreshTickets = new System.Windows.Forms.Button();
            this.btnSearchPnr = new System.Windows.Forms.Button();
            this.txtSearchPnr = new System.Windows.Forms.TextBox();
            this.lblSearchPnr = new System.Windows.Forms.Label();
            this.tabAnalytics = new System.Windows.Forms.TabPage();
            this.pnlCardOccupancy = new System.Windows.Forms.Panel();
            this.lblOccupancyValue = new System.Windows.Forms.Label();
            this.lblOccupancyTitle = new System.Windows.Forms.Label();
            this.pnlCardTrips = new System.Windows.Forms.Panel();
            this.lblTripsValue = new System.Windows.Forms.Label();
            this.lblTripsTitle = new System.Windows.Forms.Label();
            this.pnlCardBookings = new System.Windows.Forms.Panel();
            this.lblBookingsValue = new System.Windows.Forms.Label();
            this.lblBookingsTitle = new System.Windows.Forms.Label();
            this.pnlCardRevenue = new System.Windows.Forms.Panel();
            this.lblRevenueValue = new System.Windows.Forms.Label();
            this.lblRevenueTitle = new System.Windows.Forms.Label();
            this.btnRefreshAnalytics = new System.Windows.Forms.Button();
            this.tabSchedule = new System.Windows.Forms.TabPage();
            this.dgvTripsSchedule = new System.Windows.Forms.DataGridView();
            this.lblScheduleHeader = new System.Windows.Forms.Label();
            this.pnlTopHeader.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabBooking.SuspendLayout();
            this.pnlRightBooking.SuspendLayout();
            this.grpLegend.SuspendLayout();
            this.pnlCenterSeatMap.SuspendLayout();
            this.pnlLeftSearch.SuspendLayout();
            this.tabTicketManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            this.pnlTicketActions.SuspendLayout();
            this.tabAnalytics.SuspendLayout();
            this.pnlCardOccupancy.SuspendLayout();
            this.pnlCardTrips.SuspendLayout();
            this.pnlCardBookings.SuspendLayout();
            this.pnlCardRevenue.SuspendLayout();
            this.tabSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTripsSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopHeader
            // 
            this.pnlTopHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlTopHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlTopHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlTopHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlTopHeader.Name = "pnlTopHeader";
            this.pnlTopHeader.Size = new System.Drawing.Size(1064, 65);
            this.pnlTopHeader.TabIndex = 0;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(18, 38);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(395, 15);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Enterprise Bus Reservation Engine, Interactive Seat Mapper & Analytics";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(16, 8);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(428, 30);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "ADVANCED BUS TICKET SYSTEM";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabBooking);
            this.tabControlMain.Controls.Add(this.tabTicketManager);
            this.tabControlMain.Controls.Add(this.tabAnalytics);
            this.tabControlMain.Controls.Add(this.tabSchedule);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tabControlMain.ItemSize = new System.Drawing.Size(200, 35);
            this.tabControlMain.Location = new System.Drawing.Point(0, 65);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1064, 616);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlMain.TabIndex = 1;
            // 
            // tabBooking
            // 
            this.tabBooking.Controls.Add(this.pnlCenterSeatMap);
            this.tabBooking.Controls.Add(this.pnlRightBooking);
            this.tabBooking.Controls.Add(this.pnlLeftSearch);
            this.tabBooking.Location = new System.Drawing.Point(4, 39);
            this.tabBooking.Name = "tabBooking";
            this.tabBooking.Padding = new System.Windows.Forms.Padding(3);
            this.tabBooking.Size = new System.Drawing.Size(1056, 573);
            this.tabBooking.TabIndex = 0;
            this.tabBooking.Text = "🚌 Ticket Booking Engine";
            this.tabBooking.UseVisualStyleBackColor = true;
            // 
            // pnlRightBooking
            // 
            this.pnlRightBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlRightBooking.Controls.Add(this.btnProceedCheckout);
            this.pnlRightBooking.Controls.Add(this.lblTotalFare);
            this.pnlRightBooking.Controls.Add(this.lblSelectedSeatNum);
            this.pnlRightBooking.Controls.Add(this.lblBookingSummaryHeader);
            this.pnlRightBooking.Controls.Add(this.grpLegend);
            this.pnlRightBooking.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRightBooking.Location = new System.Drawing.Point(793, 3);
            this.pnlRightBooking.Name = "pnlRightBooking";
            this.pnlRightBooking.Size = new System.Drawing.Size(260, 567);
            this.pnlRightBooking.TabIndex = 2;
            // 
            // btnProceedCheckout
            // 
            this.btnProceedCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnProceedCheckout.Enabled = false;
            this.btnProceedCheckout.FlatAppearance.BorderSize = 0;
            this.btnProceedCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceedCheckout.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnProceedCheckout.ForeColor = System.Drawing.Color.White;
            this.btnProceedCheckout.Location = new System.Drawing.Point(15, 330);
            this.btnProceedCheckout.Name = "btnProceedCheckout";
            this.btnProceedCheckout.Size = new System.Drawing.Size(230, 45);
            this.btnProceedCheckout.TabIndex = 4;
            this.btnProceedCheckout.Text = "Proceed to Checkout ➔";
            this.btnProceedCheckout.UseVisualStyleBackColor = false;
            this.btnProceedCheckout.Click += new System.EventHandler(this.btnProceedCheckout_Click);
            // 
            // lblTotalFare
            // 
            this.lblTotalFare.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalFare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblTotalFare.Location = new System.Drawing.Point(15, 280);
            this.lblTotalFare.Name = "lblTotalFare";
            this.lblTotalFare.Size = new System.Drawing.Size(230, 30);
            this.lblTotalFare.TabIndex = 3;
            this.lblTotalFare.Text = "Total Fare: $0.00";
            this.lblTotalFare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectedSeatNum
            // 
            this.lblSelectedSeatNum.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSelectedSeatNum.Location = new System.Drawing.Point(15, 240);
            this.lblSelectedSeatNum.Name = "lblSelectedSeatNum";
            this.lblSelectedSeatNum.Size = new System.Drawing.Size(230, 30);
            this.lblSelectedSeatNum.TabIndex = 2;
            this.lblSelectedSeatNum.Text = "Selected Seat: None";
            this.lblSelectedSeatNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBookingSummaryHeader
            // 
            this.lblBookingSummaryHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblBookingSummaryHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBookingSummaryHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblBookingSummaryHeader.ForeColor = System.Drawing.Color.White;
            this.lblBookingSummaryHeader.Location = new System.Drawing.Point(0, 0);
            this.lblBookingSummaryHeader.Name = "lblBookingSummaryHeader";
            this.lblBookingSummaryHeader.Size = new System.Drawing.Size(260, 35);
            this.lblBookingSummaryHeader.TabIndex = 1;
            this.lblBookingSummaryHeader.Text = "Reservation Summary";
            this.lblBookingSummaryHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpLegend
            // 
            this.grpLegend.Controls.Add(this.lblLegendBlocked);
            this.grpLegend.Controls.Add(this.lblLegendSelected);
            this.grpLegend.Controls.Add(this.lblLegendFemale);
            this.grpLegend.Controls.Add(this.lblLegendMale);
            this.grpLegend.Controls.Add(this.lblLegendAvail);
            this.grpLegend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpLegend.Location = new System.Drawing.Point(15, 50);
            this.grpLegend.Name = "grpLegend";
            this.grpLegend.Size = new System.Drawing.Size(230, 175);
            this.grpLegend.TabIndex = 0;
            this.grpLegend.TabStop = false;
            this.grpLegend.Text = "Seat Color Legend";
            // 
            // lblLegendBlocked
            // 
            this.lblLegendBlocked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblLegendBlocked.ForeColor = System.Drawing.Color.White;
            this.lblLegendBlocked.Location = new System.Drawing.Point(15, 138);
            this.lblLegendBlocked.Name = "lblLegendBlocked";
            this.lblLegendBlocked.Size = new System.Drawing.Size(200, 24);
            this.lblLegendBlocked.TabIndex = 4;
            this.lblLegendBlocked.Text = "■ Blocked / Unavailable";
            this.lblLegendBlocked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLegendSelected
            // 
            this.lblLegendSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.lblLegendSelected.ForeColor = System.Drawing.Color.White;
            this.lblLegendSelected.Location = new System.Drawing.Point(15, 110);
            this.lblLegendSelected.Name = "lblLegendSelected";
            this.lblLegendSelected.Size = new System.Drawing.Size(200, 24);
            this.lblLegendSelected.TabIndex = 3;
            this.lblLegendSelected.Text = "■ Selected Seat";
            this.lblLegendSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLegendFemale
            // 
            this.lblLegendFemale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(67)))), ((int)(((byte)(147)))));
            this.lblLegendFemale.ForeColor = System.Drawing.Color.White;
            this.lblLegendFemale.Location = new System.Drawing.Point(15, 82);
            this.lblLegendFemale.Name = "lblLegendFemale";
            this.lblLegendFemale.Size = new System.Drawing.Size(200, 24);
            this.lblLegendFemale.TabIndex = 2;
            this.lblLegendFemale.Text = "■ Reserved (Female)";
            this.lblLegendFemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLegendMale
            // 
            this.lblLegendMale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblLegendMale.ForeColor = System.Drawing.Color.White;
            this.lblLegendMale.Location = new System.Drawing.Point(15, 54);
            this.lblLegendMale.Name = "lblLegendMale";
            this.lblLegendMale.Size = new System.Drawing.Size(200, 24);
            this.lblLegendMale.TabIndex = 1;
            this.lblLegendMale.Text = "■ Reserved (Male)";
            this.lblLegendMale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLegendAvail
            // 
            this.lblLegendAvail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblLegendAvail.ForeColor = System.Drawing.Color.White;
            this.lblLegendAvail.Location = new System.Drawing.Point(15, 26);
            this.lblLegendAvail.Name = "lblLegendAvail";
            this.lblLegendAvail.Size = new System.Drawing.Size(200, 24);
            this.lblLegendAvail.TabIndex = 0;
            this.lblLegendAvail.Text = "■ Available Seat";
            this.lblLegendAvail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCenterSeatMap
            // 
            this.pnlCenterSeatMap.Controls.Add(this.seatMapControl);
            this.pnlCenterSeatMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenterSeatMap.Location = new System.Drawing.Point(320, 3);
            this.pnlCenterSeatMap.Name = "pnlCenterSeatMap";
            this.pnlCenterSeatMap.Size = new System.Drawing.Size(473, 567);
            this.pnlCenterSeatMap.TabIndex = 1;
            // 
            // seatMapControl
            // 
            this.seatMapControl.AutoScroll = true;
            this.seatMapControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.seatMapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seatMapControl.Location = new System.Drawing.Point(0, 0);
            this.seatMapControl.Name = "seatMapControl";
            this.seatMapControl.Padding = new System.Windows.Forms.Padding(15);
            this.seatMapControl.Size = new System.Drawing.Size(473, 567);
            this.seatMapControl.TabIndex = 0;
            // 
            // pnlLeftSearch
            // 
            this.pnlLeftSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlLeftSearch.Controls.Add(this.lblSelectedTripInfo);
            this.pnlLeftSearch.Controls.Add(this.lstTrips);
            this.pnlLeftSearch.Controls.Add(this.lblTripsListHeader);
            this.pnlLeftSearch.Controls.Add(this.btnSearchTrips);
            this.pnlLeftSearch.Controls.Add(this.dtpTripDate);
            this.pnlLeftSearch.Controls.Add(this.lblDate);
            this.pnlLeftSearch.Controls.Add(this.cmbDestination);
            this.pnlLeftSearch.Controls.Add(this.lblDestination);
            this.pnlLeftSearch.Controls.Add(this.cmbOrigin);
            this.pnlLeftSearch.Controls.Add(this.lblOrigin);
            this.pnlLeftSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftSearch.Location = new System.Drawing.Point(3, 3);
            this.pnlLeftSearch.Name = "pnlLeftSearch";
            this.pnlLeftSearch.Size = new System.Drawing.Size(317, 567);
            this.pnlLeftSearch.TabIndex = 0;
            // 
            // lblSelectedTripInfo
            // 
            this.lblSelectedTripInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblSelectedTripInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblSelectedTripInfo.Location = new System.Drawing.Point(15, 480);
            this.lblSelectedTripInfo.Name = "lblSelectedTripInfo";
            this.lblSelectedTripInfo.Size = new System.Drawing.Size(287, 65);
            this.lblSelectedTripInfo.TabIndex = 9;
            this.lblSelectedTripInfo.Text = "Select a trip from the list above to view bus layout and book seats.";
            this.lblSelectedTripInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstTrips
            // 
            this.lstTrips.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstTrips.FormattingEnabled = true;
            this.lstTrips.ItemHeight = 15;
            this.lstTrips.Location = new System.Drawing.Point(15, 235);
            this.lstTrips.Name = "lstTrips";
            this.lstTrips.Size = new System.Drawing.Size(287, 229);
            this.lstTrips.TabIndex = 8;
            this.lstTrips.SelectedIndexChanged += new System.EventHandler(this.lstTrips_SelectedIndexChanged);
            // 
            // lblTripsListHeader
            // 
            this.lblTripsListHeader.AutoSize = true;
            this.lblTripsListHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTripsListHeader.Location = new System.Drawing.Point(12, 212);
            this.lblTripsListHeader.Name = "lblTripsListHeader";
            this.lblTripsListHeader.Size = new System.Drawing.Size(130, 17);
            this.lblTripsListHeader.TabIndex = 7;
            this.lblTripsListHeader.Text = "Available Departures";
            // 
            // btnSearchTrips
            // 
            this.btnSearchTrips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSearchTrips.FlatAppearance.BorderSize = 0;
            this.btnSearchTrips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchTrips.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSearchTrips.ForeColor = System.Drawing.Color.White;
            this.btnSearchTrips.Location = new System.Drawing.Point(15, 165);
            this.btnSearchTrips.Name = "btnSearchTrips";
            this.btnSearchTrips.Size = new System.Drawing.Size(287, 34);
            this.btnSearchTrips.TabIndex = 6;
            this.btnSearchTrips.Text = "Search Trips";
            this.btnSearchTrips.UseVisualStyleBackColor = false;
            this.btnSearchTrips.Click += new System.EventHandler(this.btnSearchTrips_Click);
            // 
            // dtpTripDate
            // 
            this.dtpTripDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTripDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTripDate.Location = new System.Drawing.Point(15, 128);
            this.dtpTripDate.Name = "dtpTripDate";
            this.dtpTripDate.Size = new System.Drawing.Size(287, 23);
            this.dtpTripDate.TabIndex = 5;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDate.Location = new System.Drawing.Point(12, 110);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(74, 15);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Travel Date *";
            // 
            // cmbDestination
            // 
            this.cmbDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestination.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbDestination.FormattingEnabled = true;
            this.cmbDestination.Location = new System.Drawing.Point(15, 78);
            this.cmbDestination.Name = "cmbDestination";
            this.cmbDestination.Size = new System.Drawing.Size(287, 23);
            this.cmbDestination.TabIndex = 3;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDestination.Location = new System.Drawing.Point(12, 60);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(75, 15);
            this.lblDestination.TabIndex = 2;
            this.lblDestination.Text = "Destination *";
            // 
            // cmbOrigin
            // 
            this.cmbOrigin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbOrigin.FormattingEnabled = true;
            this.cmbOrigin.Location = new System.Drawing.Point(15, 28);
            this.cmbOrigin.Name = "cmbOrigin";
            this.cmbOrigin.Size = new System.Drawing.Size(287, 23);
            this.cmbOrigin.TabIndex = 1;
            // 
            // lblOrigin
            // 
            this.lblOrigin.AutoSize = true;
            this.lblOrigin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOrigin.Location = new System.Drawing.Point(12, 10);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(48, 15);
            this.lblOrigin.TabIndex = 0;
            this.lblOrigin.Text = "Origin *";
            // 
            // tabTicketManager
            // 
            this.tabTicketManager.Controls.Add(this.dgvTickets);
            this.tabTicketManager.Controls.Add(this.pnlTicketActions);
            this.tabTicketManager.Location = new System.Drawing.Point(4, 39);
            this.tabTicketManager.Name = "tabTicketManager";
            this.tabTicketManager.Padding = new System.Windows.Forms.Padding(3);
            this.tabTicketManager.Size = new System.Drawing.Size(1056, 573);
            this.tabTicketManager.TabIndex = 1;
            this.tabTicketManager.Text = "📋 Ticket Manager & PNR Lookup";
            this.tabTicketManager.UseVisualStyleBackColor = true;
            // 
            // dgvTickets
            // 
            this.dgvTickets.AllowUserToAddRows = false;
            this.dgvTickets.AllowUserToDeleteRows = false;
            this.dgvTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTickets.BackgroundColor = System.Drawing.Color.White;
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTickets.Location = new System.Drawing.Point(3, 58);
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.ReadOnly = true;
            this.dgvTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTickets.Size = new System.Drawing.Size(1050, 512);
            this.dgvTickets.TabIndex = 1;
            // 
            // pnlTicketActions
            // 
            this.pnlTicketActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.pnlTicketActions.Controls.Add(this.btnCancelTicket);
            this.pnlTicketActions.Controls.Add(this.btnViewVoucher);
            this.pnlTicketActions.Controls.Add(this.btnRefreshTickets);
            this.pnlTicketActions.Controls.Add(this.btnSearchPnr);
            this.pnlTicketActions.Controls.Add(this.txtSearchPnr);
            this.pnlTicketActions.Controls.Add(this.lblSearchPnr);
            this.pnlTicketActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTicketActions.Location = new System.Drawing.Point(3, 3);
            this.pnlTicketActions.Name = "pnlTicketActions";
            this.pnlTicketActions.Size = new System.Drawing.Size(1050, 55);
            this.pnlTicketActions.TabIndex = 0;
            // 
            // btnCancelTicket
            // 
            this.btnCancelTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCancelTicket.FlatAppearance.BorderSize = 0;
            this.btnCancelTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelTicket.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelTicket.ForeColor = System.Drawing.Color.White;
            this.btnCancelTicket.Location = new System.Drawing.Point(905, 12);
            this.btnCancelTicket.Name = "btnCancelTicket";
            this.btnCancelTicket.Size = new System.Drawing.Size(130, 32);
            this.btnCancelTicket.TabIndex = 5;
            this.btnCancelTicket.Text = "Cancel Ticket";
            this.btnCancelTicket.UseVisualStyleBackColor = false;
            this.btnCancelTicket.Click += new System.EventHandler(this.btnCancelTicket_Click);
            // 
            // btnViewVoucher
            // 
            this.btnViewVoucher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnViewVoucher.FlatAppearance.BorderSize = 0;
            this.btnViewVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewVoucher.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnViewVoucher.ForeColor = System.Drawing.Color.White;
            this.btnViewVoucher.Location = new System.Drawing.Point(765, 12);
            this.btnViewVoucher.Name = "btnViewVoucher";
            this.btnViewVoucher.Size = new System.Drawing.Size(130, 32);
            this.btnViewVoucher.TabIndex = 4;
            this.btnViewVoucher.Text = "View Voucher";
            this.btnViewVoucher.UseVisualStyleBackColor = false;
            this.btnViewVoucher.Click += new System.EventHandler(this.btnViewVoucher_Click);
            // 
            // btnRefreshTickets
            // 
            this.btnRefreshTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnRefreshTickets.FlatAppearance.BorderSize = 0;
            this.btnRefreshTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshTickets.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshTickets.ForeColor = System.Drawing.Color.White;
            this.btnRefreshTickets.Location = new System.Drawing.Point(440, 12);
            this.btnRefreshTickets.Name = "btnRefreshTickets";
            this.btnRefreshTickets.Size = new System.Drawing.Size(100, 32);
            this.btnRefreshTickets.TabIndex = 3;
            this.btnRefreshTickets.Text = "Refresh All";
            this.btnRefreshTickets.UseVisualStyleBackColor = false;
            this.btnRefreshTickets.Click += new System.EventHandler(this.btnRefreshTickets_Click);
            // 
            // btnSearchPnr
            // 
            this.btnSearchPnr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearchPnr.FlatAppearance.BorderSize = 0;
            this.btnSearchPnr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPnr.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearchPnr.ForeColor = System.Drawing.Color.White;
            this.btnSearchPnr.Location = new System.Drawing.Point(330, 12);
            this.btnSearchPnr.Name = "btnSearchPnr";
            this.btnSearchPnr.Size = new System.Drawing.Size(100, 32);
            this.btnSearchPnr.TabIndex = 2;
            this.btnSearchPnr.Text = "Search PNR";
            this.btnSearchPnr.UseVisualStyleBackColor = false;
            this.btnSearchPnr.Click += new System.EventHandler(this.btnSearchPnr_Click);
            // 
            // txtSearchPnr
            // 
            this.txtSearchPnr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchPnr.Location = new System.Drawing.Point(125, 17);
            this.txtSearchPnr.Name = "txtSearchPnr";
            this.txtSearchPnr.Size = new System.Drawing.Size(190, 23);
            this.txtSearchPnr.TabIndex = 1;
            // 
            // lblSearchPnr
            // 
            this.lblSearchPnr.AutoSize = true;
            this.lblSearchPnr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSearchPnr.Location = new System.Drawing.Point(15, 20);
            this.lblSearchPnr.Name = "lblSearchPnr";
            this.lblSearchPnr.Size = new System.Drawing.Size(104, 15);
            this.lblSearchPnr.TabIndex = 0;
            this.lblSearchPnr.Text = "Search PNR / Code:";
            // 
            // tabAnalytics
            // 
            this.tabAnalytics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.tabAnalytics.Controls.Add(this.btnRefreshAnalytics);
            this.tabAnalytics.Controls.Add(this.pnlCardOccupancy);
            this.tabAnalytics.Controls.Add(this.pnlCardTrips);
            this.tabAnalytics.Controls.Add(this.pnlCardBookings);
            this.tabAnalytics.Controls.Add(this.pnlCardRevenue);
            this.tabAnalytics.Location = new System.Drawing.Point(4, 39);
            this.tabAnalytics.Name = "tabAnalytics";
            this.tabAnalytics.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnalytics.Size = new System.Drawing.Size(1056, 573);
            this.tabAnalytics.TabIndex = 2;
            this.tabAnalytics.Text = "📊 Financial & Revenue Analytics";
            // 
            // btnRefreshAnalytics
            // 
            this.btnRefreshAnalytics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnRefreshAnalytics.FlatAppearance.BorderSize = 0;
            this.btnRefreshAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshAnalytics.ForeColor = System.Drawing.Color.White;
            this.btnRefreshAnalytics.Location = new System.Drawing.Point(40, 260);
            this.btnRefreshAnalytics.Name = "btnRefreshAnalytics";
            this.btnRefreshAnalytics.Size = new System.Drawing.Size(200, 40);
            this.btnRefreshAnalytics.TabIndex = 4;
            this.btnRefreshAnalytics.Text = "🔄 Refresh Metrics";
            this.btnRefreshAnalytics.UseVisualStyleBackColor = false;
            this.btnRefreshAnalytics.Click += new System.EventHandler(this.btnRefreshAnalytics_Click);
            // 
            // pnlCardOccupancy
            // 
            this.pnlCardOccupancy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.pnlCardOccupancy.Controls.Add(this.lblOccupancyValue);
            this.pnlCardOccupancy.Controls.Add(this.lblOccupancyTitle);
            this.pnlCardOccupancy.Location = new System.Drawing.Point(770, 40);
            this.pnlCardOccupancy.Name = "pnlCardOccupancy";
            this.pnlCardOccupancy.Size = new System.Drawing.Size(220, 160);
            this.pnlCardOccupancy.TabIndex = 3;
            // 
            // lblOccupancyValue
            // 
            this.lblOccupancyValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOccupancyValue.Font = new System.Drawing.Font("Segoe UI Bold", 24F);
            this.lblOccupancyValue.ForeColor = System.Drawing.Color.White;
            this.lblOccupancyValue.Location = new System.Drawing.Point(0, 40);
            this.lblOccupancyValue.Name = "lblOccupancyValue";
            this.lblOccupancyValue.Size = new System.Drawing.Size(220, 120);
            this.lblOccupancyValue.TabIndex = 1;
            this.lblOccupancyValue.Text = "0.0%";
            this.lblOccupancyValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOccupancyTitle
            // 
            this.lblOccupancyTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOccupancyTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblOccupancyTitle.ForeColor = System.Drawing.Color.White;
            this.lblOccupancyTitle.Location = new System.Drawing.Point(0, 0);
            this.lblOccupancyTitle.Name = "lblOccupancyTitle";
            this.lblOccupancyTitle.Size = new System.Drawing.Size(220, 40);
            this.lblOccupancyTitle.TabIndex = 0;
            this.lblOccupancyTitle.Text = "OCCUPANCY RATE";
            this.lblOccupancyTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCardTrips
            // 
            this.pnlCardTrips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.pnlCardTrips.Controls.Add(this.lblTripsValue);
            this.pnlCardTrips.Controls.Add(this.lblTripsTitle);
            this.pnlCardTrips.Location = new System.Drawing.Point(525, 40);
            this.pnlCardTrips.Name = "pnlCardTrips";
            this.pnlCardTrips.Size = new System.Drawing.Size(220, 160);
            this.pnlCardTrips.TabIndex = 2;
            // 
            // lblTripsValue
            // 
            this.lblTripsValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTripsValue.Font = new System.Drawing.Font("Segoe UI Bold", 24F);
            this.lblTripsValue.ForeColor = System.Drawing.Color.White;
            this.lblTripsValue.Location = new System.Drawing.Point(0, 40);
            this.lblTripsValue.Name = "lblTripsValue";
            this.lblTripsValue.Size = new System.Drawing.Size(220, 120);
            this.lblTripsValue.TabIndex = 1;
            this.lblTripsValue.Text = "0";
            this.lblTripsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTripsTitle
            // 
            this.lblTripsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTripsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTripsTitle.ForeColor = System.Drawing.Color.White;
            this.lblTripsTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTripsTitle.Name = "lblTripsTitle";
            this.lblTripsTitle.Size = new System.Drawing.Size(220, 40);
            this.lblTripsTitle.TabIndex = 0;
            this.lblTripsTitle.Text = "ACTIVE TRIPS";
            this.lblTripsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCardBookings
            // 
            this.pnlCardBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.pnlCardBookings.Controls.Add(this.lblBookingsValue);
            this.pnlCardBookings.Controls.Add(this.lblBookingsTitle);
            this.pnlCardBookings.Location = new System.Drawing.Point(280, 40);
            this.pnlCardBookings.Name = "pnlCardBookings";
            this.pnlCardBookings.Size = new System.Drawing.Size(220, 160);
            this.pnlCardBookings.TabIndex = 1;
            // 
            // lblBookingsValue
            // 
            this.lblBookingsValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBookingsValue.Font = new System.Drawing.Font("Segoe UI Bold", 24F);
            this.lblBookingsValue.ForeColor = System.Drawing.Color.White;
            this.lblBookingsValue.Location = new System.Drawing.Point(0, 40);
            this.lblBookingsValue.Name = "lblBookingsValue";
            this.lblBookingsValue.Size = new System.Drawing.Size(220, 120);
            this.lblBookingsValue.TabIndex = 1;
            this.lblBookingsValue.Text = "0";
            this.lblBookingsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBookingsTitle
            // 
            this.lblBookingsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBookingsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblBookingsTitle.ForeColor = System.Drawing.Color.White;
            this.lblBookingsTitle.Location = new System.Drawing.Point(0, 0);
            this.lblBookingsTitle.Name = "lblBookingsTitle";
            this.lblBookingsTitle.Size = new System.Drawing.Size(220, 40);
            this.lblBookingsTitle.TabIndex = 0;
            this.lblBookingsTitle.Text = "TICKETS ISSUED";
            this.lblBookingsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCardRevenue
            // 
            this.pnlCardRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlCardRevenue.Controls.Add(this.lblRevenueValue);
            this.pnlCardRevenue.Controls.Add(this.lblRevenueTitle);
            this.pnlCardRevenue.Location = new System.Drawing.Point(40, 40);
            this.pnlCardRevenue.Name = "pnlCardRevenue";
            this.pnlCardRevenue.Size = new System.Drawing.Size(220, 160);
            this.pnlCardRevenue.TabIndex = 0;
            // 
            // lblRevenueValue
            // 
            this.lblRevenueValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRevenueValue.Font = new System.Drawing.Font("Segoe UI Bold", 22F);
            this.lblRevenueValue.ForeColor = System.Drawing.Color.White;
            this.lblRevenueValue.Location = new System.Drawing.Point(0, 40);
            this.lblRevenueValue.Name = "lblRevenueValue";
            this.lblRevenueValue.Size = new System.Drawing.Size(220, 120);
            this.lblRevenueValue.TabIndex = 1;
            this.lblRevenueValue.Text = "$0.00";
            this.lblRevenueValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRevenueTitle
            // 
            this.lblRevenueTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRevenueTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblRevenueTitle.ForeColor = System.Drawing.Color.White;
            this.lblRevenueTitle.Location = new System.Drawing.Point(0, 0);
            this.lblRevenueTitle.Name = "lblRevenueTitle";
            this.lblRevenueTitle.Size = new System.Drawing.Size(220, 40);
            this.lblRevenueTitle.TabIndex = 0;
            this.lblRevenueTitle.Text = "TOTAL REVENUE";
            this.lblRevenueTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabSchedule
            // 
            this.tabSchedule.Controls.Add(this.dgvTripsSchedule);
            this.tabSchedule.Controls.Add(this.lblScheduleHeader);
            this.tabSchedule.Location = new System.Drawing.Point(4, 39);
            this.tabSchedule.Name = "tabSchedule";
            this.tabSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabSchedule.Size = new System.Drawing.Size(1056, 573);
            this.tabSchedule.TabIndex = 3;
            this.tabSchedule.Text = "🚍 Fleet & Scheduled Trips";
            this.tabSchedule.UseVisualStyleBackColor = true;
            // 
            // dgvTripsSchedule
            // 
            this.dgvTripsSchedule.AllowUserToAddRows = false;
            this.dgvTripsSchedule.AllowUserToDeleteRows = false;
            this.dgvTripsSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTripsSchedule.BackgroundColor = System.Drawing.Color.White;
            this.dgvTripsSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTripsSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTripsSchedule.Location = new System.Drawing.Point(3, 48);
            this.dgvTripsSchedule.Name = "dgvTripsSchedule";
            this.dgvTripsSchedule.ReadOnly = true;
            this.dgvTripsSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTripsSchedule.Size = new System.Drawing.Size(1050, 522);
            this.dgvTripsSchedule.TabIndex = 1;
            // 
            // lblScheduleHeader
            // 
            this.lblScheduleHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.lblScheduleHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblScheduleHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblScheduleHeader.Location = new System.Drawing.Point(3, 3);
            this.lblScheduleHeader.Name = "lblScheduleHeader";
            this.lblScheduleHeader.Size = new System.Drawing.Size(1050, 45);
            this.lblScheduleHeader.TabIndex = 0;
            this.lblScheduleHeader.Text = "Master Scheduled Departures & Bus Fleet Registry";
            this.lblScheduleHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.pnlTopHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced Bus Ticket & Trip Management System";
            this.pnlTopHeader.ResumeLayout(false);
            this.pnlTopHeader.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabBooking.ResumeLayout(false);
            this.pnlRightBooking.ResumeLayout(false);
            this.grpLegend.ResumeLayout(false);
            this.pnlCenterSeatMap.ResumeLayout(false);
            this.pnlLeftSearch.ResumeLayout(false);
            this.pnlLeftSearch.PerformLayout();
            this.tabTicketManager.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            this.pnlTicketActions.ResumeLayout(false);
            this.pnlTicketActions.PerformLayout();
            this.tabAnalytics.ResumeLayout(false);
            this.pnlCardOccupancy.ResumeLayout(false);
            this.pnlCardTrips.ResumeLayout(false);
            this.pnlCardBookings.ResumeLayout(false);
            this.pnlCardRevenue.ResumeLayout(false);
            this.tabSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTripsSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopHeader;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabBooking;
        private System.Windows.Forms.TabPage tabTicketManager;
        private System.Windows.Forms.TabPage tabAnalytics;
        private System.Windows.Forms.TabPage tabSchedule;
        private System.Windows.Forms.Panel pnlLeftSearch;
        private System.Windows.Forms.Label lblOrigin;
        private System.Windows.Forms.ComboBox cmbOrigin;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.ComboBox cmbDestination;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpTripDate;
        private System.Windows.Forms.Button btnSearchTrips;
        private System.Windows.Forms.Label lblTripsListHeader;
        private System.Windows.Forms.ListBox lstTrips;
        private System.Windows.Forms.Label lblSelectedTripInfo;
        private System.Windows.Forms.Panel pnlCenterSeatMap;
        private Controls.BusSeatMapControl seatMapControl;
        private System.Windows.Forms.Panel pnlRightBooking;
        private System.Windows.Forms.GroupBox grpLegend;
        private System.Windows.Forms.Label lblLegendAvail;
        private System.Windows.Forms.Label lblLegendMale;
        private System.Windows.Forms.Label lblLegendFemale;
        private System.Windows.Forms.Label lblLegendSelected;
        private System.Windows.Forms.Label lblLegendBlocked;
        private System.Windows.Forms.Label lblBookingSummaryHeader;
        private System.Windows.Forms.Label lblSelectedSeatNum;
        private System.Windows.Forms.Label lblTotalFare;
        private System.Windows.Forms.Button btnProceedCheckout;
        private System.Windows.Forms.Panel pnlTicketActions;
        private System.Windows.Forms.Label lblSearchPnr;
        private System.Windows.Forms.TextBox txtSearchPnr;
        private System.Windows.Forms.Button btnSearchPnr;
        private System.Windows.Forms.Button btnRefreshTickets;
        private System.Windows.Forms.Button btnViewVoucher;
        private System.Windows.Forms.Button btnCancelTicket;
        private System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.Panel pnlCardRevenue;
        private System.Windows.Forms.Label lblRevenueTitle;
        private System.Windows.Forms.Label lblRevenueValue;
        private System.Windows.Forms.Panel pnlCardBookings;
        private System.Windows.Forms.Label lblBookingsTitle;
        private System.Windows.Forms.Label lblBookingsValue;
        private System.Windows.Forms.Panel pnlCardTrips;
        private System.Windows.Forms.Label lblTripsTitle;
        private System.Windows.Forms.Label lblTripsValue;
        private System.Windows.Forms.Panel pnlCardOccupancy;
        private System.Windows.Forms.Label lblOccupancyTitle;
        private System.Windows.Forms.Label lblOccupancyValue;
        private System.Windows.Forms.Button btnRefreshAnalytics;
        private System.Windows.Forms.Label lblScheduleHeader;
        private System.Windows.Forms.DataGridView dgvTripsSchedule;
    }
}
