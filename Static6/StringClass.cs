using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Static6
{
    static class StringClass
    {
       public static string Sub_String(this string text, int startIndex, int length)
        {
            string resultStr = "";   
         
            StringBuilder stringBuilder  = new StringBuilder();
            for (int i = startIndex; i < length + startIndex; i++)
            {               
                stringBuilder.Append(text[i]);                                
            }
            resultStr = stringBuilder.ToString();
            return resultStr; 
        }

       public static int Index_Of(this string text, string value)
       {
           int index = 0;           
           int i = 0;
           while (i<text.Length)
           {              
               if (text[i] == value[0])
               {                   
                   index = i;
                   break;
               }
               else
               {
                   i++;
                   index = -1;                  
               }
           }
           return index;
       }

       public static string Replace_(this string text, string oldValue, string newValue)
       {
           

           while (text.Index_Of(oldValue) != -1)
           {
               StringBuilder stringBuilder = new StringBuilder();
               int startIndex = text.Index_Of(oldValue);
               string headStr = text.Sub_String(0,startIndex);
               string tailStr = text.Sub_String(startIndex+oldValue.Length,text.Length-startIndex-oldValue.Length);               
               stringBuilder.Append(headStr);
               stringBuilder.Append(newValue);
               stringBuilder.Append(tailStr);
               text = stringBuilder.ToString();
           }

           return text;

 
       }

    }
}

