using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTextFileWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            ///This code is only to print the file
            StreamReader myReader = new StreamReader("Values.txt");//correct name is values.txt
            string line = "";

            while (line != null)
            {
                line = myReader.ReadLine();
                if (line != null)
                    Console.WriteLine(line);
            }

            myReader.Close();
            
            
            //This code is to handle the previous code with the posibility of not finding the file
            try
            {
                StreamReader myReader2 = new StreamReader("WrongNamedFile.txt");//correct name is values.txt
                string line2 = "";

                while (line2 != null)
                {
                    line = myReader2.ReadLine();
                    if (line2 != null)
                        Console.WriteLine(line2);
                }

                myReader2.Close();
                
            }
                //The catches goes from the most specific to the most generic and a finally that is executed no matter what
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Could not find the directory, are you sure it exists?: {0}", e.Message);
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("Could not find the file, are you sure it exists?");
            }
            catch (Exception e)
            {

                Console.WriteLine("An error ocurred : {0}", e.Message);
            }
            finally
            {
                //Perform any cleanup to rol back the data or close connections to files, db, network, etc.
            }

            Console.ReadLine();
            
        }
    }
}
