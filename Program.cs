//1. String ustida amallar ishla
Console.Write("Iltimos biror son kiriting:");
int x = Convert.ToInt32(Console.ReadLine());
string str = "komPyuter";

int strLen = str.Length;

if (x > strLen)
{
    str = str.ToUpper();
}
else
{
    str = str.ToLower();
}

Console.WriteLine(str);  // Output: "kompyuter"
//2. Quyida ternary operator bilan ifodalandan qiymatni if-else yordamida ifodalang.
Console.Write("Iltimos birinchi sonni kiriting:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Iltimos ikkinchi sonni kiriting:");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("x is greater than y");
}
else if (b > a)
{
    Console.WriteLine("x is less than y");
}
else if (a == b)
{
    Console.WriteLine("x is equal to y");
}
else
{
    Console.WriteLine("x and y are not comparable");
}
//3. Consoleda o’zbek tilida kiritilgan hafta kunini ingliz tiliga o’girib, natijani ekranga chiqaradigan dastur tuzing. Switch expression dan foydalaning!
// O'zbek tilida hafta kunini kiritish lozim
Console.Write("Hafta kunini kiriting (o'zbek tilida): ");
string uzbekDay = Console.ReadLine();

// Kiritilgan hafta kunini ingliz tiliga o'girish
string englishDay = uzbekDay switch
{
    "Dushanba" => "Monday",
    "Seshanba" => "Tuesday",
    "Chorshanba" => "Wednesday",
    "Payshanba" => "Thursday",
    "Juma" => "Friday",
    "Shanba" => "Saturday",
    "Yakshanba" => "Sunday",
    _ => "Noto'g'ri hafta kuni"
};

// Natijani chop etish
Console.WriteLine("Ingliz tilida: " + englishDay);