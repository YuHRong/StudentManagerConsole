
using System;
using System.ComponentModel.Design;

namespace StManager;

class Program
{
 static void Main(string[] args)
 {

  // 打印欢迎信息。
  Console.WriteLine("欢迎使用简易学生管理系统。\n");

  // 调用时间模块
  // 创建时间模块实例并调用时间显示方法
  TimeModules timeModules = new TimeModules();
  timeModules.TimeNow();

Console.WriteLine();

  // 调用菜单模块
  // 创建菜单模块实例并调用菜单方法
  MenuModules menu = new MenuModules();
  menu.Menu();

 }
}
