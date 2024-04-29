using XaXbEngineS;
namespace GUI
{
    public partial class Form1 : Form
    {
        XaXbEngine xaxb;
        private int counter;//猜測次數
        DialogResult Resresult;//重新遊戲結果

        //初始化
        public Form1()
        {
            InitializeComponent();
            xaxb = new XaXbEngine();
            counter = 0;
            label1.Text = "請輸入不重複的三個數字(0~9):";
            string ans = xaxb.luckyNum;
        }

        //點擊事件
        private void button1_Click(object sender, EventArgs e)
        {
            string PlayerNum = PlayerInput.Text.Trim(); //獲取玩家輸入數字

            if (xaxb.IsLegalNum(PlayerNum)) //判斷數字是否合法
            {
                counter++;
                string result = xaxb.GetResult(PlayerNum); //獲取猜測結果
                listBox1.Items.Add($"{PlayerNum}: {result}， 猜測次數: {counter}"); // 將猜測結果顯示在列表框中
                
                if (result == "3A0B") // 如果猜對了
                {
                    //遊戲結束，詢問玩家是否重新遊玩
                    Resresult = MessageBox.Show($"恭喜猜對了\n 是否繼續遊戲?", "遊戲結果", MessageBoxButtons.YesNo);

                    if (Resresult == DialogResult.Yes)
                    {
                        xaxb = new XaXbEngine();
                        counter = 0;
                        listBox1.Items.Clear(); ;
                    }
                    else if (Resresult == DialogResult.No)
                    {
                        Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("格式或內容錯誤，請重新輸入!!"); //提示玩家重新輸入
            }
            PlayerInput.Clear(); //清空輸入框
        }

      
    }
}