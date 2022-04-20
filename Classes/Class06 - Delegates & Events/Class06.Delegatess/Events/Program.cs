// See https://aka.ms/new-console-template for more information
using Events.Entities;



Market tineks = new Market()
{
    Name = "Tinex",
    CurrentProperty = ProductType.Food
};

Market reptil = new Market()
{
    Name = "Reptil",
    CurrentProperty = ProductType.Cosmetics
};

Market neptun = new Market()
{
    Name = "Neptun",
    CurrentProperty = ProductType.Electronic
};


User ivan = new User("Ïvan", "Dzajkovski", 34, "ivan.dzikovski@gmail.com");
User vlatko = new User("Vlatko", "Tasevski", 25, "vlatko.vlatkovski@gmail.com");
User petko = new User("Petko", "Petkovski", 20, "petko.petkovski@gmail.com");
User stanko = new User("Stanko", "Stankovski", 26, "stanko.stankovski@gmail.com");

Console.WriteLine("\n========= TINEX =========");
tineks.SubscribeToPromotion(ivan.ReadPromotion, ivan.Email);
tineks.SubscribeToPromotion(vlatko.ReadPromotion, vlatko.Email);
tineks.SubscribeToPromotion(petko.ReadPromotion, petko.Email);
tineks.Send();

Console.WriteLine("\n========= REPTIL =========");
reptil.SubscribeToPromotion(ivan.ReadPromotion, ivan.Email);
reptil.SubscribeToPromotion(vlatko.ReadPromotion, vlatko.Email);
reptil.SubscribeToPromotion(petko.ReadPromotion, petko.Email);
reptil.Send();

Console.WriteLine("\nIvan has unsubscribed".ToUpper());
reptil.UnsubscribeToPromotion(ivan.ReadPromotion, ivan.Email);
reptil.Send();

Console.WriteLine("\n========= NEPTUN =========");
neptun.SubscribeToPromotion(vlatko.ReadPromotion, vlatko.Email);
neptun.SubscribeToPromotion(stanko.ReadPromotion, stanko.Email);
neptun.SubscribeToPromotion(ReadPromotion, "email");
neptun.SubscribeToPromotion((type, marketName) =>
{
    Console.WriteLine("*** Subscription from anonymous method");
}, "fakeEmail");
neptun.Send();



Console.ReadLine();


static void ReadPromotion(ProductType type, string marketName)
{
    Console.WriteLine($"*** Subscription from main method: Promotion for {type} at {marketName}.");
}