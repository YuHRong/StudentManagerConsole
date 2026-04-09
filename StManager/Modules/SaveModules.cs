
//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.IO;
//using System.Text;
//using StManager;

//namespace StManager;

//public class SaveModules
//{

// public static void SaveStudentInformation(string name, string grade, string subject, double score)
// {

//  // 创建 Data 目录
//  string dataPath = "Data";
//  string fileName = "StudentInformation.txt";
//  string filePath = Path.Combine(dataPath, fileName);

//  // 确保目录存在
//  if (!Directory.Exists(dataPath))
//  {
//   Directory.CreateDirectory(dataPath);
//  }

//  // 写入文件
//  using (StreamWriter writer = new StreamWriter(filePath, true, Encoding.UTF8))
//  {
//   writer.WriteLine($"{name},{grade},{subject},{score}");
//  }

//Console.WriteLine($"学生信息已保存到文件：{filePath}");
// }
//}
