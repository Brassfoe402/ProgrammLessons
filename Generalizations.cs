using System;

public class GenericArray<T>
{
    private T[] array;

    public GenericArray(int size)
    {
        array = new T[size]; 
    }

    
    public void Add(T item, int index)
    {
        array[index] = item;
    }

    
    public void Remove(int index)
    {
        array[index] = default(T); 
    }

    
    public T Get(int index)
    {
        return array[index];
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        GenericArray<string> stringArray = new GenericArray<string>(5);
        stringArray.Add("строка1", 0);
        stringArray.Add("строка2", 1);
        stringArray.Add("строка3", 2);
        stringArray.Add("строка4", 3);
        stringArray.Add("строка5", 4);
        stringArray.Remove(3);
        Console.WriteLine(stringArray.Get(2)); 

        
        GenericArray<int> intArray = new GenericArray<int>(3);
        intArray.Add(1, 0);
        intArray.Add(2, 1);
        intArray.Add(3, 2);
        Console.WriteLine(intArray.Get(1)); 

        Console.ReadKey();
    }
}


