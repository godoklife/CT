using System;
using System.Collections;
using System.Linq;

namespace CT
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            BunsuSum bun = new BunsuSum();

            Console.WriteLine(bun.solution(9,2,1,3)[0]);
            Console.WriteLine(bun.solution(9,2,1,3)[1]);

            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int solution(int num1, int num2)
        {
            if (num1 < 1 || num1 > 100 || num2 < 1 || num2 > 100)
                return -1;

            return num1/num2;
        }
    }

    public class Solution2
    {
        public int solution(int num1, int num2)
        {
            if (num1 < 0 || num1 > 100 || num2 < 0 || num2 > 100)
                return -1;

            return num1 * num2;
        }
    }

    public class Solution3
    {
        public int solution(int age)
        {
            if (age < 1 || age > 120)
                return -1;

            return 2022 - (age - 1 );
        }
    }

    public class ContinousNumSum
    {
        public int[] solution(int num, int total)
        {

            #region 제한사항
            
            if (num < 1 || num > 100 || total < 0 || total > 1000)
                return new int[] { };
            
            #endregion
            
            int[] answer = new int[num];
            int middleNum = total / num;
            int substractNum = total % num == 0 ? num / 2 : num / 2 - 1;
            int startNum = middleNum - substractNum;

            Console.WriteLine($"middleNum : {middleNum.ToString()}");
            Console.WriteLine($"substractNum : {substractNum.ToString()}");
            Console.WriteLine($"startNum : {startNum.ToString()}");
            
            for (int i = 0; i < num; i++)
                answer[i]= startNum + i;

            #region 제한사항

            if (answer.Sum() != total)
                answer = new int[] { };

            #endregion

            return answer;
        }
    }

    public class AlignChar
    {
        public string solution(string myString)
        {

            #region 제한사항

            if (myString.Length < 1 || myString.Length > 100)
                return string.Empty;

            #endregion

            return new string(myString.ToLower().ToCharArray().OrderBy(e => e).ToArray());
        }
    }

    public class NextNum
    {
        public int solution(int[] common)
        {
            return common[1] - common[0] == common[2] - common[1]
                ? common[common.Length - 1] + (common[1] - common[0])
                : common[common.Length - 1] * (common[1] / common[0]);
        }
    }

    public class Babbling
    {
        public int solution(string[] babbling)
        {
            string[] words = { "aya", "ye", "woo", "ma" };
            int result = 0;

            foreach (string babySays in babbling)
            {
                string[] tmp = babySays.Split(words, StringSplitOptions.RemoveEmptyEntries);
                if (tmp.Length == 0)
                    result++;
            }
            
            
            return result;
        }
    }

    public class BunsuSum
    {
        public int[] solution(int denum1, int num1, int denum2, int num2)
        {

            int larger = denum1 * num2 + denum2 * num1 > num1 * num2 ? denum1 * num2 + denum2 * num1 : num1 * num2;
            int smaller = denum1 * num2 + denum2 * num1 > num1 * num2 ? num1 * num2 : denum1 * num2 + denum2 * num1;
            int tmp = 0;

            while (true)
            {
                if(larger%smaller==0)
                    break;
                else
                {
                    tmp = larger;
                    larger = smaller;
                    smaller = tmp % smaller;
                }
            }
            return new int[] { (denum1 * num2 + denum2 * num1)/smaller, (num1 * num2)/smaller};
        }

        public class ArrayMp
        {
            public int[] solution(int[] numbers)
            {
                int[] resultArray = new int[numbers.Length];

                resultArray = numbers.Select(e => e * 2).ToArray();
                
                for (int i = 0; i < numbers.Length; i++)
                    numbers[i] *= 2;
                
                return numbers;
                // for문 돌리는게 Linq 쓰는거보다 3배가까이 빠름...
            }
        }

        public class StringChange
        {
            public int solution(string a, string b)
            {
                int answer = 0;

                if (! a.ToCharArray().All(e => b.ToCharArray().Contains(e)))
                    return -1;

                int count = 0;
                char[] tmpArray = a.ToCharArray();
                char tmpLastChar = '0';
                char tmpChar = '0';
                while (true)
                {
                    for (int i = 0; i < tmpArray.Length; i++)
                    {
                        tmpLastChar = tmpArray.Last();
                        for (int j = 0; j < tmpArray.Length; j++)
                        {
                            tmpChar = tmpArray[j];
                            
                        }
                        
                    }

                    if (new string(tmpArray).Equals(b))
                        return count;
                    if (count == tmpArray.Length)
                        return -1;
                }
                
            }
        }

        
    }
    
    
    /*
     * 9,2,1,3
     * 9/2 = 
     * 1/3 =
     *
     * 1,2,5,6
     * 1/2
     * 5/6
     * 
     */
    
}