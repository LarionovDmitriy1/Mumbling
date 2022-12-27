using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mumbling;

public class MumblingWork
{
    public static String Accum(string s)
    {
        s = s.ToLower();
        string temp = "";
        string result = "";
        char[] engLett = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        for (int i = 0; i < engLett.Length; i++)
        {
            if (engLett.Contains(s[i]))
            {
                for (int j = 1; i < s.Length;)
                {
                    temp = s[i].ToString().ToUpper();
                    for (int k = 0; ; k++)
                    {
                        if (temp.Length == j)
                        {
                            result = result + temp + '-';
                            i++;
                            j++;
                            break;
                        }
                        temp = temp + s[i].ToString();
                    }

                }
            }
            break;
        }
        result = result.Remove(result.Length - 1, 1);
        return result;
    }
}
