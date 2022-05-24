namespace SamarkinProject
{
    class Programm
    {
        static void Main(string[] args)
        {

        }
    }
    public class Client
    {
        public int ClientID;
        public string last_name;
        public string fist_name;
        public string middle_name;
        public string tel;
        private int Paid = 0;

        public void Photo_Before()
        {
            Console.WriteLine("Пожалуйста, сфотографируйте самокат перед тем, как начать поездку");
        }
        public void Booking()
        {
            if (Paid == 500)
            {
                Console.WriteLine("Клиент забронировал самокат, $Было внесено {Paid}.");
            }
            if (Paid > 500)
            {
                Console.WriteLine($"Было внесено {Paid}. На балансе клиента больше 500 рублей, можно начинать поездку");
            }

        }

        public void Pause()
        {
            Console.WriteLine("Самокат был поставлен на паузу");
        }


        public void Photo_After()
        {
            Console.WriteLine("Пожалуйста, сфотографируйте самокат перед тем, как завершить поездку");
        }

    }

    public class Worker
    {
        public int WorkerID;
        public string last_name;
        public string fist_name;
        public string middle_name;
        public string tel;


        public void Repair()
        {
            Console.WriteLine("Самокат был принят в ремонт");
        }
        public void TypeWork()
        {
            Console.WriteLine("Замена заднего колеса и рулевой ручки управления");
        }
        public void Term()
        {
            Console.WriteLine("Ремонт займет 3 часа");
        }
        public void Agreement()
        {
            Console.WriteLine("Договор о назначении ремонта самоката подписан");
        }
    }
    public class Scooter
    {
        public int ScooterID;
        public string belay_cost;
        public string cost_of_rental;
        public string battery;
        public int clas;

        public void Phone()
        {
            Console.WriteLine("Телефон был успешно закреплен");
        }
        public void GPS()
        {
            Console.WriteLine("Клиент находится по данным координатам: 55.33544,85.54577");
        }
        public void Battery()
        {
            Console.WriteLine("Заряд батареи равен 75%");
        }
        public void Speed()
        {
            Console.WriteLine("Скорость равна 18 км/ч");
        }
        public void Mode()
        {
            Console.WriteLine("На самокате установлен режим Eco");
        }



    }

    public class Order_detail
    {
        public int OrderID;
        public int ScooterID;
        public int WorkerID;
        public int ClientID;
        public string stat_time;
        public string end_time;
        public string start_place;
        public string finish_place;
        public string defect;
        public string defect_specification;
        public string fine;
        private int Amount = 0;


        public void TTIME()
        {
            Console.WriteLine("Текущее время поездки: 00:21:12");
        }
        public void Ppause()
        {
            Console.WriteLine("Если вы хотите, вы можете поставить самокат на паузу");
        }
        public void Cost()
        {

            Console.WriteLine("Текущая стоимость поездки: 189Р.");
        }


        public void CreateOrder()
        {
            if (OrderID > 0)
            {
                Console.WriteLine($"Самокат с номером: {ScooterID}");
            }
        }
        public void Promocode()
        {
            if (Amount > 300)
            {
                Console.WriteLine("Спасибо за поездку! Введите: 6HGDG5G, и получите скидку на следующую поездку! ");
            }
        }

    }

    public class Maintenace_log
    {
        public int repairID;
        public int WorkerID;
        public int ScooterID;
        public string take_time;
        public string recoil_time;
        public string repair_work;

        public void remont()
        {

            Console.WriteLine("Стоимость ремонта составляет: 1500Р.");
        }
        public void TypeWorkk()
        {
            Console.WriteLine("Работа по технической части");
        }
        public void Malfunction()
        {
            Console.WriteLine("Замена передних колодок и заднего фонаря");
        }
        public void Date_Issue()
        {
            Console.WriteLine("Дата выдачи самоката: 09.07.2021");
        }
        public void Signature()
        {
            Console.WriteLine("Договор о выдаче самоката успешно подписан");
        }
    }
}
