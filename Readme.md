# РЕШЕНИЕ ИТОГОВОГО ЗАДАНИЯ ВВОДНОГО БЛОКА
### **ЗАДАЧА:** Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Для решения данной задачи необходимо создать **3 метода**, а именно:
1. Метод создания исходного массива строк и заполнения его с клавиатуры;
2. Метод перебора исходного массива строк, удаления из него строк, в которых содержится свыше 3-х символов и создания на основе оставшихся строк нового массива строк;
3. Метод печати массива строк.

## Метод создания исходного массива строк и заполнения его с клавиатуры.

Первый метод ничего не принимает и возвращает массив строк **string []**. Для решения данной задачи необходимо было создать **два массива**, а именно:
1. **Основной**, который будет возвращать метод;
2. **Временный** - для записи значений строк, вводимых с клавиатуры и передачи их в основной массив.

Для решения задачи использовался цикл **Do While**. В теле цикла осуществлялся ввод строки с клавиатуры и записывался в переменную **s**. Далее осуществлялась проверка условием **if** на пустую строку. Если строка была заполнена, то счеткик **count** (изначально равен 0), который используется для подсчета строк в массиве, увеличивался на единицу. Далее мы инициаизировали временный массив **arrayStringTemp** с размером **count**. 

Далее использовался цикл **for** для перезаписи исходного массива во временный. После этого на последний индекс временного массива записывалось текущее значение переменной **s**

Далее перенаправляем ссылку с arrayString на arrayStringTemp. 

Таким образом происходило заполнение массива с клавиатуры.

## Метод перебора исходного массива строк, удаления из него строк, в которых содержится свыше 3-х символов и создания на основе оставшихся строк нового массива строк.

Данный метод возвращает массив строк и принимает также массив строк.
Для решения данной задачи так было необходимо создать **2 массива**, а именно:
1. **Основной**, который будет возвращать метод;
2. **Вспомогательный** - для записи значений в цикле.

Для начала необходимо было пройтись по всем строкам исходного массива, для этого использовался цикл **for (int i = 0; i < array.Length; i++)**. 

В теле цикла было условие **if (array[i].Length < 4)**, проверяющее длину каждой строки на соответствие условию задачи, причем в расчет длины входили символы пробела, скобки и т.п.

Если условие выполнялось, то происходила аналогичная ситуация как в методе FillArray, а именно счеткик **count** (изначально равен 0), который используется для подсчета строк в массиве, увеличивался на единицу. Далее мы инициаизировали временный массив **returnArrayTemp** с размером **count**. 

Далее использовался цикл **for** для перезаписи исходного массива *returnArray* во временный *returnArrayTemp*. После этого на последний индекс временного массива записывалось текущее значение массива с индексом *i*.

После этого перенаправляем ссылку массива returnArray = returnArrayTemp;
Таким образом создавался новый массив со строками не больше 3 символов.

## Метод печати массива строк.

Этот метод ничего не возвращает, но на вход принимает массив строк. Здесь использовался цикл for для перебора элементов массива. Командой Console.WriteLine выводим данные в терминал.
