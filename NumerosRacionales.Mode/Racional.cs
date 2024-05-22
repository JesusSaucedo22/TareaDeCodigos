namespace NumerosRacionales.Mode
{
    public class Racional
    {
        /*
        private uint _numerador;
        private uint _denominador;

        propiedades
        public uint Numerador
        {
            get
            {
                return _numerador;
            }
            set
            {
                if(_numerador != value)
                {
                    _numerador = value; 
                }
            }
        }
        public uint Denominador
        {
            get => _denominador;
            set => _denominador = value;    
        }
        */
        public uint Numerador { get; set; }

        public uint Denominador { get; set; } 
        public bool EsFraccionImpropia => Numerador >= Denominador; 
        

        public Racional(uint numerador, uint denominador) 
        {
            Numerador = numerador;
            Denominador = denominador; 
        }

        /*
        public uint GetNumerador() //Metodo Getters
        {
            return _numerador;
        }
        public uint GetDenominador()
        {
            return _denominador;
        }

        public void SetNumerador(uint nuevoNumerador) //Metodo Setters
        {
            if (_numerador != nuevoNumerador)
            {
                _numerador = nuevoNumerador;
            }
               
        }
        public void SetDenominador(uint nuevoDenominador) //Metodo Setters
        {
            if (_denominador != nuevoDenominador)
            {
                _denominador = nuevoDenominador;
            }

        }*/

        public string ComoTexto() => $"{Numerador}/{Denominador}"; //metodo con cuerpo de expresion 

        public double Fraccion()
        {
            return (double)Numerador / Denominador;
        }

        public bool EsFraccionPropia()
        {
            return Numerador < Denominador;
        }

        public Racional Sumar(Racional r)
        {
            // verificar si los dos sumandos tiene diferentes denominadores
            uint numerador;
            uint denominador;

            if (Denominador != r.Denominador)
            {
                numerador = Numerador * r.Denominador + r.Numerador * Denominador;
                denominador = Denominador;
            }
            else
            {
                numerador = Numerador + r.Numerador;
                denominador = Denominador;
            }
            return new Racional(numerador, denominador);
        }

        public Racional Restar(Racional r)
        {
            uint numerador;
            uint denominador;

            if (Denominador != r.Denominador)
            {
                numerador = Numerador * r.Denominador - r.Numerador * Denominador;
                denominador = Denominador;
            }
            else
            {
                numerador = Numerador - r.Numerador;
                denominador = Denominador;
            }
            return new Racional(numerador, denominador);
        }

        public Racional Multiplicar(Racional r)
        {
            uint numerador;
            uint denominador;

            numerador = Numerador * r.Numerador;
            denominador = Denominador * r.Denominador;
            return new Racional(numerador, denominador);

        }

        public Racional Dividir(Racional r)
        {
            uint numerador;
            uint denominador;

            numerador = Numerador / r.Denominador;
            denominador = Denominador / r.Numerador;
            return new Racional(numerador, denominador);
        }
    }
}
