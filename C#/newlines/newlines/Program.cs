using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace newlines
{
    class Program
    {
        public (long, long) Solve(long N, long[] W)
        {

            // Dividi in righe
            List<List<int>> righe = new List<List<int>>();
            List<int> rigaCorrente = new List<int>();

            for (int i = 0; i < N; i++)
            {
                if (W[i] == -1)
                {
                    righe.Add(rigaCorrente);
                    rigaCorrente = new List<int>();
                }
                else
                {
                    rigaCorrente.Add(W[i]);
                }
            }
            righe.Add(rigaCorrente);
            long[] lunghezze = new long[righe.Count];
            for (int i = 0; i < righe.Count; i++)
            {
                long sum = 0;
                foreach (int w in righe[i]) sum += w;
                lunghezze[i] = sum + (righe[i].Count - 1); 
            }

            long K1 = 0;
            foreach (long l in lunghezze) if (l > K1) K1 = l;

            
            long K2 = long.MaxValue;
            for (int i = 0; i < righe.Count - 1; i++)
            {
                long primaParolaSuccessiva = righe[i + 1][0];
                long maxPerQuestaRiga = lunghezze[i] + primaParolaSuccessiva;
                if (maxPerQuestaRiga < K2) K2 = maxPerQuestaRiga;
            }

            return ((int)K1, (int)K2);
        }

        public void Run()
        {
            streamReader = new StreamReader("input.txt");
            streamWriter = new StreamWriter("output.txt");

            iterator = GetEnumerator(streamReader);

            int T = NextInt();

            for (int t = 1; t <= T; t++)
            {
                int N = NextInt();
                int[] W = new int[N];

                for (int i = 0; i < N; i++)
                {
                    W[i] = NextInt();
                }

                (int K1, int K2) = Solve(N, W);
                streamWriter.WriteLine($"Case #{t}: {K1} {K2}");
                streamWriter.Flush();
            }

            streamReader.Close();
            streamWriter.Close();
        }

        public IEnumerator<String> GetEnumerator(StreamReader sr)
        {
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                String[] tokens = line.Split(' ').Where(t => t.Length > 0).ToArray();
                foreach (String t in tokens)
                {
                    yield return t;
                }
            }
        }

        public String NextToken()
        {
            iterator.MoveNext();
            return iterator.Current;
        }

        public int NextInt()
        {
            return Convert.ToInt32(NextToken());
        }

        static void Main(String[] args)
        {
            var program = new Program();
            program.Run();
        }

        private StreamReader streamReader = new StreamReader(Console.OpenStandardInput());
        private StreamWriter streamWriter = new StreamWriter(Console.OpenStandardOutput());
        private IEnumerator<String> iterator;
    }
}

