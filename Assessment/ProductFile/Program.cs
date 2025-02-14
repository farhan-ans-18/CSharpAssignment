namespace ProductFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            ReadFile();
        }
        static void ReadFile()
        {
            FileStream fs = null;
            FileStream fs1 = null;
            StreamReader sr = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream("products.txt", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                if(File.Exists("product_updated.txt"))
                {
                    File.Delete("product_updated.txt");
                }
                fs1= new FileStream("product_updated.txt", FileMode.Append,FileAccess.Write);
                sw = new StreamWriter(fs1);
                string line = sr.ReadLine();
                string[] txtArr;
                Console.WriteLine("Contents of the file:");
                while (!String.IsNullOrEmpty(line))
                {
                    Console.WriteLine(line);
                    txtArr = line.Split(",");
                    double price = double.Parse(txtArr[txtArr.Length - 1]);
                    if (price < 1000)
                    {
                        txtArr[txtArr.Length-1] = Convert.ToString(price + (price * 0.10));
                    } else if(price > 1000 && price < 5000)
                    {
                        txtArr[txtArr.Length - 1] = Convert.ToString(price + (price * 0.05));
                    }
                    else
                    {
                        Console.WriteLine("No changes needed");
                    }

                    //join the array into string
                    var str=String.Join(",",txtArr);
                    sw.WriteLine(str);
                    line = sr.ReadLine();

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sr.Close();
                sw.Close();
                fs.Close();
                fs1.Close();
                
            }

        }

    }
}
