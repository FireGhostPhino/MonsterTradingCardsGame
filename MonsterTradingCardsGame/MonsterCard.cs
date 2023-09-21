//Author: Artner Patrick
namespace MonsterTradingCardsGame
{
    internal class MonsterCard : Card
    {
        public MonsterCard()
        {
            CardType = "MonsterCard";
        }

        public override void TestMethod()
        {
            Console.WriteLine("Print Class-Child MonsterCard");
            TestParentClass();
        }
    }
}