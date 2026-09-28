namespace TaxeDouane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal arme;
            string provenance;
            const decimal TaxeRoyale = 0.20m;
            const decimal TaxeMiniere = 0.10m;
            const decimal TaxeImportation = 0.055m;
            const decimal TaxeArtisanat = 0.021m;


            Console.WriteLine("Entrez le prix de l'arme :");
            arme = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Entrez la provenance de l'arme (royaume, mine, importation, artisanat) :");
            provenance = Console.ReadLine();

            if (provenance == "royaume")
            {
                decimal taxe = arme + arme * TaxeRoyale;
                Console.WriteLine($"La taxe pour l'arme provenant du royaume est : {taxe}");
            }
            else if (provenance == "mine")
            {
                decimal taxe = arme + arme * TaxeMiniere;
                Console.WriteLine($"La taxe pour l'arme provenant de la mine est : {taxe}");
            }
            else if (provenance == "importation")
            {
                decimal taxe = arme + arme * TaxeImportation;
                Console.WriteLine($"La taxe pour l'arme provenant de l'importation est : {taxe}");
            }
            else if (provenance == "artisanat")
            {
                decimal taxe = arme + arme * TaxeArtisanat;
                Console.WriteLine($"La taxe pour l'arme provenant de l'artisanat est : {taxe}");
            }
            else
            {
                Console.WriteLine("Provenance inconnue. Aucune taxe calculée.");
            }
        }
    }
}
