using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFacturas
{
    class Factura
    {
        private int _numFact;
        private DateTime _fechaFact;
        private decimal _montoFact;

        static private decimal acumulado;
        static private int n;

        // Metodo constructor
        public Factura(int numFact, DateTime fechaFact, decimal montoFact)
        {
            _numFact = numFact;
            _fechaFact = fechaFact;
            _montoFact = montoFact;
            acumulado += _montoFact;
            n++;
        }

        public int GetNumFact
        {
            get { return _numFact; }
        }

        public DateTime GetFechaFact
        {
            get { return _fechaFact; }
        }

        public decimal GetMontFact
        {
            get { return _montoFact; }
        }

        public int totalFacturas()
        {
            return n;
        }

        public decimal CalculaTotalSubtotal()
        {
            return acumulado;
        }

        public decimal CalculaComision()
        {
            return 0.12M * CalculaTotalSubtotal();
        }
    }
}
