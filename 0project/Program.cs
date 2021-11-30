// See https://aka.ms/new-console-template for more information

bool exit= false;

Console.WriteLine("*************   Welcome    **************");


while(exit != true)

{






Console.WriteLine("This is your Calculator!");
Console.WriteLine("1).   ADD");
Console.WriteLine("2).   SUBTRACT");
Console.WriteLine("3).   MULTIPLY");
Console.WriteLine("4).   DIVIDE");
Console.WriteLine("5).   EXIT");
Console.WriteLine("Please select from the folling options :");


int num = int.Parse(Console.ReadLine());







if (num == 1)

{
    int number1 = 0;
    int number2 = 0;
    bool loopStop = false;


    while (loopStop != true)
    {


        Console.WriteLine(" \n what is your first number you would like to add ?");
        bool success1 = int.TryParse(Console.ReadLine(), out number1);


        if (success1)

        {

            Console.WriteLine(" \n what is your second number you would like to add ?");
            bool success2 = int.TryParse(Console.ReadLine(), out number2);



            if (success2)
            {
                 
                Console.WriteLine(" \n This is your result: " + (number1 + number2));
                Console.WriteLine("\n Would you like to continue adding or go back to the main menu?");
                Console.WriteLine("\n Press 1 for 'Adding' or press 2 for 'Main Menu'.");


                bool keepContinue= true;

                while(keepContinue)
                
                {

                      int goingBack;
                      bool MainMenu2 = int.TryParse(Console.ReadLine(), out goingBack);
                        // this is a continue feature to choose between the main menu and adding.


               if (MainMenu2)
                {
                   if (goingBack==2)
                   // 2=  going back to the main menu
                   {
                       loopStop = true;
                       keepContinue=false;
                   }
                   else if (goingBack==1)
                    // 1= continue operation
                   {
                       loopStop= false;
                       keepContinue=false;
                   }

                   else
                 
                   {
                       Console.WriteLine("Invaild input, select '1' for adding  or '2' for main menu.");
                   }
               }
               else
               {
                     Console.WriteLine("Invaild input, select '1' for adding  or '2' for main menu.");
               }
              

                }
                

              
            }
               

            else
            {
                Console.WriteLine(" \n Invaild integer, please try again.");
            }

        }
        else
        {
            Console.WriteLine(" \n Please enter an integer vaule");
        }

    }



}


else if (num == 2)
{
    int number1 = 0;
    int number2 = 0;
    bool loopStop = false;


    while (loopStop != true)
    {


        Console.WriteLine(" \n what is your first number you would like to subtract");
        bool success1 = int.TryParse(Console.ReadLine(), out number1);


        if (success1)

        {

            Console.WriteLine(" \n what is your second number you would like to subtract");
            bool success2 = int.TryParse(Console.ReadLine(), out number2);



            if (success2)
            {
                 
                Console.WriteLine(" \n This is your result: " + (number1 - number2));
                Console.WriteLine("Would you like to continue subtracting or go back to the main menu?");
                Console.WriteLine("Press 1 for 'Adding' or press 2 for 'Main Menu'");


                bool keepContinue= true;

                while(keepContinue)
                
                {

                      int goingBack;
                      bool MainMenu2 = int.TryParse(Console.ReadLine(), out goingBack);
                        // this is a continue feature to choose between the main menu and adding.


               if (MainMenu2)
                {
                   if (goingBack==2)
                   // 2=  going back to the main menu
                   {
                       loopStop = true;
                       keepContinue=false;
                   }
                   else if (goingBack==1)
                    // 1= continue operation
                   {
                       loopStop= false;
                       keepContinue=false;
                   }

                   else
                 
                   {
                       Console.WriteLine("Invaild input, select '1' for subtracting  or '2' for main menu.");
                   }
               }
               else
               {
                     Console.WriteLine("Invaild input, select '1' for subtracting  or '2' for main menu.");
               }
              

                }
                

              
            }
               

            else
            {
                Console.WriteLine(" \n Invaild integer, please try again.");
            }

        }
        else
        {
            Console.WriteLine(" \n Please enter an integer vaule");
        }

    }



}

else if (num == 3)
{
    int number1 = 0;
    int number2 = 0;
    bool loopStop = false;


    while (loopStop != true)
    {


        Console.WriteLine(" \n what is your first number you would like to add");
        bool success1 = int.TryParse(Console.ReadLine(), out number1);


        if (success1)

        {

            Console.WriteLine(" \n what is your second number you would like to add");
            bool success2 = int.TryParse(Console.ReadLine(), out number2);



            if (success2)
            {
                 
                Console.WriteLine(" \n This is your result: " + (number1 * number2));
                Console.WriteLine("Would you like to continue multiplying  or go back to the main menu?");
                Console.WriteLine("Press 1 for 'Multiplying' or press 2 for 'Main Menu'");


                bool keepContinue= true;

                while(keepContinue)
                
                {

                      int goingBack;
                      bool MainMenu2 = int.TryParse(Console.ReadLine(), out goingBack);
                        // this is a continue feature to choose between the main menu and adding.


               if (MainMenu2)
                {
                   if (goingBack==2)
                   // 2=  going back to the main menu
                   {
                       loopStop = true;
                       keepContinue=false;
                   }
                   else if (goingBack==1)
                    // 1= continue operation
                   {
                       loopStop= false;
                       keepContinue=false;
                   }

                   else
                 
                   {
                       Console.WriteLine("Invaild input, select '1' for multiplying  or '2' for main menu.");
                   }
               }
               else
               {
                     Console.WriteLine("Invaild input, select '1' for multiplying  or '2' for main menu.");
               }
              

                }
                

              
            }
               

            else
            {
                Console.WriteLine(" \n Invaild integer, please try again.");
            }

        }
        else
        {
            Console.WriteLine(" \n Please enter an integer vaule");
        }

    }



}

else if (num == 4)

{
    int number1 = 0;
    int number2 = 0;
    bool loopStop = false;


    while (loopStop != true)
    {


        Console.WriteLine(" \n what is your first number you would like to divide");
        bool success1 = int.TryParse(Console.ReadLine(), out number1);


        if (success1)

        {

            Console.WriteLine(" \n what is your second number you would like to divide");
            bool success2 = int.TryParse(Console.ReadLine(), out number2);



            if (success2)
            {
                 
                Console.WriteLine(" \n This is your result: " + (number1 % number2));
                Console.WriteLine("Would you like to continue dividing or go back to the main menu?");
                Console.WriteLine("Press 1 for 'Dividing' or press 2 for 'Main Menu'");


                bool keepContinue= true;

                while(keepContinue)
                
                {

                      int goingBack;
                      bool MainMenu2 = int.TryParse(Console.ReadLine(), out goingBack);
                        // this is a continue feature to choose between the main menu and adding.


               if (MainMenu2)
                {
                   if (goingBack==2)
                   // 2=  going back to the main menu
                   {
                       loopStop = true;
                       keepContinue=false;
                   }
                   else if (goingBack==1)
                    // 1= continue operation
                   {
                       loopStop= false;
                       keepContinue=false;
                   }

                   else
                 
                   {
                       Console.WriteLine("Invaild input, select '1' for dividing  or '2' for main menu.");
                   }
               }
               else
               {
                     Console.WriteLine("Invaild input, select '1' for  or '2' dividing for main menu.");
               }
              

                }
                

              
            }
               

            else
            {
                Console.WriteLine(" \n Invaild integer, please try again.");
            }

        }
        else
        {
            Console.WriteLine(" \n Please enter an integer vaule");
        }

    }



}

else if ((num == 5))

{
        exit= true;
    Console.WriteLine("************** Have a good day! **************");

}

else

{
    Console.WriteLine("This is not a valid entry");
}

}


