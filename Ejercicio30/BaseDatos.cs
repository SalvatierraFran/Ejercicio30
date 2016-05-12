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
            get { return this._direccion }
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
    }
}
