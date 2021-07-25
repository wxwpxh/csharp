using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace exci14_2
{
    class MyClass
    {
        public async Task<int> AccessTheWebAsync(string uristr)
        {
            WebClient wc1 = new WebClient();
            string result = await wc1.DownloadStringTaskAsync(new Uri(uristr));
            return result.Length;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            Task<int> t1 = obj.AccessTheWebAsync("http://www.microsoft.com");
            Console.WriteLine("访问的字符个数:{0}",t1.Result.ToString());
        }
    }
}
