
namespace StManager;

public class TimeModules
{

 public void TimeNow()
 {

  // 当前时区
  TimeZoneInfo zoneInfo = TimeZoneInfo.Local;

  // 当前时间
  DateTime timeNow = DateTime.Now;

  //周几
  string dayOfWeek = timeNow.ToString("dddd", new System.Globalization.CultureInfo("zh-CN"));

  Console.WriteLine($"当前时区： {zoneInfo}");
  Console.WriteLine($"当前时间： {timeNow.ToString("yyyy年M月d日 H点m分s秒")}， {dayOfWeek}");

 }
}
