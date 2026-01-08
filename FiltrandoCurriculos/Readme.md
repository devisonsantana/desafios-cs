# Descrição
Desenvolva um sistema que filtre currículos com base em palavras-chave fornecidas. O sistema deve analisar uma lista de currículos e identificar quais currículos contêm todas as palavras-chave especificadas. Um currículo é considerado relevante apenas se contiver todas as palavras-chave fornecidas. Se nenhum currículo atender a todos os critérios, o sistema deve informar que nenhum currículo foi encontrado.

# Entrada
A entrada consiste em uma única linha contendo duas partes separadas por um ponto e vírgula (;):

Uma lista de currículos, onde cada currículo é uma string separada por vírgula (,).

Uma lista de palavras-chave, onde cada palavra-chave é uma string separada por vírgula (,).

# Saída
O sistema deve retornar uma lista de currículos que contenham todas as palavras-chave especificadas.

Se nenhum currículo atender a todos os critérios, o sistema deve retornar "Nenhum curriculo encontrado".

Os currículos relevantes devem ser apresentados em uma única string, separados por ponto e vírgula (;).

# Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

|Entrada|Saída
|---|---
|Analista de Dados, Gerente de Projetos; dados, analista|Analista de Dados
|Gerente de Produto, Analista de Mercado; analista, dados|Nenhum curriculo encontrado
|Engenheiro de Software Java, Desenvolvedor de Software Java; software, Java|Engenheiro de Software Java; Desenvolvedor de Software Java

Atenção: É extremamente importante que as entradas e saídas sejam exatamente iguais às descritas na descrição do desafio de código.