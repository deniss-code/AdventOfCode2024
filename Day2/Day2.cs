using System.IO;

class Day2
{ 
    static void Main() {

    List<int> numbers = [];
    string line;
    int safe = 0;
    bool stillSafe = false;

    {
        try
        {
            //Pass the file path and file name to the StreamReader constructor
            var sr = new StreamReader("C:/Users/cluni/Documents/Coding/AdventOfCode2024/Day2/input.txt");
            //Read the first line of text
            line = sr.ReadLine();
            //Continue to read until you reach end of file
            while (line != null)
            {   
                var values = line.Split(" ");
                // Console.WriteLine(values[0]);
                for (int i = 0; i < values.Length; i++)
                {
                    numbers.Add(int.Parse(values[i]));
                }
                
                
                Array.Clear(values);
                int[] output = numbers.ToArray();
                numbers.Clear();
                
                if (output[1] > output[0])
                {
                    for (int i = 1; i < output.Length; i++)
                    {
                        if (output[i] > output[i - 1] && (Math.Abs(output[i] - output[i - 1])) <= 3 && (Math.Abs(output[i] - output[i - 1])) >= 1)
                        {
                            stillSafe = true;
                        }
                        else
                        {
                            stillSafe = false;
                            break;
                        }
                    }
                }
                else if (output[1] < output[0])
                {
                    for (int i = 1; i < output.Length; i++)
                    {
                        if (output[i] < output[i - 1] && (Math.Abs(output[i] - output[i - 1])) <= 3 && (Math.Abs(output[i] - output[i - 1])) >= 1)
                        {
                            stillSafe = true;
                        }
                        else
                        {
                            stillSafe = false;
                            break;
                        }
                    }
                }
                Array.Clear(output);
                if (stillSafe == true)
                {
                    safe++;
                    stillSafe = false;
                }
                line = sr.ReadLine();
                
            }

            //close the file
            sr.Close();
            Console.WriteLine(safe);
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }




    }
    }
}