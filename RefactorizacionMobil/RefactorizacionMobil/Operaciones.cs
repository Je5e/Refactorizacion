namespace RefactorizacionMobil
{
    // Exponer funcionalidad de Sumar valor1 y valor2
    public class Operaciones
    {
        public int Add(int V1, int V2)
        {
            int Value1 = V1;
            int Value2 = V2;
            if (Value2 == 0)
            {
                throw new System.DivideByZeroException();
            }
            int Result = Value1 / Value2;
            return Result;
        }
    }
}
