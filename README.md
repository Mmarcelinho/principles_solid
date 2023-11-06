# Princípios SOLID - Exemplos e Refatorações

Este repositório contém exemplos de código que violam os princípios SOLID (Single Responsibility, Open-Closed, Liskov Substitution, Interface Segregation, Dependency Inversion) e suas respectivas soluções. O objetivo é ilustrar como refatorar o código para aderir aos princípios SOLID.

## SRP (Princípio da Responsabilidade Única)

- **Violacao.SRP**: Exemplo de código que viola o SRP, com uma classe realizando múltiplas responsabilidades.
- **Solucao.SRP**: Refatoração para separar as responsabilidades em classes distintas.

## OCP (Princípio Aberto/Fechado)

- **Violacao.OCP**: Exemplo de código que viola o OCP ao depender de muitas condicionais para comportamento específico.
- **Solucao.OCP**: Refatoração para uma classe abstrata que permite a extensão sem modificar o código existente.

## LSP (Princípio da Substituição de Liskov)

- **Violacao.LSP**: Exemplo de código que viola o LSP ao introduzir uma subclasse que não se comporta como a classe base.
- **Solucao.LSP**: Refatoração para uma hierarquia de classes que segue o LSP.

## ISP (Princípio da Segregação de Interfaces)

- **Violacao.ISP**: Exemplo de código que viola o ISP ao implementar interfaces que contêm métodos não relevantes.
- **Solucao.ISP**: Refatoração para interfaces mais específicas que se adaptam às necessidades das classes.

## DIP (Princípio da Inversão de Dependência)

- **Violacao.DIP**: Exemplo de código que viola o DIP ao depender de implementações concretas.
- **Solucao.DIP**: Refatoração para depender de abstrações e usar injeção de dependência.

Cada diretório contém um exemplo de violação do princípio SOLID e uma solução que segue os princípios SOLID correspondentes. Esses exemplos servem como um guia para melhorar a qualidade do código, tornando-o mais modular, extensível e de fácil manutenção.

## Autores

Estes projetos de exemplo foram criados para fins educacionais. [Marcelo] é responsável pela criação e manutenção destes projetos.

## Licença

Estes projetos não possuem uma licença específica e são fornecidos apenas para fins de aprendizado e demonstração.

## Contato

Para entrar em contato com os mantenedores dos projetos ou obter suporte, [marcelorosario2001@gmail.com].
