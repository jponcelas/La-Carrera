namespace carrera2_0
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[,] rs = new[,]
            {
                { 1, 4, 3, 5, 4 },
                { 2, 8, 2, 5, 7 },
                { 3, 7, 4, 6, 2 },
                { 4, 4, 3, 1, 3 },

            };
            ;
            var nw = new corredor();
            var result = nw.CalcularDistancia(rs);

            int[,] corredors = nw.InfoCorredors();


            int[] TotalPuntsDelCorredor = nw.CalcularDistancia(corredors);


            int CorredorGuanyador = nw.ConseguirGuanyador(TotalPuntsDelCorredor, out int maxDistancia);


            nw.MostrarResultats(TotalPuntsDelCorredor, CorredorGuanyador, maxDistancia);

        }

    }

    public class corredor
    {
        public int[,] InfoCorredors()
        {
            return new int[,]
            {
                { 1, 4, 3, 5, 4 },
                { 2, 8, 2, 5, 7 },
                { 3, 7, 4, 6, 2 },
                { 4, 4, 3, 1, 3 }
            };
        }

        public int[] CalcularDistancia(int[,] corredors)
        {
            int[] TotalPuntsDelCorredor = new int[4];  

      
            for (int i = 0; i < corredors.GetLength(0); i++)
            {
                int id = corredors[i, 0] - 1; 
                int max = int.MinValue;
                int min = int.MaxValue;

                for (int j = 1; j < corredors.GetLength(1); j++) 
                {
                    if (corredors[i, j] > max)
                        max = corredors[i, j];

                    if (corredors[i, j] < min)
                        min = corredors[i, j];
                }

                TotalPuntsDelCorredor[id] += max - min;  
            }

            return TotalPuntsDelCorredor;
        }

        public int ConseguirGuanyador(int[] TotalPuntsDelCorredor, out int maxDistancia)
        {
            maxDistancia = 0;
            int CorredorGuanyador = -1;

            for (int i = 0; i < TotalPuntsDelCorredor.Length; i++)
            {
                if (TotalPuntsDelCorredor[i] > maxDistancia)
                {
                    maxDistancia = TotalPuntsDelCorredor[i];
                    CorredorGuanyador = i + 1;
                }
            }

            return CorredorGuanyador;
        }

        public void MostrarResultats(int[] TotalPuntsDelCorredor, int CorredorGuanyador, int maxDistancia)
        {
            Console.WriteLine("\nResultats finals:");

            for (int i = 0; i < TotalPuntsDelCorredor.Length; i++)
                Console.WriteLine($"Corredor {i + 1}: {TotalPuntsDelCorredor[i]} metres");

            Console.WriteLine($"\nLa carrera l’ha guanyat el corredor {CorredorGuanyador} amb una distància total de {maxDistancia} metres!");
        }
    }
    }
    
