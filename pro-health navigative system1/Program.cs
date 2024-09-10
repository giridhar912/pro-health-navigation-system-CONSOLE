using System.ComponentModel.Design;
using System.Text.RegularExpressions;

namespace POJECT
{
    class program

    {
        public static string name, age, blood_group, disease;
        public static int a, b, c, d, e, f, num1, nft, test_bill;
        static long phn;
        static string u = "^[a-z]";
        static string pa = "^[0-9].....$";
        static List<string> test= new List<string>();
        static void Main(string[] args)
        {
            Label1:
            test.Add(" normal ");
            test.Add(" completly alright ");
            test.Add(" ok ");
            test.Add(" abnormal ");
            test.Add(" negative ");
            test.Add(" positive ");
            test.Add(" not completely alright ");
            test.Add(" not ok ");
            Console.ForegroundColor = ConsoleColor.Blue;
          Console.WriteLine("                 WELCOME TO PRO-HEALTH NAVIGATING SYSTEM               ");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("  SELECT BELOW WHO ARE YOU (1 OR 2)");
            Console.WriteLine();
            Console.WriteLine(" 1.PATIENT ");
            Console.WriteLine();
            Console.WriteLine(" 2.ADMIN ");
            Console.WriteLine();
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine();
                Console.WriteLine(" YOUR ARE     : " + "PATIENT");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(" PLEASE,COMPLETE YOUR OP APPLICATION ");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine();
                Console.Write("  OP  ");
                Console.WriteLine("\n");
                Console.Write(" NAME         : ");
                name = Console.ReadLine();
                Console.WriteLine();
                Console.Write(" AGE          : ");
                age = Console.ReadLine();
                Console.WriteLine();
                Console.Write(" BLOOD_GROUP  : ");
                blood_group = Console.ReadLine();
                Console.WriteLine();
                Console.Write(" PHONE NUMBER : ");
                phn = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(" OP DETAILS ARE :)");
                Console.WriteLine("-------------------");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(" NAME         : " + name);
                Console.WriteLine();
                Console.WriteLine(" AGE          : " + age);
                Console.WriteLine();
                Console.WriteLine(" BLOOD_GROUP  : " + blood_group);
                Console.WriteLine();
                Console.WriteLine(" PHONE NUMBER : " + phn);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" DO FIRST YOUR BLOOD TEST  ");
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
                Console.WriteLine(" IF IT IS 1.NORMAL OR 2.ABNORMAL");
                Console.WriteLine();
            
                b = Convert.ToInt32(Console.ReadLine());
                if (b == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine(" YOU ARE COMPLETLY ALRIGHT DON'T WORRY  ");
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine(" TAKE SOME PRECASIONS, AS BELOW GIVE ");
                    Console.WriteLine();
                    Console.WriteLine("--------------------------------------");
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine(" 1.Take good food daily in your dite ");
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine(" 2.Be clean and neat in your daily life ");
                    Console.WriteLine();
                    Console.WriteLine("UPDATE AFTER SOME DAYS YOUR TEST DETAILES");
                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("BEFORE UPDATE TEST RESULT IS :" + test[0]);
                    Console.WriteLine();
                    Thread.Sleep(1000);
                    Console.WriteLine("AFTER SOME DAYS ***************************");
                    Console.WriteLine();
                    Console.WriteLine("AFTER UPDATE TEST RESULR IS :" + test[1]);
                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine(" SIR,PLEASE COMPLETE YOUR BILLING  :) ");
                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(" ENTER THE NUMBER OF PATIENTS : ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine(" PRICE OF TEST1 : " + num1 + "X" + "10000=" + (num1 * 10000) + " ");
                    Console.WriteLine();
                    Console.WriteLine(" TOTAL AMOUNT   : " + ((num1 * 10000) + ""));
                    Console.WriteLine();
                    Thread.Sleep(1000);

                }
                else if (b==2)
                {

                    test.Add(test[3]);
                    Console.WriteLine("BEFORE UPDATE THE TEST :" + test[3]);
                    Console.WriteLine();
                    Console.WriteLine("-------------------------------");
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine("AFTER SOME DAYS ***************************");
                    test.Add(test[2]);
                    Console.WriteLine();
                    Console.WriteLine("AFTER UPDATE THE TEST :" + test[7]);
                    Console.WriteLine();
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("THE PRESENT TEST POSITION IS :" + test[7]);
                    Console.WriteLine();
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine(" PLEASE DO FURTHER NEXT TEST BECAUSE YOUR TEST CAME 'ABNORMAL'");
                    Console.WriteLine();
                    Console.WriteLine("                TEST-2               ");
                    Console.WriteLine();
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine(" PLEASE DO NEXT TEST-2 ");
                    Console.WriteLine();
                    Console.WriteLine(" IF IT IS 1.NORMAL OR 2.ABNORMAL");
                    Console.WriteLine();
                    c = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    if (c == 1)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(" YOU ARE OK BUT YOU USING SOME DAYS MEDICINE  ");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        Console.WriteLine(" TAKE SOME PRECASIONS, AS BELOW GIVE ");
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------------");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        Console.WriteLine(" 1.Take good food daily in your dite        ");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        Console.WriteLine(" 2.Be clean and neat in your daily life      ");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        Console.WriteLine(" 3.Take the medicine daily without fail      ");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        Console.WriteLine(" 4.Do check-up after some days using medicine ");
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine(" TAKE THE UPDATE ON TEST CHECK-UPS");
                        Console.WriteLine("------------------------------------------------");
                        test.Add(test[0]);
                        Console.WriteLine();
                        Console.WriteLine(" BEFORE UPDATE THE TEST :" + test[0]);
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine();
                        Thread.Sleep(1000);
                        Console.WriteLine(" AFTER SOME DAYS ***************************");
                        test.Add(test[1]);
                        Console.WriteLine();
                        Console.WriteLine("AFTER UPDATE THE TEST :" + test[1]);
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(" THE PRESENT TEST POSITION IS :" + test[1]);
                        Thread.Sleep(2000);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" AFTER SOME DAYS ");
                        Console.WriteLine();
                        Console.WriteLine(" PLEASE DO YOUR CHECK-UP FIRST ");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine(" THE RESULT IS 1.OK or 2.NORMAL ");
                        d = Convert.ToInt32(Console.ReadLine());
                        if (d == 1)
                        {
                            test.RemoveAt(0);
                            test.Add(test[1]);
                            Console.WriteLine(" BEFORE UPDATE THE TEST :" + test[1]);
                            Console.WriteLine("-------------------------------");
                            Console.WriteLine();
                            Thread.Sleep(1000);
                            Console.WriteLine(" AFTER SOME DAYS ***************************");
                            test.Add(test[3]);
                            Console.WriteLine(" AFTER UPDATE THE TEST :" + test[3]);
                            Console.WriteLine("-------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(" THE PRESENT TEST POSITION IS :" + test[3]);
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine();
                            Console.WriteLine(" SIR,PLEASE COMPLETE YOUR BILLING  :) ");
                            Console.WriteLine("-----------------------------------------");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(" ENTER THE NUMBER OF PATIENTS : ");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine(" PRICE OF TEST1 : " + num1 + "X" + "10000=" + (num1 * 10000) + " ");
                            Console.WriteLine();
                            Console.WriteLine(" PRICE OF TEST2 : " + num1 + "X" + "20000=" + (num1 * 20000) + " ");
                            Console.WriteLine();
                            Console.WriteLine(" TOTAL AMOUNT   : " + ((num1 * 10000) + (num1 * 20000) + ""));
                            Console.WriteLine();

                        }
                        else if (d == 2) ;
                        {
                            test.Add(test[0]);
                            Console.WriteLine(" Before the test is :" + test[0]);
                            Console.WriteLine();
                            Thread.Sleep(1000);
                            Console.WriteLine(" AFTER SOME DAYS ***************************");
                            test.Add(test[1]);
                            Console.WriteLine(" After the test is :" + test[1]);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Thread.Sleep(1000);
                            Console.WriteLine();
                            Console.WriteLine(" KEEP USING MEDICINE  :)");
                            Console.WriteLine();
                            Console.WriteLine(" SIR,PLEASE COMPLETE YOUR BILLING  :) ");
                            Console.WriteLine();
                            Console.WriteLine("-----------------------------------------");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write(" ENTER THE NUMBER OF PATIENTS : ");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine(" PRICE OF TEST1 : " + num1 + "X" + "10000=" + (num1 * 10000) + " ");
                            Console.WriteLine();
                            Console.WriteLine(" PRICE OF TEST2 : " + num1 + "X" + "20000=" + (num1 * 20000) + " ");
                            Console.WriteLine();
                            Console.WriteLine(" TOTAL AMOUNT   : " + ((num1 * 10000) + (num1 * 20000) + ""));
                            Console.WriteLine();
                        }
                    }
                    else if(c==2)
                    {
                        test.Add(test[3]);
                        Console.WriteLine("BEFORE UPDATE THE TEST :" + test[3]);
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine();
                        Thread.Sleep(1000);
                        Console.WriteLine("AFTER SOME DAYS ***************************");
                        test.Add(test[2]);
                        Console.WriteLine("AFTER UPDATE THE TEST :" + test[3]);
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("THE PRESENT TEST POSITION IS :" + test[7]);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine(" PLEASE DO FURTHER NEXT TEST BECAUSE YOUR TEST CAME 'ABNORMAL' ");
                        Console.WriteLine();
                        Console.WriteLine("                TEST-3                ");
                        Console.WriteLine();
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(" PLEASE DO NEXT TEST-3");
                        Console.WriteLine();
                        Console.WriteLine(" IF IT IS 1.NAGITIVE OR 2.POSITIVE");
                        e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        if (e == 1)
                        {
                            Console.WriteLine();
                            test.Add(test[4]);
                            Console.WriteLine("BEFORE UPDATE THE TEST :" + test[4]);
                            Console.WriteLine("-------------------------------");
                            Console.WriteLine();
                            Thread.Sleep(1000);
                            Console.WriteLine("AFTER SOME DAYS ***************************");
                            Thread.Sleep(1000);
                            test.Add(test[3]);
                            Console.WriteLine();
                            Console.WriteLine("AFTER UPDATE THE TEST :" + test[0]);
                            Thread.Sleep(1000);
                            test.Add(test[1]);
                            Console.WriteLine();
                            Console.WriteLine("AFTER UPDATE THE TEST :" + test[1]);
                            Console.WriteLine();
                            Console.WriteLine("-------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("THE PRESENT TEST POSITION IS :" + test[1]);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine(" YOU ARE OK BUT YOU USING SOME DAYS MEDICINE AND DAILY CHECK-UPS ");
                            Thread.Sleep(1000);
                            Console.WriteLine();
                            Console.WriteLine(" TAKE SOME PRECASIONS, AS BELOW GIVE ");
                            Console.WriteLine();
                            Console.WriteLine("--------------------------------------");
                            Thread.Sleep(1000);
                            Console.WriteLine();
                            Console.WriteLine(" 1.Take good food daily in your Dite");
                            Thread.Sleep(1000);
                            Console.WriteLine("");
                            Console.WriteLine(" 2.Be clean and neat in your daily life");
                            Thread.Sleep(1000);
                            Console.WriteLine();
                            Console.WriteLine(" 3.Take the medicine daily without fail");
                            Thread.Sleep(1000);
                            Console.WriteLine();
                            Console.WriteLine(" 4.Do check-up after some days using medicine");
                            Thread.Sleep(1000);
                            Console.WriteLine();
                            Console.WriteLine(" 5.Please visit hospital daily for regular check-ups");
                            Thread.Sleep(2000);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine(" AFTER SOME DAYS ");
                            Console.WriteLine();
                            Console.WriteLine(" PLEASE DO YOUR CHECK-UP FIRST ");
                            Console.WriteLine();
                            Console.WriteLine(" THE RESULT IS 1.OK or 2.ABNORMAL ");
                            f = Convert.ToInt32(Console.ReadLine());
                            if (f == 1)
                            {
                                test.RemoveAt(0);
                                test.Add(test[1]);
                                Console.WriteLine("BEFORE UPDATE THE TEST :" + test[3]);
                                Console.WriteLine("-------------------------------");
                                Console.WriteLine();
                                Thread.Sleep(1000);
                                Console.WriteLine("AFTER SOME DAYS ***************************");
                                test.Add(test[3]);
                                Console.WriteLine("AFTER UPDATE THE TEST :" + test[3]);
                                Console.WriteLine("-------------------------------");
                                Console.WriteLine();
                                Console.WriteLine("THE PRESENT TEST POSITION IS :" + test[3]);
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.WriteLine();
                                Console.WriteLine(" CHECK-UP UPDATE IS  ");
                                Thread.Sleep(1000);
                                Console.WriteLine();
                                Console.WriteLine(" YOU COMPLETLEY ALRIGHT DON'T WORRY ");
                                Console.WriteLine();
                                Console.WriteLine(" SIR,PLEASE COMPLETE YOUR BILLING  :) ");
                                Console.WriteLine();
                                Console.WriteLine("-----------------------------------------");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(" ENTER THE NUMBER OF PATIENTS : ");
                                num1 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                Console.WriteLine(" PRICE OF TEST1 : " + num1 + "X" + "10000=" + (num1 * 10000) + " ");
                                Console.WriteLine();
                                Console.WriteLine(" PRICE OF TEST2 : " + num1 + "X" + "20000=" + (num1 * 20000) + " ");
                                Console.WriteLine();
                                Console.WriteLine(" PRICE OF TEST3 : " + num1 + "X" + "20000=" + (num1 * 20000) + " ");
                                Console.WriteLine();
                                Console.WriteLine(" TOTAL AMOUNT   : " + ((num1 * 10000) + (num1 * 20000) + (num1 * 30000) + ""));
                                Console.WriteLine();
                            }
                            else if(f==2)
                            {
                                test.Add(test[0]);
                                Console.WriteLine("Before the test is :" + test[3]);
                                Console.WriteLine();
                                Thread.Sleep(1000);
                                Console.WriteLine("AFTER SOME DAYS ***************************");
                                test.Add(test[1]);
                                Console.WriteLine();
                                Console.WriteLine("After the test is :" + test[6]);
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(" CHECK-UP UPDATE IS : ");
                                Thread.Sleep(1000);
                                Console.WriteLine("");
                                Console.WriteLine(" KEEP USING MEDICINE  :) ");
                                Thread.Sleep(1000);
                                Console.WriteLine("");
                                Console.WriteLine(" KEEP VISITING HOSPITAL REGULARLY  :) ");
                                Console.WriteLine();
                                Console.WriteLine(" SIR,PLEASE COMPLETE YOUR BILLING  :) ");
                                Console.WriteLine("-----------------------------------------");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write(" ENTER THE NUMBER OF PATIENTS : ");
                                num1 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("");
                                Console.WriteLine(" PRICE OF TEST1 : " + num1 + "X" + "10000=" + (num1 * 10000) + " ");
                                Console.WriteLine("");
                                Console.WriteLine(" PRICE OF TEST2 : " + num1 + "X" + "20000=" + (num1 * 20000) + " ");
                                Console.WriteLine("");
                                Console.WriteLine(" PRICE OF TEST3 : " + num1 + "X" + "20000=" + (num1 * 20000) + " ");
                                Console.WriteLine("");
                                Console.WriteLine(" TOTAL AMOUNT   : " + ((num1 * 10000) + (num1 * 20000) + (num1 * 30000) + ""));
                                Console.WriteLine();
                                
                            }
                        }
                        else if(e==2)
                        {
                            test.Add(test[5]);
                            Console.WriteLine(" BEFORE UPDATE THE TEST :" + test[5]);
                            Console.WriteLine("-------------------------------");
                            Console.WriteLine();
                            Thread.Sleep(1000);
                            Console.WriteLine(" AFTER SOME DAYS ***************************");
                            Thread.Sleep(1000);
                            test.Add(test[4]);
                            Console.WriteLine();
                            Console.WriteLine(" AFTER UPDATE THE TEST :" + test[5]);
                            Thread.Sleep(1000);
                            test.Add(test[3]);
                            Console.WriteLine();
                            Console.WriteLine(" AFTER UPDATE THE TEST :" + test[3]);
                            Thread.Sleep(1000);
                            test.Add(test[1]);
                            Console.WriteLine(" AFTER UPDATE THE TEST :" + test[6]);
                            Console.WriteLine("-------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(" THE PRESENT TEST POSITION IS :" + test[6]);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine(" YOUR TESTED POSITIVE SO BE IN CORENTAIN AT HOSPITAL BEFORE YOUR DESEASE QUARED ");
                            Console.WriteLine();
                            Console.WriteLine(" PLEASE FOLLOW BELOW PRECAUTIONS ");
                            Console.WriteLine("");
                            Console.WriteLine("-------------------------------");
                            Thread.Sleep(1000);
                            Console.WriteLine("");
                            Console.WriteLine(" 1.Don't touch any one ");
                            Thread.Sleep(1000);
                            Console.WriteLine("");
                            Console.WriteLine(" 2.Don't be people surroundings ");
                            Thread.Sleep(1000);
                            Console.WriteLine("");
                            Console.WriteLine(" 3.Don't be without using medicine ");
                            Console.WriteLine();

                            Console.WriteLine(" SIR,PLEASE COMPLETE YOUR BILLING  :) ");
                            Console.WriteLine();
                            Console.WriteLine("-----------------------------------------");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(" ENTER THE NUMBER OF PATIENTS : ");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("");
                            Console.WriteLine(" PRICE OF TEST1 : " + num1 + "X" + "10000=" + (num1 * 10000) + " ");
                            Console.WriteLine("");
                            Console.WriteLine(" PRICE OF TEST2 : " + num1 + "X" + "20000=" + (num1 * 20000) + " ");
                            Console.WriteLine("");
                            Console.WriteLine(" PRICE OF TEST3 : " + num1 + "X" + "20000=" + (num1 * 20000) + " ");
                            Console.WriteLine("");
                            Console.WriteLine(" TOTAL AMOUNT   : " + ((num1 * 10000) + (num1 * 20000) + (num1 * 30000) + ""));
                            Console.WriteLine();
                            
                        }
                        
                    }
                  // Console.WriteLine(" YOUR TESTING COMPLETED ");
                  // Console.WriteLine();
                   // Thread.Sleep(1000);
                   // Console.Clear();
                   // Console.WriteLine(" ENTER NEW PATIENT DETAILS ");
                   //Console.WriteLine();
                   // Console.WriteLine("---------------------------");
                   // Thread.Sleep(2000);
                   // Console.WriteLine();
                   // Console.ForegroundColor = ConsoleColor.Magenta;
                   // Console.WriteLine(" SELECT BELOW WHO ARE YOU 1.PATIENT OR 2.ADMIN ");
                  // Console.Clear();
                }
            }
            else if(a==2)
            {
                Console.WriteLine();
                string u1, p1, u2, p2;
                Regex us = new Regex(u);
                Regex pa1 = new Regex(pa);
                Console.ForegroundColor = ConsoleColor.Red;
            v: Console.WriteLine(" PLEASE  SET UR  ADMIN ID AND PASSWORD ");
                Console.WriteLine();
                Console.Write(" ADMIN ID (ONLY SMALL LETTERS) : ");
                u1 = Console.ReadLine();
                Console.WriteLine();
                Console.Write(" PASSWORD (ONLY SIX DIGITS)    : ");
                p1 = Console.ReadLine();
                Console.WriteLine();
                if (us.IsMatch(u1) && pa1.IsMatch(p1))
                {
                    Console.Clear();
                c: Console.WriteLine("               <<<<<<<<PLEASE LOGIN>>>>>>>>          ");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" ADMIN ID    : ");
                    u2 = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write(" PASSWORD    : ");
                    p2 = Console.ReadLine();
                    Console.WriteLine();
                    if (u1 == u2 && p1 == p2)
                    {
                        Console.Clear();
                        Console.WriteLine("                          -----------LOGIN SUCCESSFULLY----------         ");
                        Console.WriteLine();
                        Console.WriteLine(" YOUR OP DETAILES ARE ");
                        Console.WriteLine("-----------------------");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(" NAME                   : ");
                        name = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write(" AGE                    : ");
                        age = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write(" BLOOD_GROUP            : ");
                        blood_group = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write(" PHONE NUMBER           : ");
                        phn = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write(" NUMBER OF TESTS DONE   : ");
                        nft = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write(" RESENT DISEASE STATUS  : ");
                        disease = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write(" TOTAL BILL             : ");
                        test_bill = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("              THE PATIENT DETAILES ARE            ");
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine(" ENTER CORRECT  ID AND PASSWORD");
                        Console.WriteLine(" NAME                   : " + name);
                        Console.WriteLine(" AGE                    : " + age);
                        Console.WriteLine(" BLOOD_GROUP            : " + blood_group);
                        Console.WriteLine(" PHONE NUMBER           : " + phn);
                        Console.WriteLine(" NUMBER OF TESTS DONE   : " + nft);
                        Console.WriteLine(" RESENT DISEASE STATUS  : " + disease);
                        Console.WriteLine(" TOTAL TESTS BILL       : " + (test_bill*nft));
                        Thread.Sleep(2500);
                        Console.Clear();
                      
                        
                    }
                    else
                    {
                        goto c;
                    }
                }
                else
                {
                    goto v;
                }
                

            }
            goto Label1;
            

           
      


        }





        }
    }
