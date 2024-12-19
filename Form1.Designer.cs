namespace Pizza_Project
{
    partial class orderPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orderPage));
            this.label1 = new System.Windows.Forms.Label();
            this.GbSize = new System.Windows.Forms.GroupBox();
            this.RbSmall = new System.Windows.Forms.RadioButton();
            this.Rblarge = new System.Windows.Forms.RadioButton();
            this.RbMeduim = new System.Windows.Forms.RadioButton();
            this.GbSrust = new System.Windows.Forms.GroupBox();
            this.RbThinkCrust = new System.Windows.Forms.RadioButton();
            this.RbThinCrust = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.GbTopping = new System.Windows.Forms.GroupBox();
            this.chbPepper = new System.Windows.Forms.CheckBox();
            this.chbOlives = new System.Windows.Forms.CheckBox();
            this.chbOnion = new System.Windows.Forms.CheckBox();
            this.chbTomatoes = new System.Windows.Forms.CheckBox();
            this.chbMushrooms = new System.Windows.Forms.CheckBox();
            this.chbChesse = new System.Windows.Forms.CheckBox();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.GbWhereToEat = new System.Windows.Forms.GroupBox();
            this.RbEatOut = new System.Windows.Forms.RadioButton();
            this.RbEatIn = new System.Windows.Forms.RadioButton();
            this.btnRestForm = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SummarySize = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SummaryCrust = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SummaryTopping = new System.Windows.Forms.Label();
            this.LbTopping = new System.Windows.Forms.GroupBox();
            this.LbTotalPrice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SummaryWhereToEat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GbSize.SuspendLayout();
            this.GbSrust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.GbTopping.SuspendLayout();
            this.GbWhereToEat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.LbTopping.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Hobo Std", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(396, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(636, 101);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Pizza Order";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GbSize
            // 
            this.GbSize.BackColor = System.Drawing.Color.Transparent;
            this.GbSize.Controls.Add(this.RbSmall);
            this.GbSize.Controls.Add(this.Rblarge);
            this.GbSize.Controls.Add(this.RbMeduim);
            this.GbSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbSize.ForeColor = System.Drawing.Color.White;
            this.GbSize.Location = new System.Drawing.Point(62, 138);
            this.GbSize.Name = "GbSize";
            this.GbSize.Size = new System.Drawing.Size(255, 221);
            this.GbSize.TabIndex = 0;
            this.GbSize.TabStop = false;
            this.GbSize.Text = "size";
            // 
            // RbSmall
            // 
            this.RbSmall.AutoSize = true;
            this.RbSmall.Location = new System.Drawing.Point(42, 63);
            this.RbSmall.Name = "RbSmall";
            this.RbSmall.Size = new System.Drawing.Size(112, 36);
            this.RbSmall.TabIndex = 0;
            this.RbSmall.Tag = "20";
            this.RbSmall.Text = "Small";
            this.RbSmall.UseVisualStyleBackColor = true;
            this.RbSmall.CheckedChanged += new System.EventHandler(this.RbSmall_CheckedChanged);
            // 
            // Rblarge
            // 
            this.Rblarge.AutoSize = true;
            this.Rblarge.Location = new System.Drawing.Point(42, 157);
            this.Rblarge.Name = "Rblarge";
            this.Rblarge.Size = new System.Drawing.Size(113, 36);
            this.Rblarge.TabIndex = 2;
            this.Rblarge.Tag = "40";
            this.Rblarge.Text = "Large";
            this.Rblarge.UseVisualStyleBackColor = true;
            this.Rblarge.CheckedChanged += new System.EventHandler(this.Rblarge_CheckedChanged_1);
            // 
            // RbMeduim
            // 
            this.RbMeduim.AutoSize = true;
            this.RbMeduim.Location = new System.Drawing.Point(42, 109);
            this.RbMeduim.Name = "RbMeduim";
            this.RbMeduim.Size = new System.Drawing.Size(142, 36);
            this.RbMeduim.TabIndex = 1;
            this.RbMeduim.Tag = "30";
            this.RbMeduim.Text = "Meduim";
            this.RbMeduim.UseVisualStyleBackColor = true;
            this.RbMeduim.CheckedChanged += new System.EventHandler(this.RbMeduim_CheckedChanged);
            // 
            // GbSrust
            // 
            this.GbSrust.BackColor = System.Drawing.Color.Transparent;
            this.GbSrust.Controls.Add(this.RbThinkCrust);
            this.GbSrust.Controls.Add(this.RbThinCrust);
            this.GbSrust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbSrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbSrust.ForeColor = System.Drawing.Color.White;
            this.GbSrust.Location = new System.Drawing.Point(62, 389);
            this.GbSrust.Name = "GbSrust";
            this.GbSrust.Size = new System.Drawing.Size(486, 137);
            this.GbSrust.TabIndex = 1;
            this.GbSrust.TabStop = false;
            this.GbSrust.Text = "Crust";
            // 
            // RbThinkCrust
            // 
            this.RbThinkCrust.AutoSize = true;
            this.RbThinkCrust.Location = new System.Drawing.Point(244, 63);
            this.RbThinkCrust.Name = "RbThinkCrust";
            this.RbThinkCrust.Size = new System.Drawing.Size(190, 36);
            this.RbThinkCrust.TabIndex = 5;
            this.RbThinkCrust.TabStop = true;
            this.RbThinkCrust.Tag = "50";
            this.RbThinkCrust.Text = "Think Crust";
            this.RbThinkCrust.UseVisualStyleBackColor = true;
            this.RbThinkCrust.CheckedChanged += new System.EventHandler(this.RbThinkCrust_CheckedChanged);
            // 
            // RbThinCrust
            // 
            this.RbThinCrust.AutoSize = true;
            this.RbThinCrust.Location = new System.Drawing.Point(24, 63);
            this.RbThinCrust.Name = "RbThinCrust";
            this.RbThinCrust.Size = new System.Drawing.Size(175, 36);
            this.RbThinCrust.TabIndex = 4;
            this.RbThinCrust.TabStop = true;
            this.RbThinCrust.Tag = "0";
            this.RbThinCrust.Text = "Thin Crust";
            this.RbThinCrust.UseVisualStyleBackColor = true;
            this.RbThinCrust.CheckedChanged += new System.EventHandler(this.RbThinCrust_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Pizza_Project.Properties.Resources.bell_pepper__1_;
            this.pictureBox2.Location = new System.Drawing.Point(14, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // GbTopping
            // 
            this.GbTopping.BackColor = System.Drawing.Color.Transparent;
            this.GbTopping.Controls.Add(this.chbPepper);
            this.GbTopping.Controls.Add(this.chbOlives);
            this.GbTopping.Controls.Add(this.chbOnion);
            this.GbTopping.Controls.Add(this.chbTomatoes);
            this.GbTopping.Controls.Add(this.chbMushrooms);
            this.GbTopping.Controls.Add(this.chbChesse);
            this.GbTopping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbTopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbTopping.ForeColor = System.Drawing.Color.White;
            this.GbTopping.Location = new System.Drawing.Point(341, 148);
            this.GbTopping.Name = "GbTopping";
            this.GbTopping.Size = new System.Drawing.Size(642, 212);
            this.GbTopping.TabIndex = 2;
            this.GbTopping.TabStop = false;
            this.GbTopping.Text = "Topping";
            this.GbTopping.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // chbPepper
            // 
            this.chbPepper.AutoSize = true;
            this.chbPepper.Location = new System.Drawing.Point(309, 139);
            this.chbPepper.Name = "chbPepper";
            this.chbPepper.Size = new System.Drawing.Size(241, 36);
            this.chbPepper.TabIndex = 10;
            this.chbPepper.Tag = "5";
            this.chbPepper.Text = "Green Peppers";
            this.chbPepper.UseVisualStyleBackColor = true;
            this.chbPepper.CheckedChanged += new System.EventHandler(this.chbPepper_CheckedChanged);
            // 
            // chbOlives
            // 
            this.chbOlives.AutoSize = true;
            this.chbOlives.Location = new System.Drawing.Point(309, 97);
            this.chbOlives.Name = "chbOlives";
            this.chbOlives.Size = new System.Drawing.Size(122, 36);
            this.chbOlives.TabIndex = 9;
            this.chbOlives.Tag = "5";
            this.chbOlives.Text = "Olives";
            this.chbOlives.UseVisualStyleBackColor = true;
            this.chbOlives.CheckedChanged += new System.EventHandler(this.chbOlives_CheckedChanged);
            // 
            // chbOnion
            // 
            this.chbOnion.AutoSize = true;
            this.chbOnion.Location = new System.Drawing.Point(309, 55);
            this.chbOnion.Name = "chbOnion";
            this.chbOnion.Size = new System.Drawing.Size(118, 36);
            this.chbOnion.TabIndex = 8;
            this.chbOnion.Tag = "5";
            this.chbOnion.Text = "Onion";
            this.chbOnion.UseVisualStyleBackColor = true;
            this.chbOnion.CheckedChanged += new System.EventHandler(this.chbOnion_CheckedChanged);
            // 
            // chbTomatoes
            // 
            this.chbTomatoes.AutoSize = true;
            this.chbTomatoes.Location = new System.Drawing.Point(26, 146);
            this.chbTomatoes.Name = "chbTomatoes";
            this.chbTomatoes.Size = new System.Drawing.Size(170, 36);
            this.chbTomatoes.TabIndex = 7;
            this.chbTomatoes.Tag = "5";
            this.chbTomatoes.Text = "Tomatoes";
            this.chbTomatoes.UseVisualStyleBackColor = true;
            this.chbTomatoes.CheckedChanged += new System.EventHandler(this.chbTomatoes_CheckedChanged);
            // 
            // chbMushrooms
            // 
            this.chbMushrooms.AutoSize = true;
            this.chbMushrooms.Location = new System.Drawing.Point(26, 100);
            this.chbMushrooms.Name = "chbMushrooms";
            this.chbMushrooms.Size = new System.Drawing.Size(192, 36);
            this.chbMushrooms.TabIndex = 6;
            this.chbMushrooms.Tag = "5";
            this.chbMushrooms.Text = "Mushrooms";
            this.chbMushrooms.UseVisualStyleBackColor = true;
            this.chbMushrooms.CheckedChanged += new System.EventHandler(this.chbMushrooms_CheckedChanged);
            // 
            // chbChesse
            // 
            this.chbChesse.AutoSize = true;
            this.chbChesse.Location = new System.Drawing.Point(26, 54);
            this.chbChesse.Name = "chbChesse";
            this.chbChesse.Size = new System.Drawing.Size(210, 36);
            this.chbChesse.TabIndex = 5;
            this.chbChesse.Tag = "5";
            this.chbChesse.Text = "Exra Cheese";
            this.chbChesse.UseVisualStyleBackColor = true;
            this.chbChesse.CheckedChanged += new System.EventHandler(this.chbChesse_CheckedChanged);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderPizza.Font = new System.Drawing.Font("Britannic Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPizza.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnOrderPizza.Image = global::Pizza_Project.Properties.Resources.bp41;
            this.btnOrderPizza.Location = new System.Drawing.Point(446, 654);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(320, 70);
            this.btnOrderPizza.TabIndex = 13;
            this.btnOrderPizza.Text = "Order Pizza\r\n";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // GbWhereToEat
            // 
            this.GbWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.GbWhereToEat.Controls.Add(this.RbEatOut);
            this.GbWhereToEat.Controls.Add(this.RbEatIn);
            this.GbWhereToEat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbWhereToEat.ForeColor = System.Drawing.Color.White;
            this.GbWhereToEat.Location = new System.Drawing.Point(581, 389);
            this.GbWhereToEat.Name = "GbWhereToEat";
            this.GbWhereToEat.Size = new System.Drawing.Size(402, 137);
            this.GbWhereToEat.TabIndex = 3;
            this.GbWhereToEat.TabStop = false;
            this.GbWhereToEat.Text = "Where To Eat";
            // 
            // RbEatOut
            // 
            this.RbEatOut.AutoSize = true;
            this.RbEatOut.Location = new System.Drawing.Point(244, 63);
            this.RbEatOut.Name = "RbEatOut";
            this.RbEatOut.Size = new System.Drawing.Size(138, 36);
            this.RbEatOut.TabIndex = 12;
            this.RbEatOut.TabStop = true;
            this.RbEatOut.Text = "Eat Out";
            this.RbEatOut.UseVisualStyleBackColor = true;
            this.RbEatOut.CheckedChanged += new System.EventHandler(this.RbEatOut_CheckedChanged);
            // 
            // RbEatIn
            // 
            this.RbEatIn.AutoSize = true;
            this.RbEatIn.Location = new System.Drawing.Point(24, 63);
            this.RbEatIn.Name = "RbEatIn";
            this.RbEatIn.Size = new System.Drawing.Size(114, 36);
            this.RbEatIn.TabIndex = 11;
            this.RbEatIn.TabStop = true;
            this.RbEatIn.Text = "Eat In";
            this.RbEatIn.UseVisualStyleBackColor = true;
            this.RbEatIn.CheckedChanged += new System.EventHandler(this.RbEatIn_CheckedChanged);
            // 
            // btnRestForm
            // 
            this.btnRestForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestForm.Font = new System.Drawing.Font("Britannic Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestForm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRestForm.Image = global::Pizza_Project.Properties.Resources._714;
            this.btnRestForm.Location = new System.Drawing.Point(855, 654);
            this.btnRestForm.Name = "btnRestForm";
            this.btnRestForm.Size = new System.Drawing.Size(245, 70);
            this.btnRestForm.TabIndex = 14;
            this.btnRestForm.Text = "Rest Form";
            this.btnRestForm.UseVisualStyleBackColor = true;
            this.btnRestForm.Click += new System.EventHandler(this.btnRestForm_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Image = global::Pizza_Project.Properties.Resources.basil__2_1;
            this.pictureBox4.Location = new System.Drawing.Point(1275, 55);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 23);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::Pizza_Project.Properties.Resources.pizza__3_;
            this.pictureBox7.Location = new System.Drawing.Point(256, 20);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(107, 90);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox7.TabIndex = 13;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::Pizza_Project.Properties.Resources.pizza_slice;
            this.pictureBox6.Location = new System.Drawing.Point(27, 692);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(36, 32);
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Peru;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Linen;
            this.label3.Location = new System.Drawing.Point(13, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 36);
            this.label3.TabIndex = 17;
            this.label3.Text = "Size:";
            // 
            // SummarySize
            // 
            this.SummarySize.AutoSize = true;
            this.SummarySize.BackColor = System.Drawing.Color.Peru;
            this.SummarySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummarySize.ForeColor = System.Drawing.Color.Black;
            this.SummarySize.Location = new System.Drawing.Point(105, 60);
            this.SummarySize.Name = "SummarySize";
            this.SummarySize.Size = new System.Drawing.Size(0, 29);
            this.SummarySize.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Peru;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Linen;
            this.label5.Location = new System.Drawing.Point(13, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 36);
            this.label5.TabIndex = 19;
            this.label5.Text = "Crust Type:";
            // 
            // SummaryCrust
            // 
            this.SummaryCrust.AutoSize = true;
            this.SummaryCrust.BackColor = System.Drawing.Color.Peru;
            this.SummaryCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryCrust.ForeColor = System.Drawing.Color.Black;
            this.SummaryCrust.Location = new System.Drawing.Point(201, 109);
            this.SummaryCrust.Name = "SummaryCrust";
            this.SummaryCrust.Size = new System.Drawing.Size(0, 29);
            this.SummaryCrust.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Peru;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Linen;
            this.label7.Location = new System.Drawing.Point(13, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 36);
            this.label7.TabIndex = 21;
            this.label7.Text = "Topping:";
            // 
            // SummaryTopping
            // 
            this.SummaryTopping.AutoSize = true;
            this.SummaryTopping.BackColor = System.Drawing.Color.Peru;
            this.SummaryTopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryTopping.ForeColor = System.Drawing.Color.Black;
            this.SummaryTopping.Location = new System.Drawing.Point(13, 194);
            this.SummaryTopping.Name = "SummaryTopping";
            this.SummaryTopping.Size = new System.Drawing.Size(0, 29);
            this.SummaryTopping.TabIndex = 22;
            this.SummaryTopping.Click += new System.EventHandler(this.label8_Click);
            // 
            // LbTopping
            // 
            this.LbTopping.BackColor = System.Drawing.Color.Peru;
            this.LbTopping.Controls.Add(this.LbTotalPrice);
            this.LbTopping.Controls.Add(this.label10);
            this.LbTopping.Controls.Add(this.SummaryWhereToEat);
            this.LbTopping.Controls.Add(this.label2);
            this.LbTopping.Controls.Add(this.SummaryTopping);
            this.LbTopping.Controls.Add(this.label7);
            this.LbTopping.Controls.Add(this.SummaryCrust);
            this.LbTopping.Controls.Add(this.label5);
            this.LbTopping.Controls.Add(this.SummarySize);
            this.LbTopping.Controls.Add(this.label3);
            this.LbTopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTopping.Location = new System.Drawing.Point(1001, 166);
            this.LbTopping.Name = "LbTopping";
            this.LbTopping.Size = new System.Drawing.Size(340, 391);
            this.LbTopping.TabIndex = 23;
            this.LbTopping.TabStop = false;
            this.LbTopping.Text = "Order Summary";
            // 
            // LbTotalPrice
            // 
            this.LbTotalPrice.AutoSize = true;
            this.LbTotalPrice.BackColor = System.Drawing.Color.Peru;
            this.LbTotalPrice.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotalPrice.ForeColor = System.Drawing.Color.Gold;
            this.LbTotalPrice.Location = new System.Drawing.Point(177, 319);
            this.LbTotalPrice.Name = "LbTotalPrice";
            this.LbTotalPrice.Size = new System.Drawing.Size(0, 54);
            this.LbTotalPrice.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Peru;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Linen;
            this.label10.Location = new System.Drawing.Point(13, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 32);
            this.label10.TabIndex = 25;
            this.label10.Text = "Total Price:";
            // 
            // SummaryWhereToEat
            // 
            this.SummaryWhereToEat.AutoSize = true;
            this.SummaryWhereToEat.BackColor = System.Drawing.Color.Peru;
            this.SummaryWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryWhereToEat.ForeColor = System.Drawing.Color.Black;
            this.SummaryWhereToEat.Location = new System.Drawing.Point(13, 267);
            this.SummaryWhereToEat.Name = "SummaryWhereToEat";
            this.SummaryWhereToEat.Size = new System.Drawing.Size(0, 29);
            this.SummaryWhereToEat.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Peru;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Linen;
            this.label2.Location = new System.Drawing.Point(13, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 32);
            this.label2.TabIndex = 23;
            this.label2.Text = "Where To Eat:";
            // 
            // orderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pizza_Project.Properties.Resources.top_view_delicious_food_with_copy_space;
            this.ClientSize = new System.Drawing.Size(1711, 749);
            this.Controls.Add(this.LbTopping);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnRestForm);
            this.Controls.Add(this.GbWhereToEat);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.GbTopping);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.GbSrust);
            this.Controls.Add(this.GbSize);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "orderPage";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GbSize.ResumeLayout(false);
            this.GbSize.PerformLayout();
            this.GbSrust.ResumeLayout(false);
            this.GbSrust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.GbTopping.ResumeLayout(false);
            this.GbTopping.PerformLayout();
            this.GbWhereToEat.ResumeLayout(false);
            this.GbWhereToEat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.LbTopping.ResumeLayout(false);
            this.LbTopping.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GbSize;
        private System.Windows.Forms.RadioButton Rblarge;
        private System.Windows.Forms.RadioButton RbMeduim;
        private System.Windows.Forms.GroupBox GbSrust;
        private System.Windows.Forms.RadioButton RbThinkCrust;
        private System.Windows.Forms.RadioButton RbThinCrust;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox GbTopping;
        private System.Windows.Forms.CheckBox chbChesse;
        private System.Windows.Forms.CheckBox chbMushrooms;
        private System.Windows.Forms.CheckBox chbPepper;
        private System.Windows.Forms.CheckBox chbOlives;
        private System.Windows.Forms.CheckBox chbOnion;
        private System.Windows.Forms.CheckBox chbTomatoes;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.GroupBox GbWhereToEat;
        private System.Windows.Forms.RadioButton RbEatOut;
        private System.Windows.Forms.RadioButton RbEatIn;
        private System.Windows.Forms.Button btnRestForm;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SummarySize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label SummaryCrust;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label SummaryTopping;
        private System.Windows.Forms.GroupBox LbTopping;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label SummaryWhereToEat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbTotalPrice;
        private System.Windows.Forms.RadioButton RbSmall;
    }
}

