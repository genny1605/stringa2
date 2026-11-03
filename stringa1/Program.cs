using System;

class Program
{
	static void Main()
	{
		Console.Write("Inserisci la stringa: ");
		string testo = Console.ReadLine();

		
		for (int i = 0; i < testo.Length; i++)
		{
			int conta = 0;

			
			for (int j = 0; j < testo.Length; j++)
			{
				if (testo[i] == testo[j])
				{
					conta++;
				}
			}

			
			if (conta > 1 && testo.IndexOf(testo[i]) == i)
			{
				Console.WriteLine("La lettera '" + testo[i] + "' si ripete " + conta + " volte.");
			}
		}
	}
}