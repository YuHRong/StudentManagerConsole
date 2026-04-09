

namespace StManager;

// 学生类
public class StudentInformation
{
 private string studentName;    // 姓名
 private int studentNumId;    // 学号
 private double score;    // 成绩
 private string grade;    // 年级
 public string subject;    // 科目

 public StudentInformation(string name, int numId, double score, string subject)
 {
  this.studentName = name;
  this.studentNumId = numId;
  this.score = score;
  this.grade = grade;
  this.subject = subject;
 }

 // 属性访问器
 public string name
 {
  get { return studentName; }
  set { studentName = value; }
 }

 public int numId
 {
  get { return studentNumId; }
  set { studentNumId = value; }
 }

 public double scoreValue
 {
  get { return score; }
  set { score = value; }
 }

 public string gradeValue
 {
  get { return grade; }
  set { grade = value; }
 }


 // 全局学生信息列表
 public static List<StudentInformation> studentList = new List<StudentInformation>();
}
