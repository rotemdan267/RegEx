using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q-1

            //Regex startsWithD = new Regex("^[D]");
            //Console.WriteLine("Enter text:");
            //string txt = Console.ReadLine();
            //Console.WriteLine(startsWithD.IsMatch(txt));

            #endregion

            #region Q-2,3

            //Regex startsWithDFJ = new Regex(@"^[DFJ]\d{6}_[A-Z]{2}");
            //Console.WriteLine("Enter text:");
            //string txt1 = Console.ReadLine();
            //Console.WriteLine(startsWithDFJ.IsMatch(txt1));

            #endregion

            #region Q-4

            //Regex textToReplace = new Regex("yyy");
            //Regex text2ToReplace = new Regex("zzzz");
            //Console.WriteLine("Enter text:");
            //string txt2 = Console.ReadLine();
            //txt2 = textToReplace.Replace(txt2, "");
            //txt2 = text2ToReplace.Replace(txt2, "");
            //Console.WriteLine(txt2);

            #endregion

            #region Q-5

            //Regex startsWithD = new Regex("^[A-Z]");
            //Console.WriteLine("Enter text:");
            //string txt3 = Console.ReadLine();
            //Console.WriteLine(startsWithD.IsMatch(txt3));

            #endregion

            #region Q-6

            //Regex doesContain = new Regex(".*abc.*");
            //Regex doesContain2 = new Regex(".*ABC.*");
            //Console.WriteLine("Enter text:");
            //string txt6 = Console.ReadLine();
            //bool check = doesContain.IsMatch(txt6);
            //if (!check)
            //{
            //    check = doesContain2.IsMatch(txt6);
            //}
            //Console.WriteLine(check);

            #endregion

            #region Q-7

            //Regex isName = new Regex(@"^[A-Z]\D{1,17} +[A-Z]\D{1,17}");
            //Console.WriteLine("Enter text:");
            //string txt7 = Console.ReadLine();
            //Console.WriteLine(isName.IsMatch(txt7));

            #endregion

            #region Q-8

            //Regex isDecimal = new Regex(@"\d+\.\d+");
            //Console.WriteLine("Enter text:");
            //string txt8 = Console.ReadLine();
            //Console.WriteLine(isDecimal.IsMatch(txt8));

            #endregion

            #region Q-9

            //Regex isDecimal3 = new Regex(@"\d+\.\d{3}");
            //Console.WriteLine("Enter text:");
            //string txt9 = Console.ReadLine();
            //Console.WriteLine(isDecimal3.IsMatch(txt9));

            #endregion


            #region Q-10

            Regex isGmail = new Regex(@".+\@(gmail\.com)");
            Regex isYahoo = new Regex(@".+\@(yahoo\.com)");
            Console.WriteLine("Enter text:");
            string txt10 = Console.ReadLine();
            bool check = isGmail.IsMatch(txt10);
            if (!check)
            {
                check = isYahoo.IsMatch(txt10);
            }
            Console.WriteLine(check);

            #endregion

            Console.ReadLine();
        }
    }
}
