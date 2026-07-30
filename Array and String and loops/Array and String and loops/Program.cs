using System;

class Program
{
    static void Main()
    {
        //TASK 1 IN THE RESEARCH
        //Console.WriteLine("TASK 1 IN THE RESEARCH");
        //int[] nums = { 10, 15, 22, 7, 8, 13, 30 };
        //int countEven = 0;
        //int countOdd = 0;
        //int sum = 0;
        //for (int i = 0; i < nums.Length; i++)
        //{
        //    if (nums[i] % 2 == 0)
        //        countEven++;
        //    else
        //        countOdd++;
        //    sum += nums[i];
        //}
        //double avg = (double)sum / nums.Length;
        //Console.WriteLine("Even count: " + countEven);
        //Console.WriteLine("Odd count: " + countOdd);
        //Console.WriteLine("Sum: " + sum);
        //Console.WriteLine("Average: " + avg);
        //int count = 0;
        //for (int i = 0; i < nums.Length; i++)
        //{
        //    if (nums[i] > avg)
        //        count++;
        //}
        //int[] filteredArray = new int[count];
        //int index = 0;
        //for (int i = 0; i < nums.Length; i++)
        //{
        //    if (nums[i] > avg)
        //    {
        //        filteredArray[index] = nums[i];
        //        index++;
        //    }
        //}

        //Console.Write("Filtered array: [");
        //for (int i = 0; i < filteredArray.Length; i++)
        //{
        //    Console.Write(filteredArray[i]);

        //    if (i < filteredArray.Length - 1)
        //        Console.Write(", ");
        //}
        //Console.WriteLine("]");

        //TASK 2 IN THE RESEARCH
        //Console.WriteLine("TASK 2 IN THE RESEARCH");
        //int[] maxNumber = { 12, 45, 7, 23, 56, 19 };
        //int max = maxNumber[0];
        //for (int i = 1; i < maxNumber.Length; i++) { 
        //    if (maxNumber[i] > max)
        //    {
        //        max = maxNumber[i];
        //    }
        //}
        //Console.WriteLine($"the max number is {max}");

        //TASK 3 IN THE RESEARCH
        //Console.WriteLine("TASK 3 IN THE RESEARCH");
        //int[] fromOneToTen = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //for (int i = 0; i < fromOneToTen.Length; i++) {
        //    Console.WriteLine($"From One To Ten {fromOneToTen[i]}");
        //    if (fromOneToTen[i] % 2 == 0)
        //    {
        //        Console.WriteLine($"Even : {fromOneToTen[i]}");
        //    }
        //}

        //TASK 4 IN THE RESEARCH
        //Console.WriteLine("TASK 4 IN THE RESEARCH");
        //Console.WriteLine("Enter Your Name");
        //string enterdName = Console.ReadLine();
        //Console.WriteLine("Enter Your Age");
        //int enterdAge = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter Your Height");
        //double enterdHeight = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("Are You An Employee ? (true/false)");
        //Boolean isEmployee = Convert.ToBoolean(Console.ReadLine());
        //Console.WriteLine($"---User Profile ---\n Name : {enterdName} \n Age : {enterdAge} \n Height : {enterdHeight} \n Employed : {isEmployee}");

        //TASK 1 IN THE ASSIGNMENT
        //Console.WriteLine("TASK 1 IN THE ASSIGNMENT");
        //int a = 5;
        //for (int i = 1; i <= a; i++)
        //{
        //    if (i % 2 == 1)
        //    {
        //        for (int j = 1; j <= i; j++)
        //        {
        //            Console.Write(j);
        //        }
        //    }
        //    else
        //    {
        //        for (int j = i; j >= 1; j--)
        //        {
        //            Console.Write(j);
        //        }
        //    }
        //    Console.WriteLine();
        //}

        //TASK 2 IN THE ASSIGNMENT
        //Console.WriteLine("TASK 2 IN THE ASSIGNMENT");
        //int b = 4;
        //for (int i = 1; i <= b; i++)
        //{
        //    for (int j = 1; j <= i; j++)
        //    {
        //        Console.Write(j);
        //    }
        //    for (int j = i; j >= 1; j--)
        //    {
        //        if (i < 3 && j == i)
        //        {
        //            Console.Write(i == 1 ? "   " : " ");
        //        }
        //        Console.Write(j);
        //    }
        //    Console.WriteLine();
        //}

        //TASK 3 IN THE ASSIGNMENT
        //Console.WriteLine("TASK 3 IN THE ASSIGNMENT");
        //int c = 4;
        //for (int i = 1; i <= c; i++)
        //{
        //    for (int j = c - i; j > 0; j--)
        //    {
        //        Console.Write(" ");
        //    }
        //    for (int j = 1; j <= 2 * i - 1; j++)
        //    {
        //        if (j < i)
        //            Console.Write(j);
        //        else
        //            Console.Write(2 * i - j);
        //    }
        //    Console.WriteLine();
        //}

        //TASK 4 IN THE ASSIGNMENT
        //Console.WriteLine("TASK 4 IN THE ASSIGNMENT");
        //int d = 4;
        //for (int i = 1; i <= d; i++)
        //{
        //    if (i % 2 == 1)
        //    {
        //        for (int j = 1; j <= i; j++)
        //        {
        //            if (j % 2 == 0)
        //            {
        //                continue;
        //            }
        //            Console.Write(j);
        //        }
        //        Console.WriteLine();
        //    }
        //    if (i % 2 == 0)
        //    {
        //        d++;
        //        continue;
        //    }

        //}


        //TASK 5 IN THE ASSIGNMENT
        //Console.WriteLine("TASK 5 IN THE ASSIGNMENT");
        //int e = 4, value = 1;
        //for (int i = 1; i <= e; i++)
        //{
        //    for (int j = 1; j <= i; j++)
        //        Console.Write(value + " ");
        //        Console.WriteLine();
        //        value *= 2;
        //}

        //TASK 6 IN THE ASSIGNMENT
        //Console.WriteLine("TASK 6 IN THE ASSIGNMENT");
        //int f = 4;
        //for (int i = 1; i <= f; i++)
        //{
        //    if (i % 2 == 1)
        //    {
        //        for (int j = 1; j <= i; j++)
        //        {
        //            Console.Write(j);
        //        }
        //    }
        //    else
        //    {
        //        for (int j = i; j >= 1; j--)
        //        {
        //            Console.Write(j);
        //        }
        //    }
        //    Console.WriteLine();
        //}

        //TASK 7 IN THE ASSIGNMENT
        //Console.WriteLine("TASK 7 IN THE ASSIGNMENT");
        //int g = 5;
        //for (int i = 1; i <= g; i++)
        //{
        //    // للمسافات
        //    for (int s = 1; s <= g - i; s++)
        //        Console.Write(" ");
        //    int width = 2 * i - 1;   // 1, 3, 5, 7, 9
        //    for (int j = 1; j <= width; j++)
        //    {
        //        if (i == g)                       // اخر صف اعبيه كله
        //            Console.Write("1");
        //        else if (j == 1 || j == width)    // صفوف الحواف
        //            Console.Write("1");
        //        else                              // وسط فاضي
        //            Console.Write(" ");
        //    }
        //    Console.WriteLine();
        //}

        //TASK 8 IN THE ASSIGNMENT
        //Console.WriteLine("TASK 8 IN THE ASSIGNMENT");
        //int  h= 5;
        //for (int i = 1; i <= h; i++)
        //{
        //    for (int j = 1; j <= h; j++)
        //    {
        //        // في القطر اليسار الاعمدة بتساوي الصفوف او (i==j)
        //        // Right diagonal: column mirrors it (j == n - i + 1)
        //        //القطر اليمين عبارة عن مراية للقطؤ اليسار
        //        if (j == i || j == h - i + 1)
        //            Console.Write(i);
        //        else
        //            Console.Write(" ");
        //    }
        //    Console.WriteLine();
        //}

        //TASK 9 IN THE ASSIGNMENT
        //Console.WriteLine("TASK 9 IN THE ASSIGNMENT");
        //int ii = 3;
        //int count2 = 1;
        //for(int i = 1; i<= ii; i++)
        //{
        //    for (int j = 1; j<= i; j++)
        //    {
        //        Console.Write(count2 + " ");
        //        count2 ++;
        //    }
        //    Console.WriteLine();
        //}

        //TASK 10 IN THE ASSIGNMENT
        //Console.WriteLine("TASK 10 IN THE ASSIGNMENT");
        //int n = 4;
        //for (int i = 1; i <= n; i++)
        //{
        //    if (i == n)
        //    {
        //        // Last row: solid bar of 1s spanning the full width
        //        for (int j = 1; j <= n + 1; j++)
        //            Console.Write("1");
        //    }
        //    else
        //    {
        //        Console.Write("1");                  // left wall

        //        for (int s = 1; s <= i; s++)         // i spaces in the middle
        //            Console.Write(" ");

        //        Console.Write("1");                  // right wall
        //    }
        //    Console.WriteLine();
        //}


        /////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////

        //ARRAY 
        //TASK 1 IN THE ARRAY
        //Console.WriteLine("TASK 1 IN ARRAY");
        //int[] arrOne = [1, 2, 1, 3, 4];
        //int first = 0;
        //int second = 0;
        //for (int i = 0; i <= arrOne.Length - 1; i++)
        //{
        //    if (arrOne[i] != arrOne[i + 1])
        //    {
        //        first = arrOne[i];
        //        second = arrOne[i + 1];
        //        break;
        //    }
        //}
        //Console.WriteLine("[" + first + "," + second + "]");

        //TASK 2 IN THE ARRAY
        //Console.WriteLine("TASK 2 IN ARRAY");
        //int[] arrTWO = [1, 2, 1, 2, 1, 2];
        //Dictionary<int, List<int>> positions = new Dictionary<int, List<int>>();
        //for (int i = 0; i < arrTWO.Length; i++)
        //{
        //    if (!positions.ContainsKey(arrTWO[i]))
        //        positions[arrTWO[i]] = new List<int>();

        //    positions[arrTWO[i]].Add(i);
        //}
        //// Check each value's gaps
        //foreach (var pair in positions)
        //{
        //    List<int> idx = pair.Value;

        //    if (idx.Count < 2) // لازم تظهر اكثر من مرة عشان احسب الها المسافة
        //        continue;

        //    int gap = idx[1] - idx[0];  // اول مسافة اللي الباقي لازم يطابقوها
        //    bool equal = true;

        //    for (int k = 1; k < idx.Count; k++)
        //    {
        //        if (idx[k] - idx[k - 1] != gap)
        //        {
        //            equal = false;
        //            break;
        //        }
        //    }

        //    if (equal)
        //        Console.Write(pair.Key + " ");
        //}

        //TASK 3 IN THE ARRAY
        //Console.WriteLine("TASK 3 IN ARRAY");
        //int[] arrThree = [1, 1, 2, 2, 3, 1];
        //Console.Write("[");
        //for (int i = 0; i < arrThree.Length; i++)
        //{
        //    Console.Write(arrThree[i]);
        //    if (i == arrThree.Length - 1 || arrThree[i] != arrThree[i + 1])
        //    {
        //        Console.Write("]");
        //        if (i != arrThree.Length - 1)
        //            Console.Write(" [");
        //    }
        //    else
        //    {
        //        Console.Write(","); 
        //    }
        //}
        //Console.WriteLine();

        //TASK 4 IN THE ARRAY
        //Console.WriteLine("TASK 4 IN ARRAY");
        //int[] arrFour = [1, 3, 2, 4];
        //int[] sorted = (int[])arrFour.Clone();
        //System.Array.Sort(sorted);
        //int counter = 0;
        //for (int i = 0; i < arrFour.Length; i++) { 
        //    if (arrFour[i] != sorted[i])
        //    {
        //        counter++;
        //    }
        //}
        //if (counter == 2)
        //{
        //    Console.WriteLine("Yes");
        //}
        //else
        //{
        //    Console.WriteLine("No");
        //}

        //TASK 5 IN THE ARRAY
        //Console.WriteLine("TASK 5 IN ARRAY");
        //int[] arrFive = [1, 1, 2, 2, 3, 1];
        //Console.Write("[");
        //for (int i = 0; i < arrFive.Length; i++)
        //{
        //    Console.Write(arrFive[i]);
        //    if (i == arrFive.Length - 1 || arrFive[i] != arrFive[i + 1])
        //    {
        //        Console.Write("]");
        //        if (i != arrFive.Length - 1)
        //            Console.Write(" [");
        //    }
        //    else
        //    {
        //        Console.Write(",");
        //    }
        //}
        //Console.WriteLine();


        //TASK 6 IN THE ARRAY
        //Console.WriteLine("TASK 6 IN ARRAY");
        //int[] arrSix = [1, 2, 3, 2, 4];
        //int start = 0, end = arrSix.Length; // end-start = length, start big

        //for (int i = 0; i < arrSix.Length; i++)
        //    for (int j = i + 1; j < arrSix.Length; j++)
        //        if (arrSix[i] == arrSix[j] && j - i < end - start)
        //        {
        //            start = i;
        //            end = j;
        //        }
        //Console.Write("[");
        //for (int k = start; k <= end; k++)
        //    Console.Write(arrSix[k] + (k < end ? "," : ""));
        //Console.WriteLine("]");


        //TASK 7 IN THE ARRAY
        //Console.WriteLine("TASK 7 IN ARRAY");
        //int[] arrSeven = [5, 7, 10];
        //int[] newArr = new int[arrSeven.Length];
        //newArr[0] = arrSeven[0];
        //for (int i = 1; i < arrSeven.Length; i++)
        //{
        //    newArr[i] = arrSeven[i] - arrSeven[i - 1];        }
        //Console.Write("[");
        //for (int i = 0; i < newArr.Length; i++)
        //{
        //    if (i == newArr.Length-1)
        //    {
        //        Console.Write(newArr[i]);
        //    }
        //    else
        //    {
        //        Console.Write(newArr[i] + ",");
        //    }
        //}
        //Console.Write("]");

        //TASK 8 IN THE ARRAY
        //Console.WriteLine("TASK 8 IN ARRAY");
        //int[] arrEight = [1, -2, 3, -4, 5];
        //List<int> pos = new List<int>();
        //List<int> neg = new List<int>();
        //for (int i = 0; i < arrEight.Length; i++)
        //{
        //    if (arrEight[i] >= 0) pos.Add(arrEight[i]);
        //    else neg.Add(arrEight[i]);
        //}
        //List<int> result = new List<int>();
        //int p = 0, n = 0;
        //bool takePos = true;

        //while (p < pos.Count || n < neg.Count)
        //{
        //    if (takePos && p < pos.Count)
        //        result.Add(pos[p++]);
        //    else if (!takePos && n < neg.Count)
        //        result.Add(neg[n++]);
        //    else if (p < pos.Count)
        //        result.Add(pos[p++]);
        //    else
        //        result.Add(neg[n++]);
        //    takePos = !takePos;
        //}

        //Console.WriteLine("[" + string.Join(",", result) + "]");

        //TASK 9 IN THE ARRAY
        //Console.WriteLine("TASK 9 IN ARRAY");
        //int[] arrNine = [1, 2, 3, 3];
        //int total = 0;
        //for (int i = 0; i < arrNine.Length; i++)
        //    total += arrNine[i];
        //int leftSum = 0;
        //int answer = -1;
        //for (int i = 0; i < arrNine.Length; i++)
        //{
        //    int rightSum = total - leftSum - arrNine[i];
        //    if (leftSum == rightSum)
        //    {
        //        answer = i;
        //        break;
        //    }
        //    leftSum += arrNine[i];
        //}
        //Console.WriteLine("the index of the answer is : " + answer + "\nand it's value is : "+ arrNine[answer]);

        //TASK 10 IN THE ARRAY
        //Console.WriteLine("TASK 10 IN ARRAY");
        //int[] arrTen = [3, 1, 2, 5, 4, 6];
        //int[] dp = new int[arrTen.Length];
        //int best = 0;
        //for (int i = 0; i < arrTen.Length; i++)
        //{
        //    dp[i] = 1;
        //    for (int j = 0; j < i; j++)
        //    {
        //        if (arrTen[j] < arrTen[i] && dp[j] + 1 > dp[i])
        //            dp[i] = dp[j] + 1;
        //    }
        //    if (dp[i] > best)
        //        best = dp[i];
        //}
        //Console.WriteLine(best);


        /////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////

        //STRING
        //TASK 1 IN THE STRING
        //Console.WriteLine("TASK 1 IN STRING");
        //string str = "aAbBcC";
        //string result = "";

        //foreach (char c in str)
        //{
        //    if (result.Length > 0 &&
        //        char.ToLower(result[result.Length - 1]) == char.ToLower(c) && 
        //        result[result.Length - 1] != c)
        //        result = result.Substring(0, result.Length - 1);
        //    else
        //        result += c;
        //}

        //Console.WriteLine("\"" + result + "\"");


        //TASK 2 IN THE STRING
        //Console.WriteLine("TASK 2 IN STRING");
        //string str2 = "banana";
        //string result2 = "";
        //for (int i = 0; i < str2.Length; i++)
        //{
        //    bool seen = false;
        //    for (int k = 0; k < i; k++)
        //        if (str2[k] == str2[i]) seen = true;
        //    if (seen) continue;
        //    int count = 0;
        //    for (int j = 0; j < str2.Length; j++)
        //        if (str2[j] == str2[i]) count++;
        //            result2 += str2[i].ToString() + count;
        //}
        //Console.WriteLine(result2);

        //TASK 3 IN THE STRING
        //Console.WriteLine("TASK 3 IN STRING");
        //string str3 ="aaBBcc";
        //string result3 = "";
        //for (int i = 0; i < str3.Length; i++)
        //{
        //    if(i % 2 != 0)
        //    {
        //        result3 += str3[i].ToString().ToUpper();
        //    }
        //    else
        //    {
        //        result3 += str3[i].ToString().ToLower();
        //    }
        //}
        //Console.WriteLine(result3);

        //TASK 4 IN THE STRING
        //Console.WriteLine("TASK 4 IN STRING");
        //string str4 = "10101";
        //int result4 = 0;
        //for (int i = 0; i < str4.Length; i++)
        //{
        //    int zeros = 0, ones = 0;

        //    for (int j = i; j < str4.Length; j++)   // every substring starting at i
        //    {
        //        if (str4[j] == '0') zeros++;
        //        else ones++;

        //        if (zeros == ones)
        //            result4++;
        //    }
        //}

        //Console.WriteLine(result4);

        //TASK 5 IN THE STRING
        //Console.WriteLine("TASK 5 IN STRING");
        //string s = "a-bC-dEf-ghIj";
        //char[] arrFive = s.ToCharArray();
        //int left = 0;
        //int right = arrFive.Length - 1;
        //while (left < right)
        //{
        //    if (!char.IsLetter(arrFive[left]))
        //        left++;
        //    else if (!char.IsLetter(arrFive[right]))
        //        right--;
        //    else
        //    {
        //        char temp = arrFive[left];
        //        arrFive[left] = arrFive[right];
        //        arrFive[right] = temp;
        //        left++;
        //        right--;
        //    }
        //}
        //Console.WriteLine("\"" + new string(arrFive) + "\"");

        //TASK 6 IN THE STRING
        //Console.WriteLine("TASK 6 IN STRING");
        //string strArr = "aaabbccccd";
        //int best = 0;
        //int current = 0;
        //for (int i = 0; i < strArr.Length; i++)
        //{
        //    if (i > 0 && strArr[i] == strArr[i - 1])
        //        current++;
        //    else
        //        current = 1;
        //    if (current > best)
        //        best = current;
        //}
        //Console.WriteLine(best);

        //TASK 7 IN THE STRING
        //Console.WriteLine("TASK 7 IN STRING");
        //string strArr2 = "abc";
        //string resultArr = "";
        //for (int i = 0; i < strArr2.Length; i++)
        //{
        //    char next = (char)(strArr2[i] + 1);
        //    resultArr += next;
        //}
        //Console.WriteLine("\"" + resultArr + "\"");

        //TASK 8 IN THE STRING
        //Console.WriteLine("TASK 8 IN STRING");
        //string strArr3 = "abca";
        //bool ok = false;

        //for (int skip = 0; skip < strArr3.Length; skip++)
        //{
        //    string t = strArr3.Remove(skip, 1);
        //    bool pal = true;
        //    for (int i = 0; i < t.Length / 2; i++)
        //        if (t[i] != t[t.Length - 1 - i]) { pal = false; break; }
        //    if (pal) { ok = true; break; }
        //}
        //Console.WriteLine(ok ? "Yes" : "No");

        //TASK 9 IN THE STRING
        //Console.WriteLine("TASK 9 IN STRING");
        //string strArr4 = "abca";
        //for (int i = 0; i < strArr4.Length; i++)
        //{
        //    bool seen = false;
        //    for (int k = 0; k < i; k++)
        //        if (strArr4[k] == strArr4[i]) seen = true;
        //    if (seen) continue;
        //    for (int j = i + 1; j < strArr4.Length; j++)
        //        if (strArr4[j] == strArr4[i])
        //        {
        //            Console.WriteLine(strArr4[i] + " : " + (j - i));
        //            break;
        //        }
        //}

        //TASK 10 IN THE STRING
        Console.WriteLine("ALL THE TASKS ARE SOLVED BUT THEY ARE COMMENTED");
        Console.WriteLine("TASK 10 IN STRING");
        string strArr5 = "LRLRLLRR";

        int balance = 0;
        int count = 0;

        for (int i = 0; i < strArr5.Length; i++)
        {
            if (strArr5[i] == 'L') balance++;
            else balance--;

            if (balance == 0)
                count++;
        }

        Console.WriteLine(count);
    }
}