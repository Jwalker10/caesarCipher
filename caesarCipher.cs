// See https://aka.ms/new-console-template for more information
namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      // procures message to be encrypted from user
      Console.Write("Enter your message: ");
      string? input = Console.ReadLine();
      // if statement to make sure null value isnt passed into program.
      if (input == null) 
      {
        Console.WriteLine("Error: null value entered!");
        return;
      } 
      string message = input;

      // call encryption method
      string secretMessageEncrypted = Encrypt(message);
      Console.WriteLine(secretMessageEncrypted);
      
    }

    static string Encrypt(string message) 
      {
      // Char array of alphabet
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      
      // returns message for now to stop errors being thrown!
      string encryptedString = message;
      return encryptedString;
      }
  }
}