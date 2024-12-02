using System.IO;

class Day1
{
 static void Main() {
    List<int> list1 = [];
    List<int> list2 = [];
    int[] array1;
    int[] array2;
    int listFinal = 0;
    
    string line;
    try
    {
        //Pass the file path and file name to the StreamReader constructor
        var sr = new StreamReader("./input.txt");
        //Read the first line of text
        line = sr.ReadLine();
        //Continue to read until you reach end of file
        while (line != null)
        {
            var values = line.Split("   ");
            list1.Add(int.Parse(values[0]));
            list2.Add(int.Parse(values[1]));
            
            Array.Clear(values);
            //write the line to console window
            // Console.WriteLine(line);
            //Read the next line
            line = sr.ReadLine();
        }
        //close the file
        sr.Close();
        
        array1 = list1.ToArray();
        array2 = list2.ToArray();

        Array.Sort(array1);
        Array.Sort(array2);


        for (int i = 0; i < array1.Length; i++)
        {
            listFinal += Math.Abs(array1[i] - array2[i]);
            // if (array1[i] > array2[i])
            // {
            //     listFinal += array1[i] - array2[i];
            // } else if (array1[i] < array2[i])
            // {
            //     listFinal += array2[i] - array1[i];
            // }
            // else
            // {
            //     listFinal = listFinal;
            // }
        }
        Console.WriteLine(listFinal);

    }
    catch(Exception e)
    {
        Console.WriteLine("Exception: " + e.Message);
    }
    finally
    {
        Console.WriteLine("Executing finally block.");
    }
 }
}

