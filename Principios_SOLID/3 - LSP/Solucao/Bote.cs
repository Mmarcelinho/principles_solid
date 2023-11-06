namespace Principios_SOLID.LSP.Solucao;

    public class Bote : Transporte
    {}

// Classe "Bote" que herda de "Transporte" sem a necessidade de implementar o método "LigarMotor".
// Esta solução segue o Princípio de Substituição de Liskov (LSP), pois a classe derivada não altera o contrato da classe base.