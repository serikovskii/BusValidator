using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusValidator
{
    public class Program
    {
        public static void Main()
        {
            int typeBus;
            int typeCard;
            Console.WriteLine("Выберете тип автобуса: \n1-Городской, 2-Экспресс, 3-Межгород");
            typeBus = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Выберете тариф: \n1-Стандарт, 2-Пенсионный, 3-Детский");
            typeCard = Int32.Parse(Console.ReadLine());

            int size = 4;
            Trips[] trip = new Trips[size];
            Cards[] card = new Cards[size];
            for (int i = 1; i < size; i++)
            {
                trip[i] = new Trips();
                card[i] = new Cards();

                card[i].BalansCard = i * 500;
                card[i].IdCard = i + 1000;
                trip[i].PriceTripBus = i * 90;

                switch (i)
                {
                    case 1: trip[i].TypeBus = "Городской"; card[i].TypeCard = "Взрослый"; break;
                    case 2: trip[i].TypeBus = "Экспресс"; card[i].TypeCard = "Пенсионный"; break;
                    case 3: trip[i].TypeBus = "Межгород"; card[i].TypeCard = "Детский"; break;

                }
            }
            trip[1].SaleForTripBus = 0;
            trip[2].SaleForTripBus = 90;
            trip[3].SaleForTripBus = 45;

            card[typeCard].BalansCard = card[typeCard].BalansCard - trip[typeBus].PriceTripBus + trip[typeCard].SaleForTripBus;
            Console.WriteLine("Оплата за проезд: " + (trip[typeBus].PriceTripBus - trip[typeCard].SaleForTripBus));
            Console.WriteLine("Баланс: " + card[typeCard].BalansCard);

            Console.ReadLine();
        }
    }
}
