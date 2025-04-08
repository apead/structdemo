using System.Runtime.CompilerServices;

namespace ConsoleStructDemo
{
    internal class Program
    {
        static Person[] Persons = new Person[100];

        private static void InitializePersonArrayWithRandomGeneratedData()
        {
            string[] firstNames = { "John", "Jane", "Michael", "Emily", "David", "Emma", "Chris", "Olivia", "Daniel", "Sophia" };
            string[] lastNames = { "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis", "Rodriguez", "Martinez" };
            string[] genders = { "Male", "Female", "Non-binary" };
            string[] nationalities = { "American", "Canadian", "British", "Australian", "Indian" };
            string[] jobTitles = { "Software Engineer", "Doctor", "Teacher", "Manager", "Nurse" };
            string[] companies = { "TechCorp", "HealthInc", "EduWorld", "BizGroup", "CarePlus" };
            string[] degrees = { "Bachelor's", "Master's", "PhD" };
            string[] universities = { "Harvard", "MIT", "Stanford", "Oxford", "Cambridge" };
            string[] maritalStatuses = { "Single", "Married", "Divorced" };
            string[] languages = { "English", "Spanish", "French", "German", "Chinese" };
            string[] hobbies = { "Reading", "Traveling", "Cooking", "Sports", "Music" };
            string[] skills = { "Programming", "Communication", "Leadership", "Problem-solving", "Time management" };

            Random random = new Random();
            HashSet<string> usedEmails = new HashSet<string>();

            for (int i = 0; i < Persons.Length; i++)
            {
                string firstName = firstNames[random.Next(firstNames.Length)];
                string lastName = lastNames[random.Next(lastNames.Length)];
                string email;

                do
                {
                    email = $"email{i}@example.com";
                } while (usedEmails.Contains(email));

                usedEmails.Add(email);

                Persons[i] = new Person(
                    firstName, lastName, DateTime.Now.AddYears(-30).AddDays(random.Next(365 * 30)), genders[random.Next(genders.Length)], nationalities[random.Next(nationalities.Length)],
                    email, $"123-456-789{i}", $"987-654-321{i}",
                    $"Street {i}", "City", "State", $"PostalCode{i}", "Country",
                    jobTitles[random.Next(jobTitles.Length)], companies[random.Next(companies.Length)], DateTime.Now.AddYears(-5).AddDays(random.Next(365 * 5)), DateTime.Now.AddDays(random.Next(365)), 50000 + random.Next(50000),
                    degrees[random.Next(degrees.Length)], universities[random.Next(universities.Length)], DateTime.Now.AddYears(-10).AddDays(random.Next(365 * 10)),
                    maritalStatuses[random.Next(maritalStatuses.Length)], random.Next(0, 5), new string[] { languages[random.Next(languages.Length)], languages[random.Next(languages.Length)] }, new string[] { hobbies[random.Next(hobbies.Length)], hobbies[random.Next(hobbies.Length)] }, new string[] { skills[random.Next(skills.Length)], skills[random.Next(skills.Length)] });
            }
        }

        private static void DisplayAllPersons()
        {
            for(int index=0;index< Persons.Length;index++)
            {
                Person person = Persons[index];
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Name: {person.FirstName} {person.LastName}");
            }
        }

        static void Main(string[] args)
        {
            InitializePersonArrayWithRandomGeneratedData();

            DisplayAllPersons();
        }
    }
}

