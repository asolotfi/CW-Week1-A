using System.Text;
Console.OutputEncoding = Encoding.UTF8;


//می‌توانی از float هم استفاده کنی، اما در C# معمولاً برای محاسباتی مثل مساحت دایره از double استفاده می‌شود، چون دقت بیشتری دارد.

//double pi = Math.PI;
string sentence0 = "محاسبه مساحت دایره";
Console.WriteLine("====================================================");
Console.WriteLine("           🧮" + new string(sentence0.Reverse().ToArray()) + "🧮      ");
Console.WriteLine("====================================================");
const double pi = 3.14;
string sentence = " لطفا شعاع دایره را وارد کنید:";
Console.SetCursorPosition(8, Console.CursorTop);//تنظیم دقیق محل نمایش
Console.WriteLine(new string(sentence.Reverse().ToArray()));//نمایش درست فونت فارسی
Console.WriteLine("");
Console.SetCursorPosition(22, Console.CursorTop);
double radius = Convert.ToDouble(Console.ReadLine());
double area = pi * radius * radius;
Console.WriteLine("");
string sentence1 = "  شعاع دایره برابر است با : ";
Console.SetCursorPosition(4, Console.CursorTop);
Console.WriteLine(area + new string(sentence1.Reverse().ToArray()) + "✅");

Console.WriteLine("");


string sentence02 = "تبدیل واحد دما";
Console.WriteLine("=====================================================");
Console.WriteLine("            🌡️  " + new string(sentence02.Reverse().ToArray()) + "  🌡️    ");
Console.WriteLine("=====================================================");
string sentence2 = "دمای هوا را به درجه سانتیگراد وارد کنید :";
Console.SetCursorPosition(3, Console.CursorTop);
Console.WriteLine(new string(sentence2.Reverse().ToArray()));
Console.WriteLine("");
Console.SetCursorPosition(22, Console.CursorTop);
double celsius = Convert.ToDouble(Console.ReadLine());
double fahrenheit = (celsius * 9 / 5) + 32;
string sentence4 = "دمای هوا به سانتی گراد:";
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.White;//مشخص کردن رنگ
Console.SetCursorPosition(10, Console.CursorTop);
Console.WriteLine(fahrenheit + new string(sentence4.Reverse().ToArray()));
Console.ResetColor();

Console.WriteLine("");
string sentence03 = "محاسبه میانگین چند عدد";
Console.WriteLine("\n====================================================");
Console.WriteLine("          ➕"    + new string(sentence03.Reverse().ToArray()) + " ➕      ");
Console.WriteLine("=====================================================");
string sentence6 = "عدد اول وارد کنید :";
Console.SetCursorPosition(15, Console.CursorTop);
Console.WriteLine(new string(sentence6.Reverse().ToArray()));
Console.SetCursorPosition(24, Console.CursorTop);
double outPut1 =Convert.ToDouble( Console.ReadLine());
string sentence7 = "عدد دوم وارد کنید :";
Console.SetCursorPosition(15, Console.CursorTop);
Console.WriteLine(new string(sentence7.Reverse().ToArray()));
Console.SetCursorPosition(24, Console.CursorTop);
double outPut2 = Convert.ToDouble(Console.ReadLine());
string sentence8 = "عدد سوم وارد کنید :";
Console.SetCursorPosition(15, Console.CursorTop);
Console.WriteLine(new string(sentence8.Reverse().ToArray()));
Console.SetCursorPosition(24, Console.CursorTop);
double outPut3 = Convert.ToDouble(Console.ReadLine());
string sentence9 = "عدد چهارم وارد کنید :";
Console.SetCursorPosition(15, Console.CursorTop);
Console.WriteLine(new string(sentence9.Reverse().ToArray()));
Console.SetCursorPosition(24, Console.CursorTop);
double outPut4 = Convert.ToDouble(Console.ReadLine());
string sentence10 = "عدد پنجم وارد کنید :";
Console.SetCursorPosition(15, Console.CursorTop);
Console.WriteLine(new string(sentence10.Reverse().ToArray()));
Console.SetCursorPosition(24, Console.CursorTop);
double outPut5 = Convert.ToDouble(Console.ReadLine());
double sum = outPut1 + outPut2 + outPut3 + outPut4 + outPut5;
double average = sum / 5;
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Yellow;
string sentence11 = "جمع:";
Console.WriteLine("");
Console.SetCursorPosition(23, Console.CursorTop);
Console.WriteLine(average + new string(sentence11.Reverse().ToArray()));
Console.ResetColor();

Console.WriteLine("");

string sentence04 = "تشخیص زوج یا فرد بودن عدد";
Console.WriteLine("========================================================");
Console.WriteLine("           📊" + new string(sentence04.Reverse().ToArray()) + " 📊      ");
Console.WriteLine("========================================================");
string sentence13 = "یک عدد وارد کنید";
Console.SetCursorPosition(17, Console.CursorTop);
Console.WriteLine(new string(sentence13.Reverse().ToArray()));
Console.SetCursorPosition(25, Console.CursorTop);
double number = Convert.ToDouble(Console.ReadLine());
Console.SetCursorPosition(20, Console.CursorTop);
if (number % 2 == 0)
    Console.WriteLine("number is Even");
else
    Console.WriteLine("Number is Odd");

Console.WriteLine("");

string sentence20 = " محاسبه حقوق کارمندان ";
string sentence18 = ":ساعت  کاری وارد کنید";
string sentence19 = ":ساعت اضافه کاری وارد کنید";
string sentence21 = "حقوق پایه شما ==<";
string sentence22 = "مبلغ اضافه کاری شما ==<";
string sentence23 = "مبلغ مالیات شما ==<";
string sentence24 = "مبلغ حقوق کل شما ==<";
string sentence25 = "لطفاً اعداد معتبر وارد کنید.";
Console.WriteLine("==========================================================");
Console.WriteLine("            " + "💼" + new string(sentence20.Reverse().ToArray()) + "💼");
Console.WriteLine("==========================================================");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write(new string(sentence18.Reverse().ToArray()));
Console.ResetColor();
double workingHours = Convert.ToDouble(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write(new string(sentence19.Reverse().ToArray()));
Console.ResetColor();
double extraHours = Convert.ToDouble(Console.ReadLine());
double hourlyRate = 100000;
double overtimeRate = (double)(hourlyRate * 1.5);
if (workingHours >= 0 && extraHours >= 0)
{
    double baseSalary = workingHours * hourlyRate;
    double overtimeSalary = extraHours * overtimeRate;
    double tax = (float)(baseSalary * 0.1);
    double totalSalary = baseSalary - tax + overtimeSalary;
    Console.WriteLine("------------------------------------------------------");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(baseSalary + new string(sentence21.Reverse().ToArray()));
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(overtimeSalary + new string(sentence22.Reverse().ToArray()));
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(tax + new string(sentence23.Reverse().ToArray()));
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(totalSalary + new string(sentence24.Reverse().ToArray()));
    Console.ResetColor();
    Console.WriteLine("-------------------------------------------------------");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(new string(sentence25.Reverse().ToArray()));
    Console.ResetColor();
}
