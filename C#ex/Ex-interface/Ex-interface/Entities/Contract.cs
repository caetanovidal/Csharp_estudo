using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_interface.Entities
{
    class Contract
    {

        #region Number
        private int _number;
        public int Number
        {
            get { return _number; }
            set
            {
                _number = value;
            }
        }
        #endregion

        #region Data
        private DateTime _data;

        public DateTime Data
        {
            get { return _data; }
            set
            {
                _data = Data;
            }
        }

        #endregion

        #region TotalValue

        private double _totalValue;

        public double TotalValue
        {
            get { return _totalValue; }
            set
            {
                _totalValue = TotalValue;
            }
        }
        #endregion

        public List<Installment> lista = new List<Installment>();

        public Contract(int number, DateTime data, double totalValue)
        {
            Number = number;
            Data = data;
            TotalValue = totalValue;
        }

        public void AddInstalment(Installment inst)
        {
            lista.Add(inst);
        }


        

    }
}
