# Descrição
Você é responsável por auxiliar o departamento de recursos humanos de uma empresa a categorizar currículos de candidatos com base na experiência profissional. Seu desafio é criar um sistema que, ao receber uma lista de anos de experiência, classifique cada currículo como "Junior", "Pleno" ou "Senior".

- “Junior”: Candidatos com até 3 anos de experiência.
- “Pleno”: Candidatos com mais de 3 e até 5 anos de experiência.
- “Senior”: Candidatos com mais de 5 anos de experiência.

# Entrada
A entrada deve receber uma string representando uma lista de números inteiros separados por vírgulas, representando os anos de experiência de cada candidato.

# Saída
Deverá retornar uma lista de classificações ("Junior", "Pleno" ou "Senior") correspondente a cada valor de entrada, também separada por vírgulas.

A saída deve manter a ordem dos currículos conforme a entrada.

# Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

|Entrada|Saída
|---|---
|2,4,8,6|Junior, Pleno, Senior, Senior
|1,3,5,9|Junior, Junior, Pleno, Senior
|7,2,10,4|Senior, Junior, Senior, Pleno

Atenção: É extremamente importante que as entradas e saídas sejam exatamente iguais às descritas na descrição do desafio de código.