bool playAgain = true; // play again feature
bool playAgainResponse = true; // play again data validation feature
bool isNum1; // number validation feature

string? userAnswer; // users answer for play again
string? userNum; // users number input

int number; // this will be the user's number they input and will be converted into a console.readline
int remainder; // an int variable named remainder 
int numReverse = 0; // an int variable named numReverse. This variable will contain the final numbers reversed.

    while(playAgain == true)
    {
        playAgainResponse = true;
        number = 0; // placed these here because if I wanted to play again it would mess up 
        remainder = 0; // placed these here because if I wanted to play again it would mess up 
        numReverse = 0; // placed these here because if I wanted to play again it would mess up 

        Console.Write("Enter a number to be reversed: "); // console asks the user to enter a number to get reversed

        //number = Convert.ToInt32(Console.ReadLine()); // user inputs numbers and is converted and stored into the "number" variable
        do
        {
            userNum = Console.ReadLine();
            isNum1 = int.TryParse(userNum, out number);

            if(isNum1 != true)
            {
                Console.Write("YOU AREN'T PUTTING IN A NUMBER! PLEASE PUT A NUMBER IN! NOT " + "'" + userNum + "': ");
            }
        }
        while(isNum1 != true);

        Console.Write("Non-Reversed Number is: " + number + "\n"); // console displays the user's number non-reversed

        while (number > 0) // a while loop that checks if the user's number is greater than 0. As soon as the "number" reaches 0 is when "numReverse" equals the user's input in reverse. 
        {
            remainder = number % 10; // the line of code divides the number the user inputs and the remainder is stored in the remainder 
            number = number / 10; // this line divides the user's input by 10 and the result is stored and rewritten back to the number variable
            numReverse = (numReverse * 10) + remainder; // this line multiplies whatever "numReverse" currently holds with 10 and adds that result with the remainder. The result of the two gets stored back into numReverse
        } // the while loop will loop a number of times depending on how many digits are in the user's input number
        Console.WriteLine("Reverse Number is: " + numReverse); // console displays "Reverse Number is: " then the user's reversed number

        //======================= String Reverse ==========================//

        string? userStringInput; // created a string to store the user's word input
        string? userReverse = ""; // created a empty string variable for the user's word in reverse

        Console.Write("Enter a word to be reversed: "); // display "Enter a word to be reversed: " 

        userStringInput = Console.ReadLine(); // gather user's input and store it in userStringInput

        Console.Write("Non-Reversed Word is: " + userStringInput + "\n"); // display "Non-Reversed Word is: " and then the user's input word (\n is to display on a new line)

        for (int i = userStringInput.Length - 1; i >= 0; i--) // using a for loop, the user's input is stored in "i" with the .Length property to see the number of characters are in the user's string. minus 1 is for stopping the index for going past the users input index. i >= 0 is so the first letter of the user's word shows up in userReverse. i-- is to make it go backwards making it reverse
        {
            //userReverse = userReverse + (userStringInput[i]); // the loop repeats until the user's index reaches 0 (user's first letter of input word)
            userReverse += (userStringInput[i]); // short hand version of the line above
            //Console.WriteLine("Reversed Word is: " + userReverse); // tested this CW here and it loops each index (letter) until the loops ends
        }
        Console.WriteLine("Reversed Word is: " + userReverse); // display the reversed result

        while(playAgainResponse == true)
            {
                Console.Write("Do you want to run the program again? (Y/N): "); // console asks if the user wants to run the program again

                userAnswer = Console.ReadLine().ToUpper();

                if(userAnswer == "Y")
                {
                    playAgain = true;
                    playAgainResponse = false;
                }
                else if(userAnswer == "N")
                {
                    playAgain = false;
                    playAgainResponse = false;
                }
                else
                {   
                    playAgain = false;
                    playAgainResponse = true;
                    Console.WriteLine(userAnswer + " isn't a valid response. Please Enter an actual valid response please.");
                }
            }
    }