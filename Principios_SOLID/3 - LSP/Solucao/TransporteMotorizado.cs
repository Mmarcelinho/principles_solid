namespace Principios_SOLID.LSP.Solucao;

    public class TransporteMotorizado : Transporte
    {
          public Motor Motor { get; set; }
        
        public virtual bool LigarMotor()
        {
            Motor.Ligar();
        }
    }
