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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            grbMenu = new GroupBox();
            rdoHamburger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            rdoChikenBurger = new RadioButton();
            grbExtraOption = new GroupBox();
            chkPotato = new CheckBox();
            chkCola = new CheckBox();
            chkCheese = new CheckBox();
            chkSause = new CheckBox();
            grbList = new GroupBox();
            listBox1 = new ListBox();
            lblTotalCost = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            grbMenu.SuspendLayout();
            grbExtraOption.SuspendLayout();
            grbList.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 30F);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(465, 67);
            label1.TabIndex = 0;
            label1.Text = "버거 주문 키오스크";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(223, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(223, 205);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(133, 99);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(223, 346);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(133, 107);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // grbMenu
            // 
            grbMenu.Controls.Add(rdoChikenBurger);
            grbMenu.Controls.Add(rdoBulgogiBurger);
            grbMenu.Controls.Add(rdoHamburger);
            grbMenu.Controls.Add(pictureBox1);
            grbMenu.Controls.Add(pictureBox3);
            grbMenu.Controls.Add(pictureBox2);
            grbMenu.Font = new Font("맑은 고딕", 20F);
            grbMenu.ForeColor = Color.Red;
            grbMenu.Location = new Point(31, 99);
            grbMenu.Name = "grbMenu";
            grbMenu.Size = new Size(389, 459);
            grbMenu.TabIndex = 4;
            grbMenu.TabStop = false;
            grbMenu.Text = "메뉴선택";
            // 
            // rdoHamburger
            // 
            rdoHamburger.AutoSize = true;
            rdoHamburger.Font = new Font("맑은 고딕", 15F);
            rdoHamburger.ForeColor = Color.Black;
            rdoHamburger.Location = new Point(6, 91);
            rdoHamburger.Name = "rdoHamburger";
            rdoHamburger.Size = new Size(111, 39);
            rdoHamburger.TabIndex = 4;
            rdoHamburger.TabStop = true;
            rdoHamburger.Text = "햄버거";
            rdoHamburger.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Font = new Font("맑은 고딕", 15F);
            rdoBulgogiBurger.ForeColor = Color.Black;
            rdoBulgogiBurger.Location = new Point(0, 233);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(161, 39);
            rdoBulgogiBurger.TabIndex = 5;
            rdoBulgogiBurger.TabStop = true;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            // 
            // rdoChikenBurger
            // 
            rdoChikenBurger.AutoSize = true;
            rdoChikenBurger.Font = new Font("맑은 고딕", 15F);
            rdoChikenBurger.ForeColor = Color.Black;
            rdoChikenBurger.Location = new Point(6, 379);
            rdoChikenBurger.Name = "rdoChikenBurger";
            rdoChikenBurger.Size = new Size(136, 39);
            rdoChikenBurger.TabIndex = 6;
            rdoChikenBurger.TabStop = true;
            rdoChikenBurger.Text = "치킨버거";
            rdoChikenBurger.UseVisualStyleBackColor = true;
            // 
            // grbExtraOption
            // 
            grbExtraOption.Controls.Add(chkSause);
            grbExtraOption.Controls.Add(chkCheese);
            grbExtraOption.Controls.Add(chkCola);
            grbExtraOption.Controls.Add(chkPotato);
            grbExtraOption.Font = new Font("맑은 고딕", 15F);
            grbExtraOption.ForeColor = Color.Red;
            grbExtraOption.Location = new Point(447, 104);
            grbExtraOption.Name = "grbExtraOption";
            grbExtraOption.Size = new Size(270, 380);
            grbExtraOption.TabIndex = 5;
            grbExtraOption.TabStop = false;
            grbExtraOption.Text = "추가옵션";
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.Font = new Font("맑은 고딕", 15F);
            chkPotato.ForeColor = Color.Black;
            chkPotato.Location = new Point(23, 87);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(137, 39);
            chkPotato.TabIndex = 0;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Font = new Font("맑은 고딕", 15F);
            chkCola.ForeColor = Color.Black;
            chkCola.Location = new Point(23, 169);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(87, 39);
            chkCola.TabIndex = 1;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Font = new Font("맑은 고딕", 15F);
            chkCheese.ForeColor = Color.Black;
            chkCheese.Location = new Point(23, 249);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(87, 39);
            chkCheese.TabIndex = 2;
            chkCheese.Text = "치즈";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkSause
            // 
            chkSause.AutoSize = true;
            chkSause.Font = new Font("맑은 고딕", 15F);
            chkSause.ForeColor = Color.Black;
            chkSause.Location = new Point(23, 325);
            chkSause.Name = "chkSause";
            chkSause.Size = new Size(87, 39);
            chkSause.TabIndex = 3;
            chkSause.Text = "소스";
            chkSause.UseVisualStyleBackColor = true;
            // 
            // grbList
            // 
            grbList.Controls.Add(button2);
            grbList.Controls.Add(button1);
            grbList.Controls.Add(lblTotalCost);
            grbList.Controls.Add(listBox1);
            grbList.Font = new Font("맑은 고딕", 15F);
            grbList.ForeColor = Color.Red;
            grbList.Location = new Point(749, 104);
            grbList.Name = "grbList";
            grbList.Size = new Size(312, 448);
            grbList.TabIndex = 6;
            grbList.TabStop = false;
            grbList.Text = "주문내역";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(26, 44);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(267, 284);
            listBox1.TabIndex = 0;
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Location = new Point(28, 332);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(99, 35);
            lblTotalCost.TabIndex = 1;
            lblTotalCost.Text = "총 금액";
            // 
            // button1
            // 
            button1.Location = new Point(28, 370);
            button1.Name = "button1";
            button1.Size = new Size(131, 50);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(165, 370);
            button2.Name = "button2";
            button2.Size = new Size(128, 50);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 610);
            Controls.Add(grbList);
            Controls.Add(grbExtraOption);
            Controls.Add(grbMenu);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private GroupBox grbMenu;
        private RadioButton rdoHamburger;
        private RadioButton rdoChikenBurger;
        private RadioButton rdoBulgogiBurger;
        private GroupBox grbExtraOption;
        private CheckBox chkPotato;
        private CheckBox chkSause;
        private CheckBox chkCheese;
        private CheckBox chkCola;
        private GroupBox grbList;
        private Button button2;
        private Button button1;
        private Label lblTotalCost;
        private ListBox listBox1;
    }
}
