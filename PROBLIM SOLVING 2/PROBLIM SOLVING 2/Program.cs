using System;
class Projecr
{   
    //TASK 13
    static void Read()
    {
        List<int> numbers = new List<int> { 2, 5, 5, 8 };
        Validate(numbers);
    }

    static void Validate(List<int> numbers)
    {
        foreach (int n in numbers)
        {
            if (n < 0)
            {
                Console.WriteLine("Invalid input: negative numbers are not allowed.");
                return;   // اوقف السلسلة
            }
        }
        Transform(numbers);
    }

    static void Transform(List<int> numbers)
    {
        // الخطوة الاولى احذف التكرار مع الحفاظ على اول ظهور
        List<int> result = new List<int>();
        foreach (int n in numbers)
            if (!result.Contains(n))
                result.Add(n);

        // الخطوة الثانية اعكس الترتيب
        result.Reverse();

        // الخطوة الثالثة اضرب الاعداد الزوجية ب2
        for (int i = 0; i < result.Count; i++)
            if (result[i] % 2 == 0)
                result[i] *= 2;

        // Step 4: append the total sum (computed AFTER step 3)
        // الخطوة الرابعة احسب مجموع الاعداد بعد ما اعمل الخطوات الماضية
        int sum = 0;
        foreach (int n in result)
            sum += n;
        result.Add(sum);

        Print(result);
    }

    static void Print(List<int> numbers)
    {
        Console.WriteLine(string.Join(" ", numbers));
    }

    ////////////////////////////////////////////////////////////
    ///TASK 15
    static List<int> RemoveDuplicates(int[] arr)
    {
        List<int> result = new List<int>();
        foreach (int n in arr)
        {
            if (!result.Contains(n))
                result.Add(n);
        }
        return result;
    }
    static List<int> ReverseArray(List<int> list)
    {
        List<int> result = new List<int>();
        for (int i = list.Count - 1; i >= 0; i--)
            result.Add(list[i]);
        return result;
    }

    static List<int> MoveEvenNumbers(List<int> list)
    {
        List<int> evens = new List<int>();
        List<int> odds = new List<int>();
        foreach (int n in list)
        {
            if (n % 2 == 0)
                evens.Add(n);
            else
                odds.Add(n);
        }
        // ادمجهم و الاعداد الزوجية اول بعدها الفردية
        evens.AddRange(odds);
        return evens;
    }

    static void Main()
    {
        //TASK 1
        //int[] arr1 = [4, 8, 2, 5, 7];
        //Console.Write("[");
        //for (int i = 0, j = arr1.Length - 1; i <= arr1.Length / 2 && j >= arr1.Length / 2; i++, j--)
        //{
        //    if(i == j)
        //    {
        //        Console.Write(arr1[i] + "]");
        //    }
        //    else
        //    {
        //        Console.Write(arr1[i] + arr1[j] +",");
        //    }
        //}

        //TASK 2
        //int[] arr2 = [5, 3, 5, 2, 3, 3, 8];
        //for (int i = 0; i < arr2.Length; i++)
        //{
        //    bool seenBefore = false;
        //    for (int k = 0; k < i; k++)          // هل انا حسبته من قبل؟
        //        if (arr2[k] == arr2[i]) seenBefore = true;
        //    if (seenBefore) continue;
        //    int count = 0;
        //    for (int j = 0; j < arr2.Length; j++)   // احسب المجموع
        //        if (arr2[j] == arr2[i]) count++;
        //    Console.WriteLine(arr2[i] + " -> " + count);
        //}

        //TASK 3
        //int[] arr3 = { 1, 2, 5, 9, 6, 3, 4, 7 };
        //int longest = 0;
        //int i = 1;
        //while (i < arr3.Length)
        //{
        //    // هل هذا الانديكس هو بداية صعود يعني هل هو اكبر من اللي قبله 
        //    bool goingUp = arr3[i - 1] < arr3[i];
        //    if (!goingUp)
        //    {
        //        i++;            // اذا ما كان بزيد بروح على اللي بعده
        //        continue;
        //    }
        //    int start = i - 1;  // عشان اتذكر وين بلشت اطلع
        //    // بتحرك بالطلعة
        //    while (i < arr3.Length && arr3[i - 1] < arr3[i])
        //        i++;
        //    // بتحرك بالنزلة
        //    bool wentDown = false;
        //    while (i < arr3.Length && arr3[i - 1] > arr3[i])
        //    {
        //        wentDown = true;
        //        i++;
        //    }
        //    // الجبل لازم يكون اله صعود و هبوط
        //    if (wentDown)
        //    {
        //        int length = i - start;      // الانديكس صار بعد الجبل تبعي
        //        longest = Math.Max(longest, length);
        //    }
        //}
        //Console.WriteLine(longest);

        //TASK 4
        //int[] arr4 = [1, 2, 5, 4, 3, 6];
        //int[] sortedArr = [1, 2, 5, 4, 3, 6];
        //System.Array.Sort(sortedArr);
        //int count = 0;
        //for (int i = 0; i < arr4.Length; i++)
        //{
        //    if (arr4[i] != sortedArr[i])
        //    {
        //        count++;
        //    }
        //}
        //if (count == 2)
        //{
        //    Console.WriteLine("Almost Sorted");
        //}
        //else if (count == 0)
        //{
        //    Console.WriteLine("Already Sorted");
        //}
        //else
        //{
        //    Console.WriteLine("Not Sortable By One Swap");
        //}

        //TASK 5
        //int[] arr5A = { 1, 2, 3, 4 };
        //int[] arr5B = { 3, 4, 1, 2 };
        //int n = arr5A.Length;
        //bool found = false;
        //// جرب كل مقطة بداية محتملة
        //for (int s = 0; s < n && !found; s++)
        //{
        //    bool allMatch = true;
        //    // Check if A rotated by s == B
        //    for (int i = 0; i < n; i++)
        //    {
        //        if (arr5A[(i + s) % n] != arr5B[i])
        //        {
        //            allMatch = false;
        //            break;
        //        }
        //    }
        //    if (allMatch)
        //        found = true;
        //}
        //Console.WriteLine(found ? "YES" : "NO");

        //TASK 6
        //int[] arr6 = [ 2, 4, 1 ,2 ,4];
        //int total = 0;
        //for (int i = 0; i < arr6.Length; i++)
        //    total += arr6[i];
        //int leftSum = 0;
        //int answer = -1;
        //for (int i = 0; i < arr6.Length; i++)
        //{
        //    int rightSum = total - leftSum - arr6[i];
        //    if (leftSum == rightSum)
        //    {
        //        answer = i;
        //        break;
        //    }
        //    leftSum += arr6[i];
        //}
        //if (answer == -1) {
        //    Console.WriteLine("No Number Exist");
        //}
        //else 
        //Console.WriteLine("the index of the answer is : " + answer + "\nand it's value is : "+ arr6[answer]);

        //TASK 7
        //int[] arr7 = { 100, 4, 200, 1, 3, 2 };
        //HashSet<int> set = new HashSet<int>(arr7);
        //int longest = 0;
        //foreach (int num in set)
        //{
        //    if (!set.Contains(num - 1))
        //    {
        //        int current = num;
        //        int length = 1;
        //        // Count upward as long as the next number exists
        //        while (set.Contains(current + 1))
        //        {
        //            current++;
        //            length++;
        //        }
        //        longest = Math.Max(longest, length);
        //    }
        //}
        //Console.WriteLine(longest);

        //TASK 8
        //int[] arr8 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        //int position = 0; // انا لوين وصلت بالقراءة عشان ما اضل اعيد من الاول
        //int size = 1; //
        //while (position < arr8.Length)
        //{
        //    int end = Math.Min(position + size, arr8.Length);
        //    for (int k = end - 1; k >= position; k--)
        //    {
        //        Console.Write(arr8[k]);
        //        if (k > position) Console.Write(" ");
        //    }
        //    Console.WriteLine();
        //    position = end;
        //    size++;
        //}

        //TASK 9
        //int[] arr9 = [4, 1, 7, 3];
        //int maxDiff = int.MinValue;
        //for (int i = 0; i < arr9.Length; i++) {
        //    int greater = 0;
        //    int smaller = 0;
        //    for(int j=0; j < arr9.Length; j++)
        //    {
        //        if (arr9[i] < arr9[j]) greater++;
        //        else if (arr9[i] > arr9[j]) smaller++;
        //    }
        //    int diff = greater - smaller;
        //    if (diff > maxDiff)
        //        maxDiff = diff;
        //}
        //Console.WriteLine(maxDiff);

        //Task 10
        //int[] arr10 = { 5, 2, 7, 3, 8, 1 };
        //bool isZigzag = true;
        //for (int i = 0; i < arr10.Length - 1; i++)
        //{
        //    // اذا كان عنصرين جنب بعض يطلع دايركت
        //    if (arr10[i] == arr10[i + 1])
        //    {
        //        isZigzag = false;
        //        break;
        //    }
        //    if (i > 0)
        //    {
        //        bool prevWentUp = arr10[i - 1] < arr10[i];
        //        bool currWentUp = arr10[i] < arr10[i + 1];

        //        if (prevWentUp == currWentUp)
        //        {
        //            isZigzag = false;
        //            break;
        //        }
        //    }
        //}
        //Console.WriteLine(isZigzag ? "YES" : "NO");

        //TASK 11
        //List<int> list = new List<int> { 1, 2, 3, 4 };
        //for (int k = 1; k <= list.Count; k++)
        //{
        //    int left = 0;
        //    int right = k - 1;
        //    while (left < right)
        //    {
        //        int temp = list[left];
        //        list[left] = list[right];
        //        list[right] = temp;
        //        left++;
        //        right--;
        //    }
        //}
        //Console.WriteLine(string.Join(" ", list));


        //TASK 12
        //int[] arr12 = { 3, 5, 2, 7 };
        //for (int i = 0; i < arr12.Length; i++)
        //{
        //    int distance = -1;// القيمة الإفتراضية في حال ما لقيت اي قيمة اكير منها
        //    for (int j = i + 1; j < arr12.Length; j++)
        //    {
        //        if (arr12[j] > arr12[i])
        //        {
        //            distance = j - i;
        //            break;
        //        }
        //    }
        //    Console.WriteLine(distance);
        //}

        //TASK 13
        //Read();

        //TASK 14
        //List<int> list2 = new List<int> { 1, 2, 3, 4, 5, 6 };
        //while (list2.Count > 1)
        //{
        //    List<int> next = new List<int>();
        //    int pos = 0;
        //    int size = 1;
        //    while (pos < list2.Count)
        //    {
        //        int end = Math.Min(pos + size, list2.Count);
        //        int sum = 0;
        //        for (int k = pos; k < end; k++)
        //            sum += list2[k];
        //            next.Add(sum);
        //            pos = end;
        //            size++;
        //    }
        //    if (next.Count == list2.Count)
        //    {
        //        int total = 0;
        //        foreach (int v in next) total += v;
        //        list2 = new List<int> { total };
        //    }
        //    else
        //    {
        //        list2 = next;
        //    }
        //}
        //Console.WriteLine(list2[0]);

        //TASK 15
        Console.WriteLine("ALL THE TASKS ARE SOLVED BUT THEY ARE COMMENTED");
        int[] input = { 5, 2, 8, 2, 3, 5, 4, 8, 1 };
        List<int> step1 = RemoveDuplicates(input);
        List<int> step2 = ReverseArray(step1);
        List<int> step3 = MoveEvenNumbers(step2);
        Console.WriteLine(string.Join(" ", step3));
    }

}