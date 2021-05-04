
namespace Hotel_Management
{
    partial class Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room));
            this.dtRooms = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnUpdateRoom = new System.Windows.Forms.Button();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.tbRoomNo = new System.Windows.Forms.TextBox();
            this.tbFloorNo = new System.Windows.Forms.TextBox();
            this.tbRoomType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // dtRooms
            // 
            this.dtRooms.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtRooms.Location = new System.Drawing.Point(13, 275);
            this.dtRooms.Name = "dtRooms";
            this.dtRooms.RowHeadersWidth = 51;
            this.dtRooms.RowTemplate.Height = 24;
            this.dtRooms.Size = new System.Drawing.Size(653, 274);
            this.dtRooms.TabIndex = 0;
            this.dtRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtRooms_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 37);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnLogout.Location = new System.Drawing.Point(540, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(126, 37);
            this.btnLogout.TabIndex = 23;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(16, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Room No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(16, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Room Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(16, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Floor No";
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAddRoom.Location = new System.Drawing.Point(256, 232);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(132, 37);
            this.btnAddRoom.TabIndex = 27;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.BtnAddRoom_Click);
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdateRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRoom.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnUpdateRoom.Location = new System.Drawing.Point(394, 232);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(140, 37);
            this.btnUpdateRoom.TabIndex = 28;
            this.btnUpdateRoom.Text = "Update Room";
            this.btnUpdateRoom.UseVisualStyleBackColor = false;
            this.btnUpdateRoom.Click += new System.EventHandler(this.BtnUpdateRoom_Click);
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDeleteRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRoom.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDeleteRoom.Location = new System.Drawing.Point(540, 232);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(126, 37);
            this.btnDeleteRoom.TabIndex = 29;
            this.btnDeleteRoom.Text = "Delete Room";
            this.btnDeleteRoom.UseVisualStyleBackColor = false;
            this.btnDeleteRoom.Click += new System.EventHandler(this.BtnDeleteRoom_Click);
            // 
            // tbRoomNo
            // 
            this.tbRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRoomNo.Location = new System.Drawing.Point(198, 75);
            this.tbRoomNo.Name = "tbRoomNo";
            this.tbRoomNo.Size = new System.Drawing.Size(190, 30);
            this.tbRoomNo.TabIndex = 30;
            // 
            // tbFloorNo
            // 
            this.tbFloorNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFloorNo.Location = new System.Drawing.Point(198, 196);
            this.tbFloorNo.Name = "tbFloorNo";
            this.tbFloorNo.Size = new System.Drawing.Size(190, 30);
            this.tbFloorNo.TabIndex = 32;
            // 
            // tbRoomType
            // 
            this.tbRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRoomType.Location = new System.Drawing.Point(198, 156);
            this.tbRoomType.Name = "tbRoomType";
            this.tbRoomType.Size = new System.Drawing.Size(190, 30);
            this.tbRoomType.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(16, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Customer Name";
            // 
            // tbCName
            // 
            this.tbCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCName.Location = new System.Drawing.Point(198, 117);
            this.tbCName.Name = "tbCName";
            this.tbCName.Size = new System.Drawing.Size(190, 30);
            this.tbCName.TabIndex = 35;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSearch.Location = new System.Drawing.Point(394, 78);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 28);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Aqua;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(283, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 29);
            this.label5.TabIndex = 37;
            this.label5.Text = "Rooms";
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(678, 561);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbCName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbRoomType);
            this.Controls.Add(this.tbFloorNo);
            this.Controls.Add(this.tbRoomNo);
            this.Controls.Add(this.btnDeleteRoom);
            this.Controls.Add(this.btnUpdateRoom);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtRooms);
            this.Name = "Room";
            this.Text = "Room";
            this.Load += new System.EventHandler(this.LoadData);
            ((System.ComponentModel.ISupportInitialize)(this.dtRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtRooms;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnUpdateRoom;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.TextBox tbRoomNo;
        private System.Windows.Forms.TextBox tbFloorNo;
        private System.Windows.Forms.TextBox tbRoomType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
    }
}