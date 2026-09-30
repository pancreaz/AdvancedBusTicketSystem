using AdvancedBusTicketSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AdvancedBusTicketSystem.UI.Controls
{
    public class BusSeatMapControl : UserControl
    {
        private BusType _busType = BusType.VIP_2x1;
        private int _capacity = 30;
        private Dictionary<int, SeatStatus> _seatStatusMap = new Dictionary<int, SeatStatus>();
        private int _selectedSeatNumber = -1;

        public event Action<int, SeatStatus> SeatClicked;

        public int SelectedSeatNumber => _selectedSeatNumber;

        public BusSeatMapControl()
        {
            this.DoubleBuffered = true;
            this.AutoScroll = true;
            this.BackColor = Color.FromArgb(245, 246, 250);
            this.Padding = new Padding(15);
        }

        public void LoadSeatMap(BusType busType, int capacity, Dictionary<int, SeatStatus> seatStatusMap)
        {
            _busType = busType;
            _capacity = capacity;
            _seatStatusMap = seatStatusMap ?? new Dictionary<int, SeatStatus>();
            _selectedSeatNumber = -1;

            RenderSeatLayout();
        }

        public void ClearSelection()
        {
            _selectedSeatNumber = -1;
            RenderSeatLayout();
        }

        private void RenderSeatLayout()
        {
            this.Controls.Clear();

            int seatWidth = 46;
            int seatHeight = 46;
            int margin = 12;
            int startX = 40;
            int startY = 50;

            // Draw Driver icon / label header
            Label lblDriver = new Label
            {
                Text = "DRIVER",
                Font = new Font("Segoe UI", 8.25F, FontStyle.Bold),
                ForeColor = Color.DimGray,
                BackColor = Color.LightGray,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(70, 26),
                Location = new Point(startX, 10)
            };
            this.Controls.Add(lblDriver);

            int currentSeatNum = 1;
            int colsPerRow = (_busType == BusType.VIP_2x1) ? 3 : 4;
            int rows = (int)Math.Ceiling((double)_capacity / colsPerRow);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colsPerRow; c++)
                {
                    if (currentSeatNum > _capacity) break;

                    int x = startX + c * (seatWidth + margin);
                    // Add extra gap for aisle between left & right seats
                    if (_busType == BusType.VIP_2x1 && c >= 1)
                    {
                        x += 30; // Aisle gap after single seat on left
                    }
                    else if (_busType == BusType.Standard_2x2 && c >= 2)
                    {
                        x += 30; // Aisle gap after double seats on left
                    }

                    int y = startY + r * (seatHeight + margin);

                    Button btnSeat = new Button
                    {
                        Text = currentSeatNum.ToString(),
                        Tag = currentSeatNum,
                        Size = new Size(seatWidth, seatHeight),
                        Location = new Point(x, y),
                        Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                        FlatStyle = FlatStyle.Flat,
                        Cursor = Cursors.Hand
                    };

                    btnSeat.FlatAppearance.BorderSize = 2;

                    SeatStatus status = _seatStatusMap.ContainsKey(currentSeatNum) 
                        ? _seatStatusMap[currentSeatNum] 
                        : SeatStatus.Available;

                    if (currentSeatNum == _selectedSeatNumber)
                    {
                        status = SeatStatus.Selected;
                    }

                    ApplySeatStyle(btnSeat, status);

                    int seatNo = currentSeatNum;
                    btnSeat.Click += (s, e) => HandleSeatClick(seatNo, status);

                    this.Controls.Add(btnSeat);
                    currentSeatNum++;
                }
            }
        }

        private void ApplySeatStyle(Button btn, SeatStatus status)
        {
            switch (status)
            {
                case SeatStatus.Available:
                    btn.BackColor = Color.FromArgb(46, 204, 113); // Green
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Color.FromArgb(39, 174, 96);
                    break;
                case SeatStatus.Selected:
                    btn.BackColor = Color.FromArgb(230, 126, 34); // Orange
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Color.FromArgb(211, 84, 0);
                    break;
                case SeatStatus.ReservedMale:
                    btn.BackColor = Color.FromArgb(52, 152, 219); // Blue
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
                    break;
                case SeatStatus.ReservedFemale:
                    btn.BackColor = Color.FromArgb(232, 67, 147); // Pink
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Color.FromArgb(194, 54, 122);
                    break;
                case SeatStatus.Blocked:
                default:
                    btn.BackColor = Color.FromArgb(149, 165, 166); // Gray
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Color.FromArgb(127, 140, 141);
                    btn.Enabled = false;
                    break;
            }
        }

        private void HandleSeatClick(int seatNumber, SeatStatus currentStatus)
        {
            if (currentStatus == SeatStatus.ReservedMale || currentStatus == SeatStatus.ReservedFemale || currentStatus == SeatStatus.Blocked)
            {
                MessageBox.Show($"Seat #{seatNumber} is already occupied!", "Seat Occupied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _selectedSeatNumber = (_selectedSeatNumber == seatNumber) ? -1 : seatNumber;
            RenderSeatLayout();

            SeatClicked?.Invoke(seatNumber, currentStatus);
        }
    }
}
