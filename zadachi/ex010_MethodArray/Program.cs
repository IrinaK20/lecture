int [] array = {13,12,23,14,5,66,47,98};

int n = array.Length;

int find = 23;

int index= 0;

while(index<n)
{
 if(array[index]==find)
 {
    Console.WriteLine(index);
    break; // прерви, останови работу 
           // это если несколько одинаковых элементов, так он остановится на первом найденом 
 }
    index++;
}