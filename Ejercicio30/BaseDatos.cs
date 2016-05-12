using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    class BaseDatos
    {
        /*Atributos*/
        private string _nombre;
        private string _telefono;
        private string _direccion;
        private string _ciudad;
        private string _codPosta;
        private string _cuit;
        private double _iva;

        private int _cantidad;
        private string _descripcion;
        private double _precioUnit;
        private double _importe;
        private double _totalPagar;

        /*Propiedades*/
        public double Importe
        {
            get { return this._cantidad * this._precioUnit; }
            set { this._importe=value; }
        }

        public double Iva
        {
            get { return (this.Importe * 21) / 100; }
        }

        public double TotalPagar
        {
            get { return this.Importe + this.Iva; }
        }

        public string Nombre
        {
            get { return this._nombre; }
        }

        public string Telefono
        {
            get { return this._telefono; }
        }

        public string Direccion
        {
            get { return this._direccion; }
        }

        public string Ciudad
        { 
            get { return this._ciudad; } 
        }

        public string CodPostal
        {
            get { return this._codPosta; }
        }

        public string Cuit
        {
            get { return this._cuit; }
        }

        public int Cantidad
        {
            get { return this._cantidad; }
        }

        public string Descripcion
        {
            get { return this._descripcion; }
        }

        public double PrecioUnit
        {
            get { return this._precioUnit; }
        }


        /*Constructores*/
        public BaseDatos(string Nombre, string Tel, string Dire, string Ciudad, string CP, string Cuit)
        {
            this._nombre = Nombre;
            this._telefono = Tel;
            this._direccion = Dire;
            this._ciudad = Ciudad;
            this._codPosta = CP;
            this._cuit = Cuit;
        }

        public BaseDatos(int Cantidad, string Descripcion, double PrecioUnit)
        {
            this._cantidad = Cantidad;
            this._descripcion = Descripcion;
            this._precioUnit = PrecioUnit;
        }
    }
}
