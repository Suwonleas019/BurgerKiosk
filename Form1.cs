namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
        int totalCost = 0;
        private void btnOrder_Click(object sender, EventArgs e)
        {


            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked && !chkPotato.Checked && !chkCola.Checked && !chkCheese.Checked && !chkSauce.Checked)
            {
                lblTotalCost.Text = "음식을 선택해주세요.";

                return;
            }

            if (rdoHamBurger.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거 5,000원");
            }
            else if (rdoBulgogiBurger.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기버거 4,000원");
            }
            else if (rdoChickenBurger.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치킨버거 3,000원");
            }
            if (chkPotato.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀김 3,500원");
            }
            if (chkCola.Checked)
            {
                totalCost += 2500;
                lstOrder.Items.Add("콜라 2,500원");
            }
            if (chkCheese.Checked)
            {
                totalCost += 1500;
                lstOrder.Items.Add("치즈 추가 1,500원");
            }
            if (chkSauce.Checked)
            {
                totalCost += 500;
                lstOrder.Items.Add("소스 추가 500원");
            }
            lblTotalCost.Text = "총 금액: " + totalCost.ToString("N0") + "원";
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;
            lstOrder.Items.Clear();

            lblTotalCost.Text = "총 금액: ";
            totalCost = 0;
            rdoHamBurger.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;

            // 라디오버튼과 체크박스의 CheckedChanged 이벤트에 UPdateOrder 메서드를 연결합니다.
            EventHandler handler = (s, ev) => UPdateOrder();
            rdoHamBurger.CheckedChanged += handler;
            rdoBulgogiBurger.CheckedChanged += handler;
            rdoChickenBurger.CheckedChanged += handler;
            chkPotato.CheckedChanged += handler;
            chkCola.CheckedChanged += handler;
            chkCheese.CheckedChanged += handler;
            chkSauce.CheckedChanged += handler;
        }

        private void UPdateOrder()
        {
            totalCost = 0;
            lstOrder.Items.Clear();


            if (rdoHamBurger.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거 5,000원");
            }
            else if (rdoBulgogiBurger.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기버거 4,000원");
            }
            else if (rdoChickenBurger.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치킨버거 3,000원");
            }
            if (chkPotato.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀김 3,500원");
            }
            if (chkCola.Checked)
            {
                totalCost += 2500;
                lstOrder.Items.Add("콜라 2,500원");
            }
            if (chkCheese.Checked)
            {
                totalCost += 1500;
                lstOrder.Items.Add("치즈 추가 1,500원");
            }
            if (chkSauce.Checked)
            {
                totalCost += 500;
                lstOrder.Items.Add("소스 추가 500원");
            }
            if (totalCost > 0)
            {
                lblTotalCost.Text = $"총 금액: {totalCost:N0}원";
            }
            else
            {
                lblTotalCost.Text = "총 금액: 0원";
            }
        }

        private void chkPotato_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}