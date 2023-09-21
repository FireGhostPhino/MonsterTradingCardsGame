//Author: Artner Patrick
namespace MonsterTradingCardsGame
{
    internal class SpellCard : Card
    {
        public SpellCard()
        {
            CardType = "SpellCard";
        }

        public override void TestMethod()
        {
            Console.WriteLine("Print Class-Child SpellCard");
        }
    }
}