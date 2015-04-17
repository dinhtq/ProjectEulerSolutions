using System;
using System.IO;


namespace projectEuler
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/*
			 * Using names.txt (right click and 'Save Link/Target As...'), 
			 * a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order. 
			 * Then working out the alphabetical value for each name, 
			 * multiply this value by its alphabetical position in the list to obtain a name score.

				For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, 
				is the 938th name in the list. So, COLIN would obtain a score of 938 × 53 = 49714.

				What is the total of all the name scores in the file?
			 * 
			 * */


		

			try {
				//create an instance of StreamReader to read from a file
				//the using statement also closes the StreamReader
				using (StreamReader sr = new StreamReader("/Users/jason/Documents/Project Euler/Assets/names.txt"))
				{
					string line;

					//Read and display lines from the file until the 
					//end of the file is reached
					while ((line = sr.ReadLine()) != null)
					{
						//on current line, split each name by comma delimiter and add each name to array
						string[] words = line.Split(',');

						//sort the strings in the array alphabetically
						Array.Sort(words);

						//keep track of line of name
						int count = 1;
						//keep sum of name scores
						int total = 0;

						foreach(string word in words)
						{	
							
							//trim whitespaces, if any
							string trimword = word.Trim();
							//remove leading quote
							string beginRemoved = trimword.Remove(0,1);
							//remove last quote
							string lastRemoved = beginRemoved.Remove(beginRemoved.Length -1);

							//Console.Write(lastRemoved);




							//get each name score
							int position = count;
							int worth = getWordWorth(lastRemoved);
							int score = position * worth;

							total += score;

							//Console.Write(" | the name score is " + score + " and the total is " + total + "\n");

							count++;
						}

						//print out total name scores
						Console.WriteLine(total);
					}
				}
			}
			catch (Exception e)
			{
				//let the user know what went wrong
				Console.WriteLine("The file could not be read:");
				Console.WriteLine (e.Message);
			}

			Console.ReadKey ();


			




		}//end main

		//method:  takes a string and return worth value, dependent on getLetterWorth()
		public static int getWordWorth(string word) 
		{
			//split string into array of characters
			char[] letters = word.ToCharArray();

			//initialize a sum
			int sum = 0;

			//loop through array and add to sum
			foreach( char letter in letters)
			{
				sum += getLetterWorth (letter);
			}

			return sum;

		}

		//method:  takes a letter and return alphabetical worth value
		public static int getLetterWorth(char letter)
		{
			letter = Char.ToUpper (letter);

			switch(letter)
			{
			case 'A':
				return 1;
				break;
			case 'B':
				return 2;
				break;
			case 'C':
				return 3;
				break;
			case 'D':
				return 4;
				break;
			case 'E':
				return 5;
				break;
			case 'F':
				return 6;
				break;
			case 'G':
				return 7;
				break;
			case 'H':
				return 8;
				break;
			case 'I':
				return 9;
				break;
			case 'J':
				return 10;
				break;
			case 'K':
				return 11;
				break;
			case 'L':
				return 12;
				break;
			case 'M':
				return 13;
				break;
			case 'N':
				return 14;
				break;
			case 'O':
				return 15;
				break;
			case 'P':
				return 16;
				break;
			case 'Q':
				return 17;
				break;
			case 'R':
				return 18;
				break;
			case 'S':
				return 19;
				break;
			case 'T':
				return 20;
				break;
			case 'U':
				return 21;
				break;
			case 'V':
				return 22;
				break;
			case 'W':
				return 23;
				break;
			case 'X':
				return 24;
				break;
			case 'Y':
				return 25;
				break;
			case 'Z':
				return 26;
				break;

			default:
				return 0;
				break;
			}
		}

	}
}
