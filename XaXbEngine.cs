
using System.Diagnostics.Metrics;

namespace XaXbEngineS
{
    public class XaXbEngine
    {
        public string luckyNum; //幸運數字

        //建構子
        public XaXbEngine()
        {
            GetLuckyNum();//初始化幸運數字
        }

        // 獲取幸運數字
        public void GetLuckyNum()
        {
            Random random = new Random();
            List<int> TempNum = new List<int>();

            while (TempNum.Count < 3)
            {
                int num = random.Next(0, 9);//隨機生成0~10的數字
                if (!TempNum.Contains(num))//如果list中不存在相同數字
                {
                    TempNum.Add(num);
                }
            }
            luckyNum = string.Join("", TempNum); //將數字串接
        }

        // 檢查數字合法
        public bool IsLegalNum(string num)
        {
            if (num.Length != 3)//數字不為3
            {
                return false;
            }
            foreach (char c in num)
            {
                if (!char.IsDigit(c))//如果不是數字
                {
                    return false;
                }
            }
            return num.Distinct().Count() == 3; //確保數字不重複
        }

        //獲取猜測結果
        public string GetResult(string num)
        {
            int a = 0, b = 0;
            for (int i = 0; i < 3; i++)
            {
                if (num[i] == luckyNum[i])
                {
                    a++; //數字與位置相同
                }
                else if (luckyNum.Contains(num[i]))
                {
                    b++; //數字一樣但位置錯誤
                }
            }
            return $"{a}A{b}B";
        }

        // 判斷遊戲是否結束
        public bool IsGameOver(string num)
        {
            return GetResult(num) == "3A0B";
        }

    }
}
