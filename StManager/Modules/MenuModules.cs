namespace StManager;

public class MenuModules
{
  public void Menu()
  {
    while (true)
    {
      Console.WriteLine("请选择操作：");
      Console.WriteLine("1. 查询学生信息");
      Console.WriteLine("2. 添加学生信息");
      Console.WriteLine("3. 删除学生信息");
      Console.WriteLine("4. 修改学生信息");
      Console.WriteLine("0. 退出");

      string menuChoice = Console.ReadLine().ToString();

      switch (menuChoice)
      {
        case "1":
     // 调用查询模块
     //var inquiryMethod = InquiryModules.GetInquiryMethod();

     WriteReadModules writeReadModules = new WriteReadModules();
     writeReadModules.FilesRead();

    //  间接调用私有方法
          // inquiryMethod();
          break;
        case "2":
          AddInformation.AddStudentScore();
          break;
        case "3":
          Console.WriteLine("删除学生信息开发中，请稍后！");
          break;
        case "4":
          Console.WriteLine("修改学生信息开发中，请稍后！");
          break;
        case "0":
          return;
        default:
          Console.WriteLine("无效的选择，请重新输入。");
          break;
      }
    }
  }
}