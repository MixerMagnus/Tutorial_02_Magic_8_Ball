using System;
using System.Threading;

namespace Magic_8_Ball
{
    class MainClass
    {
        static void Main(string[] args)
        {
                //Preserve console color First
			ConsoleColor OldFGC = Console.ForegroundColor;
			ConsoleColor OldBGC = Console.BackgroundColor;

			TellPeopleWhatProgramThisIs();

			    //Create a randomizer
            Random randomObject = new Random();



                //Forever loop. This will run forever
			while(true)
			{
				string questionString = GetQuestionFromUser();

                    //Make system 'Think' before answering
				int NumberOfSecondsToSleep = randomObject.Next(4) + 1;
				Console.WriteLine("Let me speak to the spirits...");
				Thread.Sleep(NumberOfSecondsToSleep * 1000);

				if( questionString.Length == 0)
				{
					Console.WriteLine("Please type a question");
                        //Continue command jumps to the end of the loop and re starts it
					continue;
				}

				if( questionString.ToLower() == "you suck")
				{
					Console.WriteLine("Don't be mean");
					continue;
				}

                    //See if the user typed "quit" as the question
                    //we want to use this to break the loop

                    //convert all input to lower case
                    //This is case sensitive so this forces all text to lower case
				if(questionString.ToLower() == "quit")
				{
					break;
				}

				    //Get a random number (to use later)
				int randomNumber = randomObject.Next(4);
				Console.ForegroundColor = (ConsoleColor)randomNumber;
                    //Use a switch statement
                    //Switch statement is like a one lined trigger
                    //When you flip that specific switch, a certain outcome comes in.



                    //Switch is using a random number to determine a response
				switch(randomNumber)
				{
					case 0:
						{
							Console.WriteLine("Yes!");
							break;
						}
					case 1:
						{
							Console.WriteLine("Nah Fam!");
                            break;
						}
					case 2:
						{
							Console.WriteLine("I aint Feelin it");
                            break;
						}
					case 3:
						{
							Console.WriteLine("Sure...but really, no");
                            break;
						}
				}



				//Demo randomizer
				//Console.ForegroundColor = ConsoleColor.White;
				//Console.WriteLine("{0}", randomObject.Next(10)+1);
	
			}

			    //Cleaning up the font and resetting
			Console.ForegroundColor = OldFGC;
			Console.BackgroundColor = OldBGC;
        }
            /// <summary>
            /// This will tell people what the program is and who created it.
            /// </summary>
		static void TellPeopleWhatProgramThisIs()
		{
			    //Changing console colors to preference
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Magic 8 ball (by: Kyler)");
			Console.WriteLine("Type 'Quit' to end the program)");
		}
        
        /// <summary>
        /// This function will return the question the user types.
        /// </summary>
        /// <returns>The question from user.</returns>
		static string GetQuestionFromUser()
		{
			//Instricting the user to interact and ask a question
            //This will also store the question in a string
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Ask a question?: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string questionString = Console.ReadLine();

			return questionString;
		}

    }
}
