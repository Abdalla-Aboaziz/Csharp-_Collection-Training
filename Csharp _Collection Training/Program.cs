using System.Collections;

namespace Csharp__Collection_Training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            ///*1.	Given an array of integers, count the frequency of each element using a hash table.*/
            //int[] numbers = { 1, 2, 2, 3, 4, 4, 4, 5 };
            //Hashtable frq = new Hashtable();
            ///*  foreach (int num in numbers)
            //  {
            //      if (frq.ContainsKey(num))
            //      {
            //          frq[num] = (int)frq[num] + 1;
            //      }
            //      else
            //      {
            //          frq[num] = 1;
            //      }
            //  }
            //*/

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (frq.ContainsKey(numbers[i]))
            //    {
            //        frq[numbers[i]] = (int)frq[numbers[i]] + 1;
            //    }
            //    else
            //    {
            //        frq[numbers[i]] = 1;
            //    }

            //}




            //foreach (DictionaryEntry entry in frq)
            //{
            //    Console.WriteLine($"Number: {entry.Key}, Frequency: {entry.Value}");
            //}
            #endregion

            #region Q2
            ///*2.	You have a hashtable where its values are integers, find the key associated with the highest value.*/
            //Hashtable findkey = new Hashtable()
            //{
            //    ["Feg"] = 123,
            //    ["apple"] = 456,
            //    ["banana"] = 789,
            //    ["orange"] = 101
            //};

            //int maxValue = int.MinValue;
            //foreach (DictionaryEntry entry in findkey)
            //{
            //    if ((int)entry.Value > maxValue)
            //    {
            //        maxValue = (int)entry.Value;
            //    }
            //}
            //foreach (DictionaryEntry entry in findkey)
            //{
            //    if ((int)entry.Value == maxValue)
            //    {
            //        Console.WriteLine($"Key with highest value: {entry.Key}, Value: {entry.Value}");
            //    }
            //}

            #endregion


            #region Q3
            ///*3.	You have a hashtable , the  user will enter targetValue 
            //        find all keys that associated with a specific targetValue
            //        Note : if the targetValue not found print(“Key not found”)
            //        Ex:
            //        Input : 
            //        { "key1", "apple" }, { "key2", "banana" }, { "key3", "apple" }
            //        apple
            //        Output:
            //        key1
            //        key3
            //*/

            //Hashtable hashtable = new Hashtable()
            //{
            //    ["key1"] = "apple",
            //    ["key2"] = "banana",
            //    ["key3"] = "apple"
            //};
            //Console.Write("Enter target value : ");
            //string targetValue = Console.ReadLine();
            //bool found = false;
            //foreach (DictionaryEntry entry in hashtable)
            //{
            //    if (entry.Value.Equals(targetValue))
            //    {
            //        Console.WriteLine(entry.Key);
            //        found = true;
            //    }
            //}
            //if (!found)
            //{
            //    Console.WriteLine("Key not found");
            //}



            #endregion

            #region Q4
            ///*4.	Given an array of strings, group anagrams together.*/
            //string[] words = { "eat", "tea", "tan", "ate", "nat", "bat" };
            //Hashtable anagramGroups = new Hashtable();
            //foreach (string word in words)
            //{
            //    char[] charArray = word.ToCharArray();
            //    Array.Sort(charArray);
            //    string sortedWord = new string(charArray);
            //    if (anagramGroups.ContainsKey(sortedWord))
            //    {
            //        List<string> group = (List<string>)anagramGroups[sortedWord];
            //        group.Add(word);
            //    }
            //    else
            //    {
            //        anagramGroups[sortedWord] = new List<string> { word };
            //    }
            //}
            //foreach (DictionaryEntry entry in anagramGroups)
            //{
            //    List<string> group = (List<string>)entry.Value;
            //    Console.WriteLine(string.Join(", ", group));
            //}


            #endregion

            #region Q5
            ///*5.	Given an array of integers, check if the array contains any duplicates.

            //    */

            //int[] nums = { 1, 2, 3, 4, 5, 1 };
            //Hashtable seenNumbers = new Hashtable();
            //bool hasDuplicates = false;
            //foreach (int num in nums)
            //{
            //    if (seenNumbers.ContainsKey(num))
            //    {
            //        hasDuplicates = true;
            //        break;
            //    }
            //    else
            //    {
            //        seenNumbers[num] = true;
            //    }
            //}
            //if (hasDuplicates)
            //{
            //    Console.WriteLine("The array contains duplicates.");
            //}
            //else
            //{
            //    Console.WriteLine("The array does not contain duplicates.");
            //}

            #endregion

            #region Q6
            /*6.Implement a SortedDictionary that stores student IDs (int) and their names (string).
             * Perform operations like adding, removing, and retrieving student names.*/






            //SortedDictionary<int, string> studentDirectory = new SortedDictionary<int, string>();
            //// Adding students
            //studentDirectory.Add(101, "Ali");
            //studentDirectory.Add(102, "Basem");
            //studentDirectory.Add(103, "Ahmed");
            ////removing a student
            //studentDirectory.Remove(102);
            ////Retrieving student names
            //foreach (var student in studentDirectory)
            //{
            //    Console.WriteLine($"Student  Name: {student.Value}");
            //}

            ////
            //int serachId = 123;
            //if (studentDirectory.ContainsKey(serachId))
            //{
            //    Console.WriteLine($"Student  found: ID = {serachId}, Name = {studentDirectory[serachId]}");
            //}
            //else
            //{
            //    Console.WriteLine("Student  not found.");
            //}


            #endregion

            #region Q7

            /*7.	Create an employee directory where employee IDs (int) are keys and employee names (string) are values.
             * Use a SortedList to manage and retrieve employees in order of their IDs.*/


            //SortedList<int, string> employeeDirectory = new SortedList<int, string>()
            //{
            //    { 123, "Ali" },
            //    { 456, "Basem" },
            //    {789,"Salma " }

            //};
            //foreach (var X in employeeDirectory)
            //{
            //    Console.WriteLine($"Employee id is : {X.Key},Name is : {X.Value}");
            //}
            //employeeDirectory.Remove(456);

            //int serachId = 123;
            //if (employeeDirectory.ContainsKey(serachId))
            //{
            //    Console.WriteLine($"Employee found: ID = {serachId}, Name = {employeeDirectory[serachId]}");
            //}
            //else
            //{
            //    Console.WriteLine("Employee not found.");
            //}



            #endregion
            #region Q8
            /*8.	Given an array of integers from 1 to N with some numbers missing, find the missing numbers.*/

            //Console.WriteLine("Enter number of element : ");
            //int n;
            //bool ispasrsed;
            //do
            //{
            //    ispasrsed = int.TryParse(Console.ReadLine(), out n);
            //} while (!ispasrsed);


            //int [] arr = new int[n-1];
            //int sumenterd=0;
            //for (int i=1;i<=n-1;i++)
            //{
            //    arr[i-1]=int.Parse(Console.ReadLine());
            //    sumenterd += arr[i - 1];
            //}
            ////foreach(int i in arr)
            ////{
            ////    Console.WriteLine(i);
            ////}
            //int sumN = n * (n + 1) / 2;
            //int missingNumber = sumN - sumenterd;
            //Console.WriteLine($"The missing number is: {missingNumber}");





            #endregion

            #region Q9
            /*9.	You  have a list of integers with possible duplicates, create a HashSet that contains only unique values.*/
            //List<int> numbersWithDuplicates = new List<int> { 1, 2, 2, 3, 4, 4, 5, 5, 5 };
            //HashSet<int> uniqueNumbers = new HashSet<int>();
            //foreach (int number in numbersWithDuplicates)
            //{
            //    uniqueNumbers.Add(number);
            //}
            //Console.WriteLine("Unique numbers:");
            //foreach (int uniqueNumber in uniqueNumbers)
            //{
            //    Console.WriteLine(uniqueNumber);
            //}



            #endregion


            #region Q10
            ///*10.	You have a hashtable with unique values, create a new hashtable where the keys and values are swapped.*/
            //Hashtable originalHashtable = new Hashtable()
            //{
            //    ["key1"] = "value1",
            //    ["key2"] = "value2",
            //    ["key3"] = "value3"
            //};
            //Hashtable swappedHashtable = new Hashtable();


            //foreach (DictionaryEntry entry in originalHashtable)
            //{
            //    swappedHashtable[entry.Value] = entry.Key;
            //}

            //Console.WriteLine("After Swapping : ");

            //foreach (DictionaryEntry entry in swappedHashtable)
            //{
            //    Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            //}
            #endregion

            #region Q11
            /*
            11.	Find the union of two sets, returning the unique elements from both sets.
            */

            //HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            //HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };
            //HashSet<int>unionSet = new HashSet<int>(setA);
            //unionSet.UnionWith(setB);
            //Console.WriteLine("Union of Set A and Set B:");
            //foreach (int num in unionSet)
            //{
            //    Console.WriteLine(num);
            //}



            #endregion

            #region Q12
            /*12.	You have a dictionary with string keys, the user will enter targetChar , count how many keys start with this targetChar.
                    Ex:
                    Input : 
                    {“apple”,1},
                    {“animal”,2},
                    {“airport”,3} 
                    a
                    Output:
                    3
                    */


            //Dictionary<string, int> myDictionary = new Dictionary<string, int>()
            //{
            //    { "apple",1},
            //    {"animal",2},
            //    {"airport",3},
            //    {"banana",4},
            //    {"avocado",5 }

            // };
            //int count = 0;
            //Console.Write("Enter target character: ");
            //char targetChar = Console.ReadLine()[0];

            //foreach (var item in myDictionary)
            //{
            //    if (item.Key.StartsWith(targetChar))
            //    {
            //        count++;
            //    }
            //}
            //if (count == 0)
            //{
            //    Console.WriteLine("No keys found starting with the target character.");
            //}
            //else
            //    Console.WriteLine(count);

            #endregion
            #region Q13
            ///*13.	You have a sorted set , the user will enter an integer target, find all elements that are greater than target and add them in the list.*/
            //SortedSet<int> sortedSet = new SortedSet<int>() { 1, 3, 5, 7, 9, 11, 13 };
            //Console.Write("Enter target integer: ");
            //int target = int.Parse(Console.ReadLine());
            //List<int> greaterElements = new List<int>();
            //foreach (int element in sortedSet) 
            //{
            //    if (element > target)
            //    {
            //        greaterElements.Add(element);
            //    }
            
            //}
            //Console.WriteLine("greater elements is : ");
            //foreach(var item in greaterElements)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion



















        }
    }
}
