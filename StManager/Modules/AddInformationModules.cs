
using System;
using System.Text;
using System.Globalization;
using System.Diagnostics;
using System.ComponentModel;

namespace StManager;

public class AddInformation
{

 public static List<StudentInformation> studentList = new List<StudentInformation>();

 // 添加学生成绩信息方法
 public static void AddStudentScore()
 {
  // 添加学生成绩信息
  Console.WriteLine("请输入学生成绩信息。\n格式为:名字，年级，课程，成绩。\n中间用中英文逗号: \",，\" 或者句号 \".。\"分隔。\n输入 \"exit\" 退出。");

  while (true)
  {
   string inputStudent = Console.ReadLine();

   if (inputStudent == "exit")
    return;

   // 分割输入
   string[] parts = inputStudent.Split(new char[] { ',', '，', '.', '。' }, StringSplitOptions.RemoveEmptyEntries);
   if (parts.Length != 4)
   {
    Console.WriteLine("输入错误，格式为：名字，年级，课程，成绩。\n中间用中英文逗号: \",，\" 或者句号 \".。\"分隔。");
    continue;
   }

   string name = parts[0].Trim();
   string grade = parts[1].Trim();
   string subject = parts[2].Trim();
   if (!double.TryParse(parts[3].Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out double score))
   {
    Console.WriteLine("成绩必须是数字，请重新输入。");
    continue;
   }

   // 验证输入
   if (string.IsNullOrWhiteSpace(name))
   {
    Console.WriteLine("名字不能为空，请重新输入。");
    continue;
   }

   if (string.IsNullOrEmpty(grade))
   {
    Console.WriteLine("年级不能为空，请重新输入。");
    continue;
   }

   if (string.IsNullOrEmpty(subject))
   {
    Console.WriteLine("课程不能为空，请重新输入。");
    continue;
   }

   if (score < 0 || score > 100)
   {
    Console.WriteLine("成绩必须在0到100之间，请重新输入。");
    continue;
   }

   // 创建学生信息对象并添加到列表
   StudentInformation studentInfo = new StudentInformation(name, 0, score, subject);
   studentList.Add(studentInfo);

   // 提示是否确定当前学生成绩信息
   Console.WriteLine($"你输入的学生成绩是： 姓名： {name}，年级： {grade}，科目： {subject}，成绩： {score}。\n输入 \"y\" 确定， \"n\" 重新输入。");

   string input = Console.ReadLine();
   
if (input == "y" || input == "Y")
   {
    Console.WriteLine("已添加");

    // 实例化写入读取类并调用保存方法
    WriteReadModules writeReadModules = new WriteReadModules();
    writeReadModules.SaveStudentInformation(name, grade, subject, score);
    Console.WriteLine("请输入下一条学生成绩信息，或输入 \"exit\" 退出。");
   }
   else if(input == "n" || input == "N")
   {
Console.WriteLine("请重新输入学生成绩信息。\n格式为:名字，年级，课程，成绩。\n中间用中英文逗号: \",，\" 或者句号 \".。\"分隔。");
   }
   else
   {
    Console.WriteLine("输入无效，请输入 \"y\" 确定， \"n\" 重新输入。");
   }
   continue;

  }
 }
}
