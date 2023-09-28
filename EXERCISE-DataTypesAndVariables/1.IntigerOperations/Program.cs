/* silly template */

// initialize inputs defined by problem


/*  
 *  Algorithm:
 *      sum = numberOne + numberTwo
 *      sum = sum / numberThree
 *      sum = sum * numberFour
 */

// parse inputs from console

int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());
int fourthNumber = int.Parse(Console.ReadLine());

int sum = 0;

// preform needed operation and print out result

sum = firstNumber + secondNumber;
sum /= thirdNumber;
sum *= fourthNumber;

Console.WriteLine(sum);
Environment.Exit(0);