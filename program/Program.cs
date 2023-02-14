// Создание рандомного массива


// функиця показа массива
void ShowArray(string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

string [] massive1 =    {"vvv", "ggg", "111", "ghbdtn"};
ShowArray (massive1);
string [] massive2 = new string[massive1.Length];
int count =0;
for (int i=0; i<massive1.Length; i++){
    if (massive1[i].Length<=3){
        massive2[count]=massive1[i];
        count++;
    }
}
Console.WriteLine();
ShowArray (massive2);