namespace taskCSADV
{
    internal class Program
    {
        static void Main(string[] args)
        { // 111
          //PhoneBook pb = new PhoneBook();
          //pb["Alice"] = "123-456-7890";
          //pb["Bob"] = "987-654-3210";
          //Console.WriteLine(pb["Alice"]); // Output: 123-456-7890

            //222

            //WeeklySchedule ws = new WeeklySchedule();
            //ws["Monday"] = "Gym at 6 PM";
            //ws["Wednesday"] = "Meeting at 10 AM";
            //Console.WriteLine(ws["Monday"]); // Output: Gym at 6 PM

            //33333333
            //Matrix matrix = new Matrix(3, 3);
            //matrix[0, 0] = 1;
            //matrix[1, 1] = 5;
            //matrix[2, 2] = 9;
            //Console.WriteLine(matrix[1, 1]); // Output: 5

            //4444444
            //Stackk<int> stack = new Stackk<int>();
            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);
            //Console.WriteLine(stack.ToString());
            //5555555
            //Pair<int, string> pair = new Pair<int, string>(1, "One");
            //Console.WriteLine(pair.ToString());

            //666666

            //Cache<string, int> cache = new Cache<string, int>(3);
            //cache.Add("A", 1);
            //cache.Add("B", 2);
            //cache.Add("C", 3);
            //Console.WriteLine(cache.Get("A")); // Output: 1 xx

            //7777777


            //static List<TTarget> ConvertList<TSource, TTarget>(List<TSource> source, Func<TSource, TTarget> converter)
            //    =>
            //      source.Select(converter).ToList();
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            //List<string> stringNumbers = ConvertList(numbers, n => $"Number: {n}");
            //stringNumbers.ForEach(Console.WriteLine);

            //8888888
            //Repository<User> userRepository = new Repository<User>();
            //userRepository.Add(new User { Id = 1, Name = "Alice" });
            //userRepository.Add(new User { Id = 2, Name = "Bob" });
            //User user = userRepository.Get(1);
            //Console.WriteLine(user.Name); // Output: Alice


            //9999999
            //ContactManager cm = new ContactManager();
            //cm.Add("Alice", "123-456-7890");
            //cm.Add("Bob", "987-654-3210");
            //Console.WriteLine(cm.Search("Alice")); // Output: 123-456-7890

            //10101010
            //ShoppingCart shoppingCart = new ShoppingCart();
            //shoppingCart.Items.Add("Apple");
            //shoppingCart.Quantities["Apple"] = 3;
            //shoppingCart.Discounts.Add("SUMMER21");
            //Console.WriteLine($"Items: {string.Join(", ", shoppingCart.Items)}");


            //111111111111 eleven 
            //double? Average(List<int?> numbers)
            //{
            //    var valid = numbers.Where(n => n.HasValue).Select(n => n.Value);
            //    return valid.Any() ? valid.Average() : null;
            //}
            //List<int?> nums = new List<int?> { 1, 2, null, 4, null, 5 };
            //Console.WriteLine(Average(nums)); // Output: 3

            //12121212121212 twelve
            //Person p = new Person { FirstName = "Alice", MiddleName ="aa " };
            //Console.WriteLine(p.ToString());

            //13131313131313 thirteen
            //done

            //14141414141414 fourteen
            //done
            //15151515151515 fifteen
            //Done

            //16161616161616 sixteen

            //Calculator calc = new Calculator();
            //calc.Calculate(2,3,);

            //17171717171717 seventeen


            //DONE
            //1818181818181818 eighteen
            // mksl 

            //1919191919191919 nineteen
            // done 
            //2020202020202020 twenty
            //var grades = new List<int> { 80, 90, 70 };
            //var passed = grades.Where(g => g >= 75);
            //var average = grades.Average();

            //21 21
            //222
            //23
            async Task<string> ReadFileAsync(string path)
            {
                try { return await File.ReadAllTextAsync(path); }
                catch (Exception ex) { return $"Error: {ex.Message}"; }
            }

            //24
            async Task<string> CallApisAsync()
            {
                var client = new HttpClient();
                var task1 = client.GetStringAsync("https://api1.com");
                var task2 = client.GetStringAsync("https://api2.com");
                await Task.WhenAll(task1, task2);
                return task1.Result + task2.Result;
            }

            //25
              //ana t3bt b2aly 3H hena  


        }
    }
}
