namespace BurgerKiosk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblAppName = new Label();
            picHamBurger = new PictureBox();
            picBulgogiBurger = new PictureBox();
            picChickenBurger = new PictureBox();
            grbMenu = new GroupBox();
            rdoChickenBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            rdoHamBurger = new RadioButton();
            grbExtraOption = new GroupBox();
            chkSauce = new CheckBox();
            chkCheese = new CheckBox();
            chkCola = new CheckBox();
            chkPotato = new CheckBox();
            grbList = new GroupBox();
            lblError = new Label();
            btnInit = new Button();
            btnOrder = new Button();
            lblTotalCost = new Label();
            lstOrder = new ListBox();
            ((System.ComponentModel.ISupportInitialize)picHamBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogiBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChickenBurger).BeginInit();
            grbMenu.SuspendLayout();
            grbExtraOption.SuspendLayout();
            grbList.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 30F);
            lblAppName.ForeColor = Color.Blue;
            lblAppName.Location = new Point(12, 9);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(465, 67);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "버거 주문 키오스크";
            // 
            // picHamBurger
            // 
            picHamBurger.Image = (Image)resources.GetObject("picHamBurger.Image");
            picHamBurger.Location = new Point(223, 66);
            picHamBurger.Name = "picHamBurger";
            picHamBurger.Size = new Size(133, 100);
            picHamBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            picHamBurger.TabIndex = 1;
            picHamBurger.TabStop = false;
            picHamBurger.Click += pictureBox1_Click;
            // 
            // picBulgogiBurger
            // 
            picBulgogiBurger.Image = (Image)resources.GetObject("picBulgogiBurger.Image");
            picBulgogiBurger.Location = new Point(223, 205);
            picBulgogiBurger.Name = "picBulgogiBurger";
            picBulgogiBurger.Size = new Size(133, 99);
            picBulgogiBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            picBulgogiBurger.TabIndex = 2;
            picBulgogiBurger.TabStop = false;
            // 
            // picChickenBurger
            // 
            picChickenBurger.Image = (Image)resources.GetObject("picChickenBurger.Image");
            picChickenBurger.Location = new Point(223, 346);
            picChickenBurger.Name = "picChickenBurger";
            picChickenBurger.Size = new Size(133, 107);
            picChickenBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            picChickenBurger.TabIndex = 3;
            picChickenBurger.TabStop = false;
            // 
            // grbMenu
            // 
            grbMenu.Controls.Add(rdoChickenBurger);
            grbMenu.Controls.Add(rdoBulgogiBurger);
            grbMenu.Controls.Add(rdoHamBurger);
            grbMenu.Controls.Add(picHamBurger);
            grbMenu.Controls.Add(picChickenBurger);
            grbMenu.Controls.Add(picBulgogiBurger);
            grbMenu.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grbMenu.ForeColor = Color.Red;
            grbMenu.Location = new Point(31, 100);
            grbMenu.Name = "grbMenu";
            grbMenu.Size = new Size(389, 459);
            grbMenu.TabIndex = 1;
            grbMenu.TabStop = false;
            grbMenu.Text = "메뉴선택";
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, GraphicsUnit.Point, 129);
            rdoChickenBurger.ForeColor = Color.Black;
            rdoChickenBurger.Location = new Point(6, 370);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(136, 39);
            rdoChickenBurger.TabIndex = 6;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            rdoChickenBurger.CheckedChanged += chkPotato_CheckedChanged;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, GraphicsUnit.Point, 129);
            rdoBulgogiBurger.ForeColor = Color.Black;
            rdoBulgogiBurger.Location = new Point(6, 231);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(161, 39);
            rdoBulgogiBurger.TabIndex = 5;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            rdoBulgogiBurger.CheckedChanged += chkPotato_CheckedChanged;
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, GraphicsUnit.Point, 129);
            rdoHamBurger.ForeColor = Color.Black;
            rdoHamBurger.Location = new Point(6, 91);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(111, 39);
            rdoHamBurger.TabIndex = 4;
            rdoHamBurger.TabStop = true;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            rdoHamBurger.CheckedChanged += chkPotato_CheckedChanged;
            // 
            // grbExtraOption
            // 
            grbExtraOption.Controls.Add(chkSauce);
            grbExtraOption.Controls.Add(chkCheese);
            grbExtraOption.Controls.Add(chkCola);
            grbExtraOption.Controls.Add(chkPotato);
            grbExtraOption.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grbExtraOption.ForeColor = Color.Red;
            grbExtraOption.Location = new Point(447, 104);
            grbExtraOption.Name = "grbExtraOption";
            grbExtraOption.Size = new Size(270, 380);
            grbExtraOption.TabIndex = 2;
            grbExtraOption.TabStop = false;
            grbExtraOption.Text = "추가옵션";
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, GraphicsUnit.Point, 129);
            chkSauce.ForeColor = Color.Black;
            chkSauce.Location = new Point(23, 319);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(146, 39);
            chkSauce.TabIndex = 3;
            chkSauce.TabStop = false;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            chkSauce.CheckedChanged += chkPotato_CheckedChanged;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, GraphicsUnit.Point, 129);
            chkCheese.ForeColor = Color.Black;
            chkCheese.Location = new Point(23, 243);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(146, 39);
            chkCheese.TabIndex = 2;
            chkCheese.TabStop = false;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            chkCheese.CheckedChanged += chkPotato_CheckedChanged;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, GraphicsUnit.Point, 129);
            chkCola.ForeColor = Color.Black;
            chkCola.Location = new Point(23, 169);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(87, 39);
            chkCola.TabIndex = 1;
            chkCola.TabStop = false;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            chkCola.CheckedChanged += chkPotato_CheckedChanged;
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, GraphicsUnit.Point, 129);
            chkPotato.ForeColor = Color.Black;
            chkPotato.Location = new Point(23, 87);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(137, 39);
            chkPotato.TabIndex = 0;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            chkPotato.CheckedChanged += chkPotato_CheckedChanged;
            // 
            // grbList
            // 
            grbList.Controls.Add(lblError);
            grbList.Controls.Add(btnInit);
            grbList.Controls.Add(btnOrder);
            grbList.Controls.Add(lblTotalCost);
            grbList.Controls.Add(lstOrder);
            grbList.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grbList.ForeColor = Color.Red;
            grbList.Location = new Point(749, 104);
            grbList.Name = "grbList";
            grbList.Size = new Size(312, 482);
            grbList.TabIndex = 3;
            grbList.TabStop = false;
            grbList.Text = "주문내역";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(28, 429);
            lblError.Name = "lblError";
            lblError.Size = new Size(249, 35);
            lblError.TabIndex = 3;
            lblError.Text = "음식을 선택해주세요";
            lblError.Visible = false;
            // 
            // btnInit
            // 
            btnInit.BackColor = Color.Red;
            btnInit.ForeColor = Color.White;
            btnInit.Location = new Point(165, 376);
            btnInit.Name = "btnInit";
            btnInit.Size = new Size(128, 50);
            btnInit.TabIndex = 1;
            btnInit.TabStop = false;
            btnInit.Text = "초기화";
            btnInit.UseVisualStyleBackColor = false;
            btnInit.Click += btnInit_Click;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.Lime;
            btnOrder.ForeColor = Color.White;
            btnOrder.Location = new Point(26, 376);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(131, 50);
            btnOrder.TabIndex = 0;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblTotalCost.ForeColor = Color.Blue;
            lblTotalCost.Location = new Point(28, 332);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(106, 35);
            lblTotalCost.TabIndex = 2;
            lblTotalCost.Text = "총 금액:";
            // 
            // lstOrder
            // 
            lstOrder.Font = new Font("맑은 고딕", 13F);
            lstOrder.ForeColor = Color.DarkBlue;
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(26, 44);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(267, 274);
            lstOrder.TabIndex = 4;
            lstOrder.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 610);
            Controls.Add(grbList);
            Controls.Add(grbExtraOption);
            Controls.Add(grbMenu);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Burger Kiosk v1.0";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picHamBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogiBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChickenBurger).EndInit();
            grbMenu.ResumeLayout(false);
            grbMenu.PerformLayout();
            grbExtraOption.ResumeLayout(false);
            grbExtraOption.PerformLayout();
            grbList.ResumeLayout(false);
            grbList.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private PictureBox picHamBurger;
        private PictureBox picBulgogiBurger;
        private PictureBox picChickenBurger;
        private GroupBox grbMenu;
        private RadioButton rdoHamBurger;
        private RadioButton rdoChickenBurger;
        private RadioButton rdoBulgogiBurger;
        private GroupBox grbExtraOption;
        private CheckBox chkPotato;
        private CheckBox chkSauce;
        private CheckBox chkCheese;
        private CheckBox chkCola;
        private GroupBox grbList;
        private Button btnInit;
        private Button btnOrder;
        private Label lblTotalCost;
        private ListBox lstOrder;
        private Label lblError;
    }
}
