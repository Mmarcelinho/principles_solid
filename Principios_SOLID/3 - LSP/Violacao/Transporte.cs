namespace Principios_SOLID.LSP.Violacao;

    public class Transporte
    {
        public string Nome { get; set; }

        public int Velocidade { get; set; }

        public Motor Motor { get; set; }
        
        public virtual bool LigarMotor()
        {
            Motor.Ligar();
        }
    }
