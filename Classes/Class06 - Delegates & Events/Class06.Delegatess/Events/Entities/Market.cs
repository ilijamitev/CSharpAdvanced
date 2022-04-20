using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Entities
{
    public class Market
    {
        public delegate void PromotionSender(ProductType productType, string marketName);         // definirame delegat
        // mora da imame metoda sto go implementira delegatot za posle da go iskoristime eventot so +=

        event PromotionSender PromotionSenderEvent;     // definirame event od tip PROMOTIONSENDER .... ako sakame da se pretplatime na  PromotionSenderEvent ke mora da imame definirano metoda spored delegatot PromotionSender

        public ProductType CurrentProperty { get; set; }
        public List<string> EmailList { get; set; } = new List<string>();   // isto e dali tuka ili vo konstruktorot (1)
        public string Name { get; set; }

        public Market()
        {
            //EmailList = new List<string>(); // isto e dali tuka ili vo propertito (2)

        }

        public void SubscribeToPromotion(PromotionSender eventHandler, string email) 
        {
            PromotionSenderEvent += eventHandler;   // gi stava vo PromotionSenderEvent t.e. ReadPromotion sto e kaj User
            EmailList.Add(email);
        }

        public void Send()
        {
            PromotionSenderEvent(CurrentProperty, Name);  
        }

        public void UnsubscribeToPromotion(PromotionSender eventHandler, string email)
        {
            PromotionSenderEvent -= eventHandler;
            string emailToDelete = EmailList.FirstOrDefault(x => x == email);
            EmailList.Remove(emailToDelete);
        }




    }


    public enum ProductType
    {
        Food,
        Cosmetics,
        Electronic,
        Other
    }

}
