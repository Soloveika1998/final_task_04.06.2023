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

//Метод создания массива строк из исходного массива строк с удалением строк больше 3 символов
string [] RemoveLargeStringsInArrayStrings (string [] array)
{
  int count=0;
  string [] returnArray = new string [count];
  string [] returnArrayTemp;

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length < 4)
    {
      count++;
      returnArrayTemp = new string [count];
      
      for (int j = 0; j < returnArrayTemp.Length-1; j++)
        returnArrayTemp[j] = returnArray[j];

      returnArrayTemp [count-1] = array[i];
      returnArray = returnArrayTemp;
    }
  }
  return returnArray;
}