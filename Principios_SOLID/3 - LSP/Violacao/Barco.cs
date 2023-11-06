namespace Principios_SOLID.LSP.Violacao;

    public class Barco : Transporte
    {
        private Tanque _tanque;

        public Barco(Tanque tanque)
        {
            _tanque = tanque;
        }
        public override bool LigarMotor()
        {
            if(_tanque.TanqueVazio)
            return false;
            
            return base.LigarMotor();
        }
    }
