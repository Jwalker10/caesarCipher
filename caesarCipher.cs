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

      // call decryption method
      string secretMessageDecrypted = Decrypt(secretMessageEncrypted);
      Console.WriteLine(secretMessageDecrypted);
      
    }

    static string Encrypt(string message) 
      {
      // Char array of alphabet
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

      // configures message ready for encryption
      string messageConfigured = message.ToLower();

      // captures message as an array of characters 
      char[] secretMessage = messageConfigured.ToCharArray();
      // tests message has been captured succesfully
      /* foreach (char character in secretMessage) 
      {
        Console.Write(character);
      }; */

      // initializes empty char array to hold encrypted message
        char[] encryptedMessage = new char[secretMessage.Length];
        // checks length of encryptedMessage is identical to secretMessage array
        // Console.Write(encryptedMessage.Length);

        // iterates through each char in secretMessage finding and accessing the index of the char within alphabet adding three and accessing the char at the resulting index then pushing that encrypted char to encryptedMessage
        for (int i = 0; i < secretMessage.Length; i++) 
        {
          bool isSpecialCharacter = Char.IsLetter(secretMessage[i]);
          if (isSpecialCharacter != true) 
          {
            encryptedMessage[i] = secretMessage[i];
            continue;
          };
          int secretCharIndex = Array.IndexOf(alphabet, secretMessage[i]);
          int secretCharEncryptedIndex = (secretCharIndex + 3) % alphabet.Length;
          char secretCharEncrypted = alphabet[secretCharEncryptedIndex];
          encryptedMessage[i] = secretCharEncrypted;
          // checks message has been succesfully encrypted
          // Console.Write(encryptedMessage[i]);
        };

        // joins encryptedMessage to make a full stringed message and returns it to the function call
        string encryptedString = String.Join("", encryptedMessage);
        return encryptedString;
      }

      static string Decrypt(string secretMessageEncrypted) 
      {
        // Char array of alphabet
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

        // captures encrypted message as an array of characters 
        char[] encryptedMessageForDecryption = secretMessageEncrypted.ToCharArray();
        // tests message has been captured succesfully
        /* foreach (char character in encryptedMessageForDecryption) 
        {
          Console.Write(character);
        }; */

        // initializes empty char array to hold decrypted message
        char[] decryptedMessage = new char[encryptedMessageForDecryption.Length];
        // checks length of decryptedMessage is identical to encryptedMessageForDecryption array
        // Console.Write(decryptedMessage.Length);

        // iterates through each char in encryptedMessageForDecryption finding and accessing the index of the char within alphabet subtracting three and accessing the char at the resulting index then pushing that decrypted char to decryptedMessage
        for (int i = 0; i < encryptedMessageForDecryption.Length; i++) 
        {
          bool isSpecialCharacter = Char.IsLetter(encryptedMessageForDecryption[i]);
          if (isSpecialCharacter != true) 
          {
            decryptedMessage[i] = encryptedMessageForDecryption[i];
            continue;
          };
          int secretCharIndex = Array.IndexOf(alphabet, encryptedMessageForDecryption[i]);
          int secretCharDecryptedIndex = (secretCharIndex - 3) % alphabet.Length;
          char secretCharDecrypted = alphabet[secretCharDecryptedIndex];
          decryptedMessage[i] = secretCharDecrypted;
          // checks message has been succesfully Decrypted
          // Console.Write(decryptedMessage[i]);
        };

        // joins decryptedMessage to make a full stringed message and returns it to the function call
        string decryptedString = String.Join("", decryptedMessage);
        return decryptedString;
      }
  }
}