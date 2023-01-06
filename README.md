1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

![bloke](https://user-images.githubusercontent.com/116267719/209050660-dd1e62cf-b562-4fb2-a907-544a2a31f50d.jpg)

## Блок-схема max number.

1. Пользователя просят ввести три числа именуевые "А", "В" и "С". И создаём переменную "мах" равную 1.
2. Программа сравнивает переменную "мах" со значение числа "А", если оно больше, то в переменную "мах" записывает число "А". И переходит к сравнению с числом "В". Если перемененная не изменилась, то сразу переходим к числу "В".
3. Далее сравнивается переменная "мах" с числом "В". Если "мах" больше чем "В", то переходим к числу "С". Если число "В" является большем чем "мах", то в переменную "мах" записываем значение числа "В" и переходим к числу "С".
4. В этом пункте сравниваем  значение переменной "мах" со значение числа "С", и если число "С" оказывается больше значения переменной "мах", то записываем его значение в переменную.
5. Печатаем, либо выводим на экран, значение переменной "мах".
6. Выход из прграммы.

## Код C#
~~~C#
Console.WriteLine("Введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = 1;
if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;
Console.Write("max= ");
Console.WriteLine(max);
~~~
