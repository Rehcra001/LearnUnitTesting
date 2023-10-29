using System.Text;

namespace LeetCodeSolutionsLibrary.Strings
{
    public static class Strings
    {
        public static string AddBinary(string a, string b)
        {
            StringBuilder sb = new StringBuilder();

            char carry = '0';
            string minStr;
            string maxStr;
            int minLength;
            int maxLength;

            if (a.Length < b.Length)
            {
                minStr = a;
                minLength = a.Length;
                maxStr = b;
                maxLength = b.Length;
            }
            else
            {
                minStr = b;
                minLength = b.Length;
                maxStr = a;
                maxLength = a.Length;
            }

            sb.Length = maxLength + 1;


            for (int i = sb.Length - 1; i >= 0; i--)
            {
                if (minLength > 0)
                {
                    (sb[i], carry) = GetSumOfBinaryChar(minStr[minLength - 1], maxStr[maxLength - 1], carry);
                    minLength--;
                    maxLength--;
                }
                else if (maxLength > 0)
                {
                    (sb[i], carry) = GetSumOfBinaryChar('0', maxStr[maxLength - 1], carry);
                    maxLength--;
                }
                else if (carry.Equals('1'))
                {
                    sb[i] = carry;
                }
            }


            if (sb[0] == default || sb[0] == '0')
            {
                return sb.ToString().Substring(1);
            }

            return sb.ToString();
        }

        public static string AddBinary2(string a, string b)
        {
            StringBuilder sb = new StringBuilder();
            int length = Math.Max(a.Length, b.Length) + 1;
            sb.Length = length;

            int aLength = a.Length;
            int bLength = b.Length;


            int carry = 0;

            for (int i = length - 1; i >= 1; i--)
            {
                carry += aLength > 0 ? a[aLength - 1] - '0' : 0;
                carry += bLength > 0 ? b[bLength - 1] - '0' : 0;
                aLength--;
                bLength--;

                sb[i] = carry % 2 == 0 ? '0' : '1';
                carry /= 2;
            }

            if (carry == 1)
            {
                sb[0] = '1';
                return sb.ToString();

            }
            else
            {
                string str = sb.ToString()[1..];
                return str;
            }
        }

        public static int StrStr(string haystack, string needle)
        {
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (haystack[i].Equals(needle[0]) && needle.Length == 1)
                {
                    return i;
                }

                if (haystack[i].Equals(needle[0]))
                {
                    for (int j = 1; j < needle.Length; j++)
                    {
                        if (!haystack[i + j].Equals(needle[j]))
                        {
                            break;
                        }
                        else if (j == needle.Length - 1)
                        {
                            return i;
                        }
                    }
                }
            }
            return -1;
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 1)
            {
                return strs[0];
            }

            //Load the first element as the prefix
            StringBuilder prefix = new StringBuilder(strs[0]);

            //Loop through each element and remove no common prefix chars
            for (int i = 1; i < strs.Length; i++)
            {
                int prefixLength = 0;
                int length = Math.Min(prefix.Length, strs[i].Length);
                for (int j = 0; j < length; j++)
                {
                    //Count matches
                    if (prefix[j].Equals(strs[i][j]))
                    {
                        prefixLength++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (prefixLength == 0)
                {
                    return "";
                }
                else if (prefixLength < prefix.Length)
                {
                    prefix.Length = prefixLength;
                }
            }
            return prefix.ToString();
        }

        public static void ReverseString(char[] s)
        {
            if (s.Length == 1)
            {
                return;
            }

            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                //Swap
                (s[left], s[right]) = (s[right], s[left]);
                left++;
                right--;
            }
        }

        public static string ReverseWords(string s)
        {
            StringBuilder str = new StringBuilder(s.Length);
            //Reverse string
            for (int i = s.Length - 1; i >= 0; i--)
            {

                if (!s[i].Equals((char)(32)))
                {
                    str.Append(s[i]);
                }
                else
                {
                    //Not the last char
                    if (i <= s.Length - 2)
                    {
                        //check if previous was non space
                        if (s[i + 1] != (char)(32))
                        {
                            //add space
                            str.Append((char)(32));
                        }
                    }
                }
            }

            //reverse words
            int left = 0;
            int right = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == (char)32 || i == str.Length - 1)
                {
                    right = i;
                    if (i == str.Length - 1 && str[i] != (char)32)
                    {
                        ReversePartion(str, left, right);
                    }
                    else
                    {
                        ReversePartion(str, left, right - 1);
                    }
                    
                    //set left
                    left = right + 1;
                }
            }
            if (str[str.Length - 1] == (char)32)
            {
                str.Length = str.Length - 1;
            }
            return str.ToString();
        }

        

        private static (char, char) GetSumOfBinaryChar(char a, char b, char carry)
        {
            int sum = a + b + carry;
            char result = '0';

            switch (sum)
            {
                case 144: // 0
                    result = '0';
                    carry = '0';
                    break;
                case 145: // 1
                    result = '1';
                    carry = '0';
                    break;
                case 146: // 2
                    result = '0';
                    carry = '1';
                    break;
                case 147: // 3
                    result = '1';
                    carry = '1';
                    break;

            }

            return (result, carry);
        }

        public static string ReverseWords2(string s)
        {
            StringBuilder str = new StringBuilder(s);

            //loop through and reverse each word's letters
            int len = str.Length;
            int left = 0;
            int right = 0;
            while (right < len)
            {
                if (str[right] == (char)32 || right == len - 1)
                {
                    if (right == len - 1)
                    {
                        ReversePartion(str, left, right);
                    }
                    else
                    {
                        ReversePartion(str, left, right - 1);
                        left = right + 1;
                    }                    
                }
                right++;
            }
            return str.ToString();
        }

        private static void ReversePartion(StringBuilder str, int left, int right)
        {
            while (left < right)
            {
                //swap
                (str[left], str[right]) = (str[right], str[left]);
                left++;
                right--;
            }
        }
    }
}
