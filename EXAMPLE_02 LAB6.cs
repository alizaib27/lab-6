using System;
namespace example02
{
    class Program
    {
        static void TestCatch2()
        {
            System.IO.StreamWriter sw = null;
            try
            {
                sw = new System.IO.StreamWriter(@ "C:\test\test.txt");
                sw.WriteLine("hello");
            }
            catch (System.IO.FileNotFoundException ex)
            {
                System.Console.WriteLine(ex.ToString());
            }
            catch (System.IO.IOException ex) {
                System.Console.WriteLine(ex.ToString());
            }
            finally
            {
                sw.Close();
            }
            System.Console.WriteLine("done");
        }
    }
}