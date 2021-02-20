using System;

namespace DRYDemoStandartLibrary
{
    public class EmployeeProcessor
    {
        public string GenerateEmployeeID(string firstName, string lastName)
        {
            return $@"{GetPartOfName(firstName, 4)}{GetPartOfName(lastName, 4)}{DateTime.Now.Millisecond}";
        }

        private string GetPartOfName(string name, int numberOfCharacters)
        {
            string output = name;

            if (name.Length > numberOfCharacters)
            {
                output = name.Substring(0, numberOfCharacters);
            }
            else
            {
                while (output.Length < 4)
                    output += "X";
            }

            return output;
        }
    }
}
