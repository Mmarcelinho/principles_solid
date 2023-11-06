namespace Principios_SOLID.LSP.Solucao;

    public class Barco : TransporteMotorizado
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
