// Ссылка на блок-схему метода https://drive.google.com/file/d/1PGtPI5Lxk7jsmRg2_0GFyB7Z2L7y2Ax4/view?usp=sharing
//Метод заполнения массива строк с клавиатуры (для окончания ввода необходимо ввести пустую строку)

string [] FillArrayString ()
{
  int count = 0;
  string [] arrayString = new string [count];
  string [] arrayStringTemp;
  string s;

  Console.WriteLine("Введите строки с клавиатуры");
  do
  {
    s = Console.ReadLine();
    
    if (s != "")
    {
      count++;
      arrayStringTemp = new string [count];
      
      for (int i = 0; i < arrayStringTemp.Length-1; i++) //копируем во вспомогательный массив основной массив
        arrayStringTemp[i] = arrayString[i];

      arrayStringTemp [count-1] = s; //записываем во вспомогательный массив новую строку

      arrayString = arrayStringTemp; //перенаправляем ссылку с arrayString на arrayStringTemp
    }
  } while (s != "");
  return arrayString;
}

//Метод печати массива строк
void PrintArray (string [] array)
{
  for (int i = 0; i < array.Length; i++)
        Console.WriteLine("#[{0}] = {1}", i, array[i]);
}
