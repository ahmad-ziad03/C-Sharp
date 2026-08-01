using System;
using System.Linq;

class Program
{
    static void Main()
    {
        //TASK 1 IN SECTIONS
        //Console.WriteLine("TASK 1 IN SECTIONS");
        //List<int> listOne = new List<int> {1,8,2,1,0,3,6,4,1,2,0,102};
        //List<int> resultOne = listOne.Where(n => n % 2 == 0).ToList();
        //Console.WriteLine(string.Join(", ", resultOne));

        //TASK 2 IN SECTIONS
        //Console.WriteLine("TASK 2 IN SECTIONS");
        //List<int> listTwo = new List<int> { 1, 8, 2, 1, 0, 3, 6, 4, 1, 2, 0, 102 };
        //List<int> resultTwo = listTwo.Distinct().ToList();
        //Console.WriteLine(string.Join(", ", resultTwo));

        //TASK 3 IN SECTIONS
        //Console.WriteLine("TASK 3 IN SECTIONS");
        //List<int> lisThree = new List<int> { 1, 8, 2, 1, 0, 3, 6, 4, 1, 2, 0, 102 };
        //int maxValue = lisThree.Max();
        //Console.WriteLine(maxValue);

        //TASK 4 IN SECTIONS
        //Console.WriteLine("TASK 4 IN SECTIONS");
        //List<int> listFour = new List<int> { 1, 8, 2, 1, 0, 3, 6, 4, 1, 2, 0, 102 };
        //listFour.Reverse();
        //Console.WriteLine(string.Join(", ", listFour));

        //TASK 5 IN SECTIONS
        //Console.WriteLine("TASK 5 IN SECTIONS");
        //List<int> listFive = new List<int> { 1, 8, 2, 1, 0, 3, 6, 4, 1, 2, 0, 102 };
        //int count = listFive.Count(n => n > 50);
        //Console.WriteLine(count);

        //TASK 6 IN SECTIONS
        //Console.WriteLine("TASK 6 IN SECTIONS");
        //Dictionary<string, int> scores = new Dictionary<string, int>{
        //    { "Ali", 92 },
        //    { "Sara", 75 },
        //    { "Omar", 88 },
        //    { "Lina", 60 },
        //    { "Zaid", 81 }
        //};
        //foreach (var student in scores)
        //{
        //    if (student.Value > 80)
        //        Console.WriteLine(student.Key + " : " + student.Value);
        //}

        //TASK 7 IN SECTIONS
        //Console.WriteLine("TASK 7 IN SECTIONS");
        //Dictionary<string, int> scoresTwo = new Dictionary<string, int>{
        //    { "Ali", 92 },
        //    { "Sara", 75 },
        //    { "Omar", 88 },
        //    { "Lina", 60 }
        //};
        //Console.Write("Enter a name: ");
        //string name = Console.ReadLine();
        //if (scoresTwo.ContainsKey(name))
        //    Console.WriteLine(name + " : " + scoresTwo[name]);
        //else
        //    Console.WriteLine("Not found");


        //TASK 8 IN SECTIONS
        //Console.WriteLine("TASK 8 IN SECTIONS");
        //Dictionary<string, int> scoresThree = new Dictionary<string, int>{
        //    { "Ali", 92 },
        //    { "Sara", 75 },
        //    { "Omar", 88 },
        //    { "Lina", 60 }
        //};
        //int total = scoresThree.Values.Sum();
        //Console.WriteLine("the sum is : "+total);

        //TASK 9 IN SECTIONS
        //Console.WriteLine("TASK 9 IN SECTIONS");
        //Dictionary<string, int> scoresFour = new Dictionary<string, int>{
        //    { "Ali", 92 },
        //    { "Sara", 45 },
        //    { "Omar", 88 },
        //    { "Lina", 30 },
        //    { "Zaid", 60 }
        //};
        //// ما بقدر احذف من الديكشيناري و انا بلق عليه فلازم الف اجمع اسماء اللي بدي احذفهم
        ////بعدها بحذفهم
        //var toRemove = scoresFour.Where(s => s.Value < 50).Select(s => s.Key).ToList();
        //foreach (var key in toRemove)
        //    scoresFour.Remove(key);
        //Console.WriteLine("The Students With Score >= 50");
        //foreach (var s in scoresFour)
        //    Console.WriteLine(s.Key + " : " + s.Value);

        //TASK 10 IN SECTIONS
        //Console.WriteLine("TASK 10 IN SECTIONS");
        //Dictionary<string, int> scoresFive = new Dictionary<string, int>
        //{
        //    { "Ali", 92 },
        //    { "Sara", 75 },
        //    { "Omar", 88 },
        //    { "Lina", 60 }
        //};
        //var top = scoresFive.OrderBy(s => s.Value).Last();
        //Console.WriteLine(top.Key + " : " + top.Value);

        //TASK 11 IN SECTIONS
        //Console.WriteLine("TASK 11 IN SECTIONS");
        //LinkedList<string> navOne = new LinkedList<string>();
        //navOne.AddLast("Home");
        //navOne.AddLast("Products");
        //navOne.AddLast("Contact");
        //navOne.AddFirst("Menu");
        //foreach (var page in navOne)
        //    Console.WriteLine(page);

        //TASK 12 IN SECTIONS
        //Console.WriteLine("TASK 12 IN SECTIONS");
        //LinkedList<string> navTwo = new LinkedList<string>();
        //navTwo.AddLast("Home");
        //navTwo.AddLast("Products");
        //navTwo.AddLast("Contact");
        //navTwo.AddLast("About");
        //navTwo.Remove("Products");
        //foreach (var page in navTwo)
        //    Console.WriteLine(page);

        //TASK 13 IN SECTIONS
        //Console.WriteLine("TASK 13 IN SECTIONS");
        //LinkedList<string> navThree = new LinkedList<string>();
        //navThree.AddLast("Home");
        //navThree.AddLast("Products");
        //navThree.AddLast("Contact");
        //// بطلع النقطة اللي بدي اضيف بناءا عليها 
        //LinkedListNode<string> target = navThree.Find("Products");
        //navThree.AddBefore(target, "Menu");
        //navThree.AddAfter(target, "Services");
        //foreach (var page in navThree)
        //    Console.WriteLine(page);

        //TASK 14 IN SECTIONS
        //Console.WriteLine("TASK 14 IN SECTIONS");
        //LinkedList<string> navFour = new LinkedList<string>();
        //navFour.AddLast("Home");
        //navFour.AddLast("Products");
        //navFour.AddLast("Contact");
        //foreach (var page in navFour)
        //    Console.WriteLine(page);

        //TASK 15 IN SECTIONS
        //Console.WriteLine("TASK 15 IN SECTIONS");
        //LinkedList<string> navFive = new LinkedList<string>();
        //navFive.AddLast("Home");
        //navFive.AddLast("Products");
        //navFive.AddLast("Contact");
        //navFive.AddLast("About");
        //Console.WriteLine("First: " + navFive.First.Value);
        //Console.WriteLine("Last: " + navFive.Last.Value);

        //TASK 16 IN SECTIONS
        //Console.WriteLine("TASK 16 IN SECTIONS");
        //List<int> listSix = new List<int> {1,8,2,1,0,3, 6, 4, 1, 2, 0, 102 };
        //List<int> resultSix = listSix.Where(n => n % 2 != 0).ToList();
        //Console.WriteLine(string.Join(", ", resultSix));

        //TASK 17 IN SECTIONS
        //Console.WriteLine("TASK 17 IN SECTIONS");
        //List<int> listSeven = new List<int> { 1, 8, 2, 1, 0, 3, 6, 4, 1, 2, 0, 102 };
        //List<int> resultSeven = new List<int>();
        //for (int i = 0; i < listSeven.Count; i++)
        //{
        //    resultSeven.Add(listSeven[i] * 2);
        //    if (i == 0)
        //    {
        //        Console.Write("{" + resultSeven[i] + ",");

        //    }
        //    else if (i == listSeven.Count - 1)
        //    {
        //        Console.Write(resultSeven[i] + "}");
        //    }
        //    else
        //    {
        //        Console.Write(resultSeven[i] + ",");
        //    }
        //}

        //TASK 18 IN SECTIONS
        //Console.WriteLine("TASK 18 IN SECTIONS");
        //List<int> listEight = new List<int> { 1, 8, 2, 1, 0, 3, 6, 4, 1, 2, 0, 102 };
        //var resultEight = listEight.OrderByDescending(x => x).ToList();
        //Console.WriteLine(string.Join(", ", resultEight));


        //TASK 19 IN SECTIONS
        //Console.WriteLine("TASK 19 IN SECTIONS");
        //List<int> listNine = new List<int> { 1, 8, 2, 1, 0, 3, 6, 4, 1, 2, 0, 102 };
        //var resultNine = listNine.First(n => n > 100);
        //Console.WriteLine(resultNine);

        //TASK 20 IN SECTIONS
        //Console.WriteLine("TASK 20 IN SECTIONS");
        //List<int> listTen = new List<int> { 1, 8, 2, 1, 0, 3, 6, 4, 1, 2, 0, 102 };
        //double resultTen = listTen.Sum();
        //double avg = resultTen / listTen.Count;
        //Console.WriteLine(avg);

        //TASK 21 IN SECTIONS
        //Console.WriteLine("TASK 21 IN SECTIONS");
        //List<int> listA = new List<int> { 1, 2, 3, 4, 5, 6 };
        //List<int> listB = new List<int> { 4, 5, 6, 7, 8, 9 };
        //List<int> common = listA.Intersect(listB).ToList();
        //Console.WriteLine(string.Join(", ", common));

        //TASK 22 IN SECTIONS
        //Console.WriteLine("TASK 22 IN SECTIONS");
        //List<int> listC = new List<int> { 1, 2, 3 };
        //List<int> listD = new List<int> { 3, 4, 5 };
        //List<int> merged = listC.Concat(listD).ToList();
        //Console.WriteLine(string.Join(", ", merged));

        //TASK 23 IN SECTIONS
        //Console.WriteLine("TASK 23 IN SECTIONS");
        //List<int> listE = new List<int> { 1, 2, 3, 4, 5 };
        //List<int> listF = new List<int> { 4, 5, 6, 7, 8 };
        //List<int> resultEleven = listE.Except(listF).Concat(listF.Except(listE)).ToList();
        //Console.WriteLine(string.Join(", ", resultEleven));

        //TASK 24 IN SECTIONS
        //Console.WriteLine("TASK 24 IN SECTIONS");
        //Dictionary<string, int> scoresSix = new Dictionary<string, int>
        //{
        //    { "Ali", 92 },
        //    { "Sara", 75 },
        //    { "Omar", 88 },
        //    { "Lina", 60 }
        //};
        //List<int> values = scoresSix.Values.ToList();
        //Console.WriteLine(string.Join(", ", values));

        //TASK 25 IN SECTIONS
        //Console.WriteLine("TASK 25 IN SECTIONS");
        //Dictionary<string, int> prices = new Dictionary<string, int>
        //{
        //    { "Laptop", 850 },
        //    { "Mouse", 25 },
        //    { "Keyboard", 60 },
        //    { "Monitor", 200 },
        //    { "Cable", 8 }
        //};
        //Dictionary<string, int> filtered = prices.Where(p => p.Value > 100).ToDictionary(p => p.Key, p => p.Value);
        //foreach (var item in filtered)
        //    Console.WriteLine(item.Key + " : " + item.Value);

        //TASK 26 IN SECTIONS
        //Console.WriteLine("TASK 26 IN SECTIONS");
        //int[] numbers = { 4, 8, 15, 16, 23, 42 };
        //int target = 16;
        //int foundIndex = -1;

        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    if (numbers[i] == target)
        //    {
        //        foundIndex = i;
        //        break;
        //    }
        //}
        //if (foundIndex != -1)
        //    Console.WriteLine("Found " + target + " at index " + foundIndex);
        //else
        //    Console.WriteLine("Not found");

        //TASK 27 IN SECTIONS
        //Console.WriteLine("TASK 27 IN SECTIONS");
        //int[] numbersTwo = { 4, 8, 15, 16, 23, 42 };
        //int countTow = 0;
        //for (int i = 0; i < numbersTwo.Length; i++) { 
        //    if (numbersTwo[i] % 2 == 0) 
        //        countTow++;
        //}
        //Console.WriteLine(countTow);

        //TASK 28 IN SECTIONS
        //Console.WriteLine("TASK 28 IN SECTIONS");
        //List<int> listEleven = new List<int> { 1, 2, 3, 4, 5 };
        //int wantToRemove = 4;
        //for (int i = 0; i < listEleven.Count; i++)
        //{
        //    if (listEleven[i] == wantToRemove) {
        //        listEleven.RemoveAt(i);
        //    }
        //}
        //foreach (int eleven in listEleven) {
        //    Console.Write(eleven + " ");
        //}

        //TASK 29 IN SECTIONS
        //Console.WriteLine("TASK 29 IN SECTIONS");
        //int[] numbersThree = { 4, 8, 15, 16, 23, 42, 40 };
        //int largest = numbersThree[0];
        //for (int i = 1; i < numbersThree.Length; i++)
        //    if (numbersThree[i] > largest)
        //        largest = numbersThree[i];
        //int secondLargest = numbersThree[0];
        //for (int i = 1; i < numbersThree.Length; i++)
        //    if (numbersThree[i] > secondLargest && numbersThree[i] < largest)
        //        secondLargest = numbersThree[i];
        //Console.WriteLine("Largest: " + largest);
        //Console.WriteLine("Second largest: " + secondLargest);

        //TASK 1 IN ADVANCED
        //Console.WriteLine("TASK 1 IN ADVANCED");
        //int[] numbersFour = { 3, 1, 4, 1, 5, 1, 4, 4, 4, 2 };
        //int mostFrequent = numbersFour[0];
        //int highestCount = 0;
        //for (int i = 0; i < numbersFour.Length; i++)
        //{
        //    int count = 0;
        //    for (int j = 0; j < numbersFour.Length; j++)
        //    {
        //        if (numbersFour[j] == numbersFour[i])
        //            count++;
        //    }
        //    if (count > highestCount)
        //    {
        //        highestCount = count;
        //        mostFrequent = numbersFour[i];
        //    }
        //}
        //Console.WriteLine("Most frequent: " + mostFrequent + " (" + highestCount + " times)");

        //TASK 2 IN ADVANCED
        //Console.WriteLine("TASK 2 IN ADVANCED");
        //int[] arr = { 1, 2, 3, 4, 5 };
        //int n = 2;
        //int[] resultTwelve = new int[arr.Length];
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    int newPos = (i + n) % arr.Length;   // باقي القسمة عشان العناصر اللي في الاخير يروحوا على الاول
        //    resultTwelve[newPos] = arr[i];
        //}
        //Console.WriteLine("[" + string.Join(",", resultTwelve) + "]");

        //TASK 3 IN ADVANCED
        //Console.WriteLine("TASK 3 IN ADVANCED");
        //int[] arrTwo = [1, 2, 3 , 3, 2, 1];
        //bool isPalindrome = true;
        //for (int i = 0 , j = arrTwo.Length -1 ; i <= arrTwo.Length /2 && j >= arrTwo.Length /2 ; i++, j--) {
        //    if (arrTwo[i] != arrTwo[j]) { 
        //        isPalindrome = false; break;
        //    }
        //}
        //Console.WriteLine(isPalindrome);

        //TASK 4 IN ADVANCED
        //Console.WriteLine("TASK 4 IN ADVANCED");
        //int[] arrThree = [1, 2, 4, 5];
        //int n = 5;
        //int expectedSum = n * (n + 1) / 2;
        //int actualSum = 0;
        //for (int i = 0; i < arrThree.Length; i++) { 
        //    actualSum += arrThree[i];
        //}
        //int missing = expectedSum - actualSum;
        //Console.WriteLine("Missing Number : "+ missing );

        //TASK 5 IN ADVANCED
        //Console.WriteLine("TASK 5 IN ADVANCED");
        //int[] numsTwo = { 1, 3, 5, 2, 4 };
        //int totalSum = 0;
        //for (int i = 0; i < numsTwo.Length; i++)
        //    totalSum += numsTwo[i];
        //int leftSum = 0;
        //int bestDiff = int.MaxValue;
        //int bestSplit = 0;
        //// split point: elements [0..i] on left, [i+1..end] on right
        //for (int i = 0; i < numsTwo.Length - 1; i++)
        //{
        //    leftSum += numsTwo[i];
        //    int rightSum = totalSum - leftSum;
        //    int diff = leftSum - rightSum;
        //    if (diff < 0) diff = -diff;
        //    if (diff < bestDiff)
        //    {
        //        bestDiff = diff;
        //        bestSplit = i;
        //    }
        //}
        //Console.Write("Left:  ");
        //for (int i = 0; i <= bestSplit; i++) Console.Write(numsTwo[i] + " ");
        //Console.Write("\nRight: ");
        //for (int i = bestSplit + 1; i < numsTwo.Length; i++) Console.Write(numsTwo[i] + " ");
        //Console.WriteLine("\nDifference: " + bestDiff);

        //TASK 6 IN ADVANCED
        //Console.WriteLine("TASK 6 IN ADVANCED");
        //int[] numsThree = { 1, 2, 2, 3, 4, 1, 2, 3 };
        //int bestLen = 1, bestEnd = 0;
        //int curLen = 1;
        //for (int i = 1; i < numsThree.Length; i++)
        //{
        //    if (numsThree[i] > numsThree[i - 1])
        //        curLen++;
        //    else
        //        curLen = 1;

        //    if (curLen > bestLen)
        //    {
        //        bestLen = curLen;
        //        bestEnd = i;
        //    }
        //}
        //Console.Write("Longest = [");
        //for (int i = bestEnd - bestLen + 1; i <= bestEnd; i++)
        //{
        //    Console.Write(numsThree[i]);
        //    if (i < bestEnd) Console.Write(",");
        //}
        //Console.WriteLine("]");

        //TASK 7 IN ADVANCED
        //Console.WriteLine("TASK 7 IN ADVANCED");
        //int[] numSeven = { 1, 2, 3, 1, 4, 2, 1 };
        //int targeSeven = 1;
        //int lastPos = -1;
        //int shortest = int.MaxValue;
        //for (int i = 0; i < numSeven.Length; i++)
        //{
        //    if (numSeven[i] == targeSeven)
        //    {
        //        if (lastPos != -1 && i - lastPos < shortest)
        //            shortest = i - lastPos;   // distance to previous occurrence
        //        lastPos = i;                  // remember this position
        //    }
        //}
        //Console.WriteLine("Distance of " + targeSeven + " = " + shortest);

        //TASK 8 IN ADVANCED
        //Console.WriteLine("TASK 8 IN ADVANCED");
        //int[] numsEight = { 3, 1, 2, 8, 7, 4, 5 };
        //int[] result8 = new int[numsEight.Length];
        //int pos = 0;
        //for (int i = 0; i < numsEight.Length; i++)   // pass 1: evens
        //    if (numsEight[i] % 2 == 0)
        //        result8[pos++] = numsEight[i];
        //for (int i = 0; i < numsEight.Length; i++)   // pass 2: odds
        //    if (numsEight[i] % 2 != 0)
        //        result8[pos++] = numsEight[i];
        //Console.WriteLine("[" + string.Join(",", result8) + "]");

        //TASK 9 IN ADVANCED
        //Console.WriteLine("TASK 9 IN ADVANCED");
        //int[] nums9 = { 1, 3, 2, 4, 1 };
        //Console.Write("Peaks = ");
        //for (int i = 1; i < nums9.Length - 1; i++)   // skip the two ends
        //    if (nums9[i] > nums9[i - 1] && nums9[i] > nums9[i + 1])
        //        Console.Write(nums9[i] + " ");
        //Console.WriteLine();

        //TASK 10 IN ADVANCED
        //Console.WriteLine("TASK 10 IN ADVANCED");
        //int[] nums10 = { 2, 7, 11, 15 };
        //int target10 = 9;
        //HashSet<int> seen = new HashSet<int>();
        //bool found = false;
        //for (int i = 0; i < nums10.Length; i++)
        //{
        //    int need = target10 - nums10[i];
        //    if (seen.Contains(need))
        //    {
        //        Console.WriteLine(need + " + " + nums10[i] + " = " + target10);
        //        found = true;
        //        break;
        //    }
        //    seen.Add(nums10[i]);
        //}
        //if (!found) Console.WriteLine("No pair found");

        //TASK 11 IN ADVANCED
        //Console.WriteLine("TASK 11 IN ADVANCED");
        //int[] nums11 = { 0, 1, 0, 3, 12 };
        //int[] result11 = new int[nums11.Length];
        //int indx = 0;
        //for (int i = 0; i < nums11.Length; i++)
        //    if (nums11[i] != 0)
        //        result11[indx++] = nums11[i];
        //Console.WriteLine("[" + string.Join(",", result11) + "]");

        //TASK 12 IN ADVANCED
        //Console.WriteLine("TASK 12 IN ADVANCED");
        //int[] a12 = { 1, 2, 3 };
        //int[] b12 = { 4, 5, 6 };
        //int[] result12 = new int[a12.Length + b12.Length];
        //for (int i = 0; i < a12.Length; i++)
        //{
        //    result12[i * 2] = a12[i];       // الاعداج الزوجية من a
        //    result12[i * 2 + 1] = b12[i];   // الاعداد الفردية من b
        //}
        //Console.WriteLine("[" + string.Join(",", result12) + "]");

        //TASK 13 IN ADVANCED
        //Console.WriteLine("TASK 13 IN ADVANCED");
        //int[] nums13 = { 3, 1, 4, 1, 5, 3, 3 };
        //for (int i = 0; i < nums13.Length; i++)
        //{
        //    bool seenBefore = false;
        //    for (int k = 0; k < i; k++)          // هل انا حسبته من قبل؟
        //        if (nums13[k] == nums13[i]) seenBefore = true;
        //    if (seenBefore) continue;
        //    int count = 0;
        //    for (int j = 0; j < nums13.Length; j++)   // احسب المجموع
        //        if (nums13[j] == nums13[i]) count++;
        //    Console.WriteLine(nums13[i] + " : " + count);
        //}


        //TASK 14 IN ADVANCED
        //Console.WriteLine("TASK 14 IN ADVANCED");
        //int[] numbers14 = { 4, 8, 15, 16, 23, 42, 40 };
        //int largest14 = numbers14[0];
        //for (int i = 1; i < numbers14.Length; i++)
        //    if (numbers14[i] > largest14)
        //        largest14 = numbers14[i];
        //int secondLargest14 = numbers14[0];
        //for (int i = 1; i < numbers14.Length; i++)
        //    if (numbers14[i] > secondLargest14 && numbers14[i] < largest14)
        //        secondLargest14 = numbers14[i];
        //Console.WriteLine("Largest: " + largest14);
        //Console.WriteLine("Second largest: " + secondLargest14);

        //TASK 15 IN ADVANCED
        //Console.WriteLine("TASK 15 IN ADVANCED");
        //int[] nums15 = { 1, 10, 3, 7, 5 };
        //int target15 = 12;
        //bool found15 = false;
        //for (int i = 0; i < nums15.Length; i++)
        //{
        //    int sum = 0;
        //    for (int j = i; j < nums15.Length; j++)
        //    {
        //        sum += nums15[j];
        //        if (sum == target15)
        //        {
        //            Console.Write(target15 + " = ");
        //            for (int k = i; k <= j; k++)
        //            {
        //                Console.Write(nums15[k]);
        //                if (k < j) Console.Write(" + ");
        //            }
        //            Console.WriteLine();
        //            found15 = true;
        //            break;
        //        }
        //    }
        //    if (found15) break;
        //}
        //if (!found15) Console.WriteLine("No subarray found");

        //TASK 16 IN ADVANCED
        //Console.WriteLine("TASK 16 IN ADVANCED");
        //int[] nums16 = { 1, 2, 3, 4, 5 };
        //int from = 1, to = 3;
        //while (from < to)   // two-pointer swap within the rang
        //{
        //    int temp = nums16[from];
        //    nums16[from] = nums16[to];
        //    nums16[to] = temp;
        //    from++;
        //    to--;
        //}
        //Console.WriteLine("[" + string.Join(",", nums16) + "]");

        //TASK 17 IN ADVANCED
        //Console.WriteLine("TASK 17 IN ADVANCED");
        //int[] nums17 = { 4, 3, 2, 1 };
        //// sorted copy to know target positions
        //int[] sorted17 = (int[])nums17.Clone();
        //System.Array.Sort(sorted17);
        //int swaps = 0;
        //for (int i = 0; i < nums17.Length; i++)
        //{
        //    if (nums17[i] != sorted17[i])
        //    {
        //        // شوف القيمة الصحيحة وين موجودة هسا
        //        int j = i;
        //        while (nums17[j] != sorted17[i]) j++;
        //        // جيب القيمة الصحيحة على مكانها
        //        int temp = nums17[i];
        //        nums17[i] = nums17[j];
        //        nums17[j] = temp;
        //        swaps++;
        //    }
        //}
        //Console.WriteLine("Minimum swaps = " + swaps);

        //TASK 18 IN ADVANCED
        //Console.WriteLine("TASK 18 IN ADVANCED");
        //int[] nums18 = { 5, 1, 4, 2, 3 };
        //System.Array.Sort(nums18);
        //int[] result18 = new int[nums18.Length];
        //int left = 0, right = nums18.Length - 1, p = 0;
        //while (left <= right)
        //{
        //    result18[p++] = nums18[left++];        // اصغر قيمة موجودة
        //    if (left <= right)
        //        result18[p++] = nums18[right--];   // اكبر قيمة موجودة
        //}
        //Console.WriteLine("[" + string.Join(",", result18) + "]");

        //TASK 19 IN ADVANCED
        //Console.WriteLine("TASK 19 IN ADVANCED");
        //int[] nums19 = { 1, 2, 3, 1, 2, 3, 4 };
        //int bestLen19 = 0, bestStart19 = 0;
        //// جرب كل زوج من نقطة البداية
        //for (int i = 0; i < nums19.Length; i++)
        //{
        //    for (int j = i + 1; j < nums19.Length; j++)
        //    {
        //        int len = 0;
        //        // match forward while equal and within bounds
        //        while (j + len < nums19.Length && nums19[i + len] == nums19[j + len])
        //            len++;
        //        if (len > bestLen19)
        //        {
        //            bestLen19 = len;
        //            bestStart19 = i;
        //        }
        //    }
        //}
        //Console.Write("Longest repeated pattern = [");
        //for (int i = bestStart19; i < bestStart19 + bestLen19; i++)
        //{
        //    Console.Write(nums19[i]);
        //    if (i < bestStart19 + bestLen19 - 1) Console.Write(",");
        //}
        //Console.WriteLine("]");

        //TASK 20 IN ADVANCED
        //Console.WriteLine("ALL TASKS ARE SOLVED BUT THEY ARE COMMENTED");
        //Console.WriteLine("TASK 20 IN ADVANCED");
        int[] nums20 = { 1, 2, 3, 2, 4, 2, 5 };
        int remove20 = 2;
        // احسب عدد العناصر اللي ما راح ينحذفوا
        int keepCount = 0;
        for (int i = 0; i < nums20.Length; i++)
            if (nums20[i] != remove20) keepCount++;
        // انسخ العناصر اللي ما راح ينحذفوا على المصفوفة الجديدة
        int[] result20 = new int[keepCount];
        int idx20 = 0;
        for (int i = 0; i < nums20.Length; i++)
            if (nums20[i] != remove20)
                result20[idx20++] = nums20[i];
        Console.WriteLine("[" + string.Join(",", result20) + "]");
    }
}