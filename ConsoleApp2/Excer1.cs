using System;

public class MainClass {

    public static void CreateFile(string filePath) {
        using (File.Create(filePath)) 
        {
            Console.WriteLine("File created successfully.");
        }
        
    }

    public static void WriteToFile(string filePath, string content) {
        File.WriteAllText(filePath, content);
    }

    public static void ReadFromFile(string filePath) {
        try
        {
            string content = File.ReadAllText(filePath);
            Console.WriteLine($"File content: {content}");
        }
        catch (System.Exception)
        {
            Console.WriteLine($"An error occurred while reading");
        }
    }

    public static void AppendToFile(string filePath, string content) {
        File.AppendAllText(filePath, content);
        Console.WriteLine("Content appended successfully.");
    }

    public static void DeleteFile(string filePath) {
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
            Console.WriteLine("File deleted successfully.");
        }
        else
        {
            Console.WriteLine("The file does not exist.");
        }
    }

    // public static void Main(string[] args) {
    //     string FilePath = "data2.txt";
    //     // CreateFile(FilePath);
    //     // WriteToFile(FilePath, "Hello Bitch!");
    //     // ReadFromFile(FilePath);
    //     // AppendToFile(FilePath, " How's the weather today?");
    //     DeleteFile(FilePath);
    // }


}
