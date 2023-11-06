namespace Principios_SOLID.LSP.Violacao;

public class Bote : Transporte
{
    public override bool LigarMotor()
    {
        //Implementação
    }

}

// Embora essa classe seja uma subclasse de "Transporte", ela não possui motor,
// o que significa que a substituição da classe base por esta classe pode levar a resultados inesperados.
// Isso fere o Princípio de Substituição de Liskov, que exige que uma subclasse seja substituível por sua classe base sem alterar o comportamento esperado.

// Em resumo, esta classe Bote viola o LSP, já que sua funcionalidade não é consistente com a classe base "Transporte".