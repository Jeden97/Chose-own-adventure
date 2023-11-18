using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      
      /* THE MYSTERIOUS NOISE */
      bool decision = true;
      // Start by asking for the user's name:
      Console.Write("What is your name?: ");

      string name = Console.ReadLine().ToLower();
      
      Console.WriteLine($"Hello, {name}! Welcome to our story.");

     Console.WriteLine("\n It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate? \n");
     
     Console.WriteLine("\n Type Yes to continue or No to stop: \n");
     string noiseChoice = Console.ReadLine();

     if (noiseChoice.ToLower() == "no"){
      decision = false;
      Console.WriteLine("\n You Chose No. GoodBye.");
     } else {
      Console.WriteLine("\n You walk into the hallway and see a light coming from under a door down the hall.You walk towards it. Do you open it or knock? \n");
    }

    Console.WriteLine("Type Open or Knock: \n");

    string doorChoice = Console.ReadLine().ToUpper();
    if (doorChoice == "KNOCK") {
      Console.WriteLine(" A voice behind the door speaks.\n It says Answer this riddle: \n Poor people have it. Rich people need it. If you eat it you die. What is it? \n");
      Console.WriteLine("Type your answer: ");
      string riddleAnswer = Console.ReadLine().ToUpper();

        if(riddleAnswer == "NOTHING"){
          Console.WriteLine("The door opens and NOTHING is there. You turn off the light and run back to your room and lock the door. THE END.");
        } else {
          Console.WriteLine("Wrong Goodbye!");
        }

    } else if (doorChoice == "OPEN") {
      Console.WriteLine("The door is locked! See if one of your three keys will open it. \n");


      Console.WriteLine("Enter a number (1-3): ");
      string keyChoice = Console.ReadLine();
      switch(keyChoice){
        case "1" :
            Console.WriteLine("You choose the first key. Lucky choice! The door opens and NOTHING is there. Strange... THE END.");
            break;
        case "2" :
            Console.WriteLine("You choose the second key. The door doesn't open. THE END.");
            break;
        case "3" :
            Console.WriteLine("You choose the third key. The door doesn't open. THE END.");
            break;
      } 

    }


    }
  }
}