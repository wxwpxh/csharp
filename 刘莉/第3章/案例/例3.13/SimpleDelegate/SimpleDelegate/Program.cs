using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleDelegate
{
    // 声明提供事件数据的类
    public class TemperatureArgs : System.EventArgs
    {
        public float Temperature { get; set; }
        public TemperatureArgs(float newTemperature)
        {
            Temperature = newTemperature;
        }
    }
    // 声明事件处理委托
    public delegate void TemperatureLowerHandler(object sender, TemperatureArgs args);
    // 声明引发事件的类（事件发送器）
    public class HotHouse
    {
        // 在事件发生器中声明事件
        public event TemperatureLowerHandler AddTemperature;

        public string Name;
        public float MinTemperature { get; set; }
        private float currTemperature;
        public HotHouse(string name, float minTemp, float currTemp)
        {
            Name = name;
            MinTemperature = minTemp;
            CurrentTemperature = currTemp;
        }
        public float CurrentTemperature
        {
            get
            {
                return currTemperature;
            }
            set
            {
                currTemperature = value;
                Console.WriteLine("温室{0}的当前温度为{1},最低温度要求为{2}",
                    Name, CurrentTemperature, MinTemperature);
                // 在事件发生器中发生事件
                if (currTemperature < MinTemperature)
                    AddTemperature(this, new TemperatureArgs(currTemperature));
            }
        }
    }
    // 声明处理事件的类（事件接收器）
    public class Heater
    {
        // 声明事件处理程序
        public static void Heating(object sender, TemperatureArgs args)
        {
            // 将sender强制转换为事件发生器类型，以便能访问MinTemperature
            HotHouse ht = (HotHouse)sender;
            // currTemperature通过参数args传递过来，当然也可以用ht访问。
            Console.WriteLine("为温室{0}加热{1}度",
                ht.Name, ht.MinTemperature - args.Temperature);
            ht.CurrentTemperature = ht.MinTemperature;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("温室温度调控系统,输入当前温度，输入负数退出");
            HotHouse ht1 = new HotHouse("HotHouse1", 22, 25);
            ht1.AddTemperature += new TemperatureLowerHandler(Heater.Heating);
            float setTemp = float.Parse(Console.ReadLine());
            while (setTemp >= 0)
            {
                ht1.CurrentTemperature = setTemp;
                setTemp = float.Parse(Console.ReadLine());
            }

        }
    }
}
