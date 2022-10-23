﻿/*Итак, задача. Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к»
заменить большими «К», а большие «С» заменить на маленькие «с». */

//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = “qwerty”
// 012345

// s[3] // r

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;       //инициализация пустой строки

    int length = text.Length;           //чтобы получить длину строки
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;     // вернуть результат
}
string newText = Replase(text, ' ', '|');
Console.WriteLine(newText);      // показываем результат 
newText = Replase(newText, 'к', 'К');
Console.WriteLine(newText);     // показываем результат 
newText = Replase(newText, 'С', 'с');
Console.WriteLine(newText);     // показываем результат 