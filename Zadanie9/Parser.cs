using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Zadanie9
{
    class Parser
    {
        private string inputString;
        private List<int> numbersList = new List<int>();

        public void ParseInput(string _input)
        {
            inputString = _input;
            if (IsStringValid(inputString))
            {
                StringToList(inputString);
                Console.WriteLine("Wartość minimalna podanych liczb: {0}", MinValue(numbersList));
                Console.WriteLine("Wartość maksymalna podanych liczb: {0}", MaxValue(numbersList));
                Console.WriteLine("Wartość średnia podanych liczb: {0}", AverageValue(numbersList));
                Console.WriteLine("Wartość mediany podanych liczb: {0}", MedianValue(numbersList));
                Console.WriteLine("Wartość odchylenia podstawowego podanych liczb: {0}", DeviationValue(numbersList));

            }
            else
            {
                Console.WriteLine("Ciąg znaków nie poprawny.");
            }
        }

        
        private bool IsStringValid(string _input)
        {
            string input = _input;
            if (Regex.IsMatch(input, @"[0-9,]") && input.Last() != ',' && input.First() != ',')
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private void StringToList(string _input)
        {
            string input = _input;

            string[] inputTab = input.Split(',');
            foreach (var number in inputTab)
            {
                int toInt = Convert.ToInt32(number);
                numbersList.Add(toInt);
            }
            
        }

        private int MinValue(List<int> _lista)
        {
            int minValue = _lista.Min();
            return minValue;
        }

        private int MaxValue(List<int> _lista)
        {
            int maxValue = _lista.Max();
            return maxValue;
        }

        private double AverageValue(List<int> _lista)
        {
            double averValue = _lista.Average();
            return averValue;
        }

        private double MedianValue(List<int> _lista)
        {
            double medianValue;
            _lista.Sort();

            if (_lista.Count % 2 == 0)
            {
                medianValue = _lista[(_lista.Count / 2)-1] + _lista[_lista.Count / 2];
                medianValue /= 2;
            }
            else
            {
                medianValue = _lista[_lista.Count / 2];
            }
            
            return medianValue;
        }

        private double DeviationValue(List<int> _lista)
        {
            double deviation = 0;

            foreach (var number in _lista)
            {
                deviation += Math.Pow(number - AverageValue(_lista),2);
            }
            deviation /= _lista.Count;
            deviation = Math.Sqrt(deviation);

            return deviation;
        }

    }
}
