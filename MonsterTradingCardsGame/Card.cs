//Author: Artner Patrick
using System.Xml.Serialization;

namespace MonsterTradingCardsGame
{
    internal class Card
    {
        private string _cardtype;
        private string _elementType;

        public string CardType
        {
            get { return _cardtype; }
            set { _cardtype = value; }
        }

        public string ElementType
        {
            get { return _elementType; }
            set { _elementType = value; }
        }


        public void TestParentClass()
        {
            Console.WriteLine("Parent Class Function call");
        }

        public virtual void TestMethod()
        {
            Console.WriteLine("Print Class-Parent Card");
        }
    }
}