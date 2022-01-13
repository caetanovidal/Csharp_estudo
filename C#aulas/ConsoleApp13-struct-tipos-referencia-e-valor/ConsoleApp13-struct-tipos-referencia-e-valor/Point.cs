
namespace ConsoleApp13_struct_tipos_referencia_e_valor
{
    struct Point
    {
        public double X;
        public double Y;

        // caso queira adicionaro um valor opcional no struct usamos nullable

        

        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }
    }
}
