using System;
using System.IO;

public class FileInput
{
    private StreamReader reader = null;
    private string fileName;

    public FileInput(string fileName)
    {
        this.fileName = fileName;
        try
        {
            reader = new StreamReader(fileName);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine("File Open Error: " + fileName + " " + e);
        }
    }

    public void FileRead()
    {
        string line;
        try
        {
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("File Read Error: " + fileName + " " + e);
        }
    }

    public string FileReadLine()
    {
        try
        {
            return reader.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine("File Read Error: " + fileName + " " + e);
            return null;
        }
    }

    public void FileClose()
    {
        if (reader != null)
        {
            try
            {
                reader.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("File Close Error: " + fileName + " " + e);
            }
        }
    }
}