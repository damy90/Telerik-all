namespace MobilePhone
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            var ipPhone6 = new GSM(model: "IP-Phone6", manufacturer: "xApple");
            var salamSumng = new GSM(model: "Jalacxy7", manufacturer: "SalamSung");

            var listFromSmartPhones = new List<GSM>();
            listFromSmartPhones.Add(ipPhone6);
            listFromSmartPhones.Add(salamSumng);

            foreach (var phones in listFromSmartPhones)
            {
                Console.WriteLine(phones);
            }

            var iPhone4s = GSM.IPhone4s;


            var firstTestCall = new Call()
            {
                TimeStart = DateTime.Now,
                TimeEnd = DateTime.Now.AddMinutes(2),
                ItsIncomming = false,
                PhoneNumber = "0043123123"
            };

            var duration = firstTestCall.Duration();

            var secondTestCall = new Call()
            {
                TimeStart = DateTime.Now,
                TimeEnd = DateTime.Now.AddMinutes(3),
                ItsIncomming = false,
                PhoneNumber = "0043123123"
            };

            ipPhone6.AddCall(firstTestCall);
            ipPhone6.AddCall(secondTestCall);

            decimal pricePerMinute = 0.37M;
            var totalPrice = ipPhone6.CallPrice(pricePerMinute);

            Console.WriteLine("Total call price: " + totalPrice);
        }
    }
}
