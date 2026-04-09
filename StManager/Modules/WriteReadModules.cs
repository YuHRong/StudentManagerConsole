using System;
using System.IO;
using System.Text;
using StManager;


namespace StManager;

public class WriteReadModules
{

 // 创建写入文件方法
 public void SaveStudentInformation(string name, string subject, string grade, double score)
 {

  // 创建 Data 目录
  string dataPath = "Data";

  // 创建 StudentInformation 文件
  string fileName = "StudentInformation.txt";

  // 合并 目录和文件
  string filePath = Path.Combine(dataPath, fileName);

  // 检查目录是否存在，如果不存在就创建目录
  if (!Directory.Exists(dataPath))
  {
   Directory.CreateDirectory(dataPath);
  }

  // 写入文件
  using (StreamWriter writer = new StreamWriter(filePath, true, Encoding.UTF8))
  {
   writer.WriteLine($"{name}, {subject}, {grade}, {score}");
  }

  // 获取保存文件路径进行输出提示
  string filePathName = Path.GetFullPath(filePath);

  Console.WriteLine($"文件已保存在： {filePathName}");
 }

 // 创建文件读取方法
 public void FilesRead()
 {

  // 打开文件并读取
  string dataPath = "Data";
  string fileName = "StudentInformation.txt";
  string filePath = Path.Combine(dataPath, fileName);

  // 便利编号并显示成绩信息

  if (!File.Exists(filePath))
  {
   Console.WriteLine("没有找到成绩文件。");
   return;
  }
  var lines = File.ReadAllLines(filePath);
  Console.WriteLine("学生成绩列表如下:");
  foreach (var line in lines)
  {
   Console.WriteLine(line);
  }

  Console.WriteLine("按回车返回主菜单...");
  Console.ReadLine();
 }
}