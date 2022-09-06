string[] UserStringArray(int element)       //метод заполнение масива строк по задданому количеству строк
{
    string[] array = new String[element];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} строку массива:");
        array[i] = "" + Console.ReadLine();
    }
    return array;
}

void ShowStringArray(string[] arr)          //метод вывода массива строе с указанием номера строки
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"{i + 1}: |{arr[i]}|");
    }
}

Console.WriteLine("Создадим массив из строк сколько строк вы хотите добавить в массив?"); 
Console.Write("Введите число целое число от 1 до 10: ");
int userLength = Convert.ToInt32(Console.ReadLine());      //запрашиваем какой размер массива создавать
while (userLength > 10 || userLength < 1)                  //проверяем пользователь указал число из заданного диапазона или нет
{                                                          //если нет повторяем запрос
    Console.WriteLine("Ой! Вы ввели число вне диапазона, попробуйте еща раз.");
    Console.Write("Введите число целое число от 1 до 10: ");
    userLength = Convert.ToInt32(Console.ReadLine());
}

string[] userArr = UserStringArray(userLength);        //создаем массив указзанной длинны и с помощью метода просим его заполнить

int linesNeed = 0;                                     //поиск количества нужных чтрок длинной до 3х символов
for (int i = 0; i < userArr.Length - 1; i++)
    if (userArr[i].Length <= 3) linesNeed++;

string[] finishArr = new string[linesNeed];            //создаем массив нужной длянны

for (int i = 0, j = 0; i < userArr.Length - 1; i++)    //повторно проходимся по массиву пользователя и копируем строки до 3х 
    if (userArr[i].Length <= 3)                        //символов в новый массив
    {
        finishArr[j] = userArr[i];
        j++;
    }
Console.WriteLine();                                   //отступаем строку
ShowStringArray(finishArr);                            //выводим получившийся массив



