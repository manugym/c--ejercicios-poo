namespace Ejercicio1
{
    internal class Cuenta
    {
        private string titular = "";

        private double cantidad = 0;
        public string Titular { get { return titular; } set { titular = value; } }
        public double Cantidad { get { return cantidad; } set { cantidad = value; } }

        public Cuenta(string titular)
        {
            this.titular = titular;
        }

        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public void Ingresar(double cantidad)
        {
            if (cantidad > 0) this.cantidad = cantidad;
            
        }

        public void Retirar(double cantidad)
        {
            this.cantidad -= cantidad;
            if (this.cantidad < 0) this.cantidad = 0;
        }


        public override string ToString()
        {
            return $"El titular: {titular} tiene: {cantidad} ";
        }
    }
}
