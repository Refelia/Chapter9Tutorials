using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellphoneTest
{
    class CellPhone
    {
        //Fields
        private string _brand; // The phone's brand.
        private string _model; //The Phon'es model.
        private decimal _price; // The Phone's price.

        //Constractor
        public CellPhone()
        {
            _brand = "";
            _model = "";
            _price = 0;
        }
        //brand property
        public string brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        //model property
        public string model
        {
            get { return _model; }
            set { _model = value; }
        }

        public decimal price
        {
            get { return _price; }
            set { _price = value; }
        }
    }   
 }


