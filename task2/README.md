# Задача №2 Дипломного проекта

<b>*Задача:* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.</b>

Решение состоит из 3-х функций:
1. **CreateArray;**
2. **ShowArray;**
3. **CheckArray;**

### CreateArray function

В данной функции мы изначально задаём величину массива из строк и затем вводим значения от пользователя через терминал.
> Дополнительно прописывает условие, что величина массива не может быть равна или быть меньше 0.

### ShowArray function

Данная функция беребирает по очереди каждый элемент введённого массива, после чего выводит весь массив в терминал.

### CheckArray function

Последняя функция проверяет каждый элемент массива на выполнение условния: длина строки введённого значения должна быть меньше либо равна 3. Если условие выполняется, то данное значние выводим в терминал и в итоге получаем новый массив.