using System;

namespace BridgePattern
{

    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            AbstractionShape abstractionShape;
            abstractionShape = new AbstractionShape(new ColorRed());
            client.ClientCode(abstractionShape);
            abstractionShape = new Circle(new ColorRed());
            client.ClientCode(abstractionShape);
            abstractionShape = new Square(new ColorYellow());
            client.ClientCode(abstractionShape);

        }
    }
}