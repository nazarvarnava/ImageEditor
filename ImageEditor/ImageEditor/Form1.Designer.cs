namespace ImageEditor
{
    partial class bValue
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btNon = new System.Windows.Forms.Button();
            this.btKrakow = new System.Windows.Forms.Button();
            this.btWarszawa = new System.Windows.Forms.Button();
            this.btOpole = new System.Windows.Forms.Button();
            this.btKatowice = new System.Windows.Forms.Button();
            this.btWroclaw = new System.Windows.Forms.Button();
            this.btLublin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.redbar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.greenbar = new System.Windows.Forms.TrackBar();
            this.bluebar = new System.Windows.Forms.TrackBar();
            this.saveButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btTarnow = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btRotateLeft = new System.Windows.Forms.Button();
            this.btRotateRight = new System.Windows.Forms.Button();
            this.btRotateVertical = new System.Windows.Forms.Button();
            this.btRotateHorizontal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btMakeSelection = new System.Windows.Forms.Button();
            this.btCrop = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.blueValue = new System.Windows.Forms.Label();
            this.gValue = new System.Windows.Forms.Label();
            this.rValue = new System.Windows.Forms.Label();
            this.aValue = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoreColors = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1485, 721);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove_1);
            // 
            // btNon
            // 
            this.btNon.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btNon.FlatAppearance.BorderSize = 6;
            this.btNon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btNon.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btNon.Location = new System.Drawing.Point(1589, 65);
            this.btNon.Margin = new System.Windows.Forms.Padding(4);
            this.btNon.Name = "btNon";
            this.btNon.Size = new System.Drawing.Size(171, 58);
            this.btNon.TabIndex = 1;
            this.btNon.Text = "No Filter";
            this.btNon.UseVisualStyleBackColor = true;
            this.btNon.Click += new System.EventHandler(this.btNon_Click);
            // 
            // btKrakow
            // 
            this.btKrakow.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btKrakow.Location = new System.Drawing.Point(1589, 131);
            this.btKrakow.Margin = new System.Windows.Forms.Padding(4);
            this.btKrakow.Name = "btKrakow";
            this.btKrakow.Size = new System.Drawing.Size(171, 58);
            this.btKrakow.TabIndex = 2;
            this.btKrakow.Text = "Kraków";
            this.btKrakow.UseVisualStyleBackColor = true;
            this.btKrakow.Click += new System.EventHandler(this.btKrakow_Click);
            // 
            // btWarszawa
            // 
            this.btWarszawa.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btWarszawa.Location = new System.Drawing.Point(1589, 197);
            this.btWarszawa.Margin = new System.Windows.Forms.Padding(4);
            this.btWarszawa.Name = "btWarszawa";
            this.btWarszawa.Size = new System.Drawing.Size(171, 58);
            this.btWarszawa.TabIndex = 3;
            this.btWarszawa.Text = "Warszawa";
            this.btWarszawa.UseVisualStyleBackColor = true;
            this.btWarszawa.Click += new System.EventHandler(this.btWarszawa_Click);
            // 
            // btOpole
            // 
            this.btOpole.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btOpole.Location = new System.Drawing.Point(1589, 263);
            this.btOpole.Margin = new System.Windows.Forms.Padding(4);
            this.btOpole.Name = "btOpole";
            this.btOpole.Size = new System.Drawing.Size(171, 58);
            this.btOpole.TabIndex = 4;
            this.btOpole.Text = "Opole";
            this.btOpole.UseVisualStyleBackColor = true;
            this.btOpole.Click += new System.EventHandler(this.btOpole_Click);
            // 
            // btKatowice
            // 
            this.btKatowice.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btKatowice.Location = new System.Drawing.Point(1589, 329);
            this.btKatowice.Margin = new System.Windows.Forms.Padding(4);
            this.btKatowice.Name = "btKatowice";
            this.btKatowice.Size = new System.Drawing.Size(171, 58);
            this.btKatowice.TabIndex = 5;
            this.btKatowice.Text = "Katowice";
            this.btKatowice.UseVisualStyleBackColor = true;
            this.btKatowice.Click += new System.EventHandler(this.btKatowice_Click);
            // 
            // btWroclaw
            // 
            this.btWroclaw.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btWroclaw.Location = new System.Drawing.Point(1589, 395);
            this.btWroclaw.Margin = new System.Windows.Forms.Padding(4);
            this.btWroclaw.Name = "btWroclaw";
            this.btWroclaw.Size = new System.Drawing.Size(171, 58);
            this.btWroclaw.TabIndex = 6;
            this.btWroclaw.Text = "Wrocław";
            this.btWroclaw.UseVisualStyleBackColor = true;
            this.btWroclaw.Click += new System.EventHandler(this.btWroclaw_Click);
            // 
            // btLublin
            // 
            this.btLublin.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btLublin.Location = new System.Drawing.Point(1589, 461);
            this.btLublin.Margin = new System.Windows.Forms.Padding(4);
            this.btLublin.Name = "btLublin";
            this.btLublin.Size = new System.Drawing.Size(171, 58);
            this.btLublin.TabIndex = 7;
            this.btLublin.Text = "Lublin";
            this.btLublin.UseVisualStyleBackColor = true;
            this.btLublin.Click += new System.EventHandler(this.btLublin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 795);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Red";
            // 
            // redbar
            // 
            this.redbar.Location = new System.Drawing.Point(111, 795);
            this.redbar.Margin = new System.Windows.Forms.Padding(4);
            this.redbar.Name = "redbar";
            this.redbar.Size = new System.Drawing.Size(169, 56);
            this.redbar.TabIndex = 9;
            this.redbar.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 835);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 875);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Blue";
            // 
            // greenbar
            // 
            this.greenbar.Location = new System.Drawing.Point(111, 835);
            this.greenbar.Margin = new System.Windows.Forms.Padding(4);
            this.greenbar.Name = "greenbar";
            this.greenbar.Size = new System.Drawing.Size(169, 56);
            this.greenbar.TabIndex = 12;
            this.greenbar.ValueChanged += new System.EventHandler(this.greenbar_ValueChanged);
            // 
            // bluebar
            // 
            this.bluebar.Location = new System.Drawing.Point(111, 875);
            this.bluebar.Margin = new System.Windows.Forms.Padding(4);
            this.bluebar.Name = "bluebar";
            this.bluebar.Size = new System.Drawing.Size(169, 56);
            this.bluebar.TabIndex = 13;
            this.bluebar.ValueChanged += new System.EventHandler(this.bluebar_ValueChanged);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(1661, 693);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 58);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openButton
            // 
            this.openButton.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openButton.Location = new System.Drawing.Point(1661, 777);
            this.openButton.Margin = new System.Windows.Forms.Padding(4);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(150, 58);
            this.openButton.TabIndex = 15;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Location = new System.Drawing.Point(1661, 861);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(150, 58);
            this.closeButton.TabIndex = 16;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btTarnow
            // 
            this.btTarnow.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btTarnow.Location = new System.Drawing.Point(1589, 527);
            this.btTarnow.Margin = new System.Windows.Forms.Padding(4);
            this.btTarnow.Name = "btTarnow";
            this.btTarnow.Size = new System.Drawing.Size(171, 58);
            this.btTarnow.TabIndex = 17;
            this.btTarnow.Text = "Tarnow";
            this.btTarnow.UseVisualStyleBackColor = true;
            this.btTarnow.Click += new System.EventHandler(this.btTarnow_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(1611, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 31);
            this.label4.TabIndex = 18;
            this.label4.Text = "Filter List";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(12, 755);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 36);
            this.label5.TabIndex = 19;
            this.label5.Text = "RGB Correction";
            // 
            // btRotateLeft
            // 
            this.btRotateLeft.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btRotateLeft.Location = new System.Drawing.Point(806, 789);
            this.btRotateLeft.Name = "btRotateLeft";
            this.btRotateLeft.Size = new System.Drawing.Size(159, 46);
            this.btRotateLeft.TabIndex = 20;
            this.btRotateLeft.Text = "Rotate Left";
            this.btRotateLeft.UseVisualStyleBackColor = true;
            this.btRotateLeft.Click += new System.EventHandler(this.btRotateLeft_Click);
            // 
            // btRotateRight
            // 
            this.btRotateRight.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btRotateRight.Location = new System.Drawing.Point(548, 786);
            this.btRotateRight.Name = "btRotateRight";
            this.btRotateRight.Size = new System.Drawing.Size(159, 46);
            this.btRotateRight.TabIndex = 21;
            this.btRotateRight.Text = "Rotate Right";
            this.btRotateRight.UseVisualStyleBackColor = true;
            this.btRotateRight.Click += new System.EventHandler(this.btRotateRight_Click);
            // 
            // btRotateVertical
            // 
            this.btRotateVertical.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btRotateVertical.Location = new System.Drawing.Point(548, 861);
            this.btRotateVertical.Name = "btRotateVertical";
            this.btRotateVertical.Size = new System.Drawing.Size(159, 46);
            this.btRotateVertical.TabIndex = 22;
            this.btRotateVertical.Text = "Rotate Horizontal";
            this.btRotateVertical.UseVisualStyleBackColor = true;
            this.btRotateVertical.Click += new System.EventHandler(this.btRotateVertical_Click);
            // 
            // btRotateHorizontal
            // 
            this.btRotateHorizontal.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btRotateHorizontal.Location = new System.Drawing.Point(806, 861);
            this.btRotateHorizontal.Name = "btRotateHorizontal";
            this.btRotateHorizontal.Size = new System.Drawing.Size(159, 46);
            this.btRotateHorizontal.TabIndex = 23;
            this.btRotateHorizontal.Text = "Rotate Vertical";
            this.btRotateHorizontal.UseVisualStyleBackColor = true;
            this.btRotateHorizontal.Click += new System.EventHandler(this.btRotateHorizontal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(699, 755);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 31);
            this.label6.TabIndex = 24;
            this.label6.Text = "Rotation";
            // 
            // btMakeSelection
            // 
            this.btMakeSelection.Location = new System.Drawing.Point(1803, 80);
            this.btMakeSelection.Name = "btMakeSelection";
            this.btMakeSelection.Size = new System.Drawing.Size(131, 36);
            this.btMakeSelection.TabIndex = 25;
            this.btMakeSelection.Text = "Make Selection";
            this.btMakeSelection.UseVisualStyleBackColor = true;
            this.btMakeSelection.Click += new System.EventHandler(this.btMakeSelection_Click);
            // 
            // btCrop
            // 
            this.btCrop.Location = new System.Drawing.Point(1830, 131);
            this.btCrop.Name = "btCrop";
            this.btCrop.Size = new System.Drawing.Size(98, 29);
            this.btCrop.TabIndex = 26;
            this.btCrop.Text = "Crop";
            this.btCrop.UseVisualStyleBackColor = true;
            this.btCrop.Click += new System.EventHandler(this.btCrop_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(1803, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 27);
            this.label7.TabIndex = 27;
            this.label7.Text = "Crop Image";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1356, 798);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 53);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(1166, 760);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 31);
            this.label8.TabIndex = 29;
            this.label8.Text = "Colors";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(1167, 798);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 27);
            this.label9.TabIndex = 30;
            this.label9.Text = "Red";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(1167, 828);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 27);
            this.label10.TabIndex = 31;
            this.label10.Text = "Green";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(1167, 861);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 27);
            this.label11.TabIndex = 32;
            this.label11.Text = "Blue";
            // 
            // blueValue
            // 
            this.blueValue.AutoSize = true;
            this.blueValue.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blueValue.Location = new System.Drawing.Point(1285, 860);
            this.blueValue.Name = "blueValue";
            this.blueValue.Size = new System.Drawing.Size(24, 27);
            this.blueValue.TabIndex = 36;
            this.blueValue.Text = "0";
            // 
            // gValue
            // 
            this.gValue.AutoSize = true;
            this.gValue.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gValue.Location = new System.Drawing.Point(1285, 828);
            this.gValue.Name = "gValue";
            this.gValue.Size = new System.Drawing.Size(24, 27);
            this.gValue.TabIndex = 35;
            this.gValue.Text = "0";
            // 
            // rValue
            // 
            this.rValue.AutoSize = true;
            this.rValue.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rValue.Location = new System.Drawing.Point(1285, 798);
            this.rValue.Name = "rValue";
            this.rValue.Size = new System.Drawing.Size(24, 27);
            this.rValue.TabIndex = 34;
            this.rValue.Text = "0";
            // 
            // aValue
            // 
            this.aValue.AutoSize = true;
            this.aValue.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aValue.Location = new System.Drawing.Point(1284, 760);
            this.aValue.Name = "aValue";
            this.aValue.Size = new System.Drawing.Size(28, 31);
            this.aValue.TabIndex = 33;
            this.aValue.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 28);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.saveToolStripMenuItem.Text = "Save as...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MoreColors
            // 
            this.MoreColors.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoreColors.Location = new System.Drawing.Point(1331, 885);
            this.MoreColors.Name = "MoreColors";
            this.MoreColors.Size = new System.Drawing.Size(157, 46);
            this.MoreColors.TabIndex = 38;
            this.MoreColors.Text = "More...";
            this.MoreColors.UseVisualStyleBackColor = true;
            this.MoreColors.Click += new System.EventHandler(this.MoreColors_Click);
            // 
            // bValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1924, 966);
            this.Controls.Add(this.MoreColors);
            this.Controls.Add(this.blueValue);
            this.Controls.Add(this.gValue);
            this.Controls.Add(this.rValue);
            this.Controls.Add(this.aValue);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btCrop);
            this.Controls.Add(this.btMakeSelection);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btRotateHorizontal);
            this.Controls.Add(this.btRotateVertical);
            this.Controls.Add(this.btRotateRight);
            this.Controls.Add(this.btRotateLeft);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btTarnow);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.bluebar);
            this.Controls.Add(this.greenbar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.redbar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btLublin);
            this.Controls.Add(this.btWroclaw);
            this.Controls.Add(this.btKatowice);
            this.Controls.Add(this.btOpole);
            this.Controls.Add(this.btWarszawa);
            this.Controls.Add(this.btKrakow);
            this.Controls.Add(this.btNon);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "bValue";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btNon;
        private System.Windows.Forms.Button btKrakow;
        private System.Windows.Forms.Button btWarszawa;
        private System.Windows.Forms.Button btOpole;
        private System.Windows.Forms.Button btKatowice;
        private System.Windows.Forms.Button btWroclaw;
        private System.Windows.Forms.Button btLublin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar redbar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar greenbar;
        private System.Windows.Forms.TrackBar bluebar;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btTarnow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btRotateLeft;
        private System.Windows.Forms.Button btRotateRight;
        private System.Windows.Forms.Button btRotateVertical;
        private System.Windows.Forms.Button btRotateHorizontal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btMakeSelection;
        private System.Windows.Forms.Button btCrop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label blueValue;
        private System.Windows.Forms.Label gValue;
        private System.Windows.Forms.Label rValue;
        private System.Windows.Forms.Label aValue;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button MoreColors;
    }
}

