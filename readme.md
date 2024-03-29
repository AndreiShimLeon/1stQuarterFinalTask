# Итоговая проверочная работа.
Работа расположена в [репозитарии GitHub](https://github.com/AndreiShimLeon/1stQuarterFinalTask.git).

## Функции программы.
Данная программа преобразует имеющийся массив строк в массив строк, длина которых не превышает 3 символа.
Предусмотрены создание массива и его заполнение пользователем.

## Алгоритм выполнения программы.
### Коротко о работе программы:
1. Программа запрашивает, какое количество элементов должно содержаться в массиве;
2. Программа просит пользователя поэтапно вводить элементы массива через терминал;
3. Программа выводит на экран получившийся массив;
4. Программа спрашивает, какую длину элемента принять за ограничение;
5. Программа выводит на экран новый массив с элементами, длина которых меньше или равна заданной длине (пункт 4).
### Создание массива. 
Массив создается в два этапа:
1. Пользователь вводит с клавиатуры размер массива;
2. Пользователь вводит каждый элемент массива с клавиатуры. Реализация через цикл *for*.
### Преобразование массива.
1. После создания массива программа запрашивает у пользователя, какую длину выбрать, чтобы "отфильтровать" массив. Это целое число затем используется в нескольких методах как *cut-off*.
2. В методе *RemoveBigElements* программа создает новый преобразованны массив с элементами не больше заданной длины.
   * Для его создания требуется знать длину создаваемого массива. Для этого используется метод *CountingSpecificLengthElements*. На входе метод имеет массив строк и целое число, которое используется в качестве предельной длины элементов. Этот метод проводит сравнение длины каждого элемента строкового массива с предельной длиной элемента с помощью цикла *for* и другого метода *ElementIsBig*. Если длина элемента не больше заданной длины, то счетчик увеличивается. После окончания цикла метод возвращает счетчик;
   * Метод *ElementIsBig* проводит сравнение длины строки с заданной длиной. Если строка длиннее, то метод возвращает *true*, иначе - *false*.
3. С помощью цикла *for* метод *RemoveBigElements* проводит проверку каждого элемента оригинального массива. Если длина проверяемого элемента меньше или равна предельной длине, то этот элемент записывается в новый массив. После окончания цикла метод возвращает новый массив, состоящий из элементов оригинального массива, длина которых меньше или равна заданной пользователем длине. 
### Печать результатов.
Во время своей работы программа выводит промежуточные данные на экран.
1. После введения размера массива и всех элементов массива пользователем с клавиатуры на экран выводится получившийся массив из строк;
2. После введения ограничительной длины для элементов программа выводит полученный массив из строк, длина которых не превышает ограничительную длину. 

Печать массивов реализована с помощью метода *PrintStrArray*. Сам метод использует цикличное выведение каждого элемента массива на экран одной строкой. 
## Используемые методы:
1. Метод печатает в терминале *text* и возвращает целое число: 
```C# 
int ReadInt(string text) 
```
2. Метод печатает в терминале *text* и возвращает строку:  
```C# 
string ReadString(string text)
```
3. Метод считывает в терминале строковые элементы массива длиной *length* и возвращает строковый массив:  
```C# 
string[] ReadStringArray(int length)
```
4. Метод печатает строковый массив с припиской *text*:  
```C# 
void PrintStrArray (string[] array, string text)
```
5. Метод проверяет, является ли длина строки *element* больше, чем *length*. Если строка длиннее, то метод возвращает *true*, иначе - *false*.  
```C# 
bool ElementIsBig (string element, int length)
```
6. Метод возвращает число элементов строкового массива, длина которых меньше или равна *length*: 
```C# 
int CountingSpecificLengthElements(string [] array, int length)
```
7. Метод принимает на входе строковый массив и целое число *cutOffLength*, а затем возвращает новый строковый массив, состоящий из элементов, длина которых меньше или равна *cutOffLength*:
```C# 
string[] RemoveBigElements(string [] array, int cutOffLength)
```

