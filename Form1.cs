using XaXbEngineS;
namespace GUI
{
    public partial class Form1 : Form
    {
        XaXbEngine xaxb;
        private int counter;//�q������
        DialogResult Resresult;//���s�C�����G

        //��l��
        public Form1()
        {
            InitializeComponent();
            xaxb = new XaXbEngine();
            counter = 0;
            label1.Text = "�п�J�����ƪ��T�ӼƦr(0~9):";
            string ans = xaxb.luckyNum;
        }

        //�I���ƥ�
        private void button1_Click(object sender, EventArgs e)
        {
            string PlayerNum = PlayerInput.Text.Trim(); //������a��J�Ʀr

            if (xaxb.IsLegalNum(PlayerNum)) //�P�_�Ʀr�O�_�X�k
            {
                counter++;
                string result = xaxb.GetResult(PlayerNum); //����q�����G
                listBox1.Items.Add($"{PlayerNum}: {result}�A �q������: {counter}"); // �N�q�����G��ܦb�C��ؤ�
                
                if (result == "3A0B") // �p�G�q��F
                {
                    //�C�������A�߰ݪ��a�O�_���s�C��
                    Resresult = MessageBox.Show($"���߲q��F\n �O�_�~��C��?", "�C�����G", MessageBoxButtons.YesNo);

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
                MessageBox.Show("�榡�Τ��e���~�A�Э��s��J!!"); //���ܪ��a���s��J
            }
            PlayerInput.Clear(); //�M�ſ�J��
        }

      
    }
}