using System.Collections;

namespace RamblerBrute
{
    public static class Globals    //класс хранит используемые переменные
    {
        public static readonly ArrayList Source = new ArrayList();  //контейнер\массив хз что место под логины пароли
        public static readonly ArrayList Proxy = new ArrayList();  //под прокси
        public static string TxtDelimiter = ";"; //разделитель
        public static int TypeProxy = 1;
        public static int CountSource;
        public static int CountProxy;
        public static int CountGood;
        public static int CountBad;
        public static int Pps;
        public static int CountThreads;
    }
}
