using System;
namespace TrainWizard
{
    public class Program
    {

        public static void Main()

        {

            const string MSG_INPUT = "Hi! Input your wizard's name: ";
            Console.WriteLine(MSG_INPUT);
            string wizardName = Console.ReadLine();
            string wizardLevel = "";
            int poder = 0;
            Random rand = new Random();
            for (int day = 1; day <= 5; day++)
            {
                for (int meditationDay = 1; meditationDay <= 1; meditationDay++)
                {
                    poder += rand.Next(1, 11);
                    Console.Write($"day {day} -> {wizardName}, ja has meditat {rand.Next(0, 25)} hores i el teu poder ara és de {poder} de punts");
                    Console.WriteLine();
                }
                if (poder < 20)
                {
                    Console.WriteLine("Repeteixes a segona convocatòria.");
                    wizardLevel = "Raoden el Elantrí";
                }
                else if (poder >= 20 && poder < 30)
                {
                    Console.WriteLine("Encara confons la vara amb una cullera.");
                    wizardLevel = "Zyn el buguejat";
                }
                else if (poder >= 30 && poder < 35)
                {
                    Console.WriteLine("Ets un invocador de brises màgiques.");
                    wizardLevel = "Arka Nullpointer";
                }
                else if (poder >= 35 && poder < 40)
                {
                    Console.WriteLine("Uau! Pots invocar dracs sense cremar el laboratori!");
                    wizardLevel = "Elarion de les Brases";
                }
                else if (poder >= 40)
                {
                    Console.WriteLine("Has assolit el rang de Mestre dels Arcans!");
                    wizardLevel = "ITB-Wizard el Gris";
                }
            }
        }
    }
}
