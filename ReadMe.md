# ApiPetShop
API criada para solução do teste prático.

O problema

Senhor Eduardo é proprietário de um canil em Belo Horizonte, ele trabalha com  diversas raças, pequenas e grandes. Eduardo gosta que seus cães estejam sempre  arrumados, felizes e cheirosos.  
No bairro do canil, para realizar o banho nos animais, existem três petshops: Meu  Canino Feliz, Vai Rex, e ChowChawgas. Cada um deles cobra preços diferentes para  banho em cães pequenos e grandes e o preço pode variar de acordo com o dia da  semana.

● Meu Canino Feliz: Está distante 2km do canil. Em dias de semana o banho para  cães pequenos custa R$20,00 e o banho em cães grandes custa R$40,00.  Durante os finais de semana o preço dos banhos é aumentado em 20%. 

● Vai Rex: Está localizado na mesma avenida do canil, a 1,7km. O preço do banho  para dias úteis em cães pequenos é R$15,00 e em cães grandes é R$50,00.  Durante os finais de semana o preço para cães pequenos é R$ 20,00 e para os  grandes é R$ 55,00. 

● ChowChawgas: Fica a 800m do canil. O preço do banho é o mesmo em todos os  dias da semana. Para cães pequenos custa R$30 e para cães grandes R$45,00. 

Apesar de se importar muito com seus cãezinhos, Eduardo quer gastar o mínimo  possível. Desenvolva uma solução para encontrar o melhor petshop para levar os cães.  O melhor petshop será o que oferecer menores preços, em caso de empate o melhor é  o mais próximo do canil. 


Entrada: 
<data> <quantidade de cães pequenos> <quantidade cães grandes>
Exemplo: 03/08/2018 3 5 
Saída: 
Nome do melhor canil e preço total dos banhos.


Instruções para Executar o Sistema
-----------------------------------------------------------------------------------
Para executar o programa, basta clonar o repositório e o abrir com uma IDE de preferência, certifique-se também de que as dependências estejam instaladas. Caso contrário, instale-as utilizando o gerenciador de pacotes NuGet.
Após a execução, uma janela no navegador irá ser executada, o Swagger. Dentro dele, basta entrar no método GET e apertar em "try it out", o sistema solicitará a entrada no seguinte formato: <data>, em dd/MM/yyyy, <quantidade de cães pequenos>, inteiro e <quantidade de cães grandes>, inteiro.
Informado os inputs, o sistema fará os cálculos com as informações recolhidas e retornará a loja com o melhor preço e o seu nome, em um arquivo do tipo JSON, que pode ser visto logo abaixo, na sessão de "Responses".

Exemplo de entrada: 03/08/2018 3 5.

Saída:
{
  "petshop": "Meu Canino Feliz",
  "preco": 260
}

Lista de Premissas Assumidas
-----------------------------------------------------------------------------------
. Os preços dos banhos nos petshops não mudam ao longo do dia.

. Os preços dos banhos não são afetados por outros fatores além do dia da semana.

. O critério para escolher o melhor petshop é baseado no menor preço total dos banhos.

. O sistema considera apenas os petshops mencionados: Meu Canino Feliz, Vai Rex e ChowChawgas.


Decisões de Projeto
-----------------------------------------------------------------------------------
1) Linguagem e Framework:
   
. O sistema foi desenvolvido em C# utilizando o framework .NET para garantir um bom desempenho.

2) Modelagem de Dados:
   
. Não houve a necessidade da crianção de um banco de dados, pois as informações dos petshops e preços são fixas e não mudam com frequência. Então por meio de uma lista, todas as petshops foram iniciadas com suas respectivas características.

3) Cálculos e Lógica de Negócio:
   
. O sistema utiliza algoritmos simples para calcular o melhor petshop com base nos preços e na proximidade.
