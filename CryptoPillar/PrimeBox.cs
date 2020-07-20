using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoPillar
{
    public class PrimeBox
    {
        private int minimum;
        private int maximum;
        private int bpm;
        private List<int> primes;
        private List<int> nonPrimes;
        private List<char> primeMapping;

        public int Minimum { get => minimum; }
        public int Maximum { get => maximum; }
        public int Bpm { get => bpm; }
        public List<int> Primes { get => primes; }
        public List<int> NonPrimes { get => nonPrimes; }
        public List<char> PrimeMapping { get => primeMapping; }

        private bool isPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        public PrimeBox(int min, int max, int speed)
        {
            primes = new List<int>();
            nonPrimes = new List<int>();
            primeMapping = new List<char>();

            Debug.Assert(min >= 0);
            Debug.Assert(max < 1000000);

            minimum = min; maximum = max; bpm = speed;

            for (char ch = 'A'; ch <= 'Z'; ch++)
            {
                primeMapping.Add(ch);
            }

            for (int num = minimum; num <= maximum; num++)
            {
                if (isPrime(num))
                {
                    primes.Add(num);
                }
                else
                {
                    nonPrimes.Add(num);
                }
            }

            minimum = min; maximum = max;

            if (primes.Count() < 26) primes = nonPrimes = null;
        }

        private void ShuffleMe<T>(IList<T> list)
        {
            Random random = new Random();
            int n = list.Count;

            for (int i = list.Count - 1; i > 1; i--)
            {
                int rnd = random.Next(i + 1);

                T value = list[rnd];
                list[rnd] = list[i];
                list[i] = value;
            }
        }

        public List<NumberDroplet> GetSequence(string keyword, int timeInMinute = 2, int pillarCount = 5)
        {
            keyword = keyword.ToUpper();
            int sequenceSize = bpm * timeInMinute;
            int keywordSize = keyword.Length;

            Random rng = new Random();

            List<int> identifier = new List<int>(); // 1 if prime, 0 if empty, -1 if non-prime
            for (int i = 0; i < sequenceSize; i++)
            {
                if (i < keywordSize) identifier.Add(1);
                else identifier.Add(-rng.Next(2));
            }
            ShuffleMe<int>(identifier);

            List<NumberDroplet> result = new List<NumberDroplet>();

            int keywordIndex = 0;
            for (int timespan = 0; timespan < sequenceSize; timespan++)
            {
                if (identifier[timespan] == 0) result.Add(new NumberDroplet(-1, -1));
                if (identifier[timespan] == +1) result.Add(new NumberDroplet(rng.Next(pillarCount), primes[keyword[keywordIndex++] - 'A']));
                if (identifier[timespan] == -1) result.Add(new NumberDroplet(rng.Next(pillarCount), nonPrimes[rng.Next(nonPrimes.Count())]));
            }

            return result;
        }
    }
}
