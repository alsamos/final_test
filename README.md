# final_test
## Задача:

*Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
коллекциями, лучше обойтись исключительно массивами*

## Решение:

**Основная программа.** Определение размера массива строк. Поочередный вызов методов 1,2,3. 

Предлагаем пользователю задать размер массива строк. Сохраняем значение в переменной типа int. Передаем это значение на вход Метода 1.

**Метод 1.** Создание массива строк.

Т.к. массив из строк, то тип массива string. На вход получаем размер массива типа int, заданный пользователем в основной программе. 
Выделяем память размера size под создаваемый массив. В цикле запрашиваем у пользователя ввод каждого i-го элемента массива строк, присваивая введенное пользователем 
значение каждому i-му элементу массива, увеличивая значение i на единицу. 
Метод возвращает полученный массив строк.

**Метод 2.** Вывод полученного массива строк на экран.

Метод типа void, ничего не возвращает. Передаем на вход массив строк типа string. Поочередно в цикле выводим на экран с помощью функции Console.Write() каждый 
i-тый элемент массива, увеличивая i на единицу. В итоге отображается весь массив строк, элементы которого введены пользователем.

**Метод 3.** Вывод массива из строк, длина которых меньше или равна 3.

Метод типа void, ничего не возвращает. Передаем на вход массив строк типа string. Поочередно в цикле выводим на экран с помощью функции Console.Write() каждый 
i-тый элемент массива, длина строки которого меньше или равна 3 (и больше нуля). Увеличивая i на единицу. Проверка длины строки производится через условие if и 
функцию Length. В итоге отображается весь массив строк, длина которых больше 0 и меньше или равна 3 символа.
